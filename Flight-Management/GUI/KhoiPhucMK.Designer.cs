namespace Flight_Management
{
    partial class KhoiPhucMK
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngetpass = new System.Windows.Forms.Button();
            this.lbresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(197, 166);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(241, 22);
            this.tbemail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "KHÔI PHỤC MẬT KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btngetpass
            // 
            this.btngetpass.BackColor = System.Drawing.Color.White;
            this.btngetpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetpass.Location = new System.Drawing.Point(251, 272);
            this.btngetpass.Name = "btngetpass";
            this.btngetpass.Size = new System.Drawing.Size(117, 38);
            this.btngetpass.TabIndex = 13;
            this.btngetpass.Text = "Khôi phục";
            this.btngetpass.UseVisualStyleBackColor = false;
            this.btngetpass.Click += new System.EventHandler(this.btngetpass_Click);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.Location = new System.Drawing.Point(80, 221);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(90, 24);
            this.lbresult.TabIndex = 14;
            this.lbresult.Text = "Kết quả: ";
            // 
            // KhoiPhucMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(657, 386);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.btngetpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục mật khẩu";
            this.Load += new System.EventHandler(this.KhoiPhucMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngetpass;
        private System.Windows.Forms.Label lbresult;
    }
}