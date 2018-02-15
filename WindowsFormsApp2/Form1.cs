using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Algne_valem = textBox1.Text;           
            if (Algne_valem.Contains("+"))
            {
                string Uus_valem = Algne_valem.Replace("+","-");
                Console.WriteLine(Algne_valem);
            }
            textBox2.Text = Algne_valem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("√");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("²");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("³");
        }
    }
}
