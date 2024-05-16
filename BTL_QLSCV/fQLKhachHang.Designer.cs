namespace BTL_QLSCV
{
    partial class fQLKhachHang
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
            this.btHuy = new System.Windows.Forms.Button();
            this.btXoaKH = new System.Windows.Forms.Button();
            this.btSuaKH = new System.Windows.Forms.Button();
            this.btThemKH = new System.Windows.Forms.Button();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTTKH = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labeldiachi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsKhachHang = new System.Windows.Forms.DataGridView();
            this.gbTimKH = new System.Windows.Forms.GroupBox();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btTimKH = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label3 = new System.Windows.Forms.Label();
            this.gbChucNang.SuspendLayout();
            this.gbTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            this.gbTimKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(400, 115);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(176, 42);
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btXoaKH
            // 
            this.btXoaKH.Location = new System.Drawing.Point(200, 115);
            this.btXoaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(176, 42);
            this.btXoaKH.TabIndex = 9;
            this.btXoaKH.Text = "Xoá";
            this.btXoaKH.UseVisualStyleBackColor = true;
            this.btXoaKH.Click += new System.EventHandler(this.btXoaKH_Click);
            // 
            // btSuaKH
            // 
            this.btSuaKH.Location = new System.Drawing.Point(400, 65);
            this.btSuaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSuaKH.Name = "btSuaKH";
            this.btSuaKH.Size = new System.Drawing.Size(176, 42);
            this.btSuaKH.TabIndex = 8;
            this.btSuaKH.Text = "Sửa";
            this.btSuaKH.UseVisualStyleBackColor = true;
            this.btSuaKH.Click += new System.EventHandler(this.btSuaKH_Click);
            // 
            // btThemKH
            // 
            this.btThemKH.Location = new System.Drawing.Point(200, 65);
            this.btThemKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(176, 42);
            this.btThemKH.TabIndex = 5;
            this.btThemKH.Text = "Thêm";
            this.btThemKH.UseVisualStyleBackColor = true;
            this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btHuy);
            this.gbChucNang.Controls.Add(this.btXoaKH);
            this.gbChucNang.Controls.Add(this.btSuaKH);
            this.gbChucNang.Controls.Add(this.btThemKH);
            this.gbChucNang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.Location = new System.Drawing.Point(22, 463);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChucNang.Size = new System.Drawing.Size(776, 234);
            this.gbChucNang.TabIndex = 8;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(836, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Danh sách khách hàng:";
            // 
            // gbTTKH
            // 
            this.gbTTKH.Controls.Add(this.txtDiaChi);
            this.gbTTKH.Controls.Add(this.labeldiachi);
            this.gbTTKH.Controls.Add(this.txtSDT);
            this.gbTTKH.Controls.Add(this.label8);
            this.gbTTKH.Controls.Add(this.txtHoTen);
            this.gbTTKH.Controls.Add(this.label2);
            this.gbTTKH.Controls.Add(this.txtMaKH);
            this.gbTTKH.Controls.Add(this.label1);
            this.gbTTKH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTKH.Location = new System.Drawing.Point(22, 225);
            this.gbTTKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTTKH.Name = "gbTTKH";
            this.gbTTKH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTTKH.Size = new System.Drawing.Size(776, 206);
            this.gbTTKH.TabIndex = 7;
            this.gbTTKH.TabStop = false;
            this.gbTTKH.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(404, 143);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(318, 33);
            this.txtDiaChi.TabIndex = 11;
            // 
            // labeldiachi
            // 
            this.labeldiachi.AutoSize = true;
            this.labeldiachi.Location = new System.Drawing.Point(399, 118);
            this.labeldiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldiachi.Name = "labeldiachi";
            this.labeldiachi.Size = new System.Drawing.Size(66, 23);
            this.labeldiachi.TabIndex = 10;
            this.labeldiachi.Text = "Đia chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(52, 143);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(322, 33);
            this.txtSDT.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(400, 66);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(322, 33);
            this.txtHoTen.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(52, 66);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(322, 33);
            this.txtMaKH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã khach hàng:";
            // 
            // dsKhachHang
            // 
            this.dsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKhachHang.Location = new System.Drawing.Point(840, 89);
            this.dsKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dsKhachHang.Name = "dsKhachHang";
            this.dsKhachHang.RowHeadersWidth = 62;
            this.dsKhachHang.Size = new System.Drawing.Size(666, 697);
            this.dsKhachHang.TabIndex = 10;
            // 
            // gbTimKH
            // 
            this.gbTimKH.Controls.Add(this.txtTimKH);
            this.gbTimKH.Controls.Add(this.btTimKH);
            this.gbTimKH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimKH.Location = new System.Drawing.Point(22, 65);
            this.gbTimKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTimKH.Name = "gbTimKH";
            this.gbTimKH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTimKH.Size = new System.Drawing.Size(776, 131);
            this.gbTimKH.TabIndex = 6;
            this.gbTimKH.TabStop = false;
            this.gbTimKH.Text = "Tìm kiếm khách hàng";
            // 
            // txtTimKH
            // 
            this.txtTimKH.BackColor = System.Drawing.Color.White;
            this.txtTimKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.Location = new System.Drawing.Point(54, 51);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(492, 33);
            this.txtTimKH.TabIndex = 8;
            // 
            // btTimKH
            // 
            this.btTimKH.BackColor = System.Drawing.Color.White;
            this.btTimKH.ForeColor = System.Drawing.Color.Black;
            this.btTimKH.Location = new System.Drawing.Point(573, 42);
            this.btTimKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimKH.Name = "btTimKH";
            this.btTimKH.Size = new System.Drawing.Size(147, 48);
            this.btTimKH.TabIndex = 7;
            this.btTimKH.Text = "Tìm";
            this.btTimKH.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quản lý khách hàng";
            // 
            // fQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1538, 805);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbTTKH);
            this.Controls.Add(this.dsKhachHang);
            this.Controls.Add(this.gbTimKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fQLKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.fQLKhachHang_Load);
            this.gbChucNang.ResumeLayout(false);
            this.gbTTKH.ResumeLayout(false);
            this.gbTTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            this.gbTimKH.ResumeLayout(false);
            this.gbTimKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXoaKH;
        private System.Windows.Forms.Button btSuaKH;
        private System.Windows.Forms.Button btThemKH;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbTTKH;
        private System.Windows.Forms.DataGridView dsKhachHang;
        private System.Windows.Forms.GroupBox gbTimKH;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btTimKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labeldiachi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}