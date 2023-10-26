using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using System.Threading;

namespace SerialTool
{
    public partial class SerialTool : Form
    {
        private SerialPort serialPort;
        private string[] strPortNames;
        private Thread thread;
        public SerialTool()
        {
            InitializeComponent();
            InitializeSerialPortSetting();
        }

        private void InitializeSerialPortSetting()
        {
            serialPort = new SerialPort();
           //检查串口
            strPortNames = SerialPort.GetPortNames();
            if (strPortNames == null)
            {
                MessageBox.Show("没有串口!请检查串口设备是否正常连接至此计算机。", "Error");
                Environment.Exit(0);
            }
            foreach (string strPortName in strPortNames)
            {
                cbPort.Items.Add(strPortName); 
            }
            //界面配置设置初始值
            cbPort.SelectedIndex = 0;
            cbBaudRate.SelectedIndex = 0;
            cbCheckBit.SelectedIndex = 0;
            cbDataBit.SelectedIndex = 0;
            cbStopBit.SelectedIndex = 0;
            thread = new Thread(DataReceive);
            thread.IsBackground = true;
        }

        private void SerialPortX()
        {
            if (!serialPort.IsOpen)
            {
                //设置串口号
                serialPort.PortName = cbPort.Text;
                serialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort.DataBits = Convert.ToInt32(cbDataBit.Text);
                switch (cbCheckBit.Text)
                {
                    case "无":
                        serialPort.Parity = Parity.None; break;
                    case "奇校验":
                        serialPort.Parity = Parity.Odd; break;
                    case "偶校验":
                        serialPort.Parity = Parity.Even; break;
                }
                switch (cbStopBit.Text)
                {
                    case "1":
                        serialPort.StopBits = StopBits.One; break;
                    case "2":
                        serialPort.StopBits = StopBits.Two; break;
                    case "1.5":
                        serialPort.StopBits = StopBits.OnePointFive; break; 
                }
                serialPort.Open();
                if(!thread.IsAlive)
                {
                    thread.Start();
                }
                else
                {
                    thread.Resume();
                }
                cbCheckBit.Enabled = false;
                cbStopBit.Enabled = false;
                cbBaudRate.Enabled = false;
                cbDataBit.Enabled = false;
                cbPort.Enabled = false;
                btnOpenPort.Text = "关闭串口";
            }
            else
            {
                serialPort.Close();
                thread.Suspend();
                cbCheckBit.Enabled = true;
                cbStopBit.Enabled = true;
                cbBaudRate.Enabled = true;
                cbDataBit.Enabled = true;
                cbPort.Enabled = true;
                txtbDataRecive.Clear();
                btnOpenPort.Text = "打开串口";
            }
        }

        private void DataReceive()
        {
            while (true)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    try
                    {
                        if(serialPort.BytesToRead > 0)
                        {
                            DateTime now = DateTime.Now;
                            txtbDataRecive.Text += now.GetDateTimeFormats('f', CultureInfo.CreateSpecificCulture("zh-CN"))[0];
                            Byte[] receivedData = new Byte[serialPort.BytesToRead];
                            serialPort.Read(receivedData, 0, receivedData.Length);
                            UTF8Encoding utf8 = new UTF8Encoding();
                            String ReceivedData = utf8.GetString(receivedData);
                            txtbDataRecive.AppendText(ReceivedData);
                            txtbDataRecive.AppendText("\r\n");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "Error");
                    }
                }));
                Thread.Sleep(1000);
            }
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Convert.ToInt32(cbBaudRate.Text));
            SerialPortX();
        }

        private void btnDataSend_Click(object sender, EventArgs e)
        {
            byte[] sendData = null;
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("请先打开串口", "Error");
            }
            else if (txtbDataSend.Text.Length == 0)
            {
                MessageBox.Show("发送数据不能为空", "Error");
            }
            else
            {
                try
                {
                    sendData = Encoding.UTF8.GetBytes(txtbDataSend.Text.Trim());
                    serialPort.Write(sendData, 0, sendData.Length);
                    MessageBox.Show("发送数据成功","Sucess");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                }

            }
        }

    }
}
