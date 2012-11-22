namespace ClassManage
{
    partial class examinfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseperiodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursekindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classManageDataSet = new ClassManage.ClassManageDataSet();
            this.courseTableAdapter = new ClassManage.ClassManageDataSetTableAdapters.courseTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.ackbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.courseperiodDataGridViewTextBoxColumn,
            this.coursecreditDataGridViewTextBoxColumn,
            this.coursekindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "Course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "课程ID";
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "Course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // courseperiodDataGridViewTextBoxColumn
            // 
            this.courseperiodDataGridViewTextBoxColumn.DataPropertyName = "Course_period";
            this.courseperiodDataGridViewTextBoxColumn.HeaderText = "课程学时";
            this.courseperiodDataGridViewTextBoxColumn.Name = "courseperiodDataGridViewTextBoxColumn";
            // 
            // coursecreditDataGridViewTextBoxColumn
            // 
            this.coursecreditDataGridViewTextBoxColumn.DataPropertyName = "Course_credit";
            this.coursecreditDataGridViewTextBoxColumn.HeaderText = "课程学分";
            this.coursecreditDataGridViewTextBoxColumn.Name = "coursecreditDataGridViewTextBoxColumn";
            // 
            // coursekindDataGridViewTextBoxColumn
            // 
            this.coursekindDataGridViewTextBoxColumn.DataPropertyName = "Course_kind";
            this.coursekindDataGridViewTextBoxColumn.HeaderText = "课程类型";
            this.coursekindDataGridViewTextBoxColumn.Name = "coursekindDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.classManageDataSet;
            // 
            // classManageDataSet
            // 
            this.classManageDataSet.DataSetName = "ClassManageDataSet";
            this.classManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "课程ID:";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(628, 16);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(122, 21);
            this.idbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "考试时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "考试地点：";
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(628, 49);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(122, 21);
            this.addressbox.TabIndex = 2;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(628, 85);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(122, 21);
            this.datetime.TabIndex = 3;
            // 
            // ackbtn
            // 
            this.ackbtn.Location = new System.Drawing.Point(581, 129);
            this.ackbtn.Name = "ackbtn";
            this.ackbtn.Size = new System.Drawing.Size(75, 23);
            this.ackbtn.TabIndex = 4;
            this.ackbtn.Text = "确认";
            this.ackbtn.UseVisualStyleBackColor = true;
            this.ackbtn.Click += new System.EventHandler(this.ackbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(756, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "(双击表格数据来填充)";
            // 
            // examinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 419);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ackbtn);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "examinfo";
            this.Text = "examinfo";
            this.Load += new System.EventHandler(this.examinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classManageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ClassManageDataSet classManageDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ClassManage.ClassManageDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseperiodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursekindDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Button ackbtn;
        private System.Windows.Forms.Label label7;
    }
}