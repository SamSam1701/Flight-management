namespace Flight_Management
{
    partial class QuyDinh
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
            this.cbmaqd = new System.Windows.Forms.ComboBox();
            this.tbnamerule = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridviewRule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewRule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÁC QUY ĐỊNH";
            // 
            // cbmaqd
            // 
            this.cbmaqd.FormattingEnabled = true;
            this.cbmaqd.Location = new System.Drawing.Point(31, 391);
            this.cbmaqd.Name = "cbmaqd";
            this.cbmaqd.Size = new System.Drawing.Size(121, 24);
            this.cbmaqd.TabIndex = 2;
            this.cbmaqd.SelectedIndexChanged += new System.EventHandler(this.cbmaqd_SelectedIndexChanged);
            // 
            // tbnamerule
            // 
            this.tbnamerule.Location = new System.Drawing.Point(200, 393);
            this.tbnamerule.Name = "tbnamerule";
            this.tbnamerule.Size = new System.Drawing.Size(206, 22);
            this.tbnamerule.TabIndex = 3;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(468, 382);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(126, 33);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã quy định";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập tên quy định";
            // 
            // datagridviewRule
            // 
            this.datagridviewRule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.datagridviewRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewRule.Location = new System.Drawing.Point(9, 54);
            this.datagridviewRule.Name = "datagridviewRule";
            this.datagridviewRule.RowHeadersWidth = 51;
            this.datagridviewRule.RowTemplate.Height = 24;
            this.datagridviewRule.Size = new System.Drawing.Size(779, 272);
            this.datagridviewRule.TabIndex = 7;
            this.datagridviewRule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewRule_CellContentClick);
            // 
            // QuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridviewRule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.tbnamerule);
            this.Controls.Add(this.cbmaqd);
            this.Controls.Add(this.label1);
            this.Name = "QuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy định";
            this.Load += new System.EventHandler(this.QuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewRule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmaqd;
        private System.Windows.Forms.TextBox tbnamerule;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagridviewRule;
    }
}