using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX5GROUP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//ถัดไป
        {
            
            Group1 gp1 = new Group1();
            Program.money = (int.Parse(mount.Text) * 12) + int.Parse(bonus.Text) + int.Parse(other.Text);
            

            //Group1 G = new Group1();
            gp1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)//หน้าหลัก
        {
            Form1 F1 = new Form1();
            F1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)//Group1
        {
            Group1 G = new Group1();
            G.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//Group2
        {
            Group2 G2 = new Group2();
            G2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)//Group3
        {
            Group3 G3 = new Group3();
            G3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//Group4
        {
            Group4 G4 = new Group4();
            G4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)//Group5
        {
            Group5 G5 = new Group5();
            G5.ShowDialog();
        }

       

        private void mount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
