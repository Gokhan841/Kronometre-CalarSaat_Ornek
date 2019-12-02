using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye=0;
        int dakika = 0;
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            // kronometre yapmı
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int salise = Convert.ToInt32(label1.Text);
            salise++;
            label1.Text = salise.ToString();

            if (salise == 100) 
            {
                salise = 0;
                label1.Text = salise.ToString();
                saniye++;
                label2.Text = saniye.ToString();
            }

            if (saniye == 59)
            {
                saniye = 0;
                label2.Text = saniye.ToString();
                dakika++;
                label3.Text = dakika.ToString();

            }
        }

        private void lblgun_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Alarm Yapımı
            lblgun.Text = DateTime.Now.Day.ToString();
            lblay.Text = DateTime.Now.Month.ToString();
            label11.Text = DateTime.Now.Hour.ToString();
            label12.Text = DateTime.Now.Minute.ToString();
            label13.Text = DateTime.Now.Second.ToString();
            timer2.Start();

            int i, gun, ay;
            for (gun=1; gun<=31;gun++)
            {
                comboBox1.Items.Add(gun);
            }
            for (ay=1;ay<=12;ay++)
            {
                comboBox2.Items.Add(ay);
            }
            for (i = 0; i <= 59; i++)
            {
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)

        {
            lblgun.Text = DateTime.Now.Day.ToString();
            lblay.Text = DateTime.Now.Month.ToString();
            label11.Text = DateTime.Now.Hour.ToString();
            label12.Text = DateTime.Now.Minute.ToString();
            label13.Text = DateTime.Now.Second.ToString();
            if (comboBox1.Text==lblgun.Text && comboBox2.Text==lblay.Text && comboBox3.Text==label11.Text&&comboBox4.Text==label12.Text)
            {
                timer2.Stop();
                MessageBox.Show("alarm çalıyor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //Trafik Lambası Örneği (timer3 intervali 1000)
            int sayi = Convert.ToInt32(label9.Text);
            sayi++;
            label9.Text = sayi.ToString();
            if (sayi>=0 && sayi <=30)
            {
                radioButton1.BackColor = Color.Red;
                radioButton3.BackColor = Color.White;
            }
            if (sayi>30 && sayi<=35)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.Orange;
            }
            if(sayi>35 && sayi<=59)
            {
                radioButton3.BackColor = Color.Green;
                radioButton2.BackColor = Color.White;
            }
            if(sayi==60)
            {
                sayi = 0;
                label9.Text = sayi.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
    }
}
