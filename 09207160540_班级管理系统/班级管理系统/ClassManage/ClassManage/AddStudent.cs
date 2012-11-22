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
    public partial class AddStudent : Form
    {
        DataClasses1DataContext stuobj;
        
        public AddStudent()
        {
            InitializeComponent();
        }

        private void ackbtn_Click(object sender, EventArgs e)
        {
            stuobj = new DataClasses1DataContext();
            student insertinfo = new student();
            insertinfo.Student_id = idbox.Text;
            insertinfo.Student_name = namebox.Text;
            if (maleradio.Checked)
                insertinfo.Student_sex = "男";
            else insertinfo.Student_sex = "女";
        
            insertinfo.Student_nation = nationbox.Text;
            insertinfo.Entry_date = this.entrytime.Value.Date;
            insertinfo.Student_birthday = birthday.Value.Date;
            insertinfo.Student_classid =gradebox.Text+classbox.Text;
            insertinfo.Student_home = addbox.Text;
            if (dongguan.Checked)
                insertinfo.School_location = "东莞";
            else insertinfo.School_location = "湛江";
            insertinfo.Student_college = collegebox.Text;
            insertinfo.Student_specialty = spebox.Text;
            insertinfo.School_system =Convert.ToInt32(systembox.Text);
            insertinfo.Student_grade = Convert.ToInt32(gradebox.Text);
            stuobj.student.InsertOnSubmit(insertinfo);
            try
            {
                if (MessageBox.Show("确定提交？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    stuobj.SubmitChanges();
                    MessageBox.Show("添加成功！");
                }
                

            }
            catch(Exception ex) 
            {
                
                MessageBox.Show("添加失败！");
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void entrytime_ValueChanged(object sender, EventArgs e)
        {
            gradebox.Text =Convert.ToString(entrytime.Value.Year);
        }
    }
}
