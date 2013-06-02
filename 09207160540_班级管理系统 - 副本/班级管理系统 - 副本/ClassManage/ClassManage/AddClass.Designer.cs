namespace ClassManage
{
    partial class AddClass
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
            this.classbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classnamebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classcollege = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.techernamebox = new System.Windows.Forms.TextBox();
            this.ackbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gradebox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "班别：";
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(100, 66);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(100, 21);
            this.classbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "班级名称：";
            // 
            // classnamebox
            // 
            this.classnamebox.Location = new System.Drawing.Point(100, 103);
            this.classnamebox.Name = "classnamebox";
            this.classnamebox.Size = new System.Drawing.Size(100, 21);
            this.classnamebox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "所属学院：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // classcollege
            // 
            this.classcollege.Location = new System.Drawing.Point(100, 146);
            this.classcollege.Name = "classcollege";
            this.classcollege.Size = new System.Drawing.Size(100, 21);
            this.classcollege.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "辅导员名称：";
            // 
            // techernamebox
            // 
            this.techernamebox.Location = new System.Drawing.Point(100, 184);
            this.techernamebox.Name = "techernamebox";
            this.techernamebox.Size = new System.Drawing.Size(100, 21);
            this.techernamebox.TabIndex = 5;
            // 
            // ackbtn
            // 
            this.ackbtn.Location = new System.Drawing.Point(34, 230);
            this.ackbtn.Name = "ackbtn";
            this.ackbtn.Size = new System.Drawing.Size(75, 23);
            this.ackbtn.TabIndex = 6;
            this.ackbtn.Text = "提交";
            this.ackbtn.UseVisualStyleBackColor = true;
            this.ackbtn.Click += new System.EventHandler(this.ackbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "年级：";
            // 
            // gradebox
            // 
            this.gradebox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gradebox.Location = new System.Drawing.Point(100, 32);
            this.gradebox.Name = "gradebox";
            this.gradebox.Size = new System.Drawing.Size(100, 21);
            this.gradebox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(206, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "例：2009级 填 2009";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(206, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "例：16班 填 16";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(206, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "专业简称+班别  如：信管16班";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 330);
            this.Controls.Add(this.ackbtn);
            this.Controls.Add(this.classcollege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.classnamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.techernamebox);
            this.Controls.Add(this.gradebox);
            this.Controls.Add(this.classbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.Load += new System.EventHandler(this.AddClass_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classnamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classcollege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox techernamebox;
        private System.Windows.Forms.Button ackbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gradebox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}