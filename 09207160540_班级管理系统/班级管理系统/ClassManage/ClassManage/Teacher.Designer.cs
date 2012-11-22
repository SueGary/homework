namespace ClassManage
{
    partial class Teacher
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
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下发通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩浏览ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.班级管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看学生信息ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 查看学生信息ToolStripMenuItem
            // 
            this.查看学生信息ToolStripMenuItem.Name = "查看学生信息ToolStripMenuItem";
            this.查看学生信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看学生信息ToolStripMenuItem.Text = "查看学生信息";
            this.查看学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查看学生信息ToolStripMenuItem_Click);
            // 
            // 班级管理ToolStripMenuItem
            // 
            this.班级管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下发通知ToolStripMenuItem});
            this.班级管理ToolStripMenuItem.Name = "班级管理ToolStripMenuItem";
            this.班级管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.班级管理ToolStripMenuItem.Text = "班级管理";
            // 
            // 下发通知ToolStripMenuItem
            // 
            this.下发通知ToolStripMenuItem.Name = "下发通知ToolStripMenuItem";
            this.下发通知ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下发通知ToolStripMenuItem.Text = "下发通知";
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩浏览ToolStripMenuItem,
            this.成绩浏览ToolStripMenuItem1});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 成绩浏览ToolStripMenuItem
            // 
            this.成绩浏览ToolStripMenuItem.Name = "成绩浏览ToolStripMenuItem";
            this.成绩浏览ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.成绩浏览ToolStripMenuItem.Text = "成绩录入";
            this.成绩浏览ToolStripMenuItem.Click += new System.EventHandler(this.成绩浏览ToolStripMenuItem_Click);
            // 
            // 成绩浏览ToolStripMenuItem1
            // 
            this.成绩浏览ToolStripMenuItem1.Name = "成绩浏览ToolStripMenuItem1";
            this.成绩浏览ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.成绩浏览ToolStripMenuItem1.Text = "成绩浏览";
            this.成绩浏览ToolStripMenuItem1.Click += new System.EventHandler(this.成绩浏览ToolStripMenuItem1_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teacher_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩浏览ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下发通知ToolStripMenuItem;
    }
}