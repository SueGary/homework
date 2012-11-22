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
    public partial class ViewClass : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        ToolTip tooltip = new ToolTip();
     
        public ViewClass()
        {
            InitializeComponent();
        }

        private void ViewClass_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
          
            var query = (from temp in db.@class
                         select new {班级编号=temp.Class_id,班级名称=temp.Class_name,所属学院=temp.Class_college,辅导员编号=temp.Class_teacherid}).ToList();
            dataGridView1.DataSource = query;
            

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string temp = "";
            temp = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == 3)
            {
                tooltip.Active = true;
                var query = (from tips in db.teacher
                             where tips.Teacher_id == temp
                             select tips.Teacher_name).First().ToString();
                tooltip.Show(query, label1, MousePosition.X, MousePosition.Y);
            }
            else tooltip.Active = false;
           

        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            tooltip.Active = false;
        }

        private void ackbtn_Click(object sender, EventArgs e)
        {
            //添加班级，更新各种信息到数据库
            #region
            
            var query = from teachername in db.teacher
                        where teachername.Teacher_name == techernamebox.Text
                        select teachername.Teacher_id;
            try { query.First(); }
            catch { MessageBox.Show("没有该老师！"); return; }
            @class a = new @class();
            a.Class_id = gradebox.Text + classbox.Text;
            a.Class_name = classnamebox.Text;
            a.Class_college = classcollege.Text;
            a.Class_teacherid = query.First();
            db.@class.InsertOnSubmit(a);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("添加成功！");
            }
            catch { MessageBox.Show("添加失败！"); }
            #endregion
            //
            #region
            var again = (from temp in db.@class
                         select new { 班级编号 = temp.Class_id, 班级名称 = temp.Class_name, 所属学院 = temp.Class_college, 辅导员编号 = temp.Class_teacherid }).ToList();
            dataGridView1.DataSource = again;
            #endregion
        }
    }
}
