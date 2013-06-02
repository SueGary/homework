namespace ClassManage
{
    partial class changepsw
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
            this.opswbox = new System.Windows.Forms.TextBox();
            this.npswbox = new System.Windows.Forms.TextBox();
            this.ackpswbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认新密码：";
            // 
            // opswbox
            // 
            this.opswbox.Location = new System.Drawing.Point(115, 39);
            this.opswbox.Name = "opswbox";
            this.opswbox.PasswordChar = '*';
            this.opswbox.Size = new System.Drawing.Size(100, 21);
            this.opswbox.TabIndex = 1;
            // 
            // npswbox
            // 
            this.npswbox.Location = new System.Drawing.Point(115, 87);
            this.npswbox.Name = "npswbox";
            this.npswbox.PasswordChar = '*';
            this.npswbox.Size = new System.Drawing.Size(100, 21);
            this.npswbox.TabIndex = 2;
            // 
            // ackpswbox
            // 
            this.ackpswbox.Location = new System.Drawing.Point(115, 134);
            this.ackpswbox.Name = "ackpswbox";
            this.ackpswbox.PasswordChar = '*';
            this.ackpswbox.Size = new System.Drawing.Size(100, 21);
            this.ackpswbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // changepsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ackpswbox);
            this.Controls.Add(this.npswbox);
            this.Controls.Add(this.opswbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changepsw";
            this.Text = "changepsw";
            this.Load += new System.EventHandler(this.changepsw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opswbox;
        private System.Windows.Forms.TextBox npswbox;
        private System.Windows.Forms.TextBox ackpswbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}