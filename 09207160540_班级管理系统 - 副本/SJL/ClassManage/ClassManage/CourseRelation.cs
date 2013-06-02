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
    public partial class CourseRelation : Form
    {
        public CourseRelation()
        {
            InitializeComponent();
        }

        private void CourseRelation_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: 这行代码将数据加载到表“classManageDataSet._class”中。您可以根据需要移动或移除它。
            this.classTableAdapter.Fill(this.classManageDataSet._class);
            // TODO: 这行代码将数据加载到表“classManageDataSet.course”中。您可以根据需要移动或移除它。
            this.courseTableAdapter.Fill(this.classManageDataSet.course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            //添加学生-课程关系
            #region
            var query = (from students in db.student
                         where students.Student_classid == classbox.Text
                         select students.Student_id).ToList();
            int right = 0;
            int wrong = 0;
            int num = 0;
            foreach (var a in query)
            {
                sutdent_course temp = new sutdent_course();
                temp.id = a + coursebox.Text;
                temp.Course_id = coursebox.Text;
                temp.Student_id = a;
                db.sutdent_course.InsertOnSubmit(temp);
                try { db.SubmitChanges(); right++; }
                catch { wrong++; }

            }
            num = query.Count;
            String text = this.classbox.Text + "班共" + Convert.ToString(num) + "人，提交成功：" + Convert.ToString(right) + "条 ,提交失败：" + Convert.ToString(wrong) + "条";
            MessageBox.Show(text);
            #endregion
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            coursebox.Text=dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void classDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          this.classbox.Text = classDataGridView.SelectedCells[0].Value.ToString();
        }
       
    }
}
