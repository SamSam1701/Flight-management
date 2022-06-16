namespace Flight_Management
{
    partial class DangNhap
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
            this.tbusernamelogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpasslogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnforgetpass = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // tbusernamelogin
            // 
            this.tbusernamelogin.Location = new System.Drawing.Point(222, 127);
            this.tbusernamelogin.Name = "tbusernamelogin";
            this.tbusernamelogin.Size = new System.Drawing.Size(223, 22);
            this.tbusernamelogin.TabIndex = 21;
            this.tbusernamelogin.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "UserName:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbpasslogin
            // 
            this.tbpasslogin.Location = new System.Drawing.Point(222, 184);
            this.tbpasslogin.Name = "tbpasslogin";
            this.tbpasslogin.Size = new System.Drawing.Size(223, 22);
            this.tbpasslogin.TabIndex = 22;
            this.tbpasslogin.UseSystemPasswordChar = true;
            this.tbpasslogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnforgetpass
            // 
            this.btnforgetpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforgetpass.Location = new System.Drawing.Point(126, 278);
            this.btnforgetpass.Name = "btnforgetpass";
            this.btnforgetpass.Size = new System.Drawing.Size(181, 37);
            this.btnforgetpass.TabIndex = 26;
            this.btnforgetpass.Text = "Quên mật khẩu";
            this.btnforgetpass.UseVisualStyleBackColor = true;
            this.btnforgetpass.Click += new System.EventHandler(this.btnforgetpass_Click);
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(375, 278);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(143, 37);
            this.btnregister.TabIndex = 27;
            this.btnregister.Text = "Đăng Ký";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(491, 145);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(137, 41);
            this.btnlogin.TabIndex = 28;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(657, 386);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnforgetpass);
            this.Controls.Add(this.tbusernamelogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbpasslogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_formClosed);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbusernamelogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbpasslogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnforgetpass;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnlogin;
    }
}