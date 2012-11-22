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
    public partial class Addscore : Form
    {
        public Addscore()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classManageDataSet);

        }

        private void Addscore_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“classManageDataSet.student”中。您可以根据需要移动或移除它。
            this.studentTableAdapter.Fill(this.classManageDataSet.student);
            // TODO: 这行代码将数据加载到表“classManageDataSet.course”中。您可以根据需要移动或移除它。
            this.courseTableAdapter.Fill(this.classManageDataSet.course);
            this.WindowState = FormWindowState.Maximized;
        }

        private void courseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idbox.Text=courseDataGridView.SelectedCells[0].Value.ToString();
        }

        private void studentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           numbox.Text=studentDataGridView.SelectedCells[0].Value.ToString();
        }

        private void courseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            score temp = new score();
            temp.Course_id = idbox.Text;
            temp.Student_id = numbox.Text;
            temp.Course_score =Convert.ToInt32(scorebox.Text);
            temp.id = numbox.Text + idbox.Text;
            db.score.InsertOnSubmit(temp);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("提交成功！");
                numbox.Text = "";
                scorebox.Text = "";
            }
            catch { MessageBox.Show("提交失败"); }
        }
    }
}
