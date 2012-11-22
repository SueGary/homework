namespace ClassManage
{
    partial class StudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classManageDataSet = new ClassManage.ClassManageDataSet();
            this.studentTableAdapter = new ClassManage.ClassManageDataSetTableAdapters.studentTableAdapter();
            this.tableAdapterManager = new ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager();
            this.namebox = new System.Windows.Forms.TextBox();
            this.schoolbox = new System.Windows.Forms.TextBox();
            this.collegebox = new System.Windows.Forms.TextBox();
            this.spebox = new System.Windows.Forms.TextBox();
            this.classbox = new System.Windows.Forms.TextBox();
            this.gradebox = new System.Windows.Forms.TextBox();
            this.systembox = new System.Windows.Forms.TextBox();
            this.entrybox = new System.Windows.Forms.TextBox();
            this.leavebox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager();
            this.idbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "校区：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "院系：";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "专业：";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "班级：";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "年级：";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "学制：";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "入学年月：";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "毕业年月：";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.classManageDataSet;
            // 
            // classManageDataSet
            // 
            this.classManageDataSet.DataSetName = "ClassManageDataSet";
            this.classManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.examTableAdapter = null;
            this.tableAdapterManager.scoreTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.sutdent_courseTableAdapter = null;
            this.tableAdapterManager.teacher_courseTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(69, 54);
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.Size = new System.Drawing.Size(100, 21);
            this.namebox.TabIndex = 5;
            this.namebox.TabStop = false;
            // 
            // schoolbox
            // 
            this.schoolbox.Location = new System.Drawing.Point(69, 85);
            this.schoolbox.Name = "schoolbox";
            this.schoolbox.ReadOnly = true;
            this.schoolbox.Size = new System.Drawing.Size(100, 21);
            this.schoolbox.TabIndex = 6;
            this.schoolbox.TabStop = false;
            // 
            // collegebox
            // 
            this.collegebox.Location = new System.Drawing.Point(69, 114);
            this.collegebox.Name = "collegebox";
            this.collegebox.ReadOnly = true;
            this.collegebox.Size = new System.Drawing.Size(100, 21);
            this.collegebox.TabIndex = 6;
            this.collegebox.TabStop = false;
            // 
            // spebox
            // 
            this.spebox.Location = new System.Drawing.Point(69, 144);
            this.spebox.Multiline = true;
            this.spebox.Name = "spebox";
            this.spebox.ReadOnly = true;
            this.spebox.Size = new System.Drawing.Size(100, 43);
            this.spebox.TabIndex = 6;
            this.spebox.TabStop = false;
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(69, 200);
            this.classbox.Name = "classbox";
            this.classbox.ReadOnly = true;
            this.classbox.Size = new System.Drawing.Size(100, 21);
            this.classbox.TabIndex = 6;
            this.classbox.TabStop = false;
          //  this.classbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // gradebox
            // 
            this.gradebox.Location = new System.Drawing.Point(69, 232);
            this.gradebox.Name = "gradebox";
            this.gradebox.ReadOnly = true;
            this.gradebox.Size = new System.Drawing.Size(100, 21);
            this.gradebox.TabIndex = 6;
            this.gradebox.TabStop = false;
            // 
            // systembox
            // 
            this.systembox.Location = new System.Drawing.Point(69, 265);
            this.systembox.Name = "systembox";
            this.systembox.ReadOnly = true;
            this.systembox.Size = new System.Drawing.Size(100, 21);
            this.systembox.TabIndex = 6;
            this.systembox.TabStop = false;
          //  this.systembox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // entrybox
            // 
            this.entrybox.Location = new System.Drawing.Point(69, 295);
            this.entrybox.Name = "entrybox";
            this.entrybox.ReadOnly = true;
            this.entrybox.Size = new System.Drawing.Size(100, 21);
            this.entrybox.TabIndex = 6;
            this.entrybox.TabStop = false;
           // this.entrybox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // leavebox
            // 
            this.leavebox.Location = new System.Drawing.Point(68, 326);
            this.leavebox.Name = "leavebox";
            this.leavebox.ReadOnly = true;
            this.leavebox.Size = new System.Drawing.Size(100, 21);
            this.leavebox.TabIndex = 6;
            this.leavebox.TabStop = false;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.classTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.courseTableAdapter = null;
            this.tableAdapterManager1.examTableAdapter = null;
            this.tableAdapterManager1.scoreTableAdapter = null;
            this.tableAdapterManager1.studentTableAdapter = null;
            this.tableAdapterManager1.sutdent_courseTableAdapter = null;
            this.tableAdapterManager1.teacher_courseTableAdapter = null;
            this.tableAdapterManager1.teacherTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(69, 24);
            this.idbox.Name = "idbox";
            this.idbox.ReadOnly = true;
            this.idbox.Size = new System.Drawing.Size(100, 21);
            this.idbox.TabIndex = 5;
            this.idbox.TabStop = false;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 352);
            this.Controls.Add(this.leavebox);
            this.Controls.Add(this.entrybox);
            this.Controls.Add(this.systembox);
            this.Controls.Add(this.gradebox);
            this.Controls.Add(this.classbox);
            this.Controls.Add(this.spebox);
            this.Controls.Add(this.collegebox);
            this.Controls.Add(this.schoolbox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentInfo";
            this.Text = "学籍信息";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classManageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ClassManageDataSet classManageDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ClassManage.ClassManageDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox schoolbox;
        private System.Windows.Forms.TextBox collegebox;
        private System.Windows.Forms.TextBox spebox;
        private System.Windows.Forms.TextBox classbox;
        private System.Windows.Forms.TextBox gradebox;
        private System.Windows.Forms.TextBox systembox;
        private System.Windows.Forms.TextBox entrybox;
        private System.Windows.Forms.TextBox leavebox;
        private ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idbox;
    }
}