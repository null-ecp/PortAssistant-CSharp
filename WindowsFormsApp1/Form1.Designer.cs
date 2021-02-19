namespace PortAssistant
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grp_Port_Base = new System.Windows.Forms.GroupBox();
            this.lbl_Port_Check = new System.Windows.Forms.Label();
            this.btn_Port_Open = new MetroFramework.Controls.MetroButton();
            this.cmb_Port_Check = new MetroFramework.Controls.MetroComboBox();
            this.lbl_Port_Stop = new System.Windows.Forms.Label();
            this.lbl_Port_Level = new System.Windows.Forms.Label();
            this.cmb_Port_Stop = new MetroFramework.Controls.MetroComboBox();
            this.lbl_Port_Data = new System.Windows.Forms.Label();
            this.cmb_Port_Level = new MetroFramework.Controls.MetroComboBox();
            this.lbl_Port_Nums = new System.Windows.Forms.Label();
            this.cmb_Port_Nums = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Port_Data = new MetroFramework.Controls.MetroComboBox();
            this.txt_Port_Recv = new System.Windows.Forms.TextBox();
            this.txt_Port_Send = new System.Windows.Forms.TextBox();
            this.btn_Port_send = new MetroFramework.Controls.MetroButton();
            this.grp_Port_Recv = new System.Windows.Forms.GroupBox();
            this.grp_Port_Send = new System.Windows.Forms.GroupBox();
            this.grp_Recv_Set = new System.Windows.Forms.GroupBox();
            this.ckb_Recv_Time = new MetroFramework.Controls.MetroCheckBox();
            this.ckb_Recv_Hex = new MetroFramework.Controls.MetroCheckBox();
            this.ckb_Send_show = new MetroFramework.Controls.MetroCheckBox();
            this.grp_Send_Set = new System.Windows.Forms.GroupBox();
            this.lbl_Send_Each = new System.Windows.Forms.Label();
            this.txt_Send_Each = new System.Windows.Forms.TextBox();
            this.ckb_Send_Each = new MetroFramework.Controls.MetroCheckBox();
            this.lbl_Send_Timer = new System.Windows.Forms.Label();
            this.txt_Send_Timer = new System.Windows.Forms.TextBox();
            this.ckb_Send_Timer = new MetroFramework.Controls.MetroCheckBox();
            this.ckb_Send_Hex = new MetroFramework.Controls.MetroCheckBox();
            this.ckb_Port_Send_newLine = new MetroFramework.Controls.MetroCheckBox();
            this.Dock = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dock_lbl_Port_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dock_lbl_Port_Nums = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dock_lbl_Port_Rate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dock_lbl_ws = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dock_lbl_WBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dock_lbl_RS = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dock_lbl_RBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_Port_Base.SuspendLayout();
            this.grp_Port_Recv.SuspendLayout();
            this.grp_Port_Send.SuspendLayout();
            this.grp_Recv_Set.SuspendLayout();
            this.grp_Send_Set.SuspendLayout();
            this.Dock.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Port_Base
            // 
            this.grp_Port_Base.Controls.Add(this.lbl_Port_Check);
            this.grp_Port_Base.Controls.Add(this.btn_Port_Open);
            this.grp_Port_Base.Controls.Add(this.cmb_Port_Check);
            this.grp_Port_Base.Controls.Add(this.lbl_Port_Stop);
            this.grp_Port_Base.Controls.Add(this.lbl_Port_Level);
            this.grp_Port_Base.Controls.Add(this.cmb_Port_Stop);
            this.grp_Port_Base.Controls.Add(this.lbl_Port_Data);
            this.grp_Port_Base.Controls.Add(this.cmb_Port_Level);
            this.grp_Port_Base.Controls.Add(this.lbl_Port_Nums);
            this.grp_Port_Base.Controls.Add(this.cmb_Port_Nums);
            this.grp_Port_Base.Controls.Add(this.cmb_Port_Data);
            this.grp_Port_Base.Location = new System.Drawing.Point(8, 52);
            this.grp_Port_Base.Name = "grp_Port_Base";
            this.grp_Port_Base.Size = new System.Drawing.Size(151, 219);
            this.grp_Port_Base.TabIndex = 0;
            this.grp_Port_Base.TabStop = false;
            this.grp_Port_Base.Text = "端口基本设置";
            // 
            // lbl_Port_Check
            // 
            this.lbl_Port_Check.AutoSize = true;
            this.lbl_Port_Check.Location = new System.Drawing.Point(10, 159);
            this.lbl_Port_Check.Name = "lbl_Port_Check";
            this.lbl_Port_Check.Size = new System.Drawing.Size(47, 12);
            this.lbl_Port_Check.TabIndex = 9;
            this.lbl_Port_Check.Text = "校验位:";
            // 
            // btn_Port_Open
            // 
            this.btn_Port_Open.Location = new System.Drawing.Point(14, 185);
            this.btn_Port_Open.Name = "btn_Port_Open";
            this.btn_Port_Open.Size = new System.Drawing.Size(117, 29);
            this.btn_Port_Open.TabIndex = 4;
            this.btn_Port_Open.Text = "串口检测";
            this.btn_Port_Open.UseSelectable = true;
            this.btn_Port_Open.Click += new System.EventHandler(this.btn_Port_Open_Click);
            // 
            // cmb_Port_Check
            // 
            this.cmb_Port_Check.FormattingEnabled = true;
            this.cmb_Port_Check.ItemHeight = 23;
            this.cmb_Port_Check.Location = new System.Drawing.Point(59, 153);
            this.cmb_Port_Check.Name = "cmb_Port_Check";
            this.cmb_Port_Check.Size = new System.Drawing.Size(72, 29);
            this.cmb_Port_Check.TabIndex = 8;
            this.cmb_Port_Check.UseSelectable = true;
            this.cmb_Port_Check.SelectedIndexChanged += new System.EventHandler(this.Cmb_Select_Changed);
            // 
            // lbl_Port_Stop
            // 
            this.lbl_Port_Stop.AutoSize = true;
            this.lbl_Port_Stop.Location = new System.Drawing.Point(10, 126);
            this.lbl_Port_Stop.Name = "lbl_Port_Stop";
            this.lbl_Port_Stop.Size = new System.Drawing.Size(47, 12);
            this.lbl_Port_Stop.TabIndex = 7;
            this.lbl_Port_Stop.Text = "停止位:";
            // 
            // lbl_Port_Level
            // 
            this.lbl_Port_Level.AutoSize = true;
            this.lbl_Port_Level.Location = new System.Drawing.Point(10, 60);
            this.lbl_Port_Level.Name = "lbl_Port_Level";
            this.lbl_Port_Level.Size = new System.Drawing.Size(47, 12);
            this.lbl_Port_Level.TabIndex = 3;
            this.lbl_Port_Level.Text = "波特率:";
            // 
            // cmb_Port_Stop
            // 
            this.cmb_Port_Stop.FormattingEnabled = true;
            this.cmb_Port_Stop.ItemHeight = 23;
            this.cmb_Port_Stop.Location = new System.Drawing.Point(59, 119);
            this.cmb_Port_Stop.Name = "cmb_Port_Stop";
            this.cmb_Port_Stop.Size = new System.Drawing.Size(72, 29);
            this.cmb_Port_Stop.TabIndex = 6;
            this.cmb_Port_Stop.UseSelectable = true;
            this.cmb_Port_Stop.SelectedIndexChanged += new System.EventHandler(this.Cmb_Select_Changed);
            // 
            // lbl_Port_Data
            // 
            this.lbl_Port_Data.AutoSize = true;
            this.lbl_Port_Data.Location = new System.Drawing.Point(10, 93);
            this.lbl_Port_Data.Name = "lbl_Port_Data";
            this.lbl_Port_Data.Size = new System.Drawing.Size(47, 12);
            this.lbl_Port_Data.TabIndex = 5;
            this.lbl_Port_Data.Text = "数据位:";
            this.lbl_Port_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Port_Level
            // 
            this.cmb_Port_Level.FormattingEnabled = true;
            this.cmb_Port_Level.ItemHeight = 23;
            this.cmb_Port_Level.Location = new System.Drawing.Point(59, 51);
            this.cmb_Port_Level.Name = "cmb_Port_Level";
            this.cmb_Port_Level.Size = new System.Drawing.Size(72, 29);
            this.cmb_Port_Level.TabIndex = 2;
            this.cmb_Port_Level.UseSelectable = true;
            this.cmb_Port_Level.SelectedIndexChanged += new System.EventHandler(this.Cmb_Select_Changed);
            // 
            // lbl_Port_Nums
            // 
            this.lbl_Port_Nums.AutoSize = true;
            this.lbl_Port_Nums.Location = new System.Drawing.Point(10, 27);
            this.lbl_Port_Nums.Name = "lbl_Port_Nums";
            this.lbl_Port_Nums.Size = new System.Drawing.Size(47, 12);
            this.lbl_Port_Nums.TabIndex = 1;
            this.lbl_Port_Nums.Text = "端口号:";
            this.lbl_Port_Nums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Port_Nums
            // 
            this.cmb_Port_Nums.FormattingEnabled = true;
            this.cmb_Port_Nums.ItemHeight = 23;
            this.cmb_Port_Nums.Location = new System.Drawing.Point(59, 17);
            this.cmb_Port_Nums.Name = "cmb_Port_Nums";
            this.cmb_Port_Nums.Size = new System.Drawing.Size(72, 29);
            this.cmb_Port_Nums.TabIndex = 0;
            this.cmb_Port_Nums.UseSelectable = true;
            this.cmb_Port_Nums.SelectedIndexChanged += new System.EventHandler(this.Cmb_Select_Changed);
            // 
            // cmb_Port_Data
            // 
            this.cmb_Port_Data.FormattingEnabled = true;
            this.cmb_Port_Data.ItemHeight = 23;
            this.cmb_Port_Data.Location = new System.Drawing.Point(59, 85);
            this.cmb_Port_Data.Name = "cmb_Port_Data";
            this.cmb_Port_Data.Size = new System.Drawing.Size(72, 29);
            this.cmb_Port_Data.TabIndex = 4;
            this.cmb_Port_Data.UseSelectable = true;
            this.cmb_Port_Data.SelectedIndexChanged += new System.EventHandler(this.Cmb_Select_Changed);
            // 
            // txt_Port_Recv
            // 
            this.txt_Port_Recv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Port_Recv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Port_Recv.Location = new System.Drawing.Point(6, 15);
            this.txt_Port_Recv.Multiline = true;
            this.txt_Port_Recv.Name = "txt_Port_Recv";
            this.txt_Port_Recv.ReadOnly = true;
            this.txt_Port_Recv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Port_Recv.Size = new System.Drawing.Size(667, 380);
            this.txt_Port_Recv.TabIndex = 1;
            this.txt_Port_Recv.Text = "\r\n";
            this.txt_Port_Recv.TextChanged += new System.EventHandler(this.Txt_Content_Changed);
            this.txt_Port_Recv.DoubleClick += new System.EventHandler(this.txt_Port_recv_DBClick);
            // 
            // txt_Port_Send
            // 
            this.txt_Port_Send.Location = new System.Drawing.Point(6, 17);
            this.txt_Port_Send.Multiline = true;
            this.txt_Port_Send.Name = "txt_Port_Send";
            this.txt_Port_Send.Size = new System.Drawing.Size(548, 112);
            this.txt_Port_Send.TabIndex = 2;
            // 
            // btn_Port_send
            // 
            this.btn_Port_send.Location = new System.Drawing.Point(564, 56);
            this.btn_Port_send.Name = "btn_Port_send";
            this.btn_Port_send.Size = new System.Drawing.Size(103, 29);
            this.btn_Port_send.TabIndex = 3;
            this.btn_Port_send.Text = "发送内容";
            this.btn_Port_send.UseSelectable = true;
            this.btn_Port_send.Click += new System.EventHandler(this.btn_Port_send_Click);
            // 
            // grp_Port_Recv
            // 
            this.grp_Port_Recv.Controls.Add(this.txt_Port_Recv);
            this.grp_Port_Recv.Location = new System.Drawing.Point(165, 25);
            this.grp_Port_Recv.Name = "grp_Port_Recv";
            this.grp_Port_Recv.Size = new System.Drawing.Size(679, 401);
            this.grp_Port_Recv.TabIndex = 7;
            this.grp_Port_Recv.TabStop = false;
            this.grp_Port_Recv.Text = "数据显示区";
            // 
            // grp_Port_Send
            // 
            this.grp_Port_Send.Controls.Add(this.txt_Port_Send);
            this.grp_Port_Send.Controls.Add(this.btn_Port_send);
            this.grp_Port_Send.Location = new System.Drawing.Point(163, 432);
            this.grp_Port_Send.Name = "grp_Port_Send";
            this.grp_Port_Send.Size = new System.Drawing.Size(679, 141);
            this.grp_Port_Send.TabIndex = 8;
            this.grp_Port_Send.TabStop = false;
            this.grp_Port_Send.Text = "数据发送区";
            // 
            // grp_Recv_Set
            // 
            this.grp_Recv_Set.Controls.Add(this.ckb_Recv_Time);
            this.grp_Recv_Set.Controls.Add(this.ckb_Recv_Hex);
            this.grp_Recv_Set.Controls.Add(this.ckb_Send_show);
            this.grp_Recv_Set.Location = new System.Drawing.Point(8, 277);
            this.grp_Recv_Set.Name = "grp_Recv_Set";
            this.grp_Recv_Set.Size = new System.Drawing.Size(151, 143);
            this.grp_Recv_Set.TabIndex = 9;
            this.grp_Recv_Set.TabStop = false;
            this.grp_Recv_Set.Text = "接收相关设置";
            // 
            // ckb_Recv_Time
            // 
            this.ckb_Recv_Time.AutoSize = true;
            this.ckb_Recv_Time.Location = new System.Drawing.Point(36, 97);
            this.ckb_Recv_Time.Name = "ckb_Recv_Time";
            this.ckb_Recv_Time.Size = new System.Drawing.Size(71, 15);
            this.ckb_Recv_Time.TabIndex = 6;
            this.ckb_Recv_Time.Text = "显示时间";
            this.ckb_Recv_Time.UseSelectable = true;
            // 
            // ckb_Recv_Hex
            // 
            this.ckb_Recv_Hex.AutoSize = true;
            this.ckb_Recv_Hex.Location = new System.Drawing.Point(36, 66);
            this.ckb_Recv_Hex.Name = "ckb_Recv_Hex";
            this.ckb_Recv_Hex.Size = new System.Drawing.Size(70, 15);
            this.ckb_Recv_Hex.TabIndex = 5;
            this.ckb_Recv_Hex.Text = "Hex 显示";
            this.ckb_Recv_Hex.UseSelectable = true;
            // 
            // ckb_Send_show
            // 
            this.ckb_Send_show.AutoSize = true;
            this.ckb_Send_show.Location = new System.Drawing.Point(36, 35);
            this.ckb_Send_show.Name = "ckb_Send_show";
            this.ckb_Send_show.Size = new System.Drawing.Size(71, 15);
            this.ckb_Send_show.TabIndex = 4;
            this.ckb_Send_show.Text = "显示发送";
            this.ckb_Send_show.UseSelectable = true;
            // 
            // grp_Send_Set
            // 
            this.grp_Send_Set.Controls.Add(this.lbl_Send_Each);
            this.grp_Send_Set.Controls.Add(this.txt_Send_Each);
            this.grp_Send_Set.Controls.Add(this.ckb_Send_Each);
            this.grp_Send_Set.Controls.Add(this.lbl_Send_Timer);
            this.grp_Send_Set.Controls.Add(this.txt_Send_Timer);
            this.grp_Send_Set.Controls.Add(this.ckb_Send_Timer);
            this.grp_Send_Set.Controls.Add(this.ckb_Send_Hex);
            this.grp_Send_Set.Controls.Add(this.ckb_Port_Send_newLine);
            this.grp_Send_Set.Location = new System.Drawing.Point(8, 428);
            this.grp_Send_Set.Name = "grp_Send_Set";
            this.grp_Send_Set.Size = new System.Drawing.Size(151, 145);
            this.grp_Send_Set.TabIndex = 10;
            this.grp_Send_Set.TabStop = false;
            this.grp_Send_Set.Text = "发送相关设置";
            // 
            // lbl_Send_Each
            // 
            this.lbl_Send_Each.AutoSize = true;
            this.lbl_Send_Each.Location = new System.Drawing.Point(107, 105);
            this.lbl_Send_Each.Name = "lbl_Send_Each";
            this.lbl_Send_Each.Size = new System.Drawing.Size(29, 12);
            this.lbl_Send_Each.TabIndex = 11;
            this.lbl_Send_Each.Text = "次数";
            // 
            // txt_Send_Each
            // 
            this.txt_Send_Each.Location = new System.Drawing.Point(74, 102);
            this.txt_Send_Each.Name = "txt_Send_Each";
            this.txt_Send_Each.Size = new System.Drawing.Size(30, 21);
            this.txt_Send_Each.TabIndex = 10;
            // 
            // ckb_Send_Each
            // 
            this.ckb_Send_Each.AutoSize = true;
            this.ckb_Send_Each.Location = new System.Drawing.Point(5, 105);
            this.ckb_Send_Each.Name = "ckb_Send_Each";
            this.ckb_Send_Each.Size = new System.Drawing.Size(71, 15);
            this.ckb_Send_Each.TabIndex = 9;
            this.ckb_Send_Each.Text = "循环发送";
            this.ckb_Send_Each.UseSelectable = true;
            this.ckb_Send_Each.CheckedChanged += new System.EventHandler(this.Send_checked);
            // 
            // lbl_Send_Timer
            // 
            this.lbl_Send_Timer.AutoSize = true;
            this.lbl_Send_Timer.Location = new System.Drawing.Point(108, 71);
            this.lbl_Send_Timer.Name = "lbl_Send_Timer";
            this.lbl_Send_Timer.Size = new System.Drawing.Size(35, 12);
            this.lbl_Send_Timer.TabIndex = 8;
            this.lbl_Send_Timer.Text = "ms/次";
            // 
            // txt_Send_Timer
            // 
            this.txt_Send_Timer.Location = new System.Drawing.Point(75, 68);
            this.txt_Send_Timer.Name = "txt_Send_Timer";
            this.txt_Send_Timer.Size = new System.Drawing.Size(30, 21);
            this.txt_Send_Timer.TabIndex = 7;
            // 
            // ckb_Send_Timer
            // 
            this.ckb_Send_Timer.AutoSize = true;
            this.ckb_Send_Timer.Location = new System.Drawing.Point(6, 71);
            this.ckb_Send_Timer.Name = "ckb_Send_Timer";
            this.ckb_Send_Timer.Size = new System.Drawing.Size(71, 15);
            this.ckb_Send_Timer.TabIndex = 6;
            this.ckb_Send_Timer.Text = "定时发送";
            this.ckb_Send_Timer.UseSelectable = true;
            this.ckb_Send_Timer.CheckedChanged += new System.EventHandler(this.Send_checked);
            // 
            // ckb_Send_Hex
            // 
            this.ckb_Send_Hex.AutoSize = true;
            this.ckb_Send_Hex.Location = new System.Drawing.Point(77, 34);
            this.ckb_Send_Hex.Name = "ckb_Send_Hex";
            this.ckb_Send_Hex.Size = new System.Drawing.Size(70, 15);
            this.ckb_Send_Hex.TabIndex = 5;
            this.ckb_Send_Hex.Text = "Hex 发送";
            this.ckb_Send_Hex.UseSelectable = true;
            // 
            // ckb_Port_Send_newLine
            // 
            this.ckb_Port_Send_newLine.AutoSize = true;
            this.ckb_Port_Send_newLine.Location = new System.Drawing.Point(6, 34);
            this.ckb_Port_Send_newLine.Name = "ckb_Port_Send_newLine";
            this.ckb_Port_Send_newLine.Size = new System.Drawing.Size(71, 15);
            this.ckb_Port_Send_newLine.TabIndex = 3;
            this.ckb_Port_Send_newLine.Text = "发送新行";
            this.ckb_Port_Send_newLine.UseSelectable = true;
            // 
            // Dock
            // 
            this.Dock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.Dock_lbl_Port_Status,
            this.toolStripStatusLabel5,
            this.Dock_lbl_Port_Nums,
            this.toolStripStatusLabel2,
            this.Dock_lbl_Port_Rate,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel1,
            this.Dock_lbl_ws,
            this.Dock_lbl_WBytes,
            this.Dock_lbl_RS,
            this.Dock_lbl_RBytes});
            this.Dock.Location = new System.Drawing.Point(20, 582);
            this.Dock.Name = "Dock";
            this.Dock.Size = new System.Drawing.Size(816, 26);
            this.Dock.TabIndex = 11;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(40, 21);
            this.toolStripStatusLabel3.Text = "        ";
            // 
            // Dock_lbl_Port_Status
            // 
            this.Dock_lbl_Port_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Dock_lbl_Port_Status.Name = "Dock_lbl_Port_Status";
            this.Dock_lbl_Port_Status.Size = new System.Drawing.Size(92, 21);
            this.Dock_lbl_Port_Status.Text = "当前串口未打开";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(44, 21);
            this.toolStripStatusLabel5.Text = "        ";
            // 
            // Dock_lbl_Port_Nums
            // 
            this.Dock_lbl_Port_Nums.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Dock_lbl_Port_Nums.Margin = new System.Windows.Forms.Padding(1, 3, 0, 2);
            this.Dock_lbl_Port_Nums.Name = "Dock_lbl_Port_Nums";
            this.Dock_lbl_Port_Nums.Size = new System.Drawing.Size(38, 21);
            this.Dock_lbl_Port_Nums.Text = "COM";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 21);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // Dock_lbl_Port_Rate
            // 
            this.Dock_lbl_Port_Rate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Dock_lbl_Port_Rate.Margin = new System.Windows.Forms.Padding(1, 3, 0, 2);
            this.Dock_lbl_Port_Rate.Name = "Dock_lbl_Port_Rate";
            this.Dock_lbl_Port_Rate.Size = new System.Drawing.Size(65, 21);
            this.Dock_lbl_Port_Rate.Text = "BoudRate";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 21);
            this.toolStripStatusLabel6.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(399, 21);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // Dock_lbl_ws
            // 
            this.Dock_lbl_ws.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.Dock_lbl_ws.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Dock_lbl_ws.Margin = new System.Windows.Forms.Padding(1, 3, 0, 2);
            this.Dock_lbl_ws.Name = "Dock_lbl_ws";
            this.Dock_lbl_ws.Size = new System.Drawing.Size(31, 21);
            this.Dock_lbl_ws.Text = "W :";
            // 
            // Dock_lbl_WBytes
            // 
            this.Dock_lbl_WBytes.Name = "Dock_lbl_WBytes";
            this.Dock_lbl_WBytes.Size = new System.Drawing.Size(15, 21);
            this.Dock_lbl_WBytes.Text = "0";
            // 
            // Dock_lbl_RS
            // 
            this.Dock_lbl_RS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.Dock_lbl_RS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Dock_lbl_RS.Margin = new System.Windows.Forms.Padding(1, 3, 0, 2);
            this.Dock_lbl_RS.Name = "Dock_lbl_RS";
            this.Dock_lbl_RS.Size = new System.Drawing.Size(26, 21);
            this.Dock_lbl_RS.Text = "S :";
            // 
            // Dock_lbl_RBytes
            // 
            this.Dock_lbl_RBytes.Name = "Dock_lbl_RBytes";
            this.Dock_lbl_RBytes.Size = new System.Drawing.Size(15, 21);
            this.Dock_lbl_RBytes.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 628);
            this.Controls.Add(this.Dock);
            this.Controls.Add(this.grp_Send_Set);
            this.Controls.Add(this.grp_Recv_Set);
            this.Controls.Add(this.grp_Port_Send);
            this.Controls.Add(this.grp_Port_Recv);
            this.Controls.Add(this.grp_Port_Base);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "PortAssistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Port_Base.ResumeLayout(false);
            this.grp_Port_Base.PerformLayout();
            this.grp_Port_Recv.ResumeLayout(false);
            this.grp_Port_Recv.PerformLayout();
            this.grp_Port_Send.ResumeLayout(false);
            this.grp_Port_Send.PerformLayout();
            this.grp_Recv_Set.ResumeLayout(false);
            this.grp_Recv_Set.PerformLayout();
            this.grp_Send_Set.ResumeLayout(false);
            this.grp_Send_Set.PerformLayout();
            this.Dock.ResumeLayout(false);
            this.Dock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Port_Base;
        private System.Windows.Forms.Label lbl_Port_Check;
        private MetroFramework.Controls.MetroComboBox cmb_Port_Check;
        private System.Windows.Forms.Label lbl_Port_Stop;
        private MetroFramework.Controls.MetroComboBox cmb_Port_Stop;
        private System.Windows.Forms.Label lbl_Port_Data;
        private MetroFramework.Controls.MetroComboBox cmb_Port_Data;
        private System.Windows.Forms.Label lbl_Port_Level;
        private MetroFramework.Controls.MetroComboBox cmb_Port_Level;
        private System.Windows.Forms.Label lbl_Port_Nums;
        private MetroFramework.Controls.MetroComboBox cmb_Port_Nums;
        private System.Windows.Forms.TextBox txt_Port_Recv;
        private System.Windows.Forms.TextBox txt_Port_Send;
        private MetroFramework.Controls.MetroButton btn_Port_send;
        private MetroFramework.Controls.MetroButton btn_Port_Open;
        private System.Windows.Forms.GroupBox grp_Port_Recv;
        private System.Windows.Forms.GroupBox grp_Port_Send;
        private System.Windows.Forms.GroupBox grp_Recv_Set;
        private System.Windows.Forms.GroupBox grp_Send_Set;
        private MetroFramework.Controls.MetroCheckBox ckb_Port_Send_newLine;
        private MetroFramework.Controls.MetroCheckBox ckb_Send_show;
        private MetroFramework.Controls.MetroCheckBox ckb_Send_Hex;
        private System.Windows.Forms.Label lbl_Send_Timer;
        private System.Windows.Forms.TextBox txt_Send_Timer;
        private MetroFramework.Controls.MetroCheckBox ckb_Send_Timer;
        private System.Windows.Forms.Label lbl_Send_Each;
        private System.Windows.Forms.TextBox txt_Send_Each;
        private MetroFramework.Controls.MetroCheckBox ckb_Send_Each;
        private MetroFramework.Controls.MetroCheckBox ckb_Recv_Hex;
        private MetroFramework.Controls.MetroCheckBox ckb_Recv_Time;
        private System.Windows.Forms.StatusStrip Dock;
        private System.Windows.Forms.ToolStripStatusLabel Dock_lbl_Port_Nums;
        private System.Windows.Forms.ToolStripStatusLabel Dock_lbl_WBytes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel Dock_lbl_Port_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Dock_lbl_ws;
        private System.Windows.Forms.ToolStripStatusLabel Dock_lbl_Port_Rate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel Dock_lbl_RS;
        private System.Windows.Forms.ToolStripStatusLabel Dock_lbl_RBytes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

