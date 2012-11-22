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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Teacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Dispose();
        }

        private void 查看学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentinfo_teacher temp = new studentinfo_teacher();
            temp.MdiParent = this;
            temp.Show();
        }

        private void 成绩浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addscore addscore = new Addscore();
            addscore.MdiParent = this;
            addscore.Show();
        }

        private void 成绩浏览ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            浏览成绩 temp = new 浏览成绩();
            temp.MdiParent = this;
            temp.Show();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
