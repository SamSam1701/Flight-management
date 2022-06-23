namespace Flight_Management
{
    partial class TraCuuChuyenBay
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvListFlight = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDayOfTakeOff = new System.Windows.Forms.CheckBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbLandAirport = new System.Windows.Forms.ComboBox();
            this.cbbTakeOffAirport = new System.Windows.Forms.ComboBox();
            this.dtpDayOfTakeOff = new System.Windows.Forms.DateTimePicker();
            this.lbLandAirport = new System.Windows.Forms.Label();
            this.lbTakeOffAirport = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFlight)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(181, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(304, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvListFlight);
            this.panel1.Location = new System.Drawing.Point(4, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 235);
            this.panel1.TabIndex = 1;
            // 
            // dtgvListFlight
            // 
            this.dtgvListFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListFlight.Location = new System.Drawing.Point(12, 3);
            this.dtgvListFlight.Name = "dtgvListFlight";
            this.dtgvListFlight.RowHeadersWidth = 51;
            this.dtgvListFlight.RowTemplate.Height = 24;
            this.dtgvListFlight.Size = new System.Drawing.Size(629, 223);
            this.dtgvListFlight.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDayOfTakeOff);
            this.panel2.Controls.Add(this.btnAll);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.cbbLandAirport);
            this.panel2.Controls.Add(this.cbbTakeOffAirport);
            this.panel2.Controls.Add(this.dtpDayOfTakeOff);
            this.panel2.Controls.Add(this.lbLandAirport);
            this.panel2.Controls.Add(this.lbTakeOffAirport);
            this.panel2.Controls.Add(this.txbId);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Location = new System.Drawing.Point(4, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 82);
            this.panel2.TabIndex = 2;
            // 
            // cbDayOfTakeOff
            // 
            this.cbDayOfTakeOff.AutoSize = true;
            this.cbDayOfTakeOff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDayOfTakeOff.Location = new System.Drawing.Point(3, 45);
            this.cbDayOfTakeOff.Name = "cbDayOfTakeOff";
            this.cbDayOfTakeOff.Size = new System.Drawing.Size(88, 28);
            this.cbDayOfTakeOff.TabIndex = 10;
            this.cbDayOfTakeOff.Text = "Ngày đi";
            this.cbDayOfTakeOff.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(540, 9);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(101, 32);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "Tất Cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(540, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbLandAirport
            // 
            this.cbbLandAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLandAirport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLandAirport.FormattingEnabled = true;
            this.cbbLandAirport.Location = new System.Drawing.Point(350, 45);
            this.cbbLandAirport.Name = "cbbLandAirport";
            this.cbbLandAirport.Size = new System.Drawing.Size(184, 32);
            this.cbbLandAirport.TabIndex = 7;
            // 
            // cbbTakeOffAirport
            // 
            this.cbbTakeOffAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTakeOffAirport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTakeOffAirport.FormattingEnabled = true;
            this.cbbTakeOffAirport.Location = new System.Drawing.Point(350, 7);
            this.cbbTakeOffAirport.Name = "cbbTakeOffAirport";
            this.cbbTakeOffAirport.Size = new System.Drawing.Size(184, 32);
            this.cbbTakeOffAirport.TabIndex = 6;
            // 
            // dtpDayOfTakeOff
            // 
            this.dtpDayOfTakeOff.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDayOfTakeOff.CustomFormat = "dd/MM/yyyy";
            this.dtpDayOfTakeOff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDayOfTakeOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayOfTakeOff.Location = new System.Drawing.Point(105, 45);
            this.dtpDayOfTakeOff.Name = "dtpDayOfTakeOff";
            this.dtpDayOfTakeOff.Size = new System.Drawing.Size(118, 30);
            this.dtpDayOfTakeOff.TabIndex = 4;
            // 
            // lbLandAirport
            // 
            this.lbLandAirport.AutoSize = true;
            this.lbLandAirport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLandAirport.Location = new System.Drawing.Point(229, 51);
            this.lbLandAirport.Name = "lbLandAirport";
            this.lbLandAirport.Size = new System.Drawing.Size(107, 24);
            this.lbLandAirport.TabIndex = 3;
            this.lbLandAirport.Text = "Sân bay đến:";
            // 
            // lbTakeOffAirport
            // 
            this.lbTakeOffAirport.AutoSize = true;
            this.lbTakeOffAirport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTakeOffAirport.Location = new System.Drawing.Point(229, 13);
            this.lbTakeOffAirport.Name = "lbTakeOffAirport";
            this.lbTakeOffAirport.Size = new System.Drawing.Size(93, 24);
            this.lbTakeOffAirport.TabIndex = 2;
            this.lbTakeOffAirport.Text = "Sân bay đi:";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(105, 10);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(118, 30);
            this.txbId.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(24, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(39, 24);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Mã:";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(4, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(657, 386);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "TraCuuChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuuChuyenBay";
            this.Load += new System.EventHandler(this.TraCuuChuyenBay_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFlight)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.ComboBox cbbLandAirport;
        private System.Windows.Forms.ComboBox cbbTakeOffAirport;
        private System.Windows.Forms.DateTimePicker dtpDayOfTakeOff;
        private System.Windows.Forms.Label lbLandAirport;
        private System.Windows.Forms.Label lbTakeOffAirport;
        private System.Windows.Forms.DataGridView dtgvListFlight;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.CheckBox cbDayOfTakeOff;
    }
}