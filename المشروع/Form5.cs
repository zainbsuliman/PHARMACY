using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace المشروع
{
    public partial class Form5 : Form
    {
        int id;
        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void ShowData()
        {
            string sql = "select * from ph";
            DataTable Emptable = Class1.GetDataTable(sql);
            dataGridView1.DataSource = Emptable;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ShowData();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int pID = Convert.ToInt32(textBox1.Text);
            string pname = textBox2.Text;
            int  pr = Convert.ToInt32(textBox3.Text);

            int dp = Convert.ToInt32(textBox4.Text);
            string sql = "INSERT into ph VALUES(" + pID + ",'" + pname + "'," + pr + "," + dp + ")";
            int rows = Class1.insertupdatedelet(sql);
            if (rows != 0)
            {
                MessageBox.Show("insert successfully");
                ShowData();

            }
            else
                MessageBox.Show("Error");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pID = Convert.ToInt32(textBox1.Text);
            string pname = textBox2.Text;
            int pr = Convert.ToInt32(textBox3.Text);

            int dp = Convert.ToInt32(textBox4.Text);

            string sql = "UPDATE ph SET P_ID =" + pID + ", P_name='"+ pname+ "', p_price=" + pr + ", p_department=" + dp  + "WHERE P_ID="+id;
            int rows = Class1.insertupdatedelet(sql);
            if (rows != 0)
            {
                MessageBox.Show("update successfully");
                ShowData();

            }
            else
                MessageBox.Show("Error");





        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pID = Convert.ToInt32(textBox1.Text);
            string sql = "DELETE FROM ph WHERE P_ID=" + pID;
            int rows = Class1.insertupdatedelet(sql);
            if (rows != 0)
            {
                MessageBox.Show("delete successfully");
                ShowData();

            }
            else
                MessageBox.Show("Error");


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(textBox1.Text);
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();






        }
    }
}
