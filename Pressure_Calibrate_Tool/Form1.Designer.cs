namespace Pressure_Calibrate_Tool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pressure_1 = new System.Windows.Forms.TextBox();
            this.textBox_pressure_2 = new System.Windows.Forms.TextBox();
            this.button_sendPressure1 = new System.Windows.Forms.Button();
            this.button_sendPressure2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_zero_point_value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_pressure_3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_sendPressure3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_adc_value_3 = new System.Windows.Forms.TextBox();
            this.textBox_mmgH_3 = new System.Windows.Forms.TextBox();
            this.textBox_adc_value_2 = new System.Windows.Forms.TextBox();
            this.textBox_mmgH_2 = new System.Windows.Forms.TextBox();
            this.textBox_adc_value_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_mmgH_1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_serialPort_connect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_serial_parity = new System.Windows.Forms.ComboBox();
            this.comboBox_serial_stopBits = new System.Windows.Forms.ComboBox();
            this.comboBox_serial_dataBits = new System.Windows.Forms.ComboBox();
            this.comboBox_serial_baud = new System.Windows.Forms.ComboBox();
            this.comboBox_serial_portName = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "压力值1(mmgH)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "压力值2(mmgH)：";
            // 
            // textBox_pressure_1
            // 
            this.textBox_pressure_1.Location = new System.Drawing.Point(162, 27);
            this.textBox_pressure_1.MaxLength = 3;
            this.textBox_pressure_1.Name = "textBox_pressure_1";
            this.textBox_pressure_1.Size = new System.Drawing.Size(95, 21);
            this.textBox_pressure_1.TabIndex = 2;
            this.textBox_pressure_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_pressure_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pressure_1_KeyPress);
            // 
            // textBox_pressure_2
            // 
            this.textBox_pressure_2.Location = new System.Drawing.Point(162, 71);
            this.textBox_pressure_2.MaxLength = 3;
            this.textBox_pressure_2.Name = "textBox_pressure_2";
            this.textBox_pressure_2.Size = new System.Drawing.Size(95, 21);
            this.textBox_pressure_2.TabIndex = 3;
            this.textBox_pressure_2.TextChanged += new System.EventHandler(this.textBox_pressure_2_TextChanged);
            this.textBox_pressure_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pressure_2_KeyPress);
            // 
            // button_sendPressure1
            // 
            this.button_sendPressure1.Location = new System.Drawing.Point(317, 25);
            this.button_sendPressure1.Name = "button_sendPressure1";
            this.button_sendPressure1.Size = new System.Drawing.Size(75, 23);
            this.button_sendPressure1.TabIndex = 4;
            this.button_sendPressure1.Text = "发送1";
            this.button_sendPressure1.UseVisualStyleBackColor = true;
            this.button_sendPressure1.Click += new System.EventHandler(this.button_sendPressure1_Click);
            // 
            // button_sendPressure2
            // 
            this.button_sendPressure2.Location = new System.Drawing.Point(317, 68);
            this.button_sendPressure2.Name = "button_sendPressure2";
            this.button_sendPressure2.Size = new System.Drawing.Size(75, 23);
            this.button_sendPressure2.TabIndex = 5;
            this.button_sendPressure2.Text = "发送2";
            this.button_sendPressure2.UseVisualStyleBackColor = true;
            this.button_sendPressure2.Click += new System.EventHandler(this.button_sendPressure2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y=";
            // 
            // textBox_rate
            // 
            this.textBox_rate.Location = new System.Drawing.Point(48, 39);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(49, 21);
            this.textBox_rate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "*X+";
            // 
            // textBox_zero_point_value
            // 
            this.textBox_zero_point_value.Location = new System.Drawing.Point(134, 39);
            this.textBox_zero_point_value.Name = "textBox_zero_point_value";
            this.textBox_zero_point_value.Size = new System.Drawing.Size(48, 21);
            this.textBox_zero_point_value.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "(斜率)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "(零点)";
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(25, 267);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(121, 49);
            this.button_clean.TabIndex = 13;
            this.button_clean.Text = "清除所有数据";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_rate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_zero_point_value);
            this.groupBox1.Location = new System.Drawing.Point(464, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "曲线";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_pressure_3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_sendPressure3);
            this.groupBox2.Controls.Add(this.textBox_pressure_2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_pressure_1);
            this.groupBox2.Controls.Add(this.button_sendPressure2);
            this.groupBox2.Controls.Add(this.button_sendPressure1);
            this.groupBox2.Location = new System.Drawing.Point(241, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 142);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送压力值";
            // 
            // textBox_pressure_3
            // 
            this.textBox_pressure_3.Location = new System.Drawing.Point(162, 115);
            this.textBox_pressure_3.MaxLength = 3;
            this.textBox_pressure_3.Name = "textBox_pressure_3";
            this.textBox_pressure_3.Size = new System.Drawing.Size(95, 21);
            this.textBox_pressure_3.TabIndex = 7;
            this.textBox_pressure_3.TextChanged += new System.EventHandler(this.textBox_pressure_3_TextChanged);
            this.textBox_pressure_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pressure_3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "压力值3(mmgH)：";
            // 
            // button_sendPressure3
            // 
            this.button_sendPressure3.Location = new System.Drawing.Point(317, 112);
            this.button_sendPressure3.Name = "button_sendPressure3";
            this.button_sendPressure3.Size = new System.Drawing.Size(75, 23);
            this.button_sendPressure3.TabIndex = 8;
            this.button_sendPressure3.Text = "发送3";
            this.button_sendPressure3.UseVisualStyleBackColor = true;
            this.button_sendPressure3.Click += new System.EventHandler(this.button_sendPressure3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox_adc_value_3);
            this.groupBox3.Controls.Add(this.textBox_mmgH_3);
            this.groupBox3.Controls.Add(this.textBox_adc_value_2);
            this.groupBox3.Controls.Add(this.textBox_mmgH_2);
            this.groupBox3.Controls.Add(this.textBox_adc_value_1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_mmgH_1);
            this.groupBox3.Location = new System.Drawing.Point(241, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 167);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读取下位机";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 17;
            this.label17.Text = "->";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(85, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 16;
            this.label16.Text = "->";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "->";
            // 
            // textBox_adc_value_3
            // 
            this.textBox_adc_value_3.Location = new System.Drawing.Point(108, 128);
            this.textBox_adc_value_3.Name = "textBox_adc_value_3";
            this.textBox_adc_value_3.Size = new System.Drawing.Size(58, 21);
            this.textBox_adc_value_3.TabIndex = 15;
            // 
            // textBox_mmgH_3
            // 
            this.textBox_mmgH_3.Location = new System.Drawing.Point(20, 128);
            this.textBox_mmgH_3.Name = "textBox_mmgH_3";
            this.textBox_mmgH_3.Size = new System.Drawing.Size(58, 21);
            this.textBox_mmgH_3.TabIndex = 14;
            // 
            // textBox_adc_value_2
            // 
            this.textBox_adc_value_2.Location = new System.Drawing.Point(108, 91);
            this.textBox_adc_value_2.Name = "textBox_adc_value_2";
            this.textBox_adc_value_2.Size = new System.Drawing.Size(58, 21);
            this.textBox_adc_value_2.TabIndex = 13;
            // 
            // textBox_mmgH_2
            // 
            this.textBox_mmgH_2.Location = new System.Drawing.Point(20, 91);
            this.textBox_mmgH_2.Name = "textBox_mmgH_2";
            this.textBox_mmgH_2.Size = new System.Drawing.Size(58, 21);
            this.textBox_mmgH_2.TabIndex = 12;
            // 
            // textBox_adc_value_1
            // 
            this.textBox_adc_value_1.Location = new System.Drawing.Point(108, 51);
            this.textBox_adc_value_1.Name = "textBox_adc_value_1";
            this.textBox_adc_value_1.Size = new System.Drawing.Size(58, 21);
            this.textBox_adc_value_1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "adc_value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "mmgH";
            // 
            // textBox_mmgH_1
            // 
            this.textBox_mmgH_1.Location = new System.Drawing.Point(20, 51);
            this.textBox_mmgH_1.Name = "textBox_mmgH_1";
            this.textBox_mmgH_1.Size = new System.Drawing.Size(58, 21);
            this.textBox_mmgH_1.TabIndex = 9;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_serialPort_connect);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.comboBox_serial_parity);
            this.groupBox4.Controls.Add(this.comboBox_serial_stopBits);
            this.groupBox4.Controls.Add(this.comboBox_serial_dataBits);
            this.groupBox4.Controls.Add(this.comboBox_serial_baud);
            this.groupBox4.Controls.Add(this.comboBox_serial_portName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 248);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口";
            // 
            // button_serialPort_connect
            // 
            this.button_serialPort_connect.Location = new System.Drawing.Point(96, 205);
            this.button_serialPort_connect.Name = "button_serialPort_connect";
            this.button_serialPort_connect.Size = new System.Drawing.Size(75, 23);
            this.button_serialPort_connect.TabIndex = 9;
            this.button_serialPort_connect.Text = "connect";
            this.button_serialPort_connect.UseVisualStyleBackColor = true;
            this.button_serialPort_connect.Click += new System.EventHandler(this.button_serialPort_open_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_serial_parity
            // 
            this.comboBox_serial_parity.FormattingEnabled = true;
            this.comboBox_serial_parity.Location = new System.Drawing.Point(96, 164);
            this.comboBox_serial_parity.Name = "comboBox_serial_parity";
            this.comboBox_serial_parity.Size = new System.Drawing.Size(89, 20);
            this.comboBox_serial_parity.TabIndex = 10;
            // 
            // comboBox_serial_stopBits
            // 
            this.comboBox_serial_stopBits.FormattingEnabled = true;
            this.comboBox_serial_stopBits.Location = new System.Drawing.Point(96, 130);
            this.comboBox_serial_stopBits.Name = "comboBox_serial_stopBits";
            this.comboBox_serial_stopBits.Size = new System.Drawing.Size(89, 20);
            this.comboBox_serial_stopBits.TabIndex = 9;
            // 
            // comboBox_serial_dataBits
            // 
            this.comboBox_serial_dataBits.FormattingEnabled = true;
            this.comboBox_serial_dataBits.Location = new System.Drawing.Point(96, 96);
            this.comboBox_serial_dataBits.Name = "comboBox_serial_dataBits";
            this.comboBox_serial_dataBits.Size = new System.Drawing.Size(89, 20);
            this.comboBox_serial_dataBits.TabIndex = 8;
            // 
            // comboBox_serial_baud
            // 
            this.comboBox_serial_baud.FormattingEnabled = true;
            this.comboBox_serial_baud.Location = new System.Drawing.Point(96, 63);
            this.comboBox_serial_baud.Name = "comboBox_serial_baud";
            this.comboBox_serial_baud.Size = new System.Drawing.Size(89, 20);
            this.comboBox_serial_baud.TabIndex = 7;
            // 
            // comboBox_serial_portName
            // 
            this.comboBox_serial_portName.FormattingEnabled = true;
            this.comboBox_serial_portName.Location = new System.Drawing.Point(96, 31);
            this.comboBox_serial_portName.Name = "comboBox_serial_portName";
            this.comboBox_serial_portName.Size = new System.Drawing.Size(89, 20);
            this.comboBox_serial_portName.TabIndex = 6;
            this.comboBox_serial_portName.SelectedValueChanged += new System.EventHandler(this.comboBox_serial_portName_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "Parity：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "Stop bits：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "Data bits：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "Baud：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "Port name：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 356);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pressure_Calibrate_Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pressure_1;
        private System.Windows.Forms.TextBox textBox_pressure_2;
        private System.Windows.Forms.Button button_sendPressure1;
        private System.Windows.Forms.Button button_sendPressure2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_zero_point_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_pressure_3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_sendPressure3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_adc_value_3;
        private System.Windows.Forms.TextBox textBox_mmgH_3;
        private System.Windows.Forms.TextBox textBox_adc_value_2;
        private System.Windows.Forms.TextBox textBox_mmgH_2;
        private System.Windows.Forms.TextBox textBox_adc_value_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_mmgH_1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_serialPort_connect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_serial_parity;
        private System.Windows.Forms.ComboBox comboBox_serial_stopBits;
        private System.Windows.Forms.ComboBox comboBox_serial_dataBits;
        private System.Windows.Forms.ComboBox comboBox_serial_baud;
        private System.Windows.Forms.ComboBox comboBox_serial_portName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
    }
}

