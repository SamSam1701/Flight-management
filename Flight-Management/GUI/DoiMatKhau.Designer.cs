namespace Flight_Management
{
    partial class DoiMatKhau
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
            this.btnresetpass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbconfirmpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcurpass = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnewpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnresetpass
            // 
            this.btnresetpass.BackColor = System.Drawing.Color.White;
            this.btnresetpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetpass.Location = new System.Drawing.Point(256, 302);
            this.btnresetpass.Name = "btnresetpass";
            this.btnresetpass.Size = new System.Drawing.Size(117, 38);
            this.btnresetpass.TabIndex = 19;
            this.btnresetpass.Text = "Đặt lại";
            this.btnresetpass.UseVisualStyleBackColor = false;
            this.btnresetpass.Click += new System.EventHandler(this.btnresetpass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Password:";
            // 
            // tbconfirmpass
            // 
            this.tbconfirmpass.Location = new System.Drawing.Point(256, 247);
            this.tbconfirmpass.Name = "tbconfirmpass";
            this.tbconfirmpass.PasswordChar = '●';
            this.tbconfirmpass.Size = new System.Drawing.Size(223, 22);
            this.tbconfirmpass.TabIndex = 18;
            this.tbconfirmpass.TextChanged += new System.EventHandler(this.tbconfirmpass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username:";
            // 
            // tbcurpass
            // 
            this.tbcurpass.Location = new System.Drawing.Point(256, 154);
            this.tbcurpass.Name = "tbcurpass";
            this.tbcurpass.PasswordChar = '●';
            this.tbcurpass.Size = new System.Drawing.Size(223, 22);
            this.tbcurpass.TabIndex = 16;
            this.tbcurpass.TextChanged += new System.EventHandler(this.tbcurpass_TextChanged);
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(257, 105);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(223, 22);
            this.tbusername.TabIndex = 15;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Current Password:";
            // 
            // tbnewpass
            // 
            this.tbnewpass.Location = new System.Drawing.Point(256, 199);
            this.tbnewpass.Name = "tbnewpass";
            this.tbnewpass.PasswordChar = '●';
            this.tbnewpass.Size = new System.Drawing.Size(223, 22);
            this.tbnewpass.TabIndex = 17;
            this.tbnewpass.TextChanged += new System.EventHandler(this.tbnewpass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm Password:";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(587, 395);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbnewpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbcurpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnresetpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbconfirmpass);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lại mật khẩu";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnresetpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbconfirmpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcurpass;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbnewpass;
        private System.Windows.Forms.Label label5;
    }
}