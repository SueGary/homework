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
    public partial class StudentInfo : Form
    {
        string identify;
        DataClasses1DataContext data = new DataClasses1DataContext();
        public StudentInfo(string id)
        {
            identify = id;
            InitializeComponent();
            this.idbox.Text = id;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            InfoInit();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //学籍信息初始化
        private void InfoInit()
        {
            try
            {

                var query = (from jilu in data.student
                             where jilu.Student_id == identify
                             select jilu).First();
                namebox.Text = query.Student_name;
                schoolbox.Text = query.School_location;
                entrybox.Text = (query.Entry_date).ToString("yyyy-MM-dd");
                collegebox.Text = query.Student_college;
                spebox.Text = query.Student_specialty;
                gradebox.Text = query.Student_grade.ToString();
                systembox.Text = query.School_system.ToString();
                classbox.Text = query.Student_classid;
                leavebox.Text = query.Entry_date.AddYears(4).AddMonths(-2).ToString("yyyy-MM-dd");
            }
            catch { MessageBox.Show("系统没有对应信息,请与管理员联系"); }
            
        }
    }
}
