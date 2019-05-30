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

namespace 串口助手
{
    public partial class Form1 : Form
    {
        SerialPort sp1 = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //忽略程序跨越线程运行导致的错误
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sp1.BaudRate = 9600;
            BaudRate.SelectedIndex = 1;
            comboBox2.SelectedIndex = 3;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;


            foreach (string com in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(com);   //获取COM口
            }

            sp1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            sp1.DtrEnable = true;
            sp1.RtsEnable = true;
            sp1.Close();
            rbSendHex.Checked = true;
            rbRcvStr.Checked = true;
 
        }


        private void 发送按钮_Click(object sender, EventArgs e)
        {
            if (!sp1.IsOpen) //如果没打开
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }

            String strSend = 输入框.Text;
            byte[] data = new byte[1];
            if (sp1.IsOpen)
            {
                if (rbSendHex.Checked)
                {
                    //处理数字转换
                    string sendBuf = strSend;
                    string sendnoNull = sendBuf.Trim();
                    string sendNOComma = sendnoNull.Replace(',', ' ');    //去掉英文逗号
                    string sendNOComma1 = sendNOComma.Replace('，', ' '); //去掉中文逗号
                    string strSendNoComma2 = sendNOComma1.Replace("0x", "");   //去掉0x
                    strSendNoComma2.Replace("0X", "");   //去掉0X
                    string[] strArray = strSendNoComma2.Split(' ');

                    int byteBufferLength = strArray.Length;
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        if (strArray[i] == "")
                        {
                            byteBufferLength--;
                        }
                    }
                    // int temp = 0;
                    byte[] byteBuffer = new byte[byteBufferLength];
                    int ii = 0;
                    for (int i = 0; i < strArray.Length; i++)        //对获取的字符做相加运算
                    {

                        Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);

                        int decNum = 0;
                        if (strArray[i] == "")
                        {
                            //ii--;     //加上此句是错误的，下面的continue以延缓了一个ii，不与i同步
                            continue;
                        }
                        else
                        {
                            decNum = Convert.ToInt32(strArray[i], 16); //atrArray[i] == 12时，temp == 18 
                        }

                        try    //防止输错，使其只能输入一个字节的字符
                        {
                            byteBuffer[ii] = Convert.ToByte(decNum);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                            
                            return;
                        }

                        ii++;
                    }
                    sp1.Write(byteBuffer, 0, byteBuffer.Length);
                }
                else
                {
                    sp1.WriteLine(输入框.Text);   
                }

            }
        }

        private void 清空按钮_Click(object sender, EventArgs e)
        {
            接收框.Text = "";
        }

        private void 关闭串口_Click(object sender, EventArgs e)
        {
            if (sp1.IsOpen)
            {
                comboBox1.Enabled = true;
                BaudRate.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                sp1.Close();
                打开串口.Enabled = true;
                关闭串口.Enabled = false;
            }
            
        }

        private void 打开串口_Click(object sender, EventArgs e)
        {
            if (!sp1.IsOpen)
            {
                try
                {
                    string serialName = comboBox1.SelectedItem.ToString();
                    sp1.PortName = serialName;
                    string strBaudRate = BaudRate.Text;
                    string strDateBits = comboBox2.Text;
                    string strStopBits = comboBox3.Text;
                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDateBits = Convert.ToInt32(strDateBits);

                    sp1.BaudRate = iBaudRate;       //波特率
                    sp1.DataBits = iDateBits;       //数据位
                    switch (comboBox3.Text)         //停止位
                    {
                        case "1":
                            sp1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    switch (comboBox4.Text)             //校验位
                    {
                        case "None":
                            sp1.Parity = Parity.None;
                            break;
                        case "奇校验":
                            sp1.Parity = Parity.Odd;
                            break;
                        case "偶校验":
                            sp1.Parity = Parity.Even;
                            break;
                        default:
                           MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    comboBox1.Enabled = false;
                    BaudRate.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    sp1.Open();     //打开串口
                }
                catch (System.Exception err)
                {
                    MessageBox.Show("Error:" + err.Message, "Error");

                    return;
                }

            }
            关闭串口.Enabled = true;
            打开串口.Enabled = false;

        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp1.IsOpen)
            {
                byte[] byteRead = new byte[sp1.BytesToRead];
                if (rbRcvStr.Checked)
                {
                    try
                    {
                       
                        byte[] receivedData = new byte[sp1.BytesToRead];
                        sp1.Read(receivedData, 0, receivedData.Length);
                        sp1.DiscardInBuffer();
                        string strRcv = null;
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += ((char)Convert.ToInt32(receivedData[i]));
                        }
                        接收框.Text += strRcv + "\r\n";             //显示信息
                      
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "出错提示");
                        接收框.Text = "";
                    }
                }
                else
                {
                    try
                    {
                        byte[] receivedData = new byte[sp1.BytesToRead];        //创建接收字节数组
                        sp1.Read(receivedData, 0, receivedData.Length);         //读取数据
                        //string text = sp1.Read();   //Encoding.ASCII.GetString(receivedData);
                        sp1.DiscardInBuffer();                                  //清空SerialPort控件的Buffer

                        string strRcv = null;
                        //int decNum = 0;//存储十进制
                        for (int i = 0; i < receivedData.Length; i++) //窗体显示
                        {
                            strRcv +=  
                            strRcv += receivedData[i].ToString("X2");  //16进制显示
                        }
                        接收框.Text += strRcv + "\r\n";
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "出错提示");
                        接收框.Text = "";
                    }
                }
            }


        }


    }
}




