namespace Flight_Management.GUI
{
    partial class quanlynhanvien
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
            this.datagvquanlynhanvien = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagvquanlynhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // datagvquanlynhanvien
            // 
            this.datagvquanlynhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvquanlynhanvien.Location = new System.Drawing.Point(16, 104);
            this.datagvquanlynhanvien.Name = "datagvquanlynhanvien";
            this.datagvquanlynhanvien.RowHeadersWidth = 51;
            this.datagvquanlynhanvien.RowTemplate.Height = 24;
            this.datagvquanlynhanvien.Size = new System.Drawing.Size(766, 337);
            this.datagvquanlynhanvien.TabIndex = 0;
            this.datagvquanlynhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvquanlynhanvien_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(237, 40);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 35);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(491, 40);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(83, 35);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(696, 40);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(86, 35);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(16, 40);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(90, 34);
            this.btnshow.TabIndex = 5;
            this.btnshow.Text = "Xem";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.datagvquanlynhanvien);
            this.Name = "quanlynhanvien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.quanlynhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagvquanlynhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagvquanlynhanvien;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnshow;
    }
}