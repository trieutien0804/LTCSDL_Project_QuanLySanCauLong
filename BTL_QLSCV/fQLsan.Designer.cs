
namespace BTL_QLSCV
{
    partial class fQLSan
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
            this.txtTimSan = new System.Windows.Forms.TextBox();
            this.btTimSan = new System.Windows.Forms.Button();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsSan = new System.Windows.Forms.DataGridView();
            this.dsCaThue = new System.Windows.Forms.DataGridView();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btXoaSan = new System.Windows.Forms.Button();
            this.btSuaSan = new System.Windows.Forms.Button();
            this.btThemSan = new System.Windows.Forms.Button();
            this.gbTimCa = new System.Windows.Forms.GroupBox();
            this.btCNCa = new System.Windows.Forms.Button();
            this.gbCaTheoSan = new System.Windows.Forms.GroupBox();
            this.comboTree1 = new DevComponents.DotNetBar.Controls.ComboTree();
            this.cbTenSan = new System.Windows.Forms.ComboBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXoaCa = new System.Windows.Forms.Button();
            this.tbSuaCa = new System.Windows.Forms.Button();
            this.btThemCaThue = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dsCaTheoSan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gbSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaThue)).BeginInit();
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
            this.gbSan.Controls.Add(this.txtTimSan);
            this.gbSan.Controls.Add(this.btTimSan);
            this.gbSan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSan.Location = new System.Drawing.Point(18, 57);
            this.gbSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSan.Name = "gbSan";
            this.gbSan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSan.Size = new System.Drawing.Size(776, 131);
            this.gbSan.TabIndex = 0;
            this.gbSan.TabStop = false;
            this.gbSan.Text = "Tìm kiếm sân";
            // 
            // txtTimSan
            // 
            this.txtTimSan.BackColor = System.Drawing.Color.White;
            this.txtTimSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSan.Location = new System.Drawing.Point(54, 48);
            this.txtTimSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimSan.Name = "txtTimSan";
            this.txtTimSan.Size = new System.Drawing.Size(492, 33);
            this.txtTimSan.TabIndex = 6;
            // 
            // btTimSan
            // 
            this.btTimSan.Location = new System.Drawing.Point(573, 42);
            this.btTimSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimSan.Name = "btTimSan";
            this.btTimSan.Size = new System.Drawing.Size(147, 48);
            this.btTimSan.TabIndex = 5;
            this.btTimSan.Text = "Tìm";
            this.btTimSan.UseVisualStyleBackColor = true;
            // 
            // txtTenSan
            // 
            this.txtTenSan.BackColor = System.Drawing.Color.White;
            this.txtTenSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSan.Location = new System.Drawing.Point(399, 57);
            this.txtTenSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(318, 33);
            this.txtTenSan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sân:";
            // 
            // txtMaSan
            // 
            this.txtMaSan.BackColor = System.Drawing.Color.White;
            this.txtMaSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSan.Location = new System.Drawing.Point(52, 57);
            this.txtMaSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.Size = new System.Drawing.Size(318, 33);
            this.txtMaSan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
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
            this.dsSan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsSan_CellContentClick);
            // 
            // dsCaThue
            // 
            this.dsCaThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCaThue.Location = new System.Drawing.Point(837, 357);
            this.dsCaThue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dsCaThue.Name = "dsCaThue";
            this.dsCaThue.RowHeadersWidth = 62;
            this.dsCaThue.Size = new System.Drawing.Size(666, 408);
            this.dsCaThue.TabIndex = 3;
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.txtTenSan);
            this.gbChucNang.Controls.Add(this.label2);
            this.gbChucNang.Controls.Add(this.txtMaSan);
            this.gbChucNang.Controls.Add(this.label1);
            this.gbChucNang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.Location = new System.Drawing.Point(18, 197);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbChucNang.Size = new System.Drawing.Size(776, 129);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btXoaSan
            // 
            this.btXoaSan.Location = new System.Drawing.Point(388, 32);
            this.btXoaSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoaSan.Name = "btXoaSan";
            this.btXoaSan.Size = new System.Drawing.Size(147, 42);
            this.btXoaSan.TabIndex = 14;
            this.btXoaSan.Text = "Xoá sân";
            this.btXoaSan.UseVisualStyleBackColor = true;
            this.btXoaSan.Click += new System.EventHandler(this.btXoaSan_Click_1);
            // 
            // btSuaSan
            // 
            this.btSuaSan.Location = new System.Drawing.Point(228, 32);
            this.btSuaSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSuaSan.Name = "btSuaSan";
            this.btSuaSan.Size = new System.Drawing.Size(147, 42);
            this.btSuaSan.TabIndex = 13;
            this.btSuaSan.Text = "Cập nhật sân";
            this.btSuaSan.UseVisualStyleBackColor = true;
            this.btSuaSan.Click += new System.EventHandler(this.btSuaSan_Click_1);
            // 
            // btThemSan
            // 
            this.btThemSan.Location = new System.Drawing.Point(52, 32);
            this.btThemSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThemSan.Name = "btThemSan";
            this.btThemSan.Size = new System.Drawing.Size(147, 42);
            this.btThemSan.TabIndex = 12;
            this.btThemSan.Text = "Thêm sân";
            this.btThemSan.UseVisualStyleBackColor = true;
            this.btThemSan.Click += new System.EventHandler(this.btThemSan_Click_1);
            // 
            // gbTimCa
            // 
            this.gbTimCa.Controls.Add(this.btCNCa);
            this.gbTimCa.Controls.Add(this.btThemSan);
            this.gbTimCa.Controls.Add(this.btXoaSan);
            this.gbTimCa.Controls.Add(this.btSuaSan);
            this.gbTimCa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimCa.Location = new System.Drawing.Point(18, 357);
            this.gbTimCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTimCa.Name = "gbTimCa";
            this.gbTimCa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTimCa.Size = new System.Drawing.Size(776, 168);
            this.gbTimCa.TabIndex = 2;
            this.gbTimCa.TabStop = false;
            this.gbTimCa.Text = "Tìm kiếm ca";
            // 
            // btCNCa
            // 
            this.btCNCa.Location = new System.Drawing.Point(543, 32);
            this.btCNCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCNCa.Name = "btCNCa";
            this.btCNCa.Size = new System.Drawing.Size(176, 42);
            this.btCNCa.TabIndex = 11;
            this.btCNCa.Text = "Cập nhật ca";
            this.btCNCa.UseVisualStyleBackColor = true;
            this.btCNCa.Click += new System.EventHandler(this.btCNCa_Click);
            // 
            // gbCaTheoSan
            // 
            this.gbCaTheoSan.Controls.Add(this.comboTree1);
            this.gbCaTheoSan.Controls.Add(this.cbTenSan);
            this.gbCaTheoSan.Controls.Add(this.btHuy);
            this.gbCaTheoSan.Controls.Add(this.btXoaCa);
            this.gbCaTheoSan.Controls.Add(this.tbSuaCa);
            this.gbCaTheoSan.Controls.Add(this.btThemCaThue);
            this.gbCaTheoSan.Controls.Add(this.txtGia);
            this.gbCaTheoSan.Controls.Add(this.label4);
            this.gbCaTheoSan.Controls.Add(this.label5);
            this.gbCaTheoSan.Controls.Add(this.label3);
            this.gbCaTheoSan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCaTheoSan.Location = new System.Drawing.Point(18, 534);
            this.gbCaTheoSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCaTheoSan.Name = "gbCaTheoSan";
            this.gbCaTheoSan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCaTheoSan.Size = new System.Drawing.Size(776, 371);
            this.gbCaTheoSan.TabIndex = 2;
            this.gbCaTheoSan.TabStop = false;
            this.gbCaTheoSan.Text = "Thông tin ca thuê";
            // 
            // comboTree1
            // 
            this.comboTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.comboTree1.BackgroundStyle.Class = "TextBoxBorder";
            this.comboTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.comboTree1.ButtonDropDown.Visible = true;
            this.comboTree1.Location = new System.Drawing.Point(52, 185);
            this.comboTree1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTree1.Name = "comboTree1";
            this.comboTree1.Size = new System.Drawing.Size(320, 38);
            this.comboTree1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTree1.TabIndex = 12;
            // 
            // cbTenSan
            // 
            this.cbTenSan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSan.FormattingEnabled = true;
            this.cbTenSan.Location = new System.Drawing.Point(54, 100);
            this.cbTenSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTenSan.Name = "cbTenSan";
            this.cbTenSan.Size = new System.Drawing.Size(316, 36);
            this.cbTenSan.TabIndex = 11;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(476, 265);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(176, 42);
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btXoaCa
            // 
            this.btXoaCa.Location = new System.Drawing.Point(476, 200);
            this.btXoaCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoaCa.Name = "btXoaCa";
            this.btXoaCa.Size = new System.Drawing.Size(176, 42);
            this.btXoaCa.TabIndex = 9;
            this.btXoaCa.Text = "Xoá ca";
            this.btXoaCa.UseVisualStyleBackColor = true;
            // 
            // tbSuaCa
            // 
            this.tbSuaCa.Location = new System.Drawing.Point(476, 138);
            this.tbSuaCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSuaCa.Name = "tbSuaCa";
            this.tbSuaCa.Size = new System.Drawing.Size(176, 42);
            this.tbSuaCa.TabIndex = 8;
            this.tbSuaCa.Text = "Sửa ca";
            this.tbSuaCa.UseVisualStyleBackColor = true;
            // 
            // btThemCaThue
            // 
            this.btThemCaThue.Location = new System.Drawing.Point(476, 69);
            this.btThemCaThue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThemCaThue.Name = "btThemCaThue";
            this.btThemCaThue.Size = new System.Drawing.Size(176, 42);
            this.btThemCaThue.TabIndex = 5;
            this.btThemCaThue.Text = "Thêm ca thuê";
            this.btThemCaThue.UseVisualStyleBackColor = true;
            this.btThemCaThue.Click += new System.EventHandler(this.btThemCaThue_Click);
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(52, 268);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(318, 33);
            this.txtGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sân:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(832, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh sách sân:";
            // 
            // dsCaTheoSan
            // 
            this.dsCaTheoSan.AutoSize = true;
            this.dsCaTheoSan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsCaTheoSan.Location = new System.Drawing.Point(832, 332);
            this.dsCaTheoSan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dsCaTheoSan.Name = "dsCaTheoSan";
            this.dsCaTheoSan.Size = new System.Drawing.Size(219, 23);
            this.dsCaTheoSan.TabIndex = 5;
            this.dsCaTheoSan.Text = "Danh sách ca theo loại sân:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quản lý sân";
            // 
            // fQLSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1814, 943);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dsCaTheoSan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbCaTheoSan);
            this.Controls.Add(this.gbTimCa);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.dsCaThue);
            this.Controls.Add(this.dsSan);
            this.Controls.Add(this.gbSan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fQLSan";
            this.Text = "fQLsan";
            this.Load += new System.EventHandler(this.fQLsan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gbSan.ResumeLayout(false);
            this.gbSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaThue)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            this.gbChucNang.PerformLayout();
            this.gbTimCa.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dsCaThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXoaCa;
        private System.Windows.Forms.Button tbSuaCa;
        private System.Windows.Forms.Button btThemCaThue;
        private System.Windows.Forms.Label dsCaTheoSan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXoaSan;
        private System.Windows.Forms.Button btSuaSan;
        private System.Windows.Forms.Button btThemSan;
        private System.Windows.Forms.TextBox txtTimSan;
        private System.Windows.Forms.Button btTimSan;
        private System.Windows.Forms.Button btCNCa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.ComboTree comboTree1;
        private System.Windows.Forms.ComboBox cbTenSan;
    }
}
