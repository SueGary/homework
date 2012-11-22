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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Dispose();
        }

        private void 添加学生信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.MdiParent = this;
            addstudent.Show();
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterStudent alterstudent = new AlterStudent();
            alterstudent.MdiParent = this;
            alterstudent.Show();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewClass addclass = new ViewClass();
            addclass.MdiParent = this;
            addclass.Show();
        }


        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AAddCourse ac = new AAddCourse();
            ac.MdiParent = this;
            ac.Show();
        }

        private void 浏览课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseRelation coursestudent = new CourseRelation();
            coursestudent.MdiParent = this;
            coursestudent.Show();
        }

        private void 课程教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            courseteacher courseteacher = new courseteacher();
            courseteacher.MdiParent = this;
            courseteacher.Show();
        }

        private void 添加考试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            examinfo temp = new examinfo();
            temp.MdiParent = this;
            temp.Show();
        }

        private void 浏览考试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_exam view = new view_exam();
            view.MdiParent = this;
            view.Show();
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterScore temp = new alterScore();
            temp.MdiParent = this;
            temp.Show();
        }

        private void 浏览成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            浏览成绩 temp = new 浏览成绩();
            temp.MdiParent = this;
            temp.Show();
        }

        private void 添加奖惩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRP temp = new ViewRP();
            temp.MdiParent = this;
            temp.Show();
        }

        private void 浏览奖惩情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

 
        private void 添加学费信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFee fee = new ViewFee();
            fee.MdiParent = this;
            fee.Show();
        }


      
    }

     
}
