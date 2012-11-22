namespace ClassManage
{
    partial class SR_fee
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
            this.xuefei = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.xuefei)).BeginInit();
            this.SuspendLayout();
            // 
            // xuefei
            // 
            this.xuefei.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xuefei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xuefei.Location = new System.Drawing.Point(2, 1);
            this.xuefei.Name = "xuefei";
            this.xuefei.RowTemplate.Height = 23;
            this.xuefei.Size = new System.Drawing.Size(337, 233);
            this.xuefei.TabIndex = 0;
            // 
            // SR_fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 236);
            this.Controls.Add(this.xuefei);
            this.Name = "SR_fee";
            this.Text = "SR_fee";
            this.Load += new System.EventHandler(this.SR_fee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xuefei)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView xuefei;
    }
}