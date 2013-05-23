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
    public partial class RP_student : Form
    {
        string record = "";
        DataClasses1DataContext db = new DataClasses1DataContext();

        public RP_student(string id)
        {
            InitializeComponent();
            record = id;
        }

        private void RP_student_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                var query = (from rp in db.Reward_Punish
                             where rp.studengID == record
                             select new { 学年 = rp.xuenian, 奖励 = rp.rewards, 惩罚 = rp.punishments }).ToList();
                dataGridView1.DataSource = query;
            }
            catch { }

        }
    }
}
