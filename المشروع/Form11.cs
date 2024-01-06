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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form6 ft = new Form6();
            ft.Show();
            this.Hide();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1 .Text = dateTimePicker1 .Value.Date.ToString();//    اسند التاريخ اللي يختارها او حددها  اليوزر من  التايم بيكر الى التكيست بوكس  اللي هي يوم الطلب 


            if (dateTimePicker1 .Value.Date < DateTime.Now.Date)// اختبر اذا كان تاريخ يوم الطلب اقل من اليوم الحالي تظهر له رساله
            {
                MessageBox.Show(" please entre a valid start date");
                textBox1.Clear(); // يحذف اللي كان موجود سابقا في التيكست بوكس 
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker2.Value.Date.ToString();//  اسند تاريخ الاستلام اللي اختاره اليوزر الى التيكست بوكس ليوم الاستلام 
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date) //  اختبر اذا كان يوم  الاستلام اقل من يوم الطلب 
            {
                MessageBox.Show(" please entre a valid end date");// تظهر له رساله 
                textBox2.Clear();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startD = dateTimePicker1.Value.Date; //  اعرف متغير من نوع ديت تايم واسند له تاريخ اليوم الطلب 
            DateTime endD = dateTimePicker2.Value.Date;//  اعرف متغير من نوع ديت تايم واسند له تاريخ اليوم الاستلام 
            TimeSpan NofDays = endD.Subtract(startD); //  التايم سبان يحسب لي الفتره بين التوصيل من يوم الطلب الى الاستلام من خلال طرح يوم الاستلام من يوم الطلب 
            MessageBox.Show(" number of day betwwen " + NofDays.TotalDays.ToString() + "days");
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {




        }

        private void Form11_Load(object sender, EventArgs e)
        { int total = 0;
            total = Form7.o + Form8.o + Form9.o;
            label2.Text = String.Format("{0:C}", total);




        }
    }
}

