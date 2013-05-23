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
    public partial class view_exam : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        ToolTip tips = new ToolTip();
        public view_exam()
        {
            InitializeComponent();
        }

        private void Teaching_material_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: 这行代码将数据加载到表“classManageDataSet.exam”中。您可以根据需要移动或移除它。
            this.examTableAdapter.Fill(this.classManageDataSet.exam);
            this.WindowState = FormWindowState.Maximized;
        }

        private void examBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classManageDataSet);

        }

        private void examDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            tips.Active = true;
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string courseName = examDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
                    var query = (from record in db.course
                                 where record.Course_id == courseName
                                 select record.Course_name).First();
                    string temp = query.ToString();
                    tips.Show(temp, label1, MousePosition.X, MousePosition.Y);           
                }
                catch { }
            }
            else tips.Active = false;
            
                       
        }

        private void examDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            tips.Active = false;
        }

        private void examBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
