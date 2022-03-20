namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Cloud" & textBox2.Text == "admin")
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();


            }
            else
            {

                MessageBox.Show("Login v? ya Passaword yanlýþdýr");

            }
        }
    }
}