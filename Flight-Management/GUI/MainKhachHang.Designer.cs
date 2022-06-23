
namespace Flight_Management
{
    partial class MainKhachHang
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
            this.lbTitile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitile
            // 
            this.lbTitile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitile.AutoSize = true;
            this.lbTitile.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitile.Location = new System.Drawing.Point(69, 28);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(667, 35);
            this.lbTitile.TabIndex = 3;
            this.lbTitile.Text = "HỆ THỐNG BÁN VÉ MÁY BAY - KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnBuyTicket);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnUpdatePassword);
            this.panel1.Location = new System.Drawing.Point(42, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 357);
            this.panel1.TabIndex = 4;
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(54, 248);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(259, 39);
            this.btnCheckout.TabIndex = 11;
            this.btnCheckout.TabStop = false;
            this.btnCheckout.Text = "Thanh Toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSize = true;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(408, 61);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(261, 39);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.TabStop = false;
            this.btnProfile.Text = "Thông Tin Cá Nhân";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(54, 150);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(261, 39);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.TabStop = false;
            this.btnHistory.Text = "Lịch Sử Mua Vé";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.AutoSize = true;
            this.btnBuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.Location = new System.Drawing.Point(54, 61);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(259, 39);
            this.btnBuyTicket.TabIndex = 8;
            this.btnBuyTicket.TabStop = false;
            this.btnBuyTicket.Text = "Tra Cứu - Mua Vé";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(408, 248);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(261, 39);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.AutoSize = true;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(408, 150);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(261, 39);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.TabStop = false;
            this.btnUpdatePassword.Text = "Đổi Mật Khẩu";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // MainKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitile);
            this.Name = "MainKhachHang";
            this.Text = "Phần Mềm Bán Vé Máy Bay - Khách Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainKH_formClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainKH_formClosed);
            this.Load += new System.EventHandler(this.MainKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdatePassword;
    }
}