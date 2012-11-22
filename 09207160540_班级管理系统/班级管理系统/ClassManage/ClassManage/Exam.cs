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
    public partial class Exam : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public Exam(string temp)
        {
            InitializeComponent();
            var query =(from e in data.exam
                       from c in data.course
                       from s in data.student
                       where s.Student_id==temp &&c.Course_id==e.course_id
                       select new {开课课号=e.course_id,课程名称=c.Course_name,考试时间=e.exam_time,考试地点=e.exam_address}).Distinct().ToList();
            dataGridView1.DataSource = query;
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
