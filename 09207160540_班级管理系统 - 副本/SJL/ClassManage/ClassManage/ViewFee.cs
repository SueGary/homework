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
    public partial class ViewFee : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public ViewFee()
        {
            InitializeComponent();
        }

        private void ViewFee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var query = (from fee in db.School_fee
                         from stu in db.student
                         where fee.studentID == stu.Student_id
                         orderby stu.Student_specialty
                         select new { 学号 = stu.Student_id, 姓名 = stu.Student_name, 学年 = fee.Xuenian,学院=stu.Student_college,专业=stu.Student_specialty, 应交学费 = fee.Yingjiaoxuefei, 已交学费 = fee.Yijiaoxuefei, 欠交学费 = fee.Qianjiaoxuefei, 应交住宿费 = fee.Yingjiaozhusufei, 已交住宿费 = fee.Yijiaozhusufei, 欠交住宿费 = fee.Qianjiaozhusufei }).ToList();
            dataGridView1.DataSource = query;

        }

        private void Addbtn_Click(object sender, EventArgs e)
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
            MessageBox.Show(collegebox.Text + "共" + record + "人，成功添加" + temp + "条。");
            #endregion
            //初始化表的信息
            #region
            var again = (from fee in db.School_fee
                         from stu in db.student
                         where fee.studentID == stu.Student_id
                         orderby stu.Student_specialty
                         select new { 学号 = stu.Student_id, 姓名 = stu.Student_name, 学年 = fee.Xuenian, 学院 = stu.Student_college, 专业 = stu.Student_specialty, 应交学费 = fee.Yingjiaoxuefei, 已交学费 = fee.Yijiaoxuefei, 欠交学费 = fee.Qianjiaoxuefei, 应交住宿费 = fee.Yingjiaozhusufei, 已交住宿费 = fee.Yijiaozhusufei, 欠交住宿费 = fee.Qianjiaozhusufei }).ToList();
            dataGridView1.DataSource = again;
            #endregion
        }
    }
}
