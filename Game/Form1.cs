using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                DataBank.TextBox1 = textBox1.Text;
                DataBank.TextBox2 = textBox2.Text;
                DataBank.TextBox3 = textBox3.Text;
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Введите имена игроков или число");
                
            }
        }
    }
}
