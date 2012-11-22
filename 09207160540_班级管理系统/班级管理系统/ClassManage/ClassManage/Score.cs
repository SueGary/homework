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
    public partial class Score : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public Score(string temp)
        {
            InitializeComponent();
            var query = (from s in data.score
                         from c in data.course
                         where s.Student_id == temp && s.Course_id == c.Course_id
                         select new { 课程号 = c.Course_id, 课程名称 = c.Course_name, 课程类别 = c.Course_kind, 学分 = c.Course_credit, 学时 = c.Course_period, 总评成绩 = s.Course_score }).Distinct().ToList();
            dataGridView1.DataSource = query;
            
        }

        private void Score_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
        }

     
    }
}
