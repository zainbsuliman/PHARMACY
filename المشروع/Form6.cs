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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form7 F7 = new Form7();
            F7.Show();
            this.Hide();
             

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form8 F8 = new Form8();
            F8.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
              
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
