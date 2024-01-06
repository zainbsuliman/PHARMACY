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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             if (shhad .Text == textBox3.Text ) {




                Form2 s = new Form2();
                string sh = shhad.Text;

                foreach (Control c in s.Controls)
                {
                    if (c.Name == "allnfo")
                    {

                        c.Text += sh;
                    }
                    s.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("the password is not true");

            }

             





















            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
