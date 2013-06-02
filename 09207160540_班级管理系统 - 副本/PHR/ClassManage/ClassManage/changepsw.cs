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
    public partial class changepsw : Form
    {
        string identify;
        public changepsw(string id)
        {
            identify = id;
            InitializeComponent();
        }

        private void changepsw_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// 核对原密码正误函数
        /// </summary>
        private void psw_certify()
        {
            
        }
        /// <summary>
        /// 修改密码函数
        /// </summary>
        /// <param name="identify">用户ID</param>
        private void psw_change(string identify)
        {
            string connString = Properties.Settings.Default.User_pasConnectionString;
            string sql = "update student set password='" + this.ackpswbox.Text + "' where name='" + identify + "'";
            // string sql = "insert into " + identify + "(name,password) values(" + this.namebox.Text +","+ this.pswbox.Text + ")";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功");

                }
                catch
                {

                }
            }

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            //核对旧密码的正误
            #region
            string connString = Properties.Settings.Default.User_pasConnectionString;
            string sql = "select password from student where name='" + identify + "'";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (this.opswbox.Text != cmd.ExecuteScalar().ToString())
                    {
                        MessageBox.Show("原密码输入有误，请重新输入。");
                        this.opswbox.Text = string.Empty;
                        this.opswbox.Focus();
                        return;
                    }
                }
                catch { }
            }
            #endregion

            if (this.npswbox.Text == this.ackpswbox.Text)
            {
                if (this.ackpswbox.Text.Trim() == string.Empty)
                { MessageBox.Show("密码不能为空"); return; }
                psw_change(identify);
                button2_Click(sender,e);
            }
            else MessageBox.Show("新密码前后不一致,请修改!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.opswbox.Text = "";
            this.npswbox.Text = "";
            this.ackpswbox.Text = "";
            this.opswbox.Focus();
        }     
    }
}