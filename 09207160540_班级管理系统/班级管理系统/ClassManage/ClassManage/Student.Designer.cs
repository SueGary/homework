namespace ClassManage
{
    partial class Student
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学籍信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的课表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的收发费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.账号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收发费信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖惩信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学籍信息ToolStripMenuItem,
            this.我的课表ToolStripMenuItem,
            this.我的收发费ToolStripMenuItem,
            this.成绩查询ToolStripMenuItem1,
            this.收发费信息ToolStripMenuItem,
            this.奖惩信息ToolStripMenuItem,
            this.账号管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 学籍信息ToolStripMenuItem
            // 
            this.学籍信息ToolStripMenuItem.Name = "学籍信息ToolStripMenuItem";
            this.学籍信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学籍信息ToolStripMenuItem.Text = "学籍信息";
            this.学籍信息ToolStripMenuItem.Click += new System.EventHandler(this.学籍信息ToolStripMenuItem_Click);
            // 
            // 我的课表ToolStripMenuItem
            // 
            this.我的课表ToolStripMenuItem.Name = "我的课表ToolStripMenuItem";
            this.我的课表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.我的课表ToolStripMenuItem.Text = "我的课表";
            this.我的课表ToolStripMenuItem.Click += new System.EventHandler(this.我的课表ToolStripMenuItem_Click);
            // 
            // 我的收发费ToolStripMenuItem
            // 
            this.我的收发费ToolStripMenuItem.Name = "我的收发费ToolStripMenuItem";
            this.我的收发费ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.我的收发费ToolStripMenuItem.Text = "考试安排";
            this.我的收发费ToolStripMenuItem.Click += new System.EventHandler(this.我的收发费ToolStripMenuItem_Click);
            // 
            // 成绩查询ToolStripMenuItem1
            // 
            this.成绩查询ToolStripMenuItem1.Name = "成绩查询ToolStripMenuItem1";
            this.成绩查询ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.成绩查询ToolStripMenuItem1.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem1.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem1_Click);
            // 
            // 账号管理ToolStripMenuItem
            // 
            this.账号管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem});
            this.账号管理ToolStripMenuItem.Name = "账号管理ToolStripMenuItem";
            this.账号管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.账号管理ToolStripMenuItem.Text = "账号管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 收发费信息ToolStripMenuItem
            // 
            this.收发费信息ToolStripMenuItem.Name = "收发费信息ToolStripMenuItem";
            this.收发费信息ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.收发费信息ToolStripMenuItem.Text = "收发费信息";
            this.收发费信息ToolStripMenuItem.Click += new System.EventHandler(this.收发费信息ToolStripMenuItem_Click);
            // 
            // 奖惩信息ToolStripMenuItem
            // 
            this.奖惩信息ToolStripMenuItem.Name = "奖惩信息ToolStripMenuItem";
            this.奖惩信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.奖惩信息ToolStripMenuItem.Text = "奖惩信息";
            this.奖惩信息ToolStripMenuItem.Click += new System.EventHandler(this.奖惩信息ToolStripMenuItem_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学籍信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的课表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的收发费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 收发费信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖惩信息ToolStripMenuItem;
    }
}