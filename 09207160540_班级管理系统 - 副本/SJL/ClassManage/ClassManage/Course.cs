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
    public partial class Course : Form
    {
        DataClasses1DataContext data=new DataClasses1DataContext();
        public Course(string id)
        {
            InitializeComponent();
            try
            {
                var query = (from sc in data.sutdent_course
                             from c in data.course
                             from tc in data.teacher_course
                             from t in data.teacher
                             where sc.Student_id == id && c.Course_id == sc.Course_id && c.Course_id == tc.Course_id && t.Teacher_id == tc.Teacher_id
                             orderby c.Course_id
                             select new { 课程号 = c.Course_id, 课程名 = c.Course_name, 学分 = c.Course_credit, 任课老师 = t.Teacher_name, 考核方式 = c.Course_kind }).Distinct().ToList();
                dataGridView1.DataSource = query;
            }
            catch { MessageBox.Show("没有相应课程信息，请与管理员联系"); }
           
        }

        private void Course_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
