namespace Timer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Kronometre = new System.Windows.Forms.Label();
            this.GÜN = new System.Windows.Forms.Label();
            this.AY = new System.Windows.Forms.Label();
            this.SAAT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sanniye = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblgun = new System.Windows.Forms.Label();
            this.lblay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "BAŞLAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Saniye";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dakika";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Kronometre
            // 
            this.Kronometre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kronometre.Location = new System.Drawing.Point(39, 25);
            this.Kronometre.Name = "Kronometre";
            this.Kronometre.Size = new System.Drawing.Size(186, 216);
            this.Kronometre.TabIndex = 3;
            this.Kronometre.Text = "                       Kronometre";
            // 
            // GÜN
            // 
            this.GÜN.AutoSize = true;
            this.GÜN.Location = new System.Drawing.Point(255, 67);
            this.GÜN.Name = "GÜN";
            this.GÜN.Size = new System.Drawing.Size(31, 13);
            this.GÜN.TabIndex = 4;
            this.GÜN.Text = "GÜN";
            // 
            // AY
            // 
            this.AY.AutoSize = true;
            this.AY.Location = new System.Drawing.Point(257, 102);
            this.AY.Name = "AY";
            this.AY.Size = new System.Drawing.Size(21, 13);
            this.AY.TabIndex = 4;
            this.AY.Text = "AY";
            // 
            // SAAT
            // 
            this.SAAT.AutoSize = true;
            this.SAAT.Location = new System.Drawing.Point(455, 69);
            this.SAAT.Name = "SAAT";
            this.SAAT.Size = new System.Drawing.Size(35, 13);
            this.SAAT.TabIndex = 4;
            this.SAAT.Text = "SAAT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "DAKİKA";
            // 
            // sanniye
            // 
            this.sanniye.AutoSize = true;
            this.sanniye.Location = new System.Drawing.Point(455, 148);
            this.sanniye.Name = "sanniye";
            this.sanniye.Size = new System.Drawing.Size(46, 13);
            this.sanniye.TabIndex = 4;
            this.sanniye.Text = "SANİYE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(302, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBox3.Location = new System.Drawing.Point(516, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(516, 104);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(53, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(516, 143);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(53, 21);
            this.comboBox5.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(354, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "KUR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(483, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "DURDUR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(600, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 31);
            this.button4.TabIndex = 6;
            this.button4.Text = "ERTELE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(247, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 216);
            this.label4.TabIndex = 3;
            this.label4.Text = "                                                               ÇALAR SAAT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblgun
            // 
            this.lblgun.AutoSize = true;
            this.lblgun.Location = new System.Drawing.Point(655, 42);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(19, 13);
            this.lblgun.TabIndex = 7;
            this.lblgun.Text = "00";
            this.lblgun.Click += new System.EventHandler(this.lblgun_Click);
            // 
            // lblay
            // 
            this.lblay.AutoSize = true;
            this.lblay.Location = new System.Drawing.Point(685, 42);
            this.lblay.Name = "lblay";
            this.lblay.Size = new System.Drawing.Size(19, 13);
            this.lblay.TabIndex = 7;
            this.lblay.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(655, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(685, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(717, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "00";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(280, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 124);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(264, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 22);
            this.button5.TabIndex = 10;
            this.button5.Text = "START";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "00";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(280, 266);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 19);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "label14";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(280, 299);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "label14";
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(280, 333);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 19);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.Text = "label14";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(299, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 83);
            this.label14.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(235, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 263);
            this.label15.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblay);
            this.Controls.Add(this.lblgun);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sanniye);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SAAT);
            this.Controls.Add(this.AY);
            this.Controls.Add(this.GÜN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kronometre);
            this.Controls.Add(this.label15);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Kronometre;
        private System.Windows.Forms.Label GÜN;
        private System.Windows.Forms.Label AY;
        private System.Windows.Forms.Label SAAT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sanniye;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.Label lblay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label radioButton1;
        private System.Windows.Forms.Label radioButton2;
        private System.Windows.Forms.Label radioButton3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

