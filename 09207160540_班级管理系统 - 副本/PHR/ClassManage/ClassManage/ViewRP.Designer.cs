namespace ClassManage
{
    partial class ViewRP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbox = new System.Windows.Forms.TextBox();
            this.nameradio = new System.Windows.Forms.RadioButton();
            this.gobtn = new System.Windows.Forms.Button();
            this.idradio = new System.Windows.Forms.RadioButton();
            this.ackbtn = new System.Windows.Forms.Button();
            this.punishbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rewardbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(462, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbox);
            this.groupBox1.Controls.Add(this.nameradio);
            this.groupBox1.Controls.Add(this.gobtn);
            this.groupBox1.Controls.Add(this.idradio);
            this.groupBox1.Location = new System.Drawing.Point(284, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 61);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索学生奖惩信息";
            // 
            // checkbox
            // 
            this.checkbox.Location = new System.Drawing.Point(59, 20);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(111, 21);
            this.checkbox.TabIndex = 1;
            // 
            // nameradio
            // 
            this.nameradio.AutoSize = true;
            this.nameradio.Location = new System.Drawing.Point(232, 23);
            this.nameradio.Name = "nameradio";
            this.nameradio.Size = new System.Drawing.Size(47, 16);
            this.nameradio.TabIndex = 5;
            this.nameradio.Text = "姓名";
            this.nameradio.UseVisualStyleBackColor = true;
            // 
            // gobtn
            // 
            this.gobtn.Location = new System.Drawing.Point(295, 18);
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
            this.idradio.Location = new System.Drawing.Point(179, 23);
            this.idradio.Name = "idradio";
            this.idradio.Size = new System.Drawing.Size(47, 16);
            this.idradio.TabIndex = 4;
            this.idradio.TabStop = true;
            this.idradio.Text = "学号";
            this.idradio.UseVisualStyleBackColor = true;
            // 
            // ackbtn
            // 
            this.ackbtn.Location = new System.Drawing.Point(20, 210);
            this.ackbtn.Name = "ackbtn";
            this.ackbtn.Size = new System.Drawing.Size(75, 23);
            this.ackbtn.TabIndex = 18;
            this.ackbtn.Text = "添加";
            this.ackbtn.UseVisualStyleBackColor = true;
            this.ackbtn.Click += new System.EventHandler(this.ackbtn_Click);
            // 
            // punishbox
            // 
            this.punishbox.Location = new System.Drawing.Point(56, 164);
            this.punishbox.Name = "punishbox";
            this.punishbox.Size = new System.Drawing.Size(100, 21);
            this.punishbox.TabIndex = 17;
           // this.punishbox.TextChanged += new System.EventHandler(this.punishbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "惩罚:";
          //  this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rewardbox
            // 
            this.rewardbox.Location = new System.Drawing.Point(56, 119);
            this.rewardbox.Name = "rewardbox";
            this.rewardbox.Size = new System.Drawing.Size(100, 21);
            this.rewardbox.TabIndex = 16;
          //  this.rewardbox.TextChanged += new System.EventHandler(this.rewardbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "奖励:";
          //  this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // yearbox
            // 
            this.yearbox.Location = new System.Drawing.Point(56, 78);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(100, 21);
            this.yearbox.TabIndex = 15;
          //  this.yearbox.TextChanged += new System.EventHandler(this.yearbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "学年:";
          //  this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(56, 36);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 21);
            this.idbox.TabIndex = 14;
          //  this.idbox.TextChanged += new System.EventHandler(this.idbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "学号:";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ackbtn);
            this.groupBox2.Controls.Add(this.idbox);
            this.groupBox2.Controls.Add(this.punishbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.yearbox);
            this.groupBox2.Controls.Add(this.rewardbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 257);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加奖惩";
            // 
            // ViewRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewRP";
            this.Text = "ViewRP";
            this.Load += new System.EventHandler(this.ViewRP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox checkbox;
        private System.Windows.Forms.RadioButton nameradio;
        private System.Windows.Forms.Button gobtn;
        private System.Windows.Forms.RadioButton idradio;
        private System.Windows.Forms.Button ackbtn;
        private System.Windows.Forms.TextBox punishbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rewardbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}