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
    public partial class Group1 : Form
    {
        
        public int sum ;




        public Group1()//เช็คการทำงาน
        {
            InitializeComponent();
            baby1.Enabled = false;
            baby2.Enabled = false;
        }





        

        private void checkbefore2561_CheckedChanged(object sender, EventArgs e)//ก่อน61
        {
            if (checkbefore2561.Checked)
            {
                baby1.Enabled = true;
            }
            else
            {
                baby1.Enabled = false;
            }
        }

        private void checkafter2561_CheckedChanged(object sender, EventArgs e)//หลัง61
        {
            if (checkafter2561.Checked)
            {
                baby2.Enabled = true;
            }
            else
            {
                baby2.Enabled = false;
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void motherMe_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void fatherSpouse_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void motherSpouse_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pregnant_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//ปุ่มถัดไป
        {
            sum = 0;//เป็นการเช็คเงื่อนไข
            if (comboBox1.Text == "มีคู่สมรส แต่คู่สมรสไม่มีรายได้")
            {
                sum = sum + 120000;
            }
            else
            {
                sum = sum + 60000;
            }
            if (checkbefore2561.Checked)//ก่อน61 ถ้าเลือก
            {
                sum = sum + (Convert.ToInt32(baby1.Text) * 30000);
            }
            else if (checkafter2561.Checked)
            {
                if (Convert.ToInt32(baby1.Text) == 0)
                {
                    sum = sum + ((Convert.ToInt32(baby2.Text) - 1) * 60000) + 30000;
                }
                else
                {
                    sum = sum + (Convert.ToInt32(baby2.Text) * 60000);
                }
            }
            else
            {
                sum = sum + 0;
            }
            if (dadme.Checked )
            {
                sum = sum + 30000;
            }
            if ( momme.Checked)
            {
                sum = sum + 30000;
            }
            if (dad.Checked)
            {
                sum = sum + 30000;
            }
            if (mom.Checked)
            {
                sum = sum + 30000;
            }
            sum = sum + Convert.ToInt32(pregnant.Value) + (Convert.ToInt32(disabled.Value) * 60000);
            Group2 gp2 = new Group2();
            Program.sum1 = sum;
            this.Hide();
            gp2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//ย้อนกลับ
        {
           Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
