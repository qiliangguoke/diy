using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_demo
{
    public partial class Form1 : Form
    {
        //判断串口打开状态
        private bool isOpen = false;
        //
        private bool isRxShow = true;
        //读取字节缓存区
        private List<byte> receiveBuffer = new List<byte>();
        //发送字节缓存区
        private List<byte> sendBuffer=new List<byte>();
        //读取缓存区字节个数
        private int receiveCount = 0;
        //发送缓存字节个数
        private int sendCount = 0;
        private int sendHexCount = 0;
        public Form1()
        {
            InitializeComponent();
            receive_txb.Clear();
        }
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            seriaLoad();
        }
        private void seriaLoad()
        {
            //send_txtbox   文本框name Text=字符串
            //this.send_txb.Text = "我是发送框";
            // this.receive_txb.Text = "我是接收框";
            //port_combox   下拉框name item下拉框集合    add 添加到下拉框
            //读取寄存器注册表
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            //获得
            string[] sSubKeys = keyCom.GetValueNames();
            port_combox.Items.Clear();
            foreach (var sSubKey in sSubKeys)
            {
                port_combox.Items.Add((string)keyCom.GetValue(sSubKey));
            }
            //初始化选择
            if(port_combox.Items.Count == 0) {
                MessageBox.Show("未找到可用串口");
            }
            else
            {
                this.port_combox.SelectedIndex = 0;
            }        
            this.baud_combox.SelectedIndex = 1;
            this.check_combox.SelectedIndex = 0;
            this.databit_combox.SelectedIndex = 3;
            this.stop_combox.SelectedIndex = 0;
        }
        //按钮点击事件
        private void send_btn_Click(object sender, EventArgs e)
        {
            if (this.send_txb.Text != "" && serialPort1.IsOpen)
            {
                
                //创建一个临时储存字节的数组            
                if (sendHex_chb.Checked)
                {
                    byte[] bytes = ByteArrayConvert.hexStringToByteArray(send_txb.Text);
                    sendCount += bytes.Length;
                    sendCount_tssl.Text = sendCount.ToString();
                    sendBuffer.AddRange(bytes);
                    serialPort1.Write(bytes, 0, bytes.Length);
                }
                else
                {
                   byte[] bytes=ByteArrayConvert.stringToByteArray(send_txb.Text);
                   sendCount += bytes.Length;
                    sendCount_tssl.Text = sendCount.ToString();
                    sendBuffer.AddRange(bytes);
                   serialPort1.Write(bytes, 0, bytes.Length); 
                }
            }
            else
            {
                MessageBox.Show("请输入文本");
            }
            //if(this.send_txb.Text!="")
            //{
            //    //AppendText 添加到文本框后面
            //    this.receive_txb.AppendText(this.send_txb.Text);  
            //}
            //else
            //{
            //    //MessageBox 对话框    show展示
            //    MessageBox.Show("请先输入数据");
            //}
        }
        private void openPort_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    //串口名称
                    serialPort1.PortName = this.port_combox.Text;
                    //波特率
                    serialPort1.BaudRate = Convert.ToInt32(this.baud_combox.Text);
                    //数据位
                    serialPort1.DataBits = Convert.ToInt32(this.databit_combox.Text);
                    //校验位
                    switch (check_combox.SelectedIndex)
                    {
                        case 0:
                            serialPort1.Parity = Parity.None;
                            break;
                        case 1:
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }
                    //停止位
                    switch (stop_combox.SelectedIndex)
                    {
                        case 0:
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                    }
                    serialPort1.Open();
                    isOpen = true;
                    openPort_btn.Text = "关闭串口";
                }
                else
                {
                    serialPort1.Close();
                    isOpen = false;
                    openPort_btn.Text = "打开串口";
                }
            }
            catch (Exception ex)
            {
                //serialPort1.PortName  串口的名字
                MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
                //创建一个临时储存字节的数组
                byte[] dataTemp = new byte[serialPort1.BytesToRead];
                serialPort1.Read(dataTemp, 0, dataTemp.Length);
                receiveBuffer.AddRange(dataTemp);
                receiveCount += dataTemp.Length;
                receiveCount_tssl.Text = receiveCount.ToString();
                this.Invoke(new EventHandler(delegate
                {
                    if(!hex_chb.Checked)
                    {
                        string str = Encoding.GetEncoding("gb2312").GetString(dataTemp);
                        str = str.Replace("\0", "\\0");
                        receive_txb.AppendText(" "+str);
                    }
                    else
                    {
                        receive_txb.AppendText(" "+ByteArrayConvert.byteArrayToHexString(dataTemp));
                    }   
                }
                ));
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            //清空接受框
            receive_txb.Clear();
            receiveCount_tssl.Text="0";
            receiveBuffer.Clear();
        }

        private void sendClear_btn_Click(object sender, EventArgs e)
        {
            //清空发送框
            send_txb.Clear();
            sendCount_tssl.Text="0";
            sendBuffer.Clear();
        }
        private void hex_chb_CheckedChanged(object sender, EventArgs e)
        {
            if(receive_txb.Text=="")
            { return; }
            //16进制开启
            if (hex_chb.Checked)
            {
                //将字符串转成字节数组
                byte[] bytes = ByteArrayConvert.stringToByteArray(receive_txb.Text);

                receive_txb.Text = ByteArrayConvert.byteArrayToHexString(bytes);
            }
            //16进制关闭
            else
            {
                //将16进制字符串转换成字节数组
                byte[] returnBytes = ByteArrayConvert.hexStringToByteArray(receive_txb.Text);
                //将字节数组转换成字符串
                receive_txb.Text = Encoding.GetEncoding("gb2312").GetString(returnBytes);
            }
        }
        private void autoClear_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (autoClear_chb.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();             
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (receive_txb.Text.Length >= 4096)
            {
                receiveBuffer.Clear();
                receiveCount_tssl.Text="0";
                receive_txb.Text = "";
            }
        }
        private void sendHex_chb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (send_txb.Text == "")
                { return; }
                //16进制开启
                if (sendHex_chb.Checked)
                {
                    //将字符串转成字节数组
                    byte[] bytes = ByteArrayConvert.stringToByteArray(send_txb.Text);

                    send_txb.Text = ByteArrayConvert.byteArrayToHexString(bytes);
                }
                //16进制关闭
                else
                {
                    //将16进制字符串转换成字节数组
                    byte[] returnBytes = ByteArrayConvert.hexStringToByteArray(send_txb.Text);
                    //将字节数组转换成字符串
                    send_txb.Text = Encoding.GetEncoding("gb2312").GetString(returnBytes);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                send_txb.Clear();
            }         
        }
        private void send_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(!sendHex_chb.Checked)
            {
                e.Handled = false;//允许输入
                if (sendHex_chb.Checked)
                {
                    sendHexCount++;
                    if (sendHexCount == 2)
                    {
                        send_txb.AppendText(" ");
                        sendHexCount = 0;
                    }
                }            
            }
            else if (((e.KeyChar <= '0' || e.KeyChar >= '9') && (e.KeyChar <= 'a' || e.KeyChar >= 'f')&& (e.KeyChar <= 'A' && e.KeyChar >= 'F')))
            {
                e.Handled = true;//不允许输入
            }
            else
            {
                sendHexCount++;
                if (sendHexCount == 2)
                {
                    send_txb.AppendText(" ");
                    sendHexCount = 0;
                }
                e.Handled = false;//允许输入             
            }
        }
        private void clearCount_tssl_Click(object sender, EventArgs e)
        {
            sendCount_tssl.Text = "0";
            receiveCount_tssl.Text="0";
            receiveBuffer.Clear();
            sendBuffer.Clear();
        }
    }
}
