using System.Windows.Forms;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Casino777_C.Form1;
using System.Security.Policy;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace Casino777_C
{
    public partial class Form1 : Form
    {
        float win = 0;
        float clk = 0;
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            pictureBox1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] ArrayRandom = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int[] ArrayValue = { random.Next(10), random.Next(10), random.Next(10) };
            label1.Text = ArrayRandom[ArrayValue[0]];
            label2.Text = ArrayRandom[ArrayValue[1]];
            label3.Text = ArrayRandom[ArrayValue[2]];
            if (ArrayValue[0] == 7 || ArrayValue[1] == 7 || ArrayValue[2] == 7)
            {
                label4.Visible = true;
                pictureBox1.Visible = true;
                win++;
                clk++;
            }  
            else
            {
                label4.Visible = false;
                pictureBox1.Visible = false;
                clk++;
            }
            float Mach = win / clk * 100;
            string Procents = "Процент выигрыша ";
            label5.Text = Procents + Math.Round(Mach,2).ToString() + "%";
        }
    }
}