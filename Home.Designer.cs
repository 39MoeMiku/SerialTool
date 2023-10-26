namespace SerialTool
{
    partial class SerialTool
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
            this.textPort = new System.Windows.Forms.Label();
            this.gbSerialSetting = new System.Windows.Forms.GroupBox();
            this.cbCheckBit = new System.Windows.Forms.ComboBox();
            this.textCheckBit = new System.Windows.Forms.Label();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.textDataBit = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.textStopBit = new System.Windows.Forms.Label();
            this.textBaudRate = new System.Windows.Forms.Label();
            this.txtbDataSend = new System.Windows.Forms.TextBox();
            this.gbDataSend = new System.Windows.Forms.GroupBox();
            this.btnDataSend = new System.Windows.Forms.Button();
            this.gbDataRecive = new System.Windows.Forms.GroupBox();
            this.txtbDataRecive = new System.Windows.Forms.TextBox();
            this.gbSerialSetting.SuspendLayout();
            this.gbDataSend.SuspendLayout();
            this.gbDataRecive.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPort
            // 
            this.textPort.AutoSize = true;
            this.textPort.Location = new System.Drawing.Point(69, 47);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(52, 15);
            this.textPort.TabIndex = 0;
            this.textPort.Text = "串口：";
            // 
            // gbSerialSetting
            // 
            this.gbSerialSetting.Controls.Add(this.cbCheckBit);
            this.gbSerialSetting.Controls.Add(this.textCheckBit);
            this.gbSerialSetting.Controls.Add(this.cbDataBit);
            this.gbSerialSetting.Controls.Add(this.textDataBit);
            this.gbSerialSetting.Controls.Add(this.btnOpenPort);
            this.gbSerialSetting.Controls.Add(this.cbStopBit);
            this.gbSerialSetting.Controls.Add(this.cbBaudRate);
            this.gbSerialSetting.Controls.Add(this.cbPort);
            this.gbSerialSetting.Controls.Add(this.textStopBit);
            this.gbSerialSetting.Controls.Add(this.textBaudRate);
            this.gbSerialSetting.Controls.Add(this.textPort);
            this.gbSerialSetting.Location = new System.Drawing.Point(12, 24);
            this.gbSerialSetting.Name = "gbSerialSetting";
            this.gbSerialSetting.Size = new System.Drawing.Size(523, 166);
            this.gbSerialSetting.TabIndex = 2;
            this.gbSerialSetting.TabStop = false;
            this.gbSerialSetting.Text = "串口设置";
            // 
            // cbCheckBit
            // 
            this.cbCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheckBit.FormattingEnabled = true;
            this.cbCheckBit.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbCheckBit.Location = new System.Drawing.Point(394, 130);
            this.cbCheckBit.Name = "cbCheckBit";
            this.cbCheckBit.Size = new System.Drawing.Size(101, 23);
            this.cbCheckBit.TabIndex = 10;
            // 
            // textCheckBit
            // 
            this.textCheckBit.AutoSize = true;
            this.textCheckBit.Location = new System.Drawing.Point(321, 133);
            this.textCheckBit.Name = "textCheckBit";
            this.textCheckBit.Size = new System.Drawing.Size(67, 15);
            this.textCheckBit.TabIndex = 9;
            this.textCheckBit.Text = "校验位：";
            // 
            // cbDataBit
            // 
            this.cbDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBit.Location = new System.Drawing.Point(394, 88);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(101, 23);
            this.cbDataBit.TabIndex = 8;
            // 
            // textDataBit
            // 
            this.textDataBit.AutoSize = true;
            this.textDataBit.Location = new System.Drawing.Point(321, 91);
            this.textDataBit.Name = "textDataBit";
            this.textDataBit.Size = new System.Drawing.Size(67, 15);
            this.textDataBit.TabIndex = 7;
            this.textDataBit.Text = "数据位：";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(394, 24);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 43);
            this.btnOpenPort.TabIndex = 6;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // cbStopBit
            // 
            this.cbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBit.Location = new System.Drawing.Point(142, 130);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(101, 23);
            this.cbStopBit.TabIndex = 5;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(142, 88);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(101, 23);
            this.cbBaudRate.TabIndex = 4;
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(142, 44);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(101, 23);
            this.cbPort.TabIndex = 3;
            // 
            // textStopBit
            // 
            this.textStopBit.AutoSize = true;
            this.textStopBit.Location = new System.Drawing.Point(69, 133);
            this.textStopBit.Name = "textStopBit";
            this.textStopBit.Size = new System.Drawing.Size(67, 15);
            this.textStopBit.TabIndex = 2;
            this.textStopBit.Text = "停止位：";
            // 
            // textBaudRate
            // 
            this.textBaudRate.AutoSize = true;
            this.textBaudRate.Location = new System.Drawing.Point(69, 91);
            this.textBaudRate.Name = "textBaudRate";
            this.textBaudRate.Size = new System.Drawing.Size(67, 15);
            this.textBaudRate.TabIndex = 1;
            this.textBaudRate.Text = "波特率：";
            // 
            // txtbDataSend
            // 
            this.txtbDataSend.Location = new System.Drawing.Point(6, 24);
            this.txtbDataSend.Multiline = true;
            this.txtbDataSend.Name = "txtbDataSend";
            this.txtbDataSend.Size = new System.Drawing.Size(327, 132);
            this.txtbDataSend.TabIndex = 3;
            // 
            // gbDataSend
            // 
            this.gbDataSend.Controls.Add(this.btnDataSend);
            this.gbDataSend.Controls.Add(this.txtbDataSend);
            this.gbDataSend.Location = new System.Drawing.Point(12, 196);
            this.gbDataSend.Name = "gbDataSend";
            this.gbDataSend.Size = new System.Drawing.Size(523, 171);
            this.gbDataSend.TabIndex = 4;
            this.gbDataSend.TabStop = false;
            this.gbDataSend.Text = "数据发送";
            // 
            // btnDataSend
            // 
            this.btnDataSend.Location = new System.Drawing.Point(394, 63);
            this.btnDataSend.Name = "btnDataSend";
            this.btnDataSend.Size = new System.Drawing.Size(75, 49);
            this.btnDataSend.TabIndex = 11;
            this.btnDataSend.Text = "发送数据";
            this.btnDataSend.UseVisualStyleBackColor = true;
            this.btnDataSend.Click += new System.EventHandler(this.btnDataSend_Click);
            // 
            // gbDataRecive
            // 
            this.gbDataRecive.Controls.Add(this.txtbDataRecive);
            this.gbDataRecive.Location = new System.Drawing.Point(12, 373);
            this.gbDataRecive.Name = "gbDataRecive";
            this.gbDataRecive.Size = new System.Drawing.Size(523, 171);
            this.gbDataRecive.TabIndex = 12;
            this.gbDataRecive.TabStop = false;
            this.gbDataRecive.Text = "接收数据";
            // 
            // txtbDataRecive
            // 
            this.txtbDataRecive.Location = new System.Drawing.Point(6, 24);
            this.txtbDataRecive.Multiline = true;
            this.txtbDataRecive.Name = "txtbDataRecive";
            this.txtbDataRecive.Size = new System.Drawing.Size(511, 132);
            this.txtbDataRecive.TabIndex = 3;
            // 
            // SerialTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 562);
            this.Controls.Add(this.gbDataRecive);
            this.Controls.Add(this.gbDataSend);
            this.Controls.Add(this.gbSerialSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SerialTool";
            this.Text = "串口工具";
            this.gbSerialSetting.ResumeLayout(false);
            this.gbSerialSetting.PerformLayout();
            this.gbDataSend.ResumeLayout(false);
            this.gbDataSend.PerformLayout();
            this.gbDataRecive.ResumeLayout(false);
            this.gbDataRecive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textPort;
        private System.Windows.Forms.GroupBox gbSerialSetting;
        private System.Windows.Forms.Label textStopBit;
        private System.Windows.Forms.Label textBaudRate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbCheckBit;
        private System.Windows.Forms.Label textCheckBit;
        private System.Windows.Forms.ComboBox cbDataBit;
        private System.Windows.Forms.Label textDataBit;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.TextBox txtbDataSend;
        private System.Windows.Forms.GroupBox gbDataSend;
        private System.Windows.Forms.Button btnDataSend;
        private System.Windows.Forms.GroupBox gbDataRecive;
        private System.Windows.Forms.TextBox txtbDataRecive;
    }
}

