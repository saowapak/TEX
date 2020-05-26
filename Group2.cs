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
    public partial class Group2 : Form
    {
        
        public double sum2;
     


        public Group2()
        {
            InitializeComponent();
        }

        private void Group2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ถัดไป
        {
            sum2 = 0;
            double social_security = Convert.ToInt32(numericsocial.Value); //ประกันสังคม
            double life_security = Convert.ToInt32(numericlife.Value); //ประกันชีวิต
            double heal_security = Convert.ToInt32(numericheal.Value); //ประกันสุขภาพ
            double spouse_security = Convert.ToInt32(numericspouse.Value); //ประกันคู่สมรส
            double FM_security = Convert.ToInt32(numericfam.Value); //ประกันบิดามารดา
            double provident_fund = Convert.ToInt32(numericproviden.Value); //กองทุนสำรองเลี้ยงชีพ
            double KOH = Convert.ToInt32(numerickoh.Value); //กอช.
            double teacher_fund = Convert.ToInt32(numericteacher.Value); //กองทุนครู
            double pension = Convert.ToInt32(numericpension.Value); //เบี้ยบำนาญ
            double LTF = Convert.ToInt32(numericltf.Value);
            double RMF = Convert.ToInt32(numericrmf.Value);
            double TMP = life_security + heal_security;
            double TMP2 = provident_fund + teacher_fund + RMF + KOH;

            if (TMP > 100000)
            {
                TMP = 100000;
            }
            if ((Program.money * 0.15) > 490000)
            {
                numericproviden.Value = 490000;
            }
            else
            {
                numericproviden.Maximum = Convert.ToInt32(Program.money * 0.15);//ถ้าไม่มากกว่า 490000
            }
            if ((Program.money * 0.15) > 500000)
            {
                numericteacher.Value = 500000;
            }
            else
            {
                numericteacher.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if ((Program.money * 0.15) > 500000)
            {
                numericrmf.Value = 500000;
            }
            else
            {
                numericrmf.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if ((Program.money * 0.15) > 500000)
            {
                numericltf.Value = 500000;
            }
            else
            {
                numericltf.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if ((Program.money * 0.15) > 500000)
            {
                numericpension.Value = 500000;
            }
            else
            {
                numericpension.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if (TMP2 > 500000)//ตัวแปรที่รวมกันทั้ง 4 ต้องไม่เกิน 500000
            {
                TMP2 = 500000;
            }
            sum2 = sum2 + TMP2 + TMP + social_security + spouse_security + FM_security + pension + LTF;

            Group3 gp3 = new Group3();
            Program.sum2 = sum2;
            this.Hide();
            gp3.ShowDialog();





        }

        private void button3_Click(object sender, EventArgs e)
        {
            Group1 G1 = new Group1();
            this.Hide();
            G1.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//คู่สมรสมีรายได้
        {
            if (radioButton3.Checked)
            {
                numericspouse.Enabled = true;
            }
            else
            {
                numericspouse.Enabled = false;
            }
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                numericspouse.Enabled = false;
            }
            else
            {
                numericspouse.Enabled = true;
            }
        }
    }
}
