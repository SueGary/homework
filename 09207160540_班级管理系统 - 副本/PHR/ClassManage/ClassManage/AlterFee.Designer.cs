namespace ClassManage
{
    partial class AlterFee
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
            this.label1 = new System.Windows.Forms.Label();
            this.collegebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.learnbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staybox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.xuenian = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "专业：";
            // 
            // collegebox
            // 
            this.collegebox.Location = new System.Drawing.Point(62, 79);
            this.collegebox.Name = "collegebox";
            this.collegebox.Size = new System.Drawing.Size(100, 21);
            this.collegebox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学费：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // learnbox
            // 
            this.learnbox.Location = new System.Drawing.Point(62, 127);
            this.learnbox.Name = "learnbox";
            this.learnbox.Size = new System.Drawing.Size(100, 21);
            this.learnbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "住宿费：";
            // 
            // staybox
            // 
            this.staybox.Location = new System.Drawing.Point(62, 171);
            this.staybox.Name = "staybox";
            this.staybox.Size = new System.Drawing.Size(100, 21);
            this.staybox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(62, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "学年：";
            // 
            // xuenian
            // 
            this.xuenian.Location = new System.Drawing.Point(62, 35);
            this.xuenian.Name = "xuenian";
            this.xuenian.Size = new System.Drawing.Size(100, 21);
            this.xuenian.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.staybox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.learnbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.xuenian);
            this.groupBox1.Controls.Add(this.collegebox);
            this.groupBox1.Location = new System.Drawing.Point(36, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "以专业为单位添加";
            // 
            // AlterFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlterFee";
            this.Text = "AlterFee";
            this.Load += new System.EventHandler(this.AlterFee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox collegebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox learnbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox staybox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xuenian;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}