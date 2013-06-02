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
    public partial class Student : Form
    {
        DataClasses1DataContext name = new DataClasses1DataContext();
        private string temp;
        private StudentInfo studentinfo;
        private Course course;
        private view_exam book;
        private Score score;
        private Exam exam;
        private Rebulit rebuilt;
        private Select_course selectcourse;

        public Student(string id)
        {
            temp = id;
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            var query=from s in name.student
                      where s.Student_id==temp
                      select s.Student_name;
            this.Text = query.First();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Dispose();
        }  

        private void 会议活动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectcourse = new Select_course();
            selectcourse.MdiParent = this;
            selectcourse.Show();
        }

        private void 教材预订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book = new view_exam();
            book.MdiParent = this;
            book.Show();
        }

        private void 申请重修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rebuilt = new Rebulit();
            rebuilt.MdiParent = this;
            rebuilt.Show();
        }
       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepsw changepassword = new changepsw(temp);
            changepassword.MdiParent = this;
            changepassword.Show();


        }

        private void 我的课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            course = new Course(temp);
            course.MdiParent = this;
            course.Show();
        }

        private void 学籍信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentinfo = new StudentInfo(temp);
            studentinfo.MdiParent = this;
            studentinfo.Show();
        }

        private void 我的收发费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exam = new Exam(temp);
            exam.MdiParent = this;
            exam.Show(); 
        }

        private void 成绩查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            score = new Score(temp);
            score.MdiParent = this;
            score.Show();
        }

        private void 收发费信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SR_fee srfee = new SR_fee(temp);
            srfee.Owner = this;
            srfee.MdiParent = this;
            srfee.Show();
        }

        private void 奖惩信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RP_student rpstudent = new RP_student(temp);
            rpstudent.Owner = this;
            rpstudent.MdiParent = this;
            rpstudent.Show();
        }

    }
}
