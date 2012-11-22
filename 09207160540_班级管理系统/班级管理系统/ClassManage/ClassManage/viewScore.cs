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
    
    public partial class 浏览成绩 : Form
    {
        ToolTip temp = new ToolTip();
        DataClasses1DataContext db = new DataClasses1DataContext();
        public 浏览成绩()
        {
            InitializeComponent();
        }

        private void scoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scoreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classManageDataSet);

        }

        private void viewScore_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“classManageDataSet.score”中。您可以根据需要移动或移除它。
            this.scoreTableAdapter.Fill(this.classManageDataSet.score);
            this.WindowState = FormWindowState.Maximized;
        }
       
        private void scoreDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //鼠标停靠提示功能
            #region
            string tempstring="";
            try
            {
                string record = scoreDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    var query = from stu in db.student
                                where stu.Student_id == record
                                select stu.Student_name;
                    tempstring = query.First();
                }
                if (e.ColumnIndex == 1)
                {
                    var query = from cour in db.course
                                where cour.Course_id == record
                                select cour.Course_name;
                    tempstring = query.First();
                }

                temp.Show(tempstring, label1, 1, 1);
               
            }
            catch { }
            #endregion
        }     
    }
}
