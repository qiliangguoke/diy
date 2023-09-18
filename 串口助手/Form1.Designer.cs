namespace _01_demo
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
            this.components = new System.ComponentModel.Container();
            this.port_combox = new System.Windows.Forms.ComboBox();
            this.send_txb = new System.Windows.Forms.TextBox();
            this.receive_txb = new System.Windows.Forms.RichTextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openPort_btn = new System.Windows.Forms.Button();
            this.DTR_chb = new System.Windows.Forms.CheckBox();
            this.RTS_chb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stop_combox = new System.Windows.Forms.ComboBox();
            this.databit_combox = new System.Windows.Forms.ComboBox();
            this.check_combox = new System.Windows.Forms.ComboBox();
            this.baud_combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savePath_txb = new System.Windows.Forms.TextBox();
            this.hex_chb = new System.Windows.Forms.CheckBox();
            this.savaData_btn = new System.Windows.Forms.Button();
            this.path_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.autoClear_chb = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autoTime_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filePath_txb = new System.Windows.Forms.TextBox();
            this.sendFile_btn = new System.Windows.Forms.Button();
            this.sendClear_btn = new System.Windows.Forms.Button();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.autoSend_chb = new System.Windows.Forms.CheckBox();
            this.sendHex_chb = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.state_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.发送计数 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendCount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.receiveCount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearCount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // port_combox
            // 
            this.port_combox.FormattingEnabled = true;
            this.port_combox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.port_combox.Location = new System.Drawing.Point(168, 24);
            this.port_combox.Name = "port_combox";
            this.port_combox.Size = new System.Drawing.Size(145, 23);
            this.port_combox.TabIndex = 1;
            // 
            // send_txb
            // 
            this.send_txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_txb.Location = new System.Drawing.Point(3, 21);
            this.send_txb.Multiline = true;
            this.send_txb.Name = "send_txb";
            this.send_txb.Size = new System.Drawing.Size(775, 321);
            this.send_txb.TabIndex = 2;
            this.send_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.send_txb_KeyPress);
            // 
            // receive_txb
            // 
            this.receive_txb.BackColor = System.Drawing.SystemColors.Desktop;
            this.receive_txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receive_txb.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.receive_txb.Location = new System.Drawing.Point(3, 21);
            this.receive_txb.Name = "receive_txb";
            this.receive_txb.ReadOnly = true;
            this.receive_txb.Size = new System.Drawing.Size(790, 235);
            this.receive_txb.TabIndex = 3;
            this.receive_txb.Text = " ";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(226, 18);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(87, 28);
            this.send_btn.TabIndex = 4;
            this.send_btn.Text = "手动发送";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.UseWaitCursor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openPort_btn);
            this.groupBox1.Controls.Add(this.DTR_chb);
            this.groupBox1.Controls.Add(this.RTS_chb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stop_combox);
            this.groupBox1.Controls.Add(this.databit_combox);
            this.groupBox1.Controls.Add(this.check_combox);
            this.groupBox1.Controls.Add(this.baud_combox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.port_combox);
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // openPort_btn
            // 
            this.openPort_btn.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openPort_btn.Location = new System.Drawing.Point(168, 193);
            this.openPort_btn.Name = "openPort_btn";
            this.openPort_btn.Size = new System.Drawing.Size(145, 60);
            this.openPort_btn.TabIndex = 12;
            this.openPort_btn.Text = "打开串口";
            this.openPort_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openPort_btn.UseVisualStyleBackColor = true;
            this.openPort_btn.Click += new System.EventHandler(this.openPort_btn_Click);
            // 
            // DTR_chb
            // 
            this.DTR_chb.AutoSize = true;
            this.DTR_chb.Location = new System.Drawing.Point(50, 219);
            this.DTR_chb.Name = "DTR_chb";
            this.DTR_chb.Size = new System.Drawing.Size(53, 19);
            this.DTR_chb.TabIndex = 11;
            this.DTR_chb.Text = "DTR";
            this.DTR_chb.UseVisualStyleBackColor = true;
            // 
            // RTS_chb
            // 
            this.RTS_chb.AutoSize = true;
            this.RTS_chb.Location = new System.Drawing.Point(50, 193);
            this.RTS_chb.Name = "RTS_chb";
            this.RTS_chb.Size = new System.Drawing.Size(53, 19);
            this.RTS_chb.TabIndex = 10;
            this.RTS_chb.Text = "RTS";
            this.RTS_chb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // stop_combox
            // 
            this.stop_combox.FormattingEnabled = true;
            this.stop_combox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stop_combox.Location = new System.Drawing.Point(168, 140);
            this.stop_combox.Name = "stop_combox";
            this.stop_combox.Size = new System.Drawing.Size(145, 23);
            this.stop_combox.TabIndex = 5;
            // 
            // databit_combox
            // 
            this.databit_combox.FormattingEnabled = true;
            this.databit_combox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databit_combox.Location = new System.Drawing.Point(168, 111);
            this.databit_combox.Name = "databit_combox";
            this.databit_combox.Size = new System.Drawing.Size(145, 23);
            this.databit_combox.TabIndex = 4;
            // 
            // check_combox
            // 
            this.check_combox.FormattingEnabled = true;
            this.check_combox.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.check_combox.Location = new System.Drawing.Point(168, 82);
            this.check_combox.Name = "check_combox";
            this.check_combox.Size = new System.Drawing.Size(145, 23);
            this.check_combox.TabIndex = 3;
            // 
            // baud_combox
            // 
            this.baud_combox.FormattingEnabled = true;
            this.baud_combox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.baud_combox.Location = new System.Drawing.Point(168, 53);
            this.baud_combox.Name = "baud_combox";
            this.baud_combox.Size = new System.Drawing.Size(145, 23);
            this.baud_combox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savePath_txb);
            this.groupBox2.Controls.Add(this.hex_chb);
            this.groupBox2.Controls.Add(this.savaData_btn);
            this.groupBox2.Controls.Add(this.path_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.autoClear_chb);
            this.groupBox2.Location = new System.Drawing.Point(30, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 169);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接受配置";
            // 
            // savePath_txb
            // 
            this.savePath_txb.Location = new System.Drawing.Point(50, 117);
            this.savePath_txb.Name = "savePath_txb";
            this.savePath_txb.Size = new System.Drawing.Size(263, 25);
            this.savePath_txb.TabIndex = 24;
            // 
            // hex_chb
            // 
            this.hex_chb.AutoSize = true;
            this.hex_chb.Location = new System.Drawing.Point(50, 63);
            this.hex_chb.Name = "hex_chb";
            this.hex_chb.Size = new System.Drawing.Size(89, 19);
            this.hex_chb.TabIndex = 20;
            this.hex_chb.Text = "十六进制";
            this.hex_chb.UseVisualStyleBackColor = true;
            this.hex_chb.CheckedChanged += new System.EventHandler(this.hex_chb_CheckedChanged);
            // 
            // savaData_btn
            // 
            this.savaData_btn.Location = new System.Drawing.Point(226, 88);
            this.savaData_btn.Name = "savaData_btn";
            this.savaData_btn.Size = new System.Drawing.Size(87, 23);
            this.savaData_btn.TabIndex = 18;
            this.savaData_btn.Text = "保存数据";
            this.savaData_btn.UseVisualStyleBackColor = true;
            // 
            // path_btn
            // 
            this.path_btn.Location = new System.Drawing.Point(50, 88);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(104, 23);
            this.path_btn.TabIndex = 17;
            this.path_btn.Text = "选择路径";
            this.path_btn.UseVisualStyleBackColor = true;
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(226, 59);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(87, 23);
            this.stop_btn.TabIndex = 16;
            this.stop_btn.Text = "暂停";
            this.stop_btn.UseVisualStyleBackColor = true;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(226, 20);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(87, 33);
            this.clear_btn.TabIndex = 15;
            this.clear_btn.Text = "手动清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // autoClear_chb
            // 
            this.autoClear_chb.AutoSize = true;
            this.autoClear_chb.Location = new System.Drawing.Point(50, 24);
            this.autoClear_chb.Name = "autoClear_chb";
            this.autoClear_chb.Size = new System.Drawing.Size(89, 19);
            this.autoClear_chb.TabIndex = 13;
            this.autoClear_chb.Text = "自动清空";
            this.autoClear_chb.UseVisualStyleBackColor = true;
            this.autoClear_chb.CheckedChanged += new System.EventHandler(this.autoClear_chb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autoTime_txb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.filePath_txb);
            this.groupBox3.Controls.Add(this.sendFile_btn);
            this.groupBox3.Controls.Add(this.sendClear_btn);
            this.groupBox3.Controls.Add(this.openFile_btn);
            this.groupBox3.Controls.Add(this.autoSend_chb);
            this.groupBox3.Controls.Add(this.send_btn);
            this.groupBox3.Controls.Add(this.sendHex_chb);
            this.groupBox3.Location = new System.Drawing.Point(30, 491);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 180);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // autoTime_txb
            // 
            this.autoTime_txb.Location = new System.Drawing.Point(238, 151);
            this.autoTime_txb.Name = "autoTime_txb";
            this.autoTime_txb.Size = new System.Drawing.Size(75, 25);
            this.autoTime_txb.TabIndex = 25;
            this.autoTime_txb.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "自动发送周期（1000ms）";
            // 
            // filePath_txb
            // 
            this.filePath_txb.Location = new System.Drawing.Point(50, 120);
            this.filePath_txb.Name = "filePath_txb";
            this.filePath_txb.Size = new System.Drawing.Size(263, 25);
            this.filePath_txb.TabIndex = 25;
            // 
            // sendFile_btn
            // 
            this.sendFile_btn.Location = new System.Drawing.Point(226, 86);
            this.sendFile_btn.Name = "sendFile_btn";
            this.sendFile_btn.Size = new System.Drawing.Size(87, 28);
            this.sendFile_btn.TabIndex = 23;
            this.sendFile_btn.Text = "发送文件";
            this.sendFile_btn.UseVisualStyleBackColor = true;
            this.sendFile_btn.UseWaitCursor = true;
            // 
            // sendClear_btn
            // 
            this.sendClear_btn.Location = new System.Drawing.Point(226, 52);
            this.sendClear_btn.Name = "sendClear_btn";
            this.sendClear_btn.Size = new System.Drawing.Size(87, 28);
            this.sendClear_btn.TabIndex = 22;
            this.sendClear_btn.Text = "清空发送";
            this.sendClear_btn.UseVisualStyleBackColor = true;
            this.sendClear_btn.UseWaitCursor = true;
            this.sendClear_btn.Click += new System.EventHandler(this.sendClear_btn_Click);
            // 
            // openFile_btn
            // 
            this.openFile_btn.Location = new System.Drawing.Point(50, 83);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(104, 23);
            this.openFile_btn.TabIndex = 21;
            this.openFile_btn.Text = "打开文件";
            this.openFile_btn.UseVisualStyleBackColor = true;
            // 
            // autoSend_chb
            // 
            this.autoSend_chb.AutoSize = true;
            this.autoSend_chb.Location = new System.Drawing.Point(50, 24);
            this.autoSend_chb.Name = "autoSend_chb";
            this.autoSend_chb.Size = new System.Drawing.Size(89, 19);
            this.autoSend_chb.TabIndex = 19;
            this.autoSend_chb.Text = "自动发送";
            this.autoSend_chb.UseVisualStyleBackColor = true;
            // 
            // sendHex_chb
            // 
            this.sendHex_chb.AutoSize = true;
            this.sendHex_chb.Location = new System.Drawing.Point(50, 58);
            this.sendHex_chb.Name = "sendHex_chb";
            this.sendHex_chb.Size = new System.Drawing.Size(89, 19);
            this.sendHex_chb.TabIndex = 14;
            this.sendHex_chb.Text = "十六进制";
            this.sendHex_chb.UseVisualStyleBackColor = true;
            this.sendHex_chb.CheckedChanged += new System.EventHandler(this.sendHex_chb_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.receive_txb);
            this.groupBox4.Location = new System.Drawing.Point(402, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(796, 259);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接受区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.send_txb);
            this.groupBox5.Location = new System.Drawing.Point(405, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(781, 345);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.state_tssl,
            this.发送计数,
            this.sendCount_tssl,
            this.toolStripStatusLabel4,
            this.receiveCount_tssl,
            this.clearCount_tssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1198, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel1.Text = "状态";
            // 
            // state_tssl
            // 
            this.state_tssl.AutoSize = false;
            this.state_tssl.Name = "state_tssl";
            this.state_tssl.Size = new System.Drawing.Size(200, 20);
            this.state_tssl.Text = "初始化正常！";
            // 
            // 发送计数
            // 
            this.发送计数.Name = "发送计数";
            this.发送计数.Size = new System.Drawing.Size(84, 20);
            this.发送计数.Text = "发送计数：";
            // 
            // sendCount_tssl
            // 
            this.sendCount_tssl.AutoSize = false;
            this.sendCount_tssl.Name = "sendCount_tssl";
            this.sendCount_tssl.Size = new System.Drawing.Size(50, 20);
            this.sendCount_tssl.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel4.Text = "接收计数";
            // 
            // receiveCount_tssl
            // 
            this.receiveCount_tssl.AutoSize = false;
            this.receiveCount_tssl.Name = "receiveCount_tssl";
            this.receiveCount_tssl.Size = new System.Drawing.Size(50, 20);
            this.receiveCount_tssl.Text = "0";
            // 
            // clearCount_tssl
            // 
            this.clearCount_tssl.Name = "clearCount_tssl";
            this.clearCount_tssl.Size = new System.Drawing.Size(69, 20);
            this.clearCount_tssl.Text = "清空计数";
            this.clearCount_tssl.Click += new System.EventHandler(this.clearCount_tssl_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 706);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox port_combox;
        private System.Windows.Forms.TextBox send_txb;
        private System.Windows.Forms.RichTextBox receive_txb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openPort_btn;
        private System.Windows.Forms.CheckBox DTR_chb;
        private System.Windows.Forms.CheckBox RTS_chb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stop_combox;
        private System.Windows.Forms.ComboBox databit_combox;
        private System.Windows.Forms.ComboBox check_combox;
        private System.Windows.Forms.ComboBox baud_combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button savaData_btn;
        private System.Windows.Forms.Button path_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox sendHex_chb;
        private System.Windows.Forms.CheckBox autoClear_chb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox hex_chb;
        private System.Windows.Forms.TextBox savePath_txb;
        private System.Windows.Forms.Button sendFile_btn;
        private System.Windows.Forms.Button sendClear_btn;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.CheckBox autoSend_chb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filePath_txb;
        private System.Windows.Forms.TextBox autoTime_txb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel state_tssl;
        private System.Windows.Forms.ToolStripStatusLabel 发送计数;
        private System.Windows.Forms.ToolStripStatusLabel sendCount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel receiveCount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel clearCount_tssl;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

