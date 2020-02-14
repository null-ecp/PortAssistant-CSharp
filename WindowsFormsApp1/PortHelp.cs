using System;
using System.Collections;
using System.IO.Ports;
using System.Windows.Forms;

/**
 * 串口辅助类
 * 使用单例维护了串口对象
 * 完善了收发事件
 */
namespace PortAssistant
{
    class PortHelp
    {
        #region 参数设定
        // 通信用窗口对象
        private SerialPort port = new SerialPort();
        // 接收数据
        private string recv_data = "";
        // 判断开关
        private bool isCheck = false;
        private bool isOpen = false;

        // getter & setter
        public SerialPort Port {
            set { port = value; }
            get { return port; } 
        }
        public string Recv_data {
            set { recv_data = value; }
            get { return recv_data; } 
        }
        public bool IsCheck {
            set { isCheck = value; }
            get { return isCheck; }
        }
        public bool IsOpen {
            set { isOpen = value; } 
            get { return isOpen; }
        }
        #endregion

        public PortHelp() {
            // 添加数据接收事件
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        /**
        * 串口参数初始化
        */
        public void initPort(SerialPort port, Hashtable datas)
        {
            // 端口号
            port.PortName = datas["PortName"].ToString();
            // 波特率
            try
            {
                port.BaudRate = int.Parse(datas["PortRate"].ToString());
            }
            catch (Exception e)
            {
                // 转换错误则赋予默认传输率
                port.BaudRate = 9600;
            }
            // 数据位
            try
            {
                port.DataBits = int.Parse(datas["PortData"].ToString());
            }
            catch (Exception e)
            {
                // 转换错误则赋予默认数据位
                port.DataBits = 8;
            }
            // 停止位
            switch (datas["PortStop"].ToString())
            {
                case "1":
                    port.StopBits = StopBits.One;
                    break;
                case "1.5":
                    port.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    port.StopBits = StopBits.Two;
                    break;
            }
            // 校验位
            switch (datas["PortCheck"].ToString())
            {
                case "odd":
                    port.Parity = Parity.Odd;
                    break;
                case "even":
                    port.Parity = Parity.Even;
                    break;
                case "none":
                    port.Parity = Parity.None;
                    break;
            }

            port.DtrEnable = true;
            port.RtsEnable = true;
            //设置数据读取超时为1000 ms
            port.ReadTimeout = 1000;

        }

        /**
         * 字符串事件读取
         */
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(200);
            SerialPort temp = sender as SerialPort;
            // 创建缓冲区
            byte[] buffer = new byte[temp.BytesToRead];
            if (temp == null)
            {
                MessageBox.Show("事件触发错误 , 串口对象不存在或引用错误");
            }
            // 读取
            temp.Read(buffer, 0, buffer.Length);
            // 解码
            recv_data = charUtils.byteArr2String(buffer);
        }

        /**
         * 发送数据(String)
         */
        public void write(string content)
        {
            byte[] arr = charUtils.string2ByteArr(content, "gb2312");
            port.Write(arr, 0, arr.Length);
        }

        /**
         * 发送数据(16进制)
         */
        public void writeByHex(string content) {
            port.Write(charUtils.string2Hex(content));
        }
    }
}
