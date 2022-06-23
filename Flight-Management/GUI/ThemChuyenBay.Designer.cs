
namespace Flight_Management.GUI
{
    partial class ThemChuyenBay
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
            this.lbDayOfTakeOff = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDayOfTakeOff = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudVipSeat = new System.Windows.Forms.NumericUpDown();
            this.lbVipSeat = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nudNormalSeat = new System.Windows.Forms.NumericUpDown();
            this.lbNormalSeat = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbTakeOffAirport = new System.Windows.Forms.Label();
            this.cbbTakeOffAirport = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbLandAirport = new System.Windows.Forms.ComboBox();
            this.lbLandAirport = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.dtpTimeOfTakeOff = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVipSeat)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalSeat)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitile
            // 
            this.lbTitile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitile.AutoSize = true;
            this.lbTitile.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitile.Location = new System.Drawing.Point(263, 23);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(273, 35);
            this.lbTitile.TabIndex = 3;
            this.lbTitile.Text = "Thêm Chuyến Bay";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 377);
            this.panel1.TabIndex = 4;
            // 
            // lbDayOfTakeOff
            // 
            this.lbDayOfTakeOff.AutoSize = true;
            this.lbDayOfTakeOff.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayOfTakeOff.Location = new System.Drawing.Point(15, 11);
            this.lbDayOfTakeOff.Name = "lbDayOfTakeOff";
            this.lbDayOfTakeOff.Size = new System.Drawing.Size(109, 29);
            this.lbDayOfTakeOff.TabIndex = 0;
            this.lbDayOfTakeOff.Text = "Khởi hành:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpTimeOfTakeOff);
            this.panel2.Controls.Add(this.dtpDayOfTakeOff);
            this.panel2.Controls.Add(this.lbDayOfTakeOff);
            this.panel2.Location = new System.Drawing.Point(21, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 51);
            this.panel2.TabIndex = 1;
            // 
            // dtpDayOfTakeOff
            // 
            this.dtpDayOfTakeOff.CustomFormat = "dd/MM/yyyy";
            this.dtpDayOfTakeOff.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDayOfTakeOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayOfTakeOff.Location = new System.Drawing.Point(181, 9);
            this.dtpDayOfTakeOff.Name = "dtpDayOfTakeOff";
            this.dtpDayOfTakeOff.Size = new System.Drawing.Size(159, 34);
            this.dtpDayOfTakeOff.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudDuration);
            this.panel3.Controls.Add(this.lbDuration);
            this.panel3.Location = new System.Drawing.Point(495, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 51);
            this.panel3.TabIndex = 2;
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.Location = new System.Drawing.Point(15, 11);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(124, 29);
            this.lbDuration.TabIndex = 0;
            this.lbDuration.Text = "Số phút bay:";
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuration.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.nudDuration.Location = new System.Drawing.Point(145, 11);
            this.nudDuration.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(112, 34);
            this.nudDuration.TabIndex = 1;
            this.nudDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudVipSeat);
            this.panel4.Controls.Add(this.lbVipSeat);
            this.panel4.Location = new System.Drawing.Point(21, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 51);
            this.panel4.TabIndex = 3;
            // 
            // nudVipSeat
            // 
            this.nudVipSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVipSeat.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.nudVipSeat.Location = new System.Drawing.Point(181, 11);
            this.nudVipSeat.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudVipSeat.Name = "nudVipSeat";
            this.nudVipSeat.Size = new System.Drawing.Size(175, 34);
            this.nudVipSeat.TabIndex = 1;
            this.nudVipSeat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbVipSeat
            // 
            this.lbVipSeat.AutoSize = true;
            this.lbVipSeat.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVipSeat.Location = new System.Drawing.Point(15, 11);
            this.lbVipSeat.Name = "lbVipSeat";
            this.lbVipSeat.Size = new System.Drawing.Size(153, 29);
            this.lbVipSeat.TabIndex = 0;
            this.lbVipSeat.Text = "Số ghế hạng 1:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nudNormalSeat);
            this.panel5.Controls.Add(this.lbNormalSeat);
            this.panel5.Location = new System.Drawing.Point(400, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 51);
            this.panel5.TabIndex = 4;
            // 
            // nudNormalSeat
            // 
            this.nudNormalSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNormalSeat.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.nudNormalSeat.Location = new System.Drawing.Point(181, 11);
            this.nudNormalSeat.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudNormalSeat.Name = "nudNormalSeat";
            this.nudNormalSeat.Size = new System.Drawing.Size(175, 34);
            this.nudNormalSeat.TabIndex = 1;
            this.nudNormalSeat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbNormalSeat
            // 
            this.lbNormalSeat.AutoSize = true;
            this.lbNormalSeat.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNormalSeat.Location = new System.Drawing.Point(15, 11);
            this.lbNormalSeat.Name = "lbNormalSeat";
            this.lbNormalSeat.Size = new System.Drawing.Size(153, 29);
            this.lbNormalSeat.TabIndex = 0;
            this.lbNormalSeat.Text = "Số ghế hạng 2:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbbTakeOffAirport);
            this.panel6.Controls.Add(this.lbTakeOffAirport);
            this.panel6.Location = new System.Drawing.Point(21, 233);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(359, 51);
            this.panel6.TabIndex = 3;
            // 
            // lbTakeOffAirport
            // 
            this.lbTakeOffAirport.AutoSize = true;
            this.lbTakeOffAirport.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTakeOffAirport.Location = new System.Drawing.Point(15, 11);
            this.lbTakeOffAirport.Name = "lbTakeOffAirport";
            this.lbTakeOffAirport.Size = new System.Drawing.Size(109, 29);
            this.lbTakeOffAirport.TabIndex = 0;
            this.lbTakeOffAirport.Text = "Sân bay đi:";
            // 
            // cbbTakeOffAirport
            // 
            this.cbbTakeOffAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTakeOffAirport.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTakeOffAirport.FormattingEnabled = true;
            this.cbbTakeOffAirport.Location = new System.Drawing.Point(181, 11);
            this.cbbTakeOffAirport.Name = "cbbTakeOffAirport";
            this.cbbTakeOffAirport.Size = new System.Drawing.Size(175, 35);
            this.cbbTakeOffAirport.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbbLandAirport);
            this.panel7.Controls.Add(this.lbLandAirport);
            this.panel7.Location = new System.Drawing.Point(400, 233);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(359, 51);
            this.panel7.TabIndex = 4;
            // 
            // cbbLandAirport
            // 
            this.cbbLandAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLandAirport.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLandAirport.FormattingEnabled = true;
            this.cbbLandAirport.Location = new System.Drawing.Point(184, 11);
            this.cbbLandAirport.Name = "cbbLandAirport";
            this.cbbLandAirport.Size = new System.Drawing.Size(175, 35);
            this.cbbLandAirport.TabIndex = 1;
            // 
            // lbLandAirport
            // 
            this.lbLandAirport.AutoSize = true;
            this.lbLandAirport.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLandAirport.Location = new System.Drawing.Point(15, 11);
            this.lbLandAirport.Name = "lbLandAirport";
            this.lbLandAirport.Size = new System.Drawing.Size(130, 29);
            this.lbLandAirport.TabIndex = 0;
            this.lbLandAirport.Text = "Sân bay đến:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAddFlight);
            this.panel8.Controls.Add(this.btnBack);
            this.panel8.Location = new System.Drawing.Point(21, 318);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(735, 53);
            this.panel8.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(257, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 39);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.AutoSize = true;
            this.btnAddFlight.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(379, 11);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(102, 39);
            this.btnAddFlight.TabIndex = 1;
            this.btnAddFlight.Text = "Thêm";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // dtpTimeOfTakeOff
            // 
            this.dtpTimeOfTakeOff.CustomFormat = "HH:mm";
            this.dtpTimeOfTakeOff.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeOfTakeOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeOfTakeOff.Location = new System.Drawing.Point(360, 9);
            this.dtpTimeOfTakeOff.Name = "dtpTimeOfTakeOff";
            this.dtpTimeOfTakeOff.ShowUpDown = true;
            this.dtpTimeOfTakeOff.Size = new System.Drawing.Size(102, 34);
            this.dtpTimeOfTakeOff.TabIndex = 2;
            // 
            // ThemChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitile);
            this.Name = "ThemChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm Mềm Bán Vé Máy Bay - Nhân Viên";
            this.Load += new System.EventHandler(this.ThemChuyenBay_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVipSeat)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalSeat)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDayOfTakeOff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDayOfTakeOff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbbLandAirport;
        private System.Windows.Forms.Label lbLandAirport;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbbTakeOffAirport;
        private System.Windows.Forms.Label lbTakeOffAirport;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nudNormalSeat;
        private System.Windows.Forms.Label lbNormalSeat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudVipSeat;
        private System.Windows.Forms.Label lbVipSeat;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpTimeOfTakeOff;
    }
}