namespace BTL_QLSCV
{
    partial class fCNCa
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
            this.dsCaTheoSan = new System.Windows.Forms.Label();
            this.gbCaTheoSan = new System.Windows.Forms.GroupBox();
            this.dtpTGKT = new System.Windows.Forms.DateTimePicker();
            this.dtpTGBD = new System.Windows.Forms.DateTimePicker();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdsCa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXoaCa = new System.Windows.Forms.Button();
            this.btSuaCa = new System.Windows.Forms.Button();
            this.btThemCa = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.gbCaTheoSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsCa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsCaTheoSan
            // 
            this.dsCaTheoSan.AutoSize = true;
            this.dsCaTheoSan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsCaTheoSan.Location = new System.Drawing.Point(532, 21);
            this.dsCaTheoSan.Name = "dsCaTheoSan";
            this.dsCaTheoSan.Size = new System.Drawing.Size(78, 13);
            this.dsCaTheoSan.TabIndex = 8;
            this.dsCaTheoSan.Text = "Danh sách ca:";
            // 
            // gbCaTheoSan
            // 
            this.gbCaTheoSan.Controls.Add(this.dtpTGKT);
            this.gbCaTheoSan.Controls.Add(this.dtpTGBD);
            this.gbCaTheoSan.Controls.Add(this.txtMaCa);
            this.gbCaTheoSan.Controls.Add(this.label2);
            this.gbCaTheoSan.Controls.Add(this.label1);
            this.gbCaTheoSan.Controls.Add(this.label4);
            this.gbCaTheoSan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCaTheoSan.Location = new System.Drawing.Point(28, 47);
            this.gbCaTheoSan.Name = "gbCaTheoSan";
            this.gbCaTheoSan.Size = new System.Drawing.Size(479, 212);
            this.gbCaTheoSan.TabIndex = 6;
            this.gbCaTheoSan.TabStop = false;
            this.gbCaTheoSan.Text = "Thông tin ca theo loại sân";
            // 
            // dtpTGKT
            // 
            this.dtpTGKT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTGKT.Location = new System.Drawing.Point(140, 161);
            this.dtpTGKT.Name = "dtpTGKT";
            this.dtpTGKT.Size = new System.Drawing.Size(187, 25);
            this.dtpTGKT.TabIndex = 12;
            // 
            // dtpTGBD
            // 
            this.dtpTGBD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTGBD.Location = new System.Drawing.Point(140, 100);
            this.dtpTGBD.Name = "dtpTGBD";
            this.dtpTGBD.Size = new System.Drawing.Size(187, 25);
            this.dtpTGBD.TabIndex = 12;
            // 
            // txtMaCa
            // 
            this.txtMaCa.BackColor = System.Drawing.Color.White;
            this.txtMaCa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCa.Location = new System.Drawing.Point(140, 40);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(187, 25);
            this.txtMaCa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Ca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời gian bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian kết thúc:";
            // 
            // dgvdsCa
            // 
            this.dgvdsCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsCa.Location = new System.Drawing.Point(535, 47);
            this.dgvdsCa.Name = "dgvdsCa";
            this.dgvdsCa.Size = new System.Drawing.Size(480, 498);
            this.dgvdsCa.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btHuy);
            this.groupBox1.Controls.Add(this.btXoaCa);
            this.groupBox1.Controls.Add(this.btSuaCa);
            this.groupBox1.Controls.Add(this.btThemCa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 193);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ca theo loại sân";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(166, 139);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(141, 26);
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXoaCa
            // 
            this.btXoaCa.Location = new System.Drawing.Point(166, 106);
            this.btXoaCa.Name = "btXoaCa";
            this.btXoaCa.Size = new System.Drawing.Size(141, 26);
            this.btXoaCa.TabIndex = 9;
            this.btXoaCa.Text = "Xoá ca";
            this.btXoaCa.UseVisualStyleBackColor = true;
            this.btXoaCa.Click += new System.EventHandler(this.btXoaCa_Click);
            // 
            // btSuaCa
            // 
            this.btSuaCa.Location = new System.Drawing.Point(166, 73);
            this.btSuaCa.Name = "btSuaCa";
            this.btSuaCa.Size = new System.Drawing.Size(141, 26);
            this.btSuaCa.TabIndex = 8;
            this.btSuaCa.Text = "Sửa ca";
            this.btSuaCa.UseVisualStyleBackColor = true;
            this.btSuaCa.Click += new System.EventHandler(this.btSuaCa_Click);
            // 
            // btThemCa
            // 
            this.btThemCa.Location = new System.Drawing.Point(166, 40);
            this.btThemCa.Name = "btThemCa";
            this.btThemCa.Size = new System.Drawing.Size(141, 26);
            this.btThemCa.TabIndex = 5;
            this.btThemCa.Text = "Thêm ca";
            this.btThemCa.UseVisualStyleBackColor = true;
            this.btThemCa.Click += new System.EventHandler(this.btThemCa_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // fCNCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dsCaTheoSan);
            this.Controls.Add(this.gbCaTheoSan);
            this.Controls.Add(this.dgvdsCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCNCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật ca";
            this.Load += new System.EventHandler(this.fCNCa_Load);
            this.gbCaTheoSan.ResumeLayout(false);
            this.gbCaTheoSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsCa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dsCaTheoSan;
        private System.Windows.Forms.GroupBox gbCaTheoSan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdsCa;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXoaCa;
        private System.Windows.Forms.Button btSuaCa;
        private System.Windows.Forms.Button btThemCa;
        private System.Windows.Forms.DateTimePicker dtpTGBD;
        private System.Windows.Forms.DateTimePicker dtpTGKT;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}