using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClassManage
{
    public partial class Login : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        private string temp;
        public Login()
        {
            InitializeComponent();
        }

        private void namebox_Enter(object sender, EventArgs e)
        {
            this.namebox.Text = string.Empty;
        }

        private void resumebtn_Click(object sender, EventArgs e)
        {
            this.namebox.Text = "姓名/职工号/学号";
            this.pswbox.Text = string.Empty;
         
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void ackbtn_Click(object sender, EventArgs e)
        {
            
            switch(this.ackbtn.Text)
            {
                case "登录": 
                    {
                        if (teacherradio.Checked) id_login("teacher");
                        if (sturadio.Checked) id_login("student");
                        if (manaradio.Checked) manager_login();
                        
                    } break;
                case "注册":
                    {
                        if (teacherradio.Checked) id_register("teacher");
                        if (sturadio.Checked) id_register("student");
                    } break;


                   
            }
                
            
            
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="identify"></param>
        private void id_register(string identify) {
            string connString = Properties.Settings.Default.User_pasConnectionString;
            string sql = "insert into "+identify+" (name,password) values(@name,@password)";
           // string sql = "insert into " + identify + "(name,password) values(" + this.namebox.Text +","+ this.pswbox.Text + ")";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = this.namebox.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = this.pswbox.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("注册成功");
                    this.ackbtn.Text = "登录";
                }
                catch 
                {

                }
            }
        }
        /// <summary>
        /// 按身份登录
        /// </summary>
        /// <param name="identify"></param>
        private void id_login(string identify)
        {
            string connString = Properties.Settings.Default.User_pasConnectionString;
            string sql = "select password from "+identify+" where name='" + this.namebox.Text + "'";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    temp = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    if (MessageBox.Show("是否注册？", "该用户尚未注册", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        this.ackbtn.Text = "注册";
                    }


                    return;
                }
            }
            if (this.pswbox.Text != temp) { MessageBox.Show("密码错误！"); return; }
            if (identify=="student")
            {
                Student student = new Student(this.namebox.Text);
                student.Show();
                student.Owner = this;
                this.Visible = false;
            }
            if (identify == "teacher")
            {
                Teacher teacher = new Teacher();
                teacher.Show();
                teacher.Owner = this;
                this.Visible = false;
            }
            
        }
        /// <summary>
        /// 管理员登录
        /// </summary>
        private void manager_login()
        {
            if (this.namebox.Text != "admin") return;
            string connString = Properties.Settings.Default.User_pasConnectionString;
            string sql = "select password from teacher where name='" + this.namebox.Text + "'";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    temp = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                   
                }
            }
            if (this.pswbox.Text != temp) { MessageBox.Show("密码错误！"); return; }
            manager admin = new manager();
            admin.Owner = this;
            admin.Show();
            this.Visible = false;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


