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
    public partial class Group3 : Form
    {
        public double sum3;
        public Group3()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum3 = 0;
            sum3 = sum3 + Convert.ToInt32(numericUpDown4.Value);//ดอกเบี้ยบ้าน
            sum3 = sum3 + Convert.ToInt32(numericUpDown1.Value) * 0.04;//ช่วงปี2558
            sum3 = sum3 + Convert.ToInt32(numericUpDown2.Value) * 0.04;//ช่วงปี2562
          
            Group4 gp4 = new Group4();
            Program.sum3 = sum3;
           this.Hide();
           gp4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Group2 G2 = new Group2();
            this.Hide();
            G2.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//ไม่มีบ้านหลังเเรก
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = false;
                groupBox5.Enabled = false;
            }
            else if (radioButton3.Checked)//2558
            {
                groupBox2.Enabled = true;
                groupBox5.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox5.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }
    }
}
