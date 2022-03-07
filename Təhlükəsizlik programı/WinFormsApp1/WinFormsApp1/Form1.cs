namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Cloud" & textBox2.Text == "admin")
            {
                Form4 frm4 = new Form4();
                frm4.ShowDialog();
            }
            else
            {

                MessageBox.Show("Login v? ya Passaword yanlýþdýr");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}