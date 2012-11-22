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
    public partial class alterScore : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public alterScore()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            if (idradio.Checked) 
            {
                try
                {
                    var query = (from tempscore in db.score
                                 from tempstudent in db.student
                                 from tempcourse in db.course
                                 where tempscore.Course_id == coursebox.Text && tempscore.Student_id == checkbox.Text && tempscore.Student_id == tempstudent.Student_id && tempscore.Course_id == tempcourse.Course_id
                                 select new { tempscore.Course_score, tempstudent.Student_id, tempstudent.Student_name, tempcourse.Course_id, tempcourse.Course_name }).First();
                    this.scorebox.Text = Convert.ToString(query.Course_score);
                    this.strnamebox.Text = query.Student_name;
                    this.stuidbox.Text = query.Student_id;
                    cidbox.Text = query.Course_id;
                    cnamebox.Text = query.Course_name;
                }
                catch { MessageBox.Show("检索失败！"); }
 
            }
     
            
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classManageDataSet);

        }

        private void alterScore_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: 这行代码将数据加载到表“classManageDataSet.course”中。您可以根据需要移动或移除它。
            this.courseTableAdapter.Fill(this.classManageDataSet.course);

        }

        private void courseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           this.coursebox.Text=courseDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scorebox.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var alterscore = (from temp in db.score
                                  where temp.Course_id == cidbox.Text && temp.Student_id == stuidbox.Text
                                  select temp).First();
                alterscore.Course_score = Convert.ToInt32(scorebox.Text);
                db.SubmitChanges();
                MessageBox.Show("修改成功!");
                scorebox.Enabled = false;
            }
            catch { MessageBox.Show("提交失败！"); }
        }
    }
}
