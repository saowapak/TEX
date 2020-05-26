using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX5GROUP
{
    public partial class Total : Form
    {
        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group5 G5 = new Group5();
            this.Hide();
            G5.ShowDialog();
        }

        public Total()
        {
            InitializeComponent();
        }

        private void Total_Load(object sender, EventArgs e)
        {
            double total = Program.money - (Program.sum1 + Program.sum2 + Program.sum3 + Program.sum4 + Program.sum5);//รายได้สุทธิ
            summytexbox.Text = Program.sum1.ToString();
            sumsocialtexbox.Text = Program.sum2.ToString();
            sumdonatetexbox.Text = Program.sum3.ToString();
            sumrimtexbox.Text = Program.sum4.ToString();
            sumpayuttexbox.Text = Program.sum5.ToString();
            sumpaseetaxbox.Text = (Program.sum1 + Program.sum2 + Program.sum3 + Program.sum4 + Program.sum5).ToString();
            if (total < 0)
            {
                total = 0;//ลดหย่อนเกินเงินเดือน มันจะติดลบก็จะให้มีค่าเป็น 0
            }
            sumsutitexbox.Text = total.ToString();//show รายได้ให้ผู้ใช้ดู
            if (total > 5000000)
            {
                total = (total *35) /100;
            }
            else if (total > 2000000)
            {
                total = (total *30)/100;
            }
            else if (total > 1000000)
            {
                total = (total *25)/100;
            }
            else if (total > 750000)
            {
                total = (total *15)/100;
            }
            else if (total > 500000)
            {
                total = (total* 20)/100;
            }
            else if (total > 300000)
            {
                total = (total*25)/100;
            }
            else if (total > 150000)
            {
                total = (total *30)/100;
            }
            else if (total <=150000)
            {
                total = 0;
            }
            sumpaytexbox.Text = total.ToString();//แสดงภาษีที่ต้องจ่าย
        }
    }
}
