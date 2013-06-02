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
    public partial class examinfo : Form
    {
        public examinfo()
        {
            InitializeComponent();
        }

        private void examinfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“classManageDataSet.course”中。您可以根据需要移动或移除它。
            this.courseTableAdapter.Fill(this.classManageDataSet.course);
            this.WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idbox.Text=dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void ackbtn_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            exam examinfo = new exam();
            examinfo.id = idbox.Text;
            examinfo.course_id = idbox.Text;
            examinfo.exam_address = addressbox.Text;
            examinfo.exam_time = datetime.Value.Date;
            db.exam.InsertOnSubmit(examinfo);
            try { db.SubmitChanges(); MessageBox.Show("提交成功"); }
            catch { MessageBox.Show("提交失败"); }
        }
    }
}
