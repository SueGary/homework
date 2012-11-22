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
    public partial class ViewRP : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public ViewRP()
        {
            InitializeComponent();
        }

        private void ViewRP_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //初始化datagridview内容，显示当前所有同学的奖惩情况
            #region
            var query=(from studentrp in db.Reward_Punish
                      from studentname in db.student
                      where studentrp.studengID== studentname.Student_id
                      select new {姓名=studentname.Student_name,学号=studentname.Student_id,学年=studentrp.xuenian,奖励=studentrp.rewards,惩罚=studentrp.punishments}).ToList();
            dataGridView1.DataSource = query;
            #endregion
        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            //精确检索学生奖惩信息
            #region
            if (idradio.Checked)
            {
                try
                {
                    //var query = (from table in db.Reward_Punish
                    //             where table.studengID == checkbox.Text
                    //             select table).ToList();
                    var query = (from studentrp in db.Reward_Punish
                                 from studentname in db.student
                                 where studentrp.studengID == studentname.Student_id && studentrp.studengID==checkbox.Text
                                 select new { 姓名 = studentname.Student_name, 学号 = studentname.Student_id, 学年 = studentrp.xuenian, 奖励 = studentrp.rewards, 惩罚 = studentrp.punishments }).ToList();
                    dataGridView1.DataSource = query;
                }
                catch { }


            }
            if (nameradio.Checked)
            {
                try
                {
                    var temp = (from stu in db.student where stu.Student_name == checkbox.Text select stu.Student_id).First();
                    var query = (from studentrp in db.Reward_Punish
                                 from studentname in db.student
                                 where studentrp.studengID == studentname.Student_id && studentrp.studengID == temp
                                 select new { 姓名 = studentname.Student_name, 学号 = studentname.Student_id, 学年 = studentrp.xuenian, 奖励 = studentrp.rewards, 惩罚 = studentrp.punishments }).ToList();
                    dataGridView1.DataSource = query;
                }
                catch { }

            }
            #endregion
           
        }

        private void ackbtn_Click(object sender, EventArgs e)
        {
            //添加奖惩信息
            #region
            string time = System.DateTime.Now.ToString();
            Reward_Punish addrp = new Reward_Punish();
            addrp.studengID = idbox.Text;
            addrp.xuenian = yearbox.Text;
            addrp.rewards = rewardbox.Text;
            addrp.punishments = punishbox.Text;
            addrp.ID = idbox.Text + " " + time;
            

            try
            {
                db.Reward_Punish.InsertOnSubmit(addrp);
                db.SubmitChanges();
                MessageBox.Show("添加成功");
            }
            catch { MessageBox.Show("添加失败"); }
            #endregion
            //初始化datagridview内容，显示当前所有同学的奖惩情况
            #region
            var again = (from studentrp in db.Reward_Punish
                         from studentname in db.student
                         where studentrp.studengID == studentname.Student_id
                         select new { 姓名 = studentname.Student_name, 学号 = studentname.Student_id, 学年 = studentrp.xuenian, 奖励 = studentrp.rewards, 惩罚 = studentrp.punishments }).ToList();
            dataGridView1.DataSource = again;
            #endregion
        }
    }
}
