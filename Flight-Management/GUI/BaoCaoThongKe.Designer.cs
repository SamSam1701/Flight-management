
namespace Flight_Management.GUI
{
    partial class BaoCaoThongKe
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
            this.dtpByMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpByYear = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportByYear = new System.Windows.Forms.Button();
            this.btnExportByMonth = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitile
            // 
            this.lbTitile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitile.AutoSize = true;
            this.lbTitile.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitile.Location = new System.Drawing.Point(239, 23);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(299, 35);
            this.lbTitile.TabIndex = 5;
            this.lbTitile.Text = "Báo Cáo - Thống Kê";
            // 
            // dtpByMonth
            // 
            this.dtpByMonth.CustomFormat = "MM/yyyy";
            this.dtpByMonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpByMonth.Location = new System.Drawing.Point(8, 13);
            this.dtpByMonth.Name = "dtpByMonth";
            this.dtpByMonth.ShowUpDown = true;
            this.dtpByMonth.Size = new System.Drawing.Size(118, 30);
            this.dtpByMonth.TabIndex = 7;
            // 
            // dtpByYear
            // 
            this.dtpByYear.CustomFormat = "yyyy";
            this.dtpByYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpByYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpByYear.Location = new System.Drawing.Point(267, 13);
            this.dtpByYear.Name = "dtpByYear";
            this.dtpByYear.ShowUpDown = true;
            this.dtpByYear.Size = new System.Drawing.Size(118, 30);
            this.dtpByYear.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnExportByYear);
            this.panel2.Controls.Add(this.btnExportByMonth);
            this.panel2.Controls.Add(this.dtpByMonth);
            this.panel2.Controls.Add(this.dtpByYear);
            this.panel2.Location = new System.Drawing.Point(15, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 53);
            this.panel2.TabIndex = 9;
            // 
            // btnExportByYear
            // 
            this.btnExportByYear.AutoSize = true;
            this.btnExportByYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportByYear.Location = new System.Drawing.Point(391, 13);
            this.btnExportByYear.Name = "btnExportByYear";
            this.btnExportByYear.Size = new System.Drawing.Size(75, 34);
            this.btnExportByYear.TabIndex = 10;
            this.btnExportByYear.Text = "Xuất";
            this.btnExportByYear.UseVisualStyleBackColor = true;
            this.btnExportByYear.Click += new System.EventHandler(this.btnExportByYear_Click);
            // 
            // btnExportByMonth
            // 
            this.btnExportByMonth.AutoSize = true;
            this.btnExportByMonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportByMonth.Location = new System.Drawing.Point(132, 13);
            this.btnExportByMonth.Name = "btnExportByMonth";
            this.btnExportByMonth.Size = new System.Drawing.Size(75, 34);
            this.btnExportByMonth.TabIndex = 9;
            this.btnExportByMonth.Text = "Xuất";
            this.btnExportByMonth.UseVisualStyleBackColor = true;
            this.btnExportByMonth.Click += new System.EventHandler(this.btnExportByMonth_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvReport);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 333);
            this.panel1.TabIndex = 6;
            // 
            // dtgvReport
            // 
            this.dtgvReport.AllowUserToAddRows = false;
            this.dtgvReport.AllowUserToDeleteRows = false;
            this.dtgvReport.AllowUserToResizeColumns = false;
            this.dtgvReport.AllowUserToResizeRows = false;
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(11, 3);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.ReadOnly = true;
            this.dtgvReport.RowHeadersWidth = 51;
            this.dtgvReport.RowTemplate.Height = 24;
            this.dtgvReport.Size = new System.Drawing.Size(751, 318);
            this.dtgvReport.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(674, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 34);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitile);
            this.Name = "BaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Bán Vé Máy Bay";
            this.Load += new System.EventHandler(this.BaoCaoThongKe_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitile;
        private System.Windows.Forms.DateTimePicker dtpByMonth;
        private System.Windows.Forms.DateTimePicker dtpByYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportByMonth;
        private System.Windows.Forms.Button btnExportByYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvReport;
        private System.Windows.Forms.Button btnBack;
    }
}