namespace ClassManage
{
    partial class alterScore
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbox = new System.Windows.Forms.TextBox();
            this.gobtn = new System.Windows.Forms.Button();
            this.idradio = new System.Windows.Forms.RadioButton();
            this.strnamebox = new System.Windows.Forms.TextBox();
            this.stuidbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cidbox = new System.Windows.Forms.TextBox();
            this.cnamebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.scorebox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.coursebox = new System.Windows.Forms.TextBox();
            this.classManageDataSet = new ClassManage.ClassManageDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new ClassManage.ClassManageDataSetTableAdapters.courseTableAdapter();
            this.tableAdapterManager = new ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameradio = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkbox);
            this.groupBox1.Controls.Add(this.nameradio);
            this.groupBox1.Controls.Add(this.gobtn);
            this.groupBox1.Controls.Add(this.idradio);
            this.groupBox1.Controls.Add(this.coursebox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(253, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索学生成绩";
            // 
            // checkbox
            // 
            this.checkbox.Location = new System.Drawing.Point(59, 68);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(111, 21);
            this.checkbox.TabIndex = 1;
            // 
            // gobtn
            // 
            this.gobtn.Location = new System.Drawing.Point(295, 66);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(34, 23);
            this.gobtn.TabIndex = 3;
            this.gobtn.Text = "GO";
            this.gobtn.UseVisualStyleBackColor = true;
            this.gobtn.Click += new System.EventHandler(this.gobtn_Click);
            // 
            // idradio
            // 
            this.idradio.AutoSize = true;
            this.idradio.Checked = true;
            this.idradio.Location = new System.Drawing.Point(179, 71);
            this.idradio.Name = "idradio";
            this.idradio.Size = new System.Drawing.Size(47, 16);
            this.idradio.TabIndex = 4;
            this.idradio.TabStop = true;
            this.idradio.Text = "学号";
            this.idradio.UseVisualStyleBackColor = true;
            // 
            // strnamebox
            // 
            this.strnamebox.Enabled = false;
            this.strnamebox.Location = new System.Drawing.Point(314, 181);
            this.strnamebox.Name = "strnamebox";
            this.strnamebox.Size = new System.Drawing.Size(100, 21);
            this.strnamebox.TabIndex = 39;
            // 
            // stuidbox
            // 
            this.stuidbox.Enabled = false;
            this.stuidbox.Location = new System.Drawing.Point(314, 143);
            this.stuidbox.Name = "stuidbox";
            this.stuidbox.Size = new System.Drawing.Size(100, 21);
            this.stuidbox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "姓  名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "学  号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "课程号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "课程名：";
            // 
            // cidbox
            // 
            this.cidbox.Enabled = false;
            this.cidbox.Location = new System.Drawing.Point(314, 220);
            this.cidbox.Name = "cidbox";
            this.cidbox.Size = new System.Drawing.Size(100, 21);
            this.cidbox.TabIndex = 38;
            // 
            // cnamebox
            // 
            this.cnamebox.Enabled = false;
            this.cnamebox.Location = new System.Drawing.Point(314, 258);
            this.cnamebox.Name = "cnamebox";
            this.cnamebox.Size = new System.Drawing.Size(100, 21);
            this.cnamebox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "分  数：";
            // 
            // scorebox
            // 
            this.scorebox.Enabled = false;
            this.scorebox.Location = new System.Drawing.Point(313, 299);
            this.scorebox.Name = "scorebox";
            this.scorebox.Size = new System.Drawing.Size(100, 21);
            this.scorebox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "课程ID：";
            // 
            // coursebox
            // 
            this.coursebox.Location = new System.Drawing.Point(61, 30);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(109, 21);
            this.coursebox.TabIndex = 38;
            // 
            // classManageDataSet
            // 
            this.classManageDataSet.DataSetName = "ClassManageDataSet";
            this.classManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.classManageDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.examTableAdapter = null;
            this.tableAdapterManager.scoreTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.sutdent_courseTableAdapter = null;
            this.tableAdapterManager.teacher_courseTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(-2, 5);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            this.courseDataGridView.RowTemplate.Height = 23;
            this.courseDataGridView.Size = new System.Drawing.Size(249, 446);
            this.courseDataGridView.TabIndex = 42;
            this.courseDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Course_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "课程ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Course_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "课程名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameradio
            // 
            this.nameradio.AutoSize = true;
            this.nameradio.Enabled = false;
            this.nameradio.Location = new System.Drawing.Point(232, 71);
            this.nameradio.Name = "nameradio";
            this.nameradio.Size = new System.Drawing.Size(47, 16);
            this.nameradio.TabIndex = 5;
            this.nameradio.Text = "姓名";
            this.nameradio.UseVisualStyleBackColor = true;
            this.nameradio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "修改成绩";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "提交";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(171, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 14);
            this.label7.TabIndex = 42;
            this.label7.Text = "(双击表格数据来填充)";
            // 
            // alterScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.scorebox);
            this.Controls.Add(this.cnamebox);
            this.Controls.Add(this.strnamebox);
            this.Controls.Add(this.cidbox);
            this.Controls.Add(this.stuidbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "alterScore";
            this.Text = "alterScore";
            this.Load += new System.EventHandler(this.alterScore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox checkbox;
        private System.Windows.Forms.Button gobtn;
        private System.Windows.Forms.RadioButton idradio;
        private System.Windows.Forms.TextBox strnamebox;
        private System.Windows.Forms.TextBox stuidbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cidbox;
        private System.Windows.Forms.TextBox cnamebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox scorebox;
        private System.Windows.Forms.TextBox coursebox;
        private System.Windows.Forms.Label label6;
        private ClassManageDataSet classManageDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ClassManage.ClassManageDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private ClassManage.ClassManageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton nameradio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}