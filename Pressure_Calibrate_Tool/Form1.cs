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


namespace Pressure_Calibrate_Tool
{
    public partial class Form1 : Form
    {

        private bool m_SerialPortOpened = false;
        private string[] m_old_serialPortNames;
        private List<byte> m_buffer = new List<byte>();

        private const int HEAD = 0;
        private const int LEN = 1;
        private const int CMDTYPE = 2;
        private const int FRAME_ID = 3;
       // private List<byte> m_SN_list = new List<byte>();

        private struct POINT
        {
            public Int32 mmgH_value;
            public Int32 adc_value;
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text=="")
            {
                return;
            }
            if (Convert.ToUInt32(((TextBox)sender).Text) < 0 || Convert.ToUInt32(((TextBox)sender).Text) > 255)
            {
                MessageBox.Show("Out of range,please input again!");
                ((TextBox)sender).Text = "0";
            }
        }


        private void LoadPicture()
        {
            if (!m_SerialPortOpened)
            {
                this.pictureBox1.Load(Environment.CurrentDirectory + @"\" + "red.bmp");
            }
            else
            {
                this.pictureBox1.Load(Environment.CurrentDirectory + @"\" + "green.bmp");
            }
        }

        private void button_serialPort_open_Click(object sender, EventArgs e)
        {
            m_SerialPortOpened = !m_SerialPortOpened;

            if (m_SerialPortOpened)
            {
                try
                {
                    this.serialPort1.Open();
                }
                catch (Exception ex)
                {
                    m_SerialPortOpened = false;
                    MessageBox.Show("系统信息:" + ex.Message);
                    return;
                }
                this.button_serialPort_connect.Text = "Close";

                m_SerialPortOpened = true;
                this.comboBox_serial_portName.Enabled = false;
                LoadPicture();

            }
            else
            {
                this.button_serialPort_connect.Text = "Connect";
                this.serialPort1.Close();
                m_SerialPortOpened = false;
                LoadPicture();
                this.comboBox_serial_portName.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] names = SerialPort.GetPortNames();

            if (names.Length == 0)
            {
                return;
            }
            if (m_old_serialPortNames == null)
            {
                return;
            }
            //Array.Sort(names);
            Array.Sort(names, (a, b) => Convert.ToInt32(((string)a).Substring(3)).CompareTo(Convert.ToInt32(((string)b).Substring(3))));
            int nCount = 0;
            if (names.Length == m_old_serialPortNames.Length)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == m_old_serialPortNames[i])
                    {
                        nCount++;
                    }
                }
                if (nCount == names.Length)  //如果每个都相同
                {
                    return;
                }
                else
                {
                    m_old_serialPortNames = names;  //如果不匹配，将新的值赋给旧的值
                }
            }
            else
            {
                m_old_serialPortNames = names;
            }

            this.comboBox_serial_portName.Items.Clear();

            Array.Sort(names, (a, b) => Convert.ToInt32(((string)a).Substring(3)).CompareTo(Convert.ToInt32(((string)b).Substring(3))));

            this.comboBox_serial_portName.Items.AddRange(names);
            this.comboBox_serial_portName.SelectedIndex = 0; 
        }

        private void Init_SerialPort()
        {
            string[] ports = SerialPort.GetPortNames();

            if (ports.Length != 0)
            {
                //Array.Sort(ports);
                Array.Sort(ports, (a, b) => Convert.ToInt32(((string)a).Substring(3)).CompareTo(Convert.ToInt32(((string)b).Substring(3))));
                m_old_serialPortNames = ports;
                this.comboBox_serial_portName.Items.AddRange(ports);
                this.comboBox_serial_portName.SelectedIndex = 0;
            }

            this.comboBox_serial_baud.Text = "115200";
            this.comboBox_serial_dataBits.Text = "8";
            this.comboBox_serial_stopBits.Text = "one";
            this.comboBox_serial_parity.Text = "none";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPicture();
            Init_SerialPort();
        }

        private Int32 abs(Int32 a, Int32 b)
        {
            if (a > b)
                return a - b;
            else
                return b - a;
        }

        private Int32 cal_pressure_rate(POINT point_1,POINT point_2,POINT point_3)
        {

            float rate1 = (float)((abs(point_2.adc_value , point_1.adc_value)) / (abs(point_2.mmgH_value , point_1.mmgH_value)));
            float rate2 = (float)((abs(point_3.adc_value, point_1.adc_value)) / (abs(point_3.mmgH_value, point_1.mmgH_value)));
            return (Int32)((rate1 + rate2) / 2);
        }

        private void ParseFrame0x60()
        {
            int len = m_buffer.Count;
            if (len != m_buffer[1]+2)  
            {
                MessageBox.Show("数据不是11位!");
                return;
            }

            ////将接收到的SN放入m_SN_list中
            //for (int i = 4; i < len - 2; i++)
            //{
            //    m_SN_list.Add(m_buffer[i]);
            //}

            POINT point_1 = new POINT() { mmgH_value = m_buffer[4], adc_value = m_buffer[5] * 256 + m_buffer[6] };
            POINT point_2 = new POINT() { mmgH_value = m_buffer[7], adc_value = m_buffer[8] * 256 + m_buffer[9] };
            POINT point_3 = new POINT() { mmgH_value = m_buffer[10], adc_value = m_buffer[11] * 256 + m_buffer[12] };

            if (abs(point_2.mmgH_value, point_1.mmgH_value) == 0 || abs(point_3.mmgH_value, point_1.mmgH_value) == 0 || abs(point_2.mmgH_value, point_3.mmgH_value) == 0)
            {
                MessageBox.Show("发送的压力值不允许重复！请修改后重新发送！");
                return;

            }

            textBox_mmgH_1.Text = Convert.ToString(point_1.mmgH_value);
            textBox_adc_value_1.Text = Convert.ToString(point_1.adc_value);

            textBox_mmgH_2.Text = Convert.ToString(point_2.mmgH_value);
            textBox_adc_value_2.Text = Convert.ToString(point_2.adc_value);


            textBox_mmgH_3.Text = Convert.ToString(point_3.mmgH_value);
            textBox_adc_value_3.Text = Convert.ToString(point_3.adc_value);

            textBox_zero_point_value.Text = Convert.ToString(m_buffer[13]*256+m_buffer[14]);

            //计算斜率
            textBox_rate.Text = Convert.ToString(cal_pressure_rate(point_1, point_2, point_3));
        }

        private void ParseData2Lists()
        {
            //将数据解析挂入到3个链表中
            if (m_buffer[CMDTYPE] != 0x00)
            {
                return;
            }
            //根据帧类型来判断
            switch (m_buffer[FRAME_ID])
            {
                case 0x60:   //下位机返回0x40,携带SN
                    //MessageBox.Show(textBox_SN_recv.Text);
                    //textBox_SN_recv.Clear();

                    ParseFrame0x60();
                    break;
                default:
                    break;
            }
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var nPendingRead = this.serialPort1.BytesToRead;
            byte[] tmp = new byte[nPendingRead];
            this.serialPort1.Read(tmp, 0, nPendingRead);

            //m_bRcvParamtersCompleted = false;
            lock (m_buffer)
            {
                m_buffer.AddRange(tmp);
                #region
                while (m_buffer.Count >= 4)
                {
                    if (m_buffer[HEAD] == 0xFF) //帧头
                    {
                        int len = Convert.ToUInt32(m_buffer[LEN]); // 获取帧长度(不包含checksum1和checksum2)
                        if (m_buffer.Count < len + 2)  //数据没有接收完全，继续接收
                        {
                            break;
                        }
                        int checksum = 256 * Convert.ToUInt32(m_buffer[len]) + Convert.ToUInt32(m_buffer[len + 1]);
                        int sum = 0;
                        for (int i = 1; i < len; i++) //校验和不包含包头
                        {
                            sum += Convert.ToUInt32(m_buffer[i]);
                        }
                        //MessageBox.Show(sum.ToString());
                        if (checksum == sum)
                        {
                            //处理接收的数据
                            ParseData2Lists();
                        }
                        else
                        {
                            //校验之后发现数据不对,清除该帧数据
                            m_buffer.RemoveRange(0, len + 2);
                            continue;
                        }
                        m_buffer.RemoveRange(0, len + 2);
                    }
                    else
                    {
                        m_buffer.RemoveAt(0); //清除帧头
                    }
                }
                #endregion
            }
        }

       

        private void send_data_by_ID(string text, Int32 ID)
        {

            if (!this.serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect serial port first!");
                return;
            }

            if (text == "")
            {
                MessageBox.Show("发送的数据为空，请检查！");
                return;
            }

            UInt32 n_send = 0;
            n_send = Convert.ToUInt32(text);

            //发送SN到下位机
            byte[] buffer = new byte[7];
            switch (ID)
            {
                case 1:
                    buffer[FRAME_ID] = 0x50;
                    break;
                case 2:
                    buffer[FRAME_ID] = 0x51;
                    break;
                case 3:
                    buffer[FRAME_ID] = 0x52;
                    break;
                default:
                    break;
            }
            
            buffer[HEAD] = 0xFF;
            buffer[LEN] = 0x05;   //4+1
            buffer[CMDTYPE] = 0x01;
            //buffer[FRAME_ID] = 0x50;

            int sum = 0;
            for (int i = 4; i < 5; i++)
            {
                buffer[i] = Convert.ToByte(n_send);
            }

            for (int i = 1; i < Convert.ToInt32(buffer[LEN]); i++)
            {
                sum += buffer[i];
            }

            buffer[Convert.ToInt32(buffer[LEN])] = Convert.ToByte(sum / 256);   //checksum1
            buffer[Convert.ToInt32(buffer[LEN]) + 1] = Convert.ToByte(sum % 256); //checksum2
            this.serialPort1.Write(buffer, 0, Convert.ToInt32(buffer[LEN]) + 2);

        }


        private void button_sendPressure1_Click(object sender, EventArgs e)
        {
            send_data_by_ID(this.textBox_pressure_1.Text, 1);
        }

        private void button_sendPressure2_Click(object sender, EventArgs e)
        {
            send_data_by_ID(this.textBox_pressure_2.Text, 2);
        }

        private void button_sendPressure3_Click(object sender, EventArgs e)
        {
            send_data_by_ID(this.textBox_pressure_3.Text, 3);
        }

        private void textBox_pressure_2_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                return;
            }
            if (Convert.ToInt32(((TextBox)sender).Text) < 0 || Convert.ToInt32(((TextBox)sender).Text) > 255)
            {
                MessageBox.Show("Out of range,please input again!");
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBox_pressure_3_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                return;
            }
            if (Convert.ToInt32(((TextBox)sender).Text) < 0 || Convert.ToInt32(((TextBox)sender).Text) > 255)
            {
                MessageBox.Show("Out of range,please input again!");
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBox_pressure_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            } 
        }

        private void textBox_pressure_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            } 
        }

        private void textBox_pressure_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            } 
        }

        private void comboBox_serial_portName_SelectedValueChanged(object sender, EventArgs e)
        {
            this.serialPort1.PortName = this.comboBox_serial_portName.Text;
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_pressure_1.Text = "";
            textBox_pressure_2.Text = "";
            textBox_pressure_3.Text = "";

            textBox_mmgH_1.Text = "";
            textBox_mmgH_2.Text = "";
            textBox_mmgH_3.Text = "";

            textBox_adc_value_1.Text = "";
            textBox_adc_value_2.Text = "";
            textBox_adc_value_3.Text = "";

            textBox_rate.Text = "";
            textBox_zero_point_value.Text = "";
        }
    }
}
