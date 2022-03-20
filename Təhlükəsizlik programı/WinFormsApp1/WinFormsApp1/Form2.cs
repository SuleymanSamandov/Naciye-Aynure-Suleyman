using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            table.Columns.Add("Destination IP");
            table.Columns.Add("Destination MASK");
            table.Columns.Add("Destination PORT");
            table.Columns.Add("Source IP");
            table.Columns.Add("Source MASK");
            table.Columns.Add("Source PORT");
            table.Columns.Add("Protocol");
            table.Columns.Add("Action");

            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text, comboBox2.Text);
            dataGridView1.DataSource = table;

        }
        DataTable table = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Destination IP");
            table.Columns.Add("Destination MASK");
            table.Columns.Add("Destination PORT");
            table.Columns.Add("Source IP");
            table.Columns.Add("Source MASK");
            table.Columns.Add("Source PORT");
            table.Columns.Add("Protocol");
            table.Columns.Add("Action");

            dataGridView1.DataSource = table;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}
