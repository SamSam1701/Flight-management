
namespace Flight_Management
{
    partial class MainAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStaffManager = new System.Windows.Forms.Button();
            this.btnCustomerManager = new System.Windows.Forms.Button();
            this.btnUpdateRule = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lbTitile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnStaffManager);
            this.panel1.Controls.Add(this.btnCustomerManager);
            this.panel1.Controls.Add(this.btnUpdateRule);
            this.panel1.Controls.Add(this.btnUpdatePassword);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Location = new System.Drawing.Point(37, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 321);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(423, 227);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(242, 39);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStaffManager
            // 
            this.btnStaffManager.AutoSize = true;
            this.btnStaffManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffManager.Location = new System.Drawing.Point(94, 140);
            this.btnStaffManager.Name = "btnStaffManager";
            this.btnStaffManager.Size = new System.Drawing.Size(244, 39);
            this.btnStaffManager.TabIndex = 2;
            this.btnStaffManager.TabStop = false;
            this.btnStaffManager.Text = "Quản Lí Nhân Viên";
            this.btnStaffManager.UseVisualStyleBackColor = true;
            // 
            // btnCustomerManager
            // 
            this.btnCustomerManager.AutoSize = true;
            this.btnCustomerManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManager.Location = new System.Drawing.Point(92, 227);
            this.btnCustomerManager.Name = "btnCustomerManager";
            this.btnCustomerManager.Size = new System.Drawing.Size(242, 39);
            this.btnCustomerManager.TabIndex = 3;
            this.btnCustomerManager.TabStop = false;
            this.btnCustomerManager.Text = "Quản Lí Khách Hàng";
            this.btnCustomerManager.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRule
            // 
            this.btnUpdateRule.AutoSize = true;
            this.btnUpdateRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRule.Location = new System.Drawing.Point(92, 51);
            this.btnUpdateRule.Name = "btnUpdateRule";
            this.btnUpdateRule.Size = new System.Drawing.Size(244, 39);
            this.btnUpdateRule.TabIndex = 1;
            this.btnUpdateRule.TabStop = false;
            this.btnUpdateRule.Text = "Thay Đổi Quy Định";
            this.btnUpdateRule.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.AutoSize = true;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(423, 140);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(244, 39);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.TabStop = false;
            this.btnUpdatePassword.Text = "Đổi Mật Khẩu";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSize = true;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(423, 51);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(244, 39);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.TabStop = false;
            this.btnProfile.Text = "Thông Tin Cá Nhân";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // lbTitile
            // 
            this.lbTitile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitile.AutoSize = true;
            this.lbTitile.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitile.Location = new System.Drawing.Point(136, 28);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(557, 35);
            this.lbTitile.TabIndex = 1;
            this.lbTitile.Text = "HỆ THỐNG BÁN VÉ MÁY BAY - ADMIN";
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitile);
            this.Controls.Add(this.panel1);
            this.Name = "MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Bán Vé Máy Bay - Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainAdmin_closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAdmin_closed);
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStaffManager;
        private System.Windows.Forms.Button btnCustomerManager;
        private System.Windows.Forms.Button btnUpdateRule;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lbTitile;
    }
}

