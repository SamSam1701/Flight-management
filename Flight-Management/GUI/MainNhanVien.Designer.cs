
namespace Flight_Management
{
    partial class MainNhanVien
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
            this.btnUpdateCheckout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnStatisticReport = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnSearchFlight = new System.Windows.Forms.Button();
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
            this.lbTitile.Location = new System.Drawing.Point(93, 22);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(626, 35);
            this.lbTitile.TabIndex = 2;
            this.lbTitile.Text = "HỆ THỐNG BÁN VÉ MÁY BAY - NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateCheckout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnStatisticReport);
            this.panel1.Controls.Add(this.btnAddFlight);
            this.panel1.Controls.Add(this.btnSearchFlight);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnUpdatePassword);
            this.panel1.Location = new System.Drawing.Point(42, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 357);
            this.panel1.TabIndex = 3;
            // 
            // btnUpdateCheckout
            // 
            this.btnUpdateCheckout.AutoSize = true;
            this.btnUpdateCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCheckout.Location = new System.Drawing.Point(57, 217);
            this.btnUpdateCheckout.Name = "btnUpdateCheckout";
            this.btnUpdateCheckout.Size = new System.Drawing.Size(259, 39);
            this.btnUpdateCheckout.TabIndex = 11;
            this.btnUpdateCheckout.TabStop = false;
            this.btnUpdateCheckout.Text = "Cập Nhật Thanh Toán";
            this.btnUpdateCheckout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSize = true;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(411, 119);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(261, 39);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.TabStop = false;
            this.btnProfile.Text = "Thông Tin Cá Nhân";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnStatisticReport
            // 
            this.btnStatisticReport.AutoSize = true;
            this.btnStatisticReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticReport.Location = new System.Drawing.Point(411, 30);
            this.btnStatisticReport.Name = "btnStatisticReport";
            this.btnStatisticReport.Size = new System.Drawing.Size(261, 39);
            this.btnStatisticReport.TabIndex = 9;
            this.btnStatisticReport.TabStop = false;
            this.btnStatisticReport.Text = "Thống Kê - Báo Cáo";
            this.btnStatisticReport.UseVisualStyleBackColor = true;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.AutoSize = true;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(57, 30);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(259, 39);
            this.btnAddFlight.TabIndex = 8;
            this.btnAddFlight.TabStop = false;
            this.btnAddFlight.Text = "Thêm Chuyến Bay";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.AutoSize = true;
            this.btnSearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFlight.Location = new System.Drawing.Point(57, 119);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(259, 39);
            this.btnSearchFlight.TabIndex = 7;
            this.btnSearchFlight.TabStop = false;
            this.btnSearchFlight.Text = "Tra Cứu Chuyến Bay";
            this.btnSearchFlight.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(246, 297);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(242, 39);
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
            this.btnUpdatePassword.Location = new System.Drawing.Point(411, 217);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(261, 39);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.TabStop = false;
            this.btnUpdatePassword.Text = "Đổi Mật Khẩu";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // MainNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitile);
            this.Name = "MainNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Bán Vé Máy Bay - Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainNV_formClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainNV_formClosed);
            this.Load += new System.EventHandler(this.MainNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatisticReport;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnSearchFlight;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnUpdateCheckout;
        private System.Windows.Forms.Button btnProfile;
    }
}