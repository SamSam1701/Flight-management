
namespace Flight_Management.GUI
{
    partial class CapNhatThanhToan
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
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUnpaid = new System.Windows.Forms.Button();
            this.btnAllBill = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitile
            // 
            this.lbTitile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitile.AutoSize = true;
            this.lbTitile.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitile.Location = new System.Drawing.Point(244, 21);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(321, 35);
            this.lbTitile.TabIndex = 4;
            this.lbTitile.Text = "Cập Nhật Thanh Toán";
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToResizeColumns = false;
            this.dtgvBill.AllowUserToResizeRows = false;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(15, 102);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(624, 336);
            this.dtgvBill.TabIndex = 5;
            this.dtgvBill.SelectionChanged += new System.EventHandler(this.dtgvBill_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnUnpaid);
            this.panel1.Controls.Add(this.btnAllBill);
            this.panel1.Controls.Add(this.btnPaid);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 40);
            this.panel1.TabIndex = 6;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(439, 1);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(188, 30);
            this.txbSearch.TabIndex = 4;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(645, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUnpaid
            // 
            this.btnUnpaid.AutoSize = true;
            this.btnUnpaid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnpaid.Location = new System.Drawing.Point(3, 2);
            this.btnUnpaid.Name = "btnUnpaid";
            this.btnUnpaid.Size = new System.Drawing.Size(152, 34);
            this.btnUnpaid.TabIndex = 2;
            this.btnUnpaid.Text = "Chưa thanh toán";
            this.btnUnpaid.UseVisualStyleBackColor = true;
            this.btnUnpaid.Click += new System.EventHandler(this.btnUnpaid_Click);
            // 
            // btnAllBill
            // 
            this.btnAllBill.AutoSize = true;
            this.btnAllBill.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBill.Location = new System.Drawing.Point(334, 1);
            this.btnAllBill.Name = "btnAllBill";
            this.btnAllBill.Size = new System.Drawing.Size(78, 36);
            this.btnAllBill.TabIndex = 0;
            this.btnAllBill.Text = "Tất cả";
            this.btnAllBill.UseVisualStyleBackColor = true;
            this.btnAllBill.Click += new System.EventHandler(this.btnAllBill_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.AutoSize = true;
            this.btnPaid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.Location = new System.Drawing.Point(178, 3);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(137, 34);
            this.btnPaid.TabIndex = 1;
            this.btnPaid.Text = "Đã thanh toán";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.btnDetail);
            this.panel2.Location = new System.Drawing.Point(645, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 349);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(12, 197);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 34);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Đã thu tiền";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.AutoSize = true;
            this.btnDetail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(12, 249);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(123, 34);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 302);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 34);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CapNhatThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvBill);
            this.Controls.Add(this.lbTitile);
            this.Name = "CapNhatThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Bán Vé Máy Bay";
            this.Load += new System.EventHandler(this.CapNhatThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitile;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllBill;
        private System.Windows.Forms.Button btnUnpaid;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnBack;
    }
}