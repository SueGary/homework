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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ackbtn_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
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
            
        }

        private void AddClass_Load(object sender, EventArgs e)
        {

        }

        private void AddClass_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
