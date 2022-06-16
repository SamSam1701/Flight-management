namespace Flight_Management
{
    partial class DangKy
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
            this.tbpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(223, 194);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(223, 22);
            this.tbpass.TabIndex = 3;
            this.tbpass.TextChanged += new System.EventHandler(this.tbpass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // tbcmnd
            // 
            this.tbcmnd.Location = new System.Drawing.Point(223, 251);
            this.tbcmnd.Name = "tbcmnd";
            this.tbcmnd.Size = new System.Drawing.Size(223, 22);
            this.tbcmnd.TabIndex = 4;
            this.tbcmnd.TextChanged += new System.EventHandler(this.tbcmnd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "CMND:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(223, 304);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(223, 22);
            this.tbsdt.TabIndex = 5;
            this.tbsdt.TextChanged += new System.EventHandler(this.tbsdt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "SĐT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Họ Tên:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(223, 82);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(223, 22);
            this.tbname.TabIndex = 1;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(223, 355);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(223, 22);
            this.tbemail.TabIndex = 6;
            this.tbemail.TextChanged += new System.EventHandler(this.tbemail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email:";
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(496, 213);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(117, 38);
            this.btnregister.TabIndex = 24;
            this.btnregister.Text = "Đăng ký";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(223, 141);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(223, 22);
            this.tbusername.TabIndex = 25;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(657, 413);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox tbusername;
    }
}