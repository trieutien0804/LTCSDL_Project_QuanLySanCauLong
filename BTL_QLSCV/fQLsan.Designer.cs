﻿namespace BTL_QLSCV
{
    partial class fQLsan
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.gbSan = new System.Windows.Forms.GroupBox();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsSan = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btXoaSan = new System.Windows.Forms.Button();
            this.btSuaSan = new System.Windows.Forms.Button();
            this.btThemSan = new System.Windows.Forms.Button();
            this.btHuySan = new System.Windows.Forms.Button();
            this.txtTimSan = new System.Windows.Forms.TextBox();
            this.btTimSan = new System.Windows.Forms.Button();
            this.gbTimCa = new System.Windows.Forms.GroupBox();
            this.txtTimCa = new System.Windows.Forms.TextBox();
            this.btTimCa = new System.Windows.Forms.Button();
            this.gbCaTheoSan = new System.Windows.Forms.GroupBox();
            this.btHuyCa = new System.Windows.Forms.Button();
            this.btXoaCa = new System.Windows.Forms.Button();
            this.tbSuaCa = new System.Windows.Forms.Button();
            this.btThemCa = new System.Windows.Forms.Button();
            this.txtLoaiSan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dsCaTheoSan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gbSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbChucNang.SuspendLayout();
            this.gbTimCa.SuspendLayout();
            this.gbCaTheoSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gbSan
            // 
            this.gbSan.Controls.Add(this.txtTenSan);
            this.gbSan.Controls.Add(this.label2);
            this.gbSan.Controls.Add(this.txtMaSan);
            this.gbSan.Controls.Add(this.label1);
            this.gbSan.Location = new System.Drawing.Point(18, 32);
            this.gbSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSan.Name = "gbSan";
            this.gbSan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSan.Size = new System.Drawing.Size(776, 131);
            this.gbSan.TabIndex = 0;
            this.gbSan.TabStop = false;
            this.gbSan.Text = "Thông tin sân";
            // 
            // txtTenSan
            // 
            this.txtTenSan.BackColor = System.Drawing.Color.White;
            this.txtTenSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSan.Location = new System.Drawing.Point(447, 65);
            this.txtTenSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(270, 33);
            this.txtTenSan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sân:";
            // 
            // txtMaSan
            // 
            this.txtMaSan.BackColor = System.Drawing.Color.White;
            this.txtMaSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSan.Location = new System.Drawing.Point(52, 65);
            this.txtMaSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.Size = new System.Drawing.Size(232, 33);
            this.txtMaSan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sân:";
            // 
            // dsSan
            // 
            this.dsSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSan.Location = new System.Drawing.Point(837, 57);
            this.dsSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dsSan.Name = "dsSan";
            this.dsSan.RowHeadersWidth = 62;
            this.dsSan.Size = new System.Drawing.Size(666, 255);
            this.dsSan.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(837, 357);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(666, 408);
            this.dataGridView2.TabIndex = 3;
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btXoaSan);
            this.gbChucNang.Controls.Add(this.btSuaSan);
            this.gbChucNang.Controls.Add(this.btThemSan);
            this.gbChucNang.Controls.Add(this.btHuySan);
            this.gbChucNang.Controls.Add(this.txtTimSan);
            this.gbChucNang.Controls.Add(this.btTimSan);
            this.gbChucNang.Location = new System.Drawing.Point(18, 172);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChucNang.Size = new System.Drawing.Size(776, 197);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btXoaSan
            // 
            this.btXoaSan.Location = new System.Drawing.Point(399, 122);
            this.btXoaSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoaSan.Name = "btXoaSan";
            this.btXoaSan.Size = new System.Drawing.Size(147, 42);
            this.btXoaSan.TabIndex = 14;
            this.btXoaSan.Text = "Xoá sân";
            this.btXoaSan.UseVisualStyleBackColor = true;
            this.btXoaSan.Click += new System.EventHandler(this.btXoaSan_Click);
            // 
            // btSuaSan
            // 
            this.btSuaSan.Location = new System.Drawing.Point(225, 122);
            this.btSuaSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSuaSan.Name = "btSuaSan";
            this.btSuaSan.Size = new System.Drawing.Size(147, 42);
            this.btSuaSan.TabIndex = 13;
            this.btSuaSan.Text = "Cập nhật sân";
            this.btSuaSan.UseVisualStyleBackColor = true;
            this.btSuaSan.Click += new System.EventHandler(this.btSuaSan_Click);
            // 
            // btThemSan
            // 
            this.btThemSan.Location = new System.Drawing.Point(52, 122);
            this.btThemSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThemSan.Name = "btThemSan";
            this.btThemSan.Size = new System.Drawing.Size(147, 42);
            this.btThemSan.TabIndex = 12;
            this.btThemSan.Text = "Thêm sân";
            this.btThemSan.UseVisualStyleBackColor = true;
            this.btThemSan.Click += new System.EventHandler(this.btThemSan_Click);
            // 
            // btHuySan
            // 
            this.btHuySan.Location = new System.Drawing.Point(572, 122);
            this.btHuySan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuySan.Name = "btHuySan";
            this.btHuySan.Size = new System.Drawing.Size(147, 42);
            this.btHuySan.TabIndex = 11;
            this.btHuySan.Text = "Huỷ";
            this.btHuySan.UseVisualStyleBackColor = true;
            // 
            // txtTimSan
            // 
            this.txtTimSan.BackColor = System.Drawing.Color.White;
            this.txtTimSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSan.Location = new System.Drawing.Point(52, 57);
            this.txtTimSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimSan.Name = "txtTimSan";
            this.txtTimSan.Size = new System.Drawing.Size(492, 33);
            this.txtTimSan.TabIndex = 4;
            // 
            // btTimSan
            // 
            this.btTimSan.Location = new System.Drawing.Point(572, 51);
            this.btTimSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimSan.Name = "btTimSan";
            this.btTimSan.Size = new System.Drawing.Size(147, 48);
            this.btTimSan.TabIndex = 3;
            this.btTimSan.Text = "Tìm";
            this.btTimSan.UseVisualStyleBackColor = true;
            // 
            // gbTimCa
            // 
            this.gbTimCa.Controls.Add(this.txtTimCa);
            this.gbTimCa.Controls.Add(this.btTimCa);
            this.gbTimCa.Location = new System.Drawing.Point(18, 398);
            this.gbTimCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTimCa.Name = "gbTimCa";
            this.gbTimCa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTimCa.Size = new System.Drawing.Size(776, 102);
            this.gbTimCa.TabIndex = 2;
            this.gbTimCa.TabStop = false;
            this.gbTimCa.Text = "Tìm kiếm ca";
            // 
            // txtTimCa
            // 
            this.txtTimCa.BackColor = System.Drawing.Color.White;
            this.txtTimCa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimCa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimCa.Location = new System.Drawing.Point(64, 34);
            this.txtTimCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimCa.Name = "txtTimCa";
            this.txtTimCa.Size = new System.Drawing.Size(480, 33);
            this.txtTimCa.TabIndex = 6;
            // 
            // btTimCa
            // 
            this.btTimCa.Location = new System.Drawing.Point(572, 29);
            this.btTimCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimCa.Name = "btTimCa";
            this.btTimCa.Size = new System.Drawing.Size(147, 48);
            this.btTimCa.TabIndex = 5;
            this.btTimCa.Text = "Tìm";
            this.btTimCa.UseVisualStyleBackColor = true;
            // 
            // gbCaTheoSan
            // 
            this.gbCaTheoSan.Controls.Add(this.btHuyCa);
            this.gbCaTheoSan.Controls.Add(this.btXoaCa);
            this.gbCaTheoSan.Controls.Add(this.tbSuaCa);
            this.gbCaTheoSan.Controls.Add(this.btThemCa);
            this.gbCaTheoSan.Controls.Add(this.txtLoaiSan);
            this.gbCaTheoSan.Controls.Add(this.label5);
            this.gbCaTheoSan.Controls.Add(this.txtGia);
            this.gbCaTheoSan.Controls.Add(this.label4);
            this.gbCaTheoSan.Controls.Add(this.txtMaCa);
            this.gbCaTheoSan.Controls.Add(this.label3);
            this.gbCaTheoSan.Location = new System.Drawing.Point(18, 531);
            this.gbCaTheoSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCaTheoSan.Name = "gbCaTheoSan";
            this.gbCaTheoSan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCaTheoSan.Size = new System.Drawing.Size(776, 234);
            this.gbCaTheoSan.TabIndex = 2;
            this.gbCaTheoSan.TabStop = false;
            this.gbCaTheoSan.Text = "Thông tin ca theo loại sân";
            // 
            // btHuyCa
            // 
            this.btHuyCa.Location = new System.Drawing.Point(543, 180);
            this.btHuyCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuyCa.Name = "btHuyCa";
            this.btHuyCa.Size = new System.Drawing.Size(176, 42);
            this.btHuyCa.TabIndex = 10;
            this.btHuyCa.Text = "Huỷ";
            this.btHuyCa.UseVisualStyleBackColor = true;
            // 
            // btXoaCa
            // 
            this.btXoaCa.Location = new System.Drawing.Point(543, 129);
            this.btXoaCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoaCa.Name = "btXoaCa";
            this.btXoaCa.Size = new System.Drawing.Size(176, 42);
            this.btXoaCa.TabIndex = 9;
            this.btXoaCa.Text = "Xoá ca";
            this.btXoaCa.UseVisualStyleBackColor = true;
            // 
            // tbSuaCa
            // 
            this.tbSuaCa.Location = new System.Drawing.Point(543, 78);
            this.tbSuaCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSuaCa.Name = "tbSuaCa";
            this.tbSuaCa.Size = new System.Drawing.Size(176, 42);
            this.tbSuaCa.TabIndex = 8;
            this.tbSuaCa.Text = "Sửa ca";
            this.tbSuaCa.UseVisualStyleBackColor = true;
            // 
            // btThemCa
            // 
            this.btThemCa.Location = new System.Drawing.Point(543, 28);
            this.btThemCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThemCa.Name = "btThemCa";
            this.btThemCa.Size = new System.Drawing.Size(176, 42);
            this.btThemCa.TabIndex = 5;
            this.btThemCa.Text = "Thêm ca";
            this.btThemCa.UseVisualStyleBackColor = true;
            // 
            // txtLoaiSan
            // 
            this.txtLoaiSan.BackColor = System.Drawing.Color.White;
            this.txtLoaiSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaiSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSan.Location = new System.Drawing.Point(302, 69);
            this.txtLoaiSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoaiSan.Name = "txtLoaiSan";
            this.txtLoaiSan.Size = new System.Drawing.Size(179, 33);
            this.txtLoaiSan.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại sân:";
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(57, 154);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(179, 33);
            this.txtGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            // 
            // txtMaCa
            // 
            this.txtMaCa.BackColor = System.Drawing.Color.White;
            this.txtMaCa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCa.Location = new System.Drawing.Point(57, 69);
            this.txtMaCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(179, 33);
            this.txtMaCa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã ca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(832, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh sách sân:";
            // 
            // dsCaTheoSan
            // 
            this.dsCaTheoSan.AutoSize = true;
            this.dsCaTheoSan.Location = new System.Drawing.Point(832, 328);
            this.dsCaTheoSan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dsCaTheoSan.Name = "dsCaTheoSan";
            this.dsCaTheoSan.Size = new System.Drawing.Size(205, 20);
            this.dsCaTheoSan.TabIndex = 5;
            this.dsCaTheoSan.Text = "Danh sách ca theo loại sân:";
            // 
            // fQLsan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1538, 805);
            this.Controls.Add(this.dsCaTheoSan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbCaTheoSan);
            this.Controls.Add(this.gbTimCa);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dsSan);
            this.Controls.Add(this.gbSan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fQLsan";
            this.Text = "fQLsan";
            this.Load += new System.EventHandler(this.fQLsan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gbSan.ResumeLayout(false);
            this.gbSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            this.gbChucNang.PerformLayout();
            this.gbTimCa.ResumeLayout(false);
            this.gbTimCa.PerformLayout();
            this.gbCaTheoSan.ResumeLayout(false);
            this.gbCaTheoSan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox gbSan;
        private System.Windows.Forms.DataGridView dsSan;
        private System.Windows.Forms.GroupBox gbCaTheoSan;
        private System.Windows.Forms.GroupBox gbTimCa;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.Button btTimSan;
        private System.Windows.Forms.TextBox txtTimSan;
        private System.Windows.Forms.TextBox txtLoaiSan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimCa;
        private System.Windows.Forms.Button btTimCa;
        private System.Windows.Forms.Button btHuyCa;
        private System.Windows.Forms.Button btXoaCa;
        private System.Windows.Forms.Button tbSuaCa;
        private System.Windows.Forms.Button btThemCa;
        private System.Windows.Forms.Label dsCaTheoSan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXoaSan;
        private System.Windows.Forms.Button btSuaSan;
        private System.Windows.Forms.Button btThemSan;
        private System.Windows.Forms.Button btHuySan;
    }
}