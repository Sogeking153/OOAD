﻿namespace OOAD
{
    partial class THYCKH
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CoQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiLienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienGhiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienThucHien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThucTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(164, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(293, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Đang xử lý",
            "Không thể xử lý"});
            this.listBox1.Location = new System.Drawing.Point(12, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 372);
            this.listBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoQuan,
            this.NguoiLienHe,
            this.NhanVienGhiNhan,
            this.NhanVienThucHien,
            this.ThucTrang});
            this.dataGridView1.Location = new System.Drawing.Point(248, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 372);
            this.dataGridView1.TabIndex = 4;
            // 
            // CoQuan
            // 
            this.CoQuan.HeaderText = "Cơ quan";
            this.CoQuan.MinimumWidth = 6;
            this.CoQuan.Name = "CoQuan";
            this.CoQuan.Width = 125;
            // 
            // NguoiLienHe
            // 
            this.NguoiLienHe.HeaderText = "Người liên hệ";
            this.NguoiLienHe.MinimumWidth = 6;
            this.NguoiLienHe.Name = "NguoiLienHe";
            this.NguoiLienHe.Width = 125;
            // 
            // NhanVienGhiNhan
            // 
            this.NhanVienGhiNhan.HeaderText = "Nhân viên ghi nhận";
            this.NhanVienGhiNhan.MinimumWidth = 6;
            this.NhanVienGhiNhan.Name = "NhanVienGhiNhan";
            this.NhanVienGhiNhan.Width = 125;
            // 
            // NhanVienThucHien
            // 
            this.NhanVienThucHien.HeaderText = "Nhân viên thực hiện";
            this.NhanVienThucHien.MinimumWidth = 6;
            this.NhanVienThucHien.Name = "NhanVienThucHien";
            this.NhanVienThucHien.Width = 125;
            // 
            // ThucTrang
            // 
            this.ThucTrang.HeaderText = "Thực trạng";
            this.ThucTrang.MinimumWidth = 6;
            this.ThucTrang.Name = "ThucTrang";
            this.ThucTrang.Width = 125;
            // 
            // THYCKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "THYCKH";
            this.Text = "THYCKH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienGhiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienThucHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThucTrang;
    }
}