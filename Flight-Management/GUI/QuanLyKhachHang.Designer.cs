namespace Flight_Management.GUI
{
    partial class QuanLyKhachHang
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
            this.dtgvkhachhang = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvkhachhang
            // 
            this.dtgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvkhachhang.Location = new System.Drawing.Point(11, 13);
            this.dtgvkhachhang.Name = "dtgvkhachhang";
            this.dtgvkhachhang.RowHeadersWidth = 51;
            this.dtgvkhachhang.RowTemplate.Height = 24;
            this.dtgvkhachhang.Size = new System.Drawing.Size(780, 332);
            this.dtgvkhachhang.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(412, 384);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(125, 40);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(273, 393);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(112, 24);
            this.cbkhachhang.TabIndex = 2;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbkhachhang);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dtgvkhachhang);
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvkhachhang;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cbkhachhang;
    }
}