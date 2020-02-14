using System;
using System.Collections;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

/**
 * 串口调试助手
 * @Auther:         Weison
 * @Version:        1.0.0.1
 * @Blog:             Https://null-ecp.github.io
 * @Updates:       更新开启串口后CPU占用率过高的问题。 -- By Weison 2020/2/13 18:22
 */
namespace PortAssistant
{
    public partial class Form1 : Form
    {
        #region 参数设定
        // 委托声明
        delegate void recv_show(string data);
        private recv_show Recv_Show;
        delegate void dock_show(Hashtable datas);
        private dock_show Dock_Show;
        delegate void dock_countW(string data);
        private dock_countW Dock_CountW;
        delegate void dock_countR(string data);
        private dock_countR Dock_CountR;
        // 串口助手类
        PortHelp portHelp = new PortHelp();
        // 线程接收线程
        Thread recv_thread;
        // 定时器
        System.Windows.Forms.Timer sendTimer = new System.Windows.Forms.Timer();
        // 控制开关
        private bool isSend = false;
        private bool TimerOpen = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
            // 初始化委托
            Recv_Show = new recv_show(controls_show);
            Dock_Show = new dock_show(Dock_PortInfo_Change);
            Dock_CountW = new dock_countW(countWriteBytes);
            Dock_CountR = new dock_countR(countReadBytes);
            // 定时器挂载事件
            sendTimer.Tick += new EventHandler(Timer_Writer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initPortNums();
            initPortLevel();
            initPortData();
            initPortCheck();
            initPortStop();
        }

        #region 组件初始化
        private void initPortNums() {
            foreach (String portname in SerialPort.GetPortNames()) {
                this.cmb_Port_Nums.Items.Add(portname);
            }
            this.cmb_Port_Nums.SelectedIndex = -1;
        }

        private void initPortLevel() {
            for (int temp = 1200; temp <= 38400; temp *= 2) {
                this.cmb_Port_Level.Items.Add(temp);
            }
            this.cmb_Port_Level.SelectedIndex = 3;
        }

        private void initPortData() {
            for (int temp = 1; temp <= 8; temp++) {
                this.cmb_Port_Data.Items.Add(temp);
            }
            this.cmb_Port_Data.SelectedIndex = 7;
        }

        private void initPortStop() {
            for (double temp = 1; temp <= 2.0; temp += 0.5) {
                this.cmb_Port_Stop.Items.Add(temp);
            }
            this.cmb_Port_Stop.SelectedIndex = 0;
        }

        private void initPortCheck() {
            this.cmb_Port_Check.Items.Add("odd");
            this.cmb_Port_Check.Items.Add("even");
            this.cmb_Port_Check.Items.Add("none");
            this.cmb_Port_Check.SelectedIndex = 2;
        }
        #endregion

        #region 组件操作

        /**
         * 判断所有下拉框是否都已选择内容
         */
        public bool checkcmbContent()
        {
            foreach (Control cl in this.grp_Port_Base.Controls)
            {
                ComboBox box = cl is ComboBox ? cl as ComboBox : null;
                if (box == null)
                {
                    continue;
                }
                if (String.IsNullOrEmpty(box.Text.ToString().Trim()))
                {
                    MessageBox.Show("请检查串口参数是否选择完整");
                    return false;
                }
            }
            return true;
        }

        /**
        * 检测参数是否可以正常开启
        */
        private void PortInitCheck()
        {
            SerialPort temp = new SerialPort();
            if (!checkcmbContent())
            {
                return;
            }
            portHelp.initPort(temp, getDatas());
            try
            {
                temp.Open();
                MessageBox.Show("串口参数设置正常 , 可正常打开串口");
                portHelp.IsCheck = true;
                this.btn_Port_Open.BackColor = Color.Green;
                this.btn_Port_Open.Text = "打开串口";
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口打开失败, 请检查参数是否设置错误");
            }
            finally
            {
                temp.Close();
            }
        }

        /**
         * 用于控制下拉框的可用状态
         */
        private void SwitchCmbBox(){
            foreach (Control cl in this.grp_Port_Base.Controls) {
                if (cl is ComboBox) {
                    ComboBox box = cl as ComboBox;
                    box.Enabled = box.Enabled ? false : true;
                }
            }
        }
        
        #endregion

        /**
         * 下拉框选择事件
         * 选择进行更改后即为重新选择参数 需重新检测
         */
        private void Cmb_Select_Changed(object sender, EventArgs e)
        {
            portHelp.IsCheck = false;
            this.btn_Port_Open.BackColor = Color.Yellow;
            this.btn_Port_Open.Text = "串口检测";
        }

