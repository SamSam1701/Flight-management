namespace Flight_Management
{
    partial class TraCuuMuaVe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.cboSBDi = new System.Windows.Forms.ComboBox();
            this.cboSBDen = new System.Windows.Forms.ComboBox();
            this.lblHrAMi = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblAPM = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.dgvCB = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTim = new System.Windows.Forms.Button();
            this.btnShowFDGV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Chuyến Bay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sân Bay Đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sân Bay Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(48, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Khởi Hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(179, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Từ:";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(214, 184);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(97, 20);
            this.dtFrom.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(329, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đến:";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(373, 185);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(97, 20);
            this.dtTo.TabIndex = 7;
            // 
            // cboSBDi
            // 
            this.cboSBDi.FormattingEnabled = true;
            this.cboSBDi.Location = new System.Drawing.Point(182, 89);
            this.cboSBDi.Name = "cboSBDi";
            this.cboSBDi.Size = new System.Drawing.Size(129, 21);
            this.cboSBDi.TabIndex = 8;
            this.cboSBDi.SelectedIndexChanged += new System.EventHandler(this.cboSBDi_SelectedIndexChanged);
            // 
            // cboSBDen
            // 
            this.cboSBDen.FormattingEnabled = true;
            this.cboSBDen.Location = new System.Drawing.Point(182, 136);
            this.cboSBDen.Name = "cboSBDen";
            this.cboSBDen.Size = new System.Drawing.Size(129, 21);
            this.cboSBDen.TabIndex = 9;
            this.cboSBDen.SelectedIndexChanged += new System.EventHandler(this.cboSBDen_SelectedIndexChanged);
            // 
            // lblHrAMi
            // 
            this.lblHrAMi.AutoSize = true;
            this.lblHrAMi.BackColor = System.Drawing.Color.Transparent;
            this.lblHrAMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblHrAMi.ForeColor = System.Drawing.Color.Yellow;
            this.lblHrAMi.Location = new System.Drawing.Point(512, 50);
            this.lblHrAMi.Name = "lblHrAMi";
            this.lblHrAMi.Size = new System.Drawing.Size(199, 76);
            this.lblHrAMi.TabIndex = 10;
            this.lblHrAMi.Text = "00:00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblSec.ForeColor = System.Drawing.Color.Yellow;
            this.lblSec.Location = new System.Drawing.Point(699, 50);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(55, 39);
            this.lblSec.TabIndex = 12;
            this.lblSec.Text = "00";
            // 
            // lblAPM
            // 
            this.lblAPM.AutoSize = true;
            this.lblAPM.BackColor = System.Drawing.Color.Transparent;
            this.lblAPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblAPM.ForeColor = System.Drawing.Color.Yellow;
            this.lblAPM.Location = new System.Drawing.Point(699, 90);
            this.lblAPM.Name = "lblAPM";
            this.lblAPM.Size = new System.Drawing.Size(68, 39);
            this.lblAPM.TabIndex = 13;
            this.lblAPM.Text = "PM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.lblDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblDate.Location = new System.Drawing.Point(520, 136);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(137, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "JUN 20 2022";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.lblDay.ForeColor = System.Drawing.Color.Yellow;
            this.lblDay.Location = new System.Drawing.Point(669, 136);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(85, 25);
            this.lblDay.TabIndex = 15;
            this.lblDay.Text = "Sunday";
            // 
            // dgvCB
            // 
            this.dgvCB.AllowUserToAddRows = false;
            this.dgvCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBuy});
            this.dgvCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCB.Location = new System.Drawing.Point(0, 266);
            this.dgvCB.MultiSelect = false;
            this.dgvCB.Name = "dgvCB";
            this.dgvCB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCB.Size = new System.Drawing.Size(800, 184);
            this.dgvCB.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTim
            // 
            this.btnTim.Image = global::Flight_Management.Properties.Resources.Search_icon_removebg_preview__1_;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(182, 216);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 44);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnShowFDGV
            // 
            this.btnShowFDGV.BackColor = System.Drawing.Color.White;
            this.btnShowFDGV.FlatAppearance.BorderSize = 0;
            this.btnShowFDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFDGV.Image = global::Flight_Management.Properties.Resources.images_removebg_preview__2_;
            this.btnShowFDGV.Location = new System.Drawing.Point(5, 238);
            this.btnShowFDGV.Name = "btnShowFDGV";
            this.btnShowFDGV.Padding = new System.Windows.Forms.Padding(1);
            this.btnShowFDGV.Size = new System.Drawing.Size(34, 30);
            this.btnShowFDGV.TabIndex = 18;
            this.btnShowFDGV.UseVisualStyleBackColor = false;
            this.btnShowFDGV.Click += new System.EventHandler(this.btnShowFDGV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Flight_Management.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(373, 216);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 44);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnBuy.HeaderText = "";
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Text = "Đặt Vé";
            this.btnBuy.UseColumnTextForButtonValue = true;
            // 
            // TraCuuMuaVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flight_Management.Properties.Resources.plane_sky_flying_sunset_1048715_wallhere_com;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnShowFDGV);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvCB);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAPM);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblHrAMi);
            this.Controls.Add(this.cboSBDen);
            this.Controls.Add(this.cboSBDi);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TraCuuMuaVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Bán Vé Máy Bay - Tra Cứu";
            this.Load += new System.EventHandler(this.TraCuuMuaVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.ComboBox cboSBDi;
        private System.Windows.Forms.ComboBox cboSBDen;
        private System.Windows.Forms.Label lblHrAMi;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblAPM;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.DataGridView dgvCB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnShowFDGV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewButtonColumn btnBuy;
    }
}