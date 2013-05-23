using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManage
{
    public partial class AAddCourse : Form
    {
        public AAddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            course xin = new course();
            xin.Course_id = courseID.Text;
            xin.Course_name = namebox.Text;
            xin.Course_period = Convert.ToInt32(periodbox.Text);
            xin.Course_credit = Convert.ToInt32(this.creditbox.Text);
            xin.Course_descible = describebox.Text;
            if (radioButton1.Checked)
                xin.Course_kind = radioButton1.Text;
            if (radioButton2.Checked)
                xin.Course_kind = radioButton2.Text;
            if (radioButton3.Checked)
                xin.Course_kind = radioButton3.Text;
            db.course.InsertOnSubmit(xin);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("添加成功！");
            }
            catch { MessageBox.Show("添加失败！"); }
        }

        private void AAddCourse_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