        /**
         * 数据显示区焦点最后一行
         */
        private void Txt_Content_Changed(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            //文本框选中的起始点在最后
            box.SelectionStart = box.TextLength;
            //将控件内容滚动到当前插入符号位置
            box.ScrollToCaret();
        }

        /**
         * 勾选判定
         * 定时器与循环只可选其一
         */
        private void Send_checked(object sender, EventArgs e) {
            CheckBox box = sender as CheckBox;
            switch (box.Text) {
                case "定时发送":
                    if (this.ckb_Send_Each.Checked)
                    {
                        box.Checked = false;
                    }
                    break;
                case "循环发送":
                    if (this.ckb_Send_Timer.Checked)
                    {
                        box.Checked = false;
                    }
                    break;
            }
        }

        /**
         * 接收数据区双击清空
         */
        public void txt_Port_recv_DBClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否清空接收区内容?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                TextBox box = sender as TextBox;
                box.Text = "\r\n";
            }
        }

        private void btn_Port_Open_Click(object sender, EventArgs e)
        {
            // 判断是否进行过参数检测
            if (! portHelp.IsCheck) {
                PortInitCheck();
                return;
            }
            // 判断是否是已开启状态
            if (portHelp.IsOpen) {
                DialogResult result = MessageBox.Show("是否关闭串口", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    portHelp.Port.Close();
                    portHelp.IsOpen = false;
                    SwitchCmbBox();
                    //同步Dock UI
                    this.Invoke(Dock_Show, getDatas()); 
                    this.btn_Port_Open.BackColor = Color.Green;
                    this.btn_Port_Open.Text = "打开串口";
                    // 关闭接收数据线程
                    try {
                        if (recv_thread.IsAlive) {
                            recv_thread.Abort();
                        }
                    }
                    catch { }
                }
                return;
            }
            try {
                portHelp.initPort(portHelp.Port, getDatas());
                portHelp.Port.Open();
                MessageBox.Show("串口打开成功");
                portHelp.IsOpen = true;
                SwitchCmbBox();
                this.btn_Port_Open.BackColor = Color.Red;
                this.btn_Port_Open.Text = "关闭串口";
                //同步Dock UI
                this.Invoke(Dock_Show, getDatas());
                // 开启接收数据线程
                recv_thread = new Thread(Recv_Thread);
                recv_thread.IsBackground = true;
                recv_thread.Start();
            }
            catch (Exception ex) { 
                MessageBox.Show("串口打开失败");
                MessageBox.Show(ex.Message, "ErrorMsg");
            }
        }
        
        private void btn_Port_send_Click(object sender, EventArgs e)
        {
            // 判断串口是否开启
            if (! portHelp.IsOpen) {
                MessageBox.Show("串口没有开启");
                return;
            }
            // 判断当前是否为定时器开启状态
            if (TimerOpen) {
                try
                {
                    sendTimer.Stop();
                    sendTimer.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    this.btn_Port_send.BackColor = Color.White;
                    this.btn_Port_send.Text = "点击发送";
                    TimerOpen = false;
                }
                return;
            }
            // 判断是否勾选定时发送
            if (this.ckb_Send_Timer.Checked) {
                // 读取定时参数
                int times = 100;
                try {
                    times = int.Parse(this.txt_Send_Timer.Text.ToString().Trim());
                } catch (Exception ex) {
                    MessageBox.Show("定时器参数设置错误 , 将使用默认值 : 1000 ms");
                    times = 1000;
                }
                // 设定定时器参数
                sendTimer.Interval = times;
                sendTimer.Enabled = true;
                // 定时器启动
                sendTimer.Start();
                // 修改按钮状态
                this.btn_Port_send.BackColor = Color.Red;
                this.btn_Port_send.Text = "停止发送";
                TimerOpen = true;
            }
            // 判断是否勾选循环发送
            if (this.ckb_Send_Each.Checked) {
                int count = 1;
                try {
                    count = int.Parse(this.txt_Send_Each.Text.ToString().Trim());
                } catch (Exception ex) {
                    MessageBox.Show("循环次数输入错误 ，将执行默认循环次数：5");
                    count = 5;
                }
                if (count > 20) {
                    MessageBox.Show("循环次数过大 , 请填写小于 20 的值");
                    count = 20;
                }
                for (int i = 0; i < count; i++) {
                    // 循环默认延时500ms
                    Delay(500);
                    Write(getSendContent());
                }
                return;
            }
            // 发送内容
            Write(getSendContent());
        }

        /**
         * 用于循环发送时更新ui
         */
        public static void Delay(int mm)
        {
            DateTime current = DateTime.Now;
            while (current.AddMilliseconds(mm) > DateTime.Now)
            {
                Application.DoEvents();
            }
            return;
        }

        /**
        * 串口参数获取
        */
        private Hashtable getDatas()
        {
            Hashtable datas = new Hashtable();
            datas.Add("PortName", this.cmb_Port_Nums.Text.ToString().Trim());
            datas.Add("PortRate", this.cmb_Port_Level.Text.ToString().Trim());
            datas.Add("PortData", this.cmb_Port_Data.Text.ToString().Trim());
            datas.Add("PortStop", this.cmb_Port_Stop.Text.ToString().Trim());
            datas.Add("PortCheck", this.cmb_Port_Check.Text.ToString().Trim());
            return datas;
        }

        /**
         * 发送内容拼接
         */
        private string getSendContent() {
            // 读取需要发送的字符串 , 多行内容截取为空格
            String content = String.Join(" ",
                this.txt_Port_Send.Text.ToString().Trim().Split(Environment.NewLine.ToCharArray()));
            // 判断是否勾选发送新行
            content = this.ckb_Port_Send_newLine.Checked? content + "\r\n": content;
            return content;
        }

        /**
         * 修改底部状态栏串口信息 显示 
         */
        private void Dock_PortInfo_Change(Hashtable datas) {
            if (portHelp.IsOpen)
            {
                this.Dock_lbl_Port_Status.Text = "当前串口已开启";
                this.Dock_lbl_Port_Nums.Text = datas["PortName"].ToString();
                this.Dock_lbl_Port_Rate.Text = datas["PortRate"].ToString();
            }
            else {
                this.Dock_lbl_Port_Status.Text = "当前串口已关闭";
                this.Dock_lbl_Port_Nums.Text = "COM";
                this.Dock_lbl_Port_Rate.Text = "BoudRate";
            }
        }

        /**
         * 统计发送字节数
         */
        private void countWriteBytes(String data) {
            int count = 0;
            try {
                count = int.Parse(this.Dock_lbl_WBytes.Text.ToString().Trim());
            } catch { } // 基本只有第一次发送会出现转换错误 ， 但是有赋予初始值0 ， 这里就不做异常处理
            count += charUtils.string2ByteArr(data).Length;
            this.Dock_lbl_WBytes.Text = count.ToString();
        }

        /**
         * 统计接收字节数
         */
        private void countReadBytes(String data)
        {
            int count = 0;
            try {
                count = int.Parse(this.Dock_lbl_RBytes.Text.ToString().Trim());
            }
            catch { } 
            count += charUtils.string2ByteArr(data).Length;
            this.Dock_lbl_RBytes.Text = count.ToString();
        }

        /**
         * 定时器方法体
         */
        private void Timer_Writer(object sender, EventArgs e) {
            Write(getSendContent());
        }

        /**
         * 数据发送业务处理
         */
        private void Write(string content) {
            try
            {
                // 判断是否勾选16进制发送
                if (this.ckb_Send_Hex.Checked) {
                    portHelp.writeByHex(content);
                } else {
                    portHelp.write(content);
                }
                // 判断是否勾选显示发送
                if (ckb_Send_show.Checked)
                {
                    isSend = true;
                    this.Invoke(Recv_Show, content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Invoke(Dock_CountW, content);
        }

        /**
         * 接收数据线程体
         */
        private void Recv_Thread() {
            while (true) {
                // 存在发送数据同步控件
                if (! String.IsNullOrEmpty(portHelp.Recv_data)) {
                    this.BeginInvoke(Recv_Show, portHelp.Recv_data);
                    this.BeginInvoke(Dock_CountR, portHelp.Recv_data);
                    // 重置接收数据
                    portHelp.Recv_data = "";
                }
                Thread.Sleep(20);
            }
        }

        /**
         * 委托事件方法体
         * 用于同步显示数据到控件
         */
        private void controls_show(string data) {
            // 判断是否勾选为16进制显示
            data = this.ckb_Recv_Hex.Checked ? charUtils.string2Hex(data) : data;
            // 获取时间戳
            string date = this.ckb_Recv_Time.Checked? DateTime.Now.ToString("HH:mm:ss"): null;
            date = String.IsNullOrEmpty(date)? "": "[" + date + "]";
            // 判断显示数据为发送还是接收
            txt_Port_Recv.Text += date + (isSend? " →→ ": " ←← ") + data + "\r\n";
            // 修改控件显示判断
            isSend = false;
        }
    }
}
