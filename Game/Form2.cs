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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = DataBank.TextBox1;
            label2.Text = DataBank.TextBox2;
            label3.Text = DataBank.TextBox3;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num = Int32.Parse(label3.Text);
            float chis = Int32.Parse(textBox1.Text);
            float res = num / chis;
            float chisvlab = num - chis;
            if ((num % chis == 0) && (res != 1 && num != 2) && (res > 0))
            {
                label3.Text = chisvlab.ToString();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if ( chisvlab == 1 )
            {
                label3.Text = "1";
                MessageBox.Show("Поебедил игрок 1");
            }
            else
            {
                MessageBox.Show("Это число не кратно");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float num = Int32.Parse(label3.Text);
            float chis = Int32.Parse(textBox2.Text);
            float res = num / chis;
            float chisvlab = num - chis;
            if ((num % chis == 0) && (res != 1 && num != 2) && (res > 0))
            {
                label3.Text = chisvlab.ToString();
                button2.Enabled = false;
                button1.Enabled = true;
            }
            else if (chisvlab == 1 )
            {
                label3.Text = "1";
                MessageBox.Show("Поебедил игрок 2");
            }
            else
            {
                MessageBox.Show("Это число не кратно");
            }


        }
    }
}
