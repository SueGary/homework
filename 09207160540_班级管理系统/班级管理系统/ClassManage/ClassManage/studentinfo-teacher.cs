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
    public partial class studentinfo_teacher : Form
    {
        public studentinfo_teacher()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classManageDataSet);

        }

        private void studentinfo_teacher_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“classManageDataSet.student”中。您可以根据需要移动或移除它。
            this.studentTableAdapter.Fill(this.classManageDataSet.student);
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
