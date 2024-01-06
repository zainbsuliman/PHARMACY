using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المشروع
{
    public partial class Form8 : Form
    {
        public static int o = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f9 = new Form6();
            f9.Show();
            this.Hide();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))
            {
                MessageBox.Show("pleas select one item");
            }

            else
            {
                int bag = 0;
                if (checkBox1.Checked)
                    bag += Convert.ToInt32(label1.Text);

                if (checkBox2.Checked)
                    bag += Convert.ToInt32(label2.Text);

                if (checkBox3.Checked)
                    bag += Convert.ToInt32(label3.Text);

                if (checkBox4.Checked)
                    bag += Convert.ToInt32(label4.Text);

                label6.Text = string.Format("{0:C}", bag);
                o = bag;
            }
        }
    }
    }

