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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text =="Admin")&&(textBox2.Text == "12345")) 
            {
                Form5 d5 = new Form5();
                d5.Show();

            }
            else
            {
                
                MessageBox.Show(" the informaiton is not true ");

            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
