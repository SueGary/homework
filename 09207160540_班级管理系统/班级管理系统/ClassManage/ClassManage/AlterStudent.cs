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
    public partial class AlterStudent : Form
    {
        public AlterStudent()
        {
            InitializeComponent();
        }

        private void AlterStudent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
   

        private void button1_Click()
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataClasses1DataContext studentinfo = new DataClasses1DataContext();
         
            if (radioButton1.Checked)
            {
                //判定搜索的对象是否存在
                #region
                try
                {
                    var test = (from db in studentinfo.student
                                 where db.Student_id == this.textBox1.Text
                                 select db).First();
                }
                catch
                {
                    MessageBox.Show("没有该同学信息");
                    return;
                }
                #endregion
                var query = (from db in studentinfo.student
                            where db.Student_id == this.textBox1.Text
                            select db).First();
                //信息初始化
                #region
                idbox.Text = query.Student_id;
                namebox.Text = query.Student_name;
                nationbox.Text = query.Student_nation;
                birthday.Value = query.Student_birthday;
                entrytime.Value = query.Entry_date;
                if (query.Student_sex.Trim() == "男") maleradio.Checked = true;
                else femaleradio.Checked = true;
                if (query.School_location.Trim() == "东莞") dongguan.Checked = true;
                else zhanjiang.Checked = true;
                addbox.Text = query.Student_home;
                collegebox.Text = query.Student_college;
                spebox.Text = query.Student_specialty;
                gradebox.Text = query.Student_grade.ToString();
                classbox.Text = query.Student_classid;
                systembox.Text = query.School_system.ToString();
                #endregion
            }
            if (radioButton2.Checked)
            {
                //判定搜索的对象是否存在
                #region
                try
                {
                    var test = (from db in studentinfo.student
                                 where db.Student_name == this.textBox1.Text
                                 select db).First();
                }
                catch
                {
                    MessageBox.Show("没有该同学信息");
                    return;
                }
                #endregion
                var query = (from db in studentinfo.student
                            where db.Student_name == this.textBox1.Text
                            select db).First();
                //信息初始化
                #region
                idbox.Text = query.Student_id;
                namebox.Text = query.Student_name;
                nationbox.Text = query.Student_nation;
                birthday.Value = query.Student_birthday;
                entrytime.Value = query.Entry_date;
                if (query.Student_sex.Trim() == "男") maleradio.Checked = true;
                else femaleradio.Checked = true;
                if (query.School_location.Trim() == "东莞") dongguan.Checked = true;
                else zhanjiang.Checked = true;
                addbox.Text = query.Student_home;
                collegebox.Text = query.Student_college;
                spebox.Text = query.Student_specialty;
                gradebox.Text = query.Student_grade.ToString();
                classbox.Text = query.Student_classid;
                systembox.Text = query.School_system.ToString();
                #endregion
            }
            
        }

        private void rewrite_Click(object sender, EventArgs e)
        {
            //让文本框可以修改
            #region
            this.systembox.Enabled = true;
            this.namebox.Enabled = true;
            this.addbox.Enabled = true;
            this.birthday.Enabled = true;
            this.entrytime.Enabled = true;
            this.groupBox2.Enabled = true;
            this.groupBox3.Enabled = true;
            this.nationbox.Enabled = true;
            this.collegebox.Enabled = true;
            this.spebox.Enabled = true;
            this.gradebox.Enabled = true;
            this.classbox.Enabled = true;
            #endregion
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext update = new DataClasses1DataContext();
                var query = (from c in update.student
                             where c.Student_id == idbox.Text
                             select c).First();
                //更新信息
                #region
                query.Student_id = idbox.Text;
                query.Student_name = namebox.Text;
                query.Student_nation = nationbox.Text;
                query.Student_birthday = birthday.Value.Date;
                query.Entry_date = entrytime.Value.Date;
                if (femaleradio.Checked)
                    query.Student_sex = "女";
                else query.Student_sex = "男";
                if (dongguan.Checked)
                    query.School_location = "东莞";
                else query.School_location = "湛江";
                query.Student_home = addbox.Text;
                query.Student_college = collegebox.Text;
                query.Student_specialty = spebox.Text;
                query.Student_grade = Convert.ToInt32(gradebox.Text);
                query.Student_classid = classbox.Text;
                query.School_system = Convert.ToInt32(systembox.Text);
                #endregion
                update.SubmitChanges();
                MessageBox.Show("修改成功");
                //让文本框不可以修改
                #region
                this.systembox.Enabled = false;
                this.namebox.Enabled = false;
                this.addbox.Enabled = false;
                this.birthday.Enabled = false;
                this.entrytime.Enabled = false;
                this.groupBox2.Enabled = false;
                this.groupBox3.Enabled = false;
                this.nationbox.Enabled = false;
                this.collegebox.Enabled = false;
                this.spebox.Enabled = false;
                this.gradebox.Enabled = false;
                this.classbox.Enabled = false;
                #endregion
            }
            catch { MessageBox.Show("修改失败"); }
        }
    }
}
