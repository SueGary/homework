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
    public partial class courseteacher : Form
    {
        public courseteacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            //添加教师-课程关系
            #region
            teacher_course teachercourse = new teacher_course();
            teachercourse.Teacher_id = teacherbox.Text;
            teachercourse.Course_id = coursebox.Text;
            teachercourse.Class_id = classbox.Text;
            teachercourse.id = teacherbox.Text + classbox.Text + coursebox.Text;
            db.teacher_course.InsertOnSubmit(teachercourse);
            try { db.SubmitChanges(); MessageBox.Show("提交成功"); }
            catch { MessageBox.Show("提交失败"); }
            #endregion
        }

        private void courseteacher_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: 这行代码将数据加载到表“classManageDataSet._class”中。您可以根据需要移动或移除它。
            this.classTableAdapter.Fill(this.classManageDataSet._class);
            // TODO: 这行代码将数据加载到表“classManageDataSet.teacher”中。您可以根据需要移动或移除它。
            this.teacherTableAdapter.Fill(this.classManageDataSet.teacher);
            // TODO: 这行代码将数据加载到表“classManageDataSet.teacher”中。您可以根据需要移动或移除它。
            this.teacherTableAdapter.Fill(this.classManageDataSet.teacher);
            // TODO: 这行代码将数据加载到表“classManageDataSet.teacher_course”中。您可以根据需要移动或移除它。
         //   this.teacher_courseTableAdapter.Fill(this.classManageDataSet.teacher_course);
            // TODO: 这行代码将数据加载到表“classManageDataSet.course”中。您可以根据需要移动或移除它。
            this.courseTableAdapter.Fill(this.classManageDataSet.course);

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           teacherbox.Text=dataGridView2.SelectedCells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            coursebox.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void classDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            classbox.Text = classDataGridView.SelectedCells[0].Value.ToString();
        }
    }
}
