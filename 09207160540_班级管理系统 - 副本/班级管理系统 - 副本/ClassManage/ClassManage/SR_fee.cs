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
    public partial class SR_fee : Form
    {
        string record = "";
        DataClasses1DataContext db=new DataClasses1DataContext();
        public SR_fee(string id)
        {
            InitializeComponent();
            record = id;
        }

        private void SR_fee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                var query = (from srfee in db.School_fee
                             where srfee.studentID == record
                             select new { 学年 = srfee.Xuenian, 应交学费 = srfee.Yingjiaoxuefei, 已交学费 = srfee.Yijiaoxuefei,欠交学费=srfee.Qianjiaoxuefei,应交住宿费 = srfee.Yingjiaozhusufei, 已交住宿费 = srfee.Yijiaozhusufei,欠交住宿费=srfee.Qianjiaozhusufei }).ToList();
                xuefei.DataSource = query;
            }
            catch 
            {

            }
        }
    }
}
