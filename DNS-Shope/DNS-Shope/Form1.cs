namespace DNS_Shope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] list = { "Доп. жесткий диск", "Принтер", "Спутниковая антена" };
            listBox1.Items.AddRange(list);
            string[] list1 = { "₽ Рубли", "$ Dollar", "£ Sterling", "Чек/Check"};
            comboBox1.Items.AddRange(list1);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton1.Checked == true ? pictureBox1.Visible = true : pictureBox1.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = checkBox4.Checked == true ? pictureBox7.Visible = true : pictureBox7.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = radioButton2.Checked == true ? pictureBox2.Visible = true : pictureBox2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = radioButton3.Checked == true ? pictureBox3.Visible = true : pictureBox3.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox1.Checked == true ? pictureBox4.Visible = true : pictureBox4.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = checkBox2.Checked == true ? pictureBox5.Visible = true : pictureBox5.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = checkBox3.Checked == true ? pictureBox6.Visible = true : pictureBox6.Visible = false;
        }
    }
}