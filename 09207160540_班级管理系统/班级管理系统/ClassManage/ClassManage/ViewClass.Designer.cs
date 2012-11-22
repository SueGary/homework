namespace ClassManage
{
    partial class ViewClass
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ackbtn = new System.Windows.Forms.Button();
            this.classcollege = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classnamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.techernamebox = new System.Windows.Forms.TextBox();
            this.gradebox = new System.Windows.Forms.TextBox();
            this.classbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(404, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-23, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // ackbtn
            // 
            this.ackbtn.Location = new System.Drawing.Point(109, 229);
            this.ackbtn.Name = "ackbtn";
            this.ackbtn.Size = new System.Drawing.Size(75, 23);
            this.ackbtn.TabIndex = 20;
            this.ackbtn.Text = "提交";
            this.ackbtn.UseVisualStyleBackColor = true;
            this.ackbtn.Click += new System.EventHandler(this.ackbtn_Click);
            // 
            // classcollege
            // 
            this.classcollege.Location = new System.Drawing.Point(84, 140);
            this.classcollege.Name = "classcollege";
            this.classcollege.Size = new System.Drawing.Size(100, 21);
            this.classcollege.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "所属学院：";
            // 
            // classnamebox
            // 
            this.classnamebox.Location = new System.Drawing.Point(84, 97);
            this.classnamebox.Name = "classnamebox";
            this.classnamebox.Size = new System.Drawing.Size(100, 21);
            this.classnamebox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "班级名称：";
            // 
            // techernamebox
            // 
            this.techernamebox.Location = new System.Drawing.Point(84, 178);
            this.techernamebox.Name = "techernamebox";
            this.techernamebox.Size = new System.Drawing.Size(100, 21);
            this.techernamebox.TabIndex = 19;
            // 
            // gradebox
            // 
            this.gradebox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gradebox.Location = new System.Drawing.Point(84, 26);
            this.gradebox.Name = "gradebox";
            this.gradebox.Size = new System.Drawing.Size(100, 21);
            this.gradebox.TabIndex = 15;
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(84, 60);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(100, 21);
            this.classbox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "辅导员名称：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(190, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "专业简称+班别  如：信管16班";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(190, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "例：16班 填 16";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(190, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "例：2009级 填 2009";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "年级：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "班别：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ackbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.classcollege);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.classnamebox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.techernamebox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gradebox);
            this.groupBox1.Controls.Add(this.classbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 277);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加班级";
            // 
            // ViewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewClass";
            this.Text = "浏览成绩";
            this.Load += new System.EventHandler(this.ViewClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ackbtn;
        private System.Windows.Forms.TextBox classcollege;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classnamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox techernamebox;
        private System.Windows.Forms.TextBox gradebox;
        private System.Windows.Forms.TextBox classbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}