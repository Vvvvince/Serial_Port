namespace 串口助手
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.输入框 = new System.Windows.Forms.TextBox();
            this.接收框 = new System.Windows.Forms.TextBox();
            this.发送按钮 = new System.Windows.Forms.Button();
            this.清空按钮 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.打开串口 = new System.Windows.Forms.Button();
            this.关闭串口 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSendStr = new System.Windows.Forms.RadioButton();
            this.rbSendHex = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcvHex = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // 输入框
            // 
            this.输入框.Location = new System.Drawing.Point(12, 303);
            this.输入框.Multiline = true;
            this.输入框.Name = "输入框";
            this.输入框.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.输入框.Size = new System.Drawing.Size(351, 41);
            this.输入框.TabIndex = 2;
            // 
            // 接收框
            // 
            this.接收框.AcceptsReturn = true;
            this.接收框.Location = new System.Drawing.Point(312, 35);
            this.接收框.Multiline = true;
            this.接收框.Name = "接收框";
            this.接收框.ReadOnly = true;
            this.接收框.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.接收框.Size = new System.Drawing.Size(242, 244);
            this.接收框.TabIndex = 3;
            // 
            // 发送按钮
            // 
            this.发送按钮.Location = new System.Drawing.Point(386, 305);
            this.发送按钮.Name = "发送按钮";
            this.发送按钮.Size = new System.Drawing.Size(75, 39);
            this.发送按钮.TabIndex = 5;
            this.发送按钮.Text = "发送";
            this.发送按钮.UseVisualStyleBackColor = true;
            this.发送按钮.Click += new System.EventHandler(this.发送按钮_Click);
            // 
            // 清空按钮
            // 
            this.清空按钮.Location = new System.Drawing.Point(474, 305);
            this.清空按钮.Name = "清空按钮";
            this.清空按钮.Size = new System.Drawing.Size(75, 39);
            this.清空按钮.TabIndex = 6;
            this.清空按钮.Text = "清空";
            this.清空按钮.UseVisualStyleBackColor = true;
            this.清空按钮.Click += new System.EventHandler(this.清空按钮_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "接收字符";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "发送字符";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "串口：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // 打开串口
            // 
            this.打开串口.Location = new System.Drawing.Point(137, 31);
            this.打开串口.Name = "打开串口";
            this.打开串口.Size = new System.Drawing.Size(75, 23);
            this.打开串口.TabIndex = 13;
            this.打开串口.Text = "打开串口";
            this.打开串口.UseVisualStyleBackColor = true;
            this.打开串口.Click += new System.EventHandler(this.打开串口_Click);
            // 
            // 关闭串口
            // 
            this.关闭串口.Enabled = false;
            this.关闭串口.Location = new System.Drawing.Point(218, 31);
            this.关闭串口.Name = "关闭串口";
            this.关闭串口.Size = new System.Drawing.Size(75, 23);
            this.关闭串口.TabIndex = 14;
            this.关闭串口.Text = "关闭串口";
            this.关闭串口.UseVisualStyleBackColor = true;
            this.关闭串口.Click += new System.EventHandler(this.关闭串口_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(143, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "数据位：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "波特率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "停止位：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(199, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(58, 20);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox3.Location = new System.Drawing.Point(66, 52);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(58, 20);
            this.comboBox3.TabIndex = 18;
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(66, 20);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(58, 20);
            this.BaudRate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F);
            this.label7.Location = new System.Drawing.Point(143, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "校验位：";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "None",
            "奇校验",
            "偶校验"});
            this.comboBox4.Location = new System.Drawing.Point(199, 53);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(58, 20);
            this.comboBox4.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(19, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSendStr);
            this.panel1.Controls.Add(this.rbSendHex);
            this.panel1.Location = new System.Drawing.Point(6, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 54);
            this.panel1.TabIndex = 22;
            // 
            // rbSendStr
            // 
            this.rbSendStr.AutoSize = true;
            this.rbSendStr.Location = new System.Drawing.Point(13, 25);
            this.rbSendStr.Name = "rbSendStr";
            this.rbSendStr.Size = new System.Drawing.Size(47, 16);
            this.rbSendStr.TabIndex = 1;
            this.rbSendStr.TabStop = true;
            this.rbSendStr.Text = "字符";
            this.rbSendStr.UseVisualStyleBackColor = true;
            // 
            // rbSendHex
            // 
            this.rbSendHex.AutoSize = true;
            this.rbSendHex.Location = new System.Drawing.Point(13, 3);
            this.rbSendHex.Name = "rbSendHex";
            this.rbSendHex.Size = new System.Drawing.Size(41, 16);
            this.rbSendHex.TabIndex = 0;
            this.rbSendHex.TabStop = true;
            this.rbSendHex.Text = "HEX";
            this.rbSendHex.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(19, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 74);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送格式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(137, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 74);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收格式";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbRcvStr);
            this.panel2.Controls.Add(this.rbRcvHex);
            this.panel2.Location = new System.Drawing.Point(11, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 54);
            this.panel2.TabIndex = 22;
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.Location = new System.Drawing.Point(13, 25);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(47, 16);
            this.rbRcvStr.TabIndex = 1;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            // 
            // rbRcvHex
            // 
            this.rbRcvHex.AutoSize = true;
            this.rbRcvHex.Location = new System.Drawing.Point(13, 3);
            this.rbRcvHex.Name = "rbRcvHex";
            this.rbRcvHex.Size = new System.Drawing.Size(41, 16);
            this.rbRcvHex.TabIndex = 0;
            this.rbRcvHex.TabStop = true;
            this.rbRcvHex.Text = "HEX";
            this.rbRcvHex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.关闭串口);
            this.Controls.Add(this.打开串口);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.清空按钮);
            this.Controls.Add(this.发送按钮);
            this.Controls.Add(this.接收框);
            this.Controls.Add(this.输入框);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox 输入框;
        private System.Windows.Forms.TextBox 接收框;
        private System.Windows.Forms.Button 发送按钮;
        private System.Windows.Forms.Button 清空按钮;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button 打开串口;
        private System.Windows.Forms.Button 关闭串口;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSendStr;
        private System.Windows.Forms.RadioButton rbSendHex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcvHex;
    }
}

