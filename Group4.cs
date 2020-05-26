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
    public partial class Group4 : Form
    {
        public double sum4;
        public Group4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum4 = 0;
            sum4 = sum4 + (Convert.ToInt32(numericeducation.Value) * 2);//การศึกษา
            sum4 = sum4 + (Convert.ToInt32(numericnurse.Value) * 2);//พยาบาล
            sum4 = sum4 + (Convert.ToInt32(numericsport.Value) * 2);//กีฬา
            sum4 = sum4 + (Convert.ToInt32(numericdonatebaba.Value) * 2);//สาธารณะประโยชน์
            sum4 = sum4 + Convert.ToInt32(numericdonateprayut.Value);//การเมือง
            sum4 = sum4 + Convert.ToInt32(numericdonatepayu.Value);//พายุ
            Group5 gp5 = new Group5();
            Program.sum4 = sum4;
            this.Hide();
            gp5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//ย้อนกลับ
        {
            Group3 G3 = new Group3();
            this.Hide();
            G3.ShowDialog();
        }

        private void Group4_Load(object sender, EventArgs e)
        {

        }
    }
}
