namespace ClassManage
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.pswbox = new System.Windows.Forms.TextBox();
            this.ackbtn = new System.Windows.Forms.Button();
            this.resumebtn = new System.Windows.Forms.Button();
            this.sturadio = new System.Windows.Forms.RadioButton();
            this.teacherradio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manaradio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级管理系统";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密  码：";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(106, 81);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(117, 21);
            this.namebox.TabIndex = 3;
            this.namebox.Text = "姓名/职工号/学号";
         //   this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            this.namebox.Enter += new System.EventHandler(this.namebox_Enter);
            // 
            // pswbox
            // 
            this.pswbox.Location = new System.Drawing.Point(106, 121);
            this.pswbox.Name = "pswbox";
            this.pswbox.PasswordChar = '*';
            this.pswbox.Size = new System.Drawing.Size(117, 21);
            this.pswbox.TabIndex = 4;
         //   this.pswbox.TextChanged += new System.EventHandler(this.pswbox_TextChanged);
            // 
            // ackbtn
            // 
            this.ackbtn.Location = new System.Drawing.Point(43, 226);
            this.ackbtn.Name = "ackbtn";
            this.ackbtn.Size = new System.Drawing.Size(62, 24);
            this.ackbtn.TabIndex = 1;
            this.ackbtn.Text = "登录";
            this.ackbtn.UseVisualStyleBackColor = true;
            this.ackbtn.Click += new System.EventHandler(this.ackbtn_Click);
            // 
            // resumebtn
            // 
            this.resumebtn.Location = new System.Drawing.Point(157, 226);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(62, 24);
            this.resumebtn.TabIndex = 2;
            this.resumebtn.Text = "重置";
            this.resumebtn.UseVisualStyleBackColor = true;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // sturadio
            // 
            this.sturadio.AutoSize = true;
            this.sturadio.Checked = true;
            this.sturadio.Location = new System.Drawing.Point(17, 20);
            this.sturadio.Name = "sturadio";
            this.sturadio.Size = new System.Drawing.Size(47, 16);
            this.sturadio.TabIndex = 6;
            this.sturadio.TabStop = true;
            this.sturadio.Text = "学生";
            this.sturadio.UseVisualStyleBackColor = true;
            // 
            // teacherradio
            // 
            this.teacherradio.AutoSize = true;
            this.teacherradio.Location = new System.Drawing.Point(70, 20);
            this.teacherradio.Name = "teacherradio";
            this.teacherradio.Size = new System.Drawing.Size(47, 16);
            this.teacherradio.TabIndex = 7;
            this.teacherradio.Text = "教师";
            this.teacherradio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sturadio);
            this.groupBox1.Controls.Add(this.manaradio);
            this.groupBox1.Controls.Add(this.teacherradio);
            this.groupBox1.Location = new System.Drawing.Point(41, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // manaradio
            // 
            this.manaradio.AutoSize = true;
            this.manaradio.Location = new System.Drawing.Point(123, 20);
            this.manaradio.Name = "manaradio";
            this.manaradio.Size = new System.Drawing.Size(59, 16);
            this.manaradio.TabIndex = 8;
            this.manaradio.Text = "管理员";
            this.manaradio.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.ackbtn);
            this.Controls.Add(this.pswbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox pswbox;
        private System.Windows.Forms.Button ackbtn;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.RadioButton sturadio;
        private System.Windows.Forms.RadioButton teacherradio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton manaradio;
    }
}