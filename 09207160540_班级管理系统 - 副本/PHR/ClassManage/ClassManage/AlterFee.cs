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
    public partial class AlterFee : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public AlterFee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //以专业为单位添加每个学生的费用，查询专业学生，对每个学生插入相应的费用
            #region
            int temp = 0;
            int record = 0;
            var query = (from stu in db.student
                         where stu.Student_specialty == collegebox.Text
                         select stu.Student_id).ToArray();
            record = query.Length;
            for (int i = 0; i < record; i++)
            {
                School_fee add = new School_fee();
                add.studentID = query[i];
                add.Xuenian = xuenian.Text;
                add.Yingjiaoxuefei = learnbox.Text;
                add.Yijiaoxuefei = "0";
                add.Yijiaozhusufei = "0";
                add.Qianjiaoxuefei = learnbox.Text;
                add.Yingjiaozhusufei = staybox.Text;
                add.Qianjiaozhusufei = staybox.Text;
                db.School_fee.InsertOnSubmit(add);
                try { db.SubmitChanges(); temp++; }
                catch { }
            }
            MessageBox.Show(collegebox.Text+"共"+record+"人，成功添加"+temp+"条。");
            #endregion
        }


        private void AlterFee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
