namespace QLBH
{
    partial class khachhang
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
            this.txtKiemkiemkh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btntimkiemkh = new System.Windows.Forms.Button();
            this.btnCloseKH = new System.Windows.Forms.Button();
            this.btnReloadKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSDTKH = new System.Windows.Forms.GroupBox();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbtenkhach = new System.Windows.Forms.Label();
            this.cbb_gt = new System.Windows.Forms.ComboBox();
            this.txtDCKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb100 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.lbSDTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKiemkiemkh
            // 
            this.txtKiemkiemkh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKiemkiemkh.Location = new System.Drawing.Point(735, 26);
            this.txtKiemkiemkh.Name = "txtKiemkiemkh";
            this.txtKiemkiemkh.Size = new System.Drawing.Size(193, 24);
            this.txtKiemkiemkh.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 58;
            this.label8.Text = "Tìm Kiếm:";
            // 
            // btntimkiemkh
            // 
            this.btntimkiemkh.Image = global::QLBH.Properties.Resources.icons8_search_48;
            this.btntimkiemkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiemkh.Location = new System.Drawing.Point(946, 16);
            this.btntimkiemkh.Name = "btntimkiemkh";
            this.btntimkiemkh.Size = new System.Drawing.Size(141, 41);
            this.btntimkiemkh.TabIndex = 1;
            this.btntimkiemkh.Text = "      Tìm Kiếm";
            this.btntimkiemkh.UseVisualStyleBackColor = true;
            this.btntimkiemkh.Click += new System.EventHandler(this.btntimkiemkh_Click);
            // 
            // btnCloseKH
            // 
            this.btnCloseKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseKH.Location = new System.Drawing.Point(1015, 631);
            this.btnCloseKH.Name = "btnCloseKH";
            this.btnCloseKH.Size = new System.Drawing.Size(204, 32);
            this.btnCloseKH.TabIndex = 6;
            this.btnCloseKH.Text = "Đóng";
            this.btnCloseKH.UseVisualStyleBackColor = true;
            this.btnCloseKH.Click += new System.EventHandler(this.btnCloseKH_Click);
            // 
            // btnReloadKH
            // 
            this.btnReloadKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadKH.Location = new System.Drawing.Point(790, 631);
            this.btnReloadKH.Name = "btnReloadKH";
            this.btnReloadKH.Size = new System.Drawing.Size(204, 32);
            this.btnReloadKH.TabIndex = 5;
            this.btnReloadKH.Text = "Tải lại";
            this.btnReloadKH.UseVisualStyleBackColor = true;
            this.btnReloadKH.Click += new System.EventHandler(this.btnReloadKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKH.Location = new System.Drawing.Point(568, 631);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(204, 32);
            this.btnSuaKH.TabIndex = 4;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Location = new System.Drawing.Point(348, 631);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(204, 32);
            this.btnXoaKH.TabIndex = 3;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Location = new System.Drawing.Point(126, 631);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(204, 32);
            this.btnThemKH.TabIndex = 2;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDTKH,
            this.GioiTinhKH,
            this.DiaChiKH});
            this.dgvKH.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvKH.Location = new System.Drawing.Point(86, 260);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1178, 345);
            this.dgvKH.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(321, 29);
            this.label10.TabIndex = 50;
            this.label10.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // lbSDTKH
            // 
            this.lbSDTKH.BackColor = System.Drawing.Color.Transparent;
            this.lbSDTKH.Controls.Add(this.lbdiachi);
            this.lbSDTKH.Controls.Add(this.lbsdt);
            this.lbSDTKH.Controls.Add(this.lbtenkhach);
            this.lbSDTKH.Controls.Add(this.cbb_gt);
            this.lbSDTKH.Controls.Add(this.txtDCKH);
            this.lbSDTKH.Controls.Add(this.label6);
            this.lbSDTKH.Controls.Add(this.lb100);
            this.lbSDTKH.Controls.Add(this.txtSDTKH);
            this.lbSDTKH.Controls.Add(this.label11);
            this.lbSDTKH.Controls.Add(this.label7);
            this.lbSDTKH.Controls.Add(this.txtMaKH);
            this.lbSDTKH.Controls.Add(this.txtTenKH);
            this.lbSDTKH.Controls.Add(this.label9);
            this.lbSDTKH.Location = new System.Drawing.Point(89, 65);
            this.lbSDTKH.Name = "lbSDTKH";
            this.lbSDTKH.Size = new System.Drawing.Size(1175, 177);
            this.lbSDTKH.TabIndex = 49;
            this.lbSDTKH.TabStop = false;
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.ForeColor = System.Drawing.Color.Red;
            this.lbdiachi.Location = new System.Drawing.Point(697, 66);
            this.lbdiachi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(0, 14);
            this.lbdiachi.TabIndex = 5;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.ForeColor = System.Drawing.Color.Red;
            this.lbsdt.Location = new System.Drawing.Point(551, 130);
            this.lbsdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(0, 14);
            this.lbsdt.TabIndex = 5;
            // 
            // lbtenkhach
            // 
            this.lbtenkhach.AutoSize = true;
            this.lbtenkhach.ForeColor = System.Drawing.Color.Red;
            this.lbtenkhach.Location = new System.Drawing.Point(123, 130);
            this.lbtenkhach.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbtenkhach.Name = "lbtenkhach";
            this.lbtenkhach.Size = new System.Drawing.Size(0, 14);
            this.lbtenkhach.TabIndex = 5;
            // 
            // cbb_gt
            // 
            this.cbb_gt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gt.Location = new System.Drawing.Point(966, 97);
            this.cbb_gt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbb_gt.Name = "cbb_gt";
            this.cbb_gt.Size = new System.Drawing.Size(120, 25);
            this.cbb_gt.TabIndex = 3;
            this.cbb_gt.SelectedIndexChanged += new System.EventHandler(this.cbb_gt_SelectedIndexChanged);
            // 
            // txtDCKH
            // 
            this.txtDCKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCKH.Location = new System.Drawing.Point(698, 30);
            this.txtDCKH.Name = "txtDCKH";
            this.txtDCKH.Size = new System.Drawing.Size(268, 24);
            this.txtDCKH.TabIndex = 2;
            this.txtDCKH.TextChanged += new System.EventHandler(this.txtDCKH_TextChanged);
            this.txtDCKH.Leave += new System.EventHandler(this.txtDCKH_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ:";
            // 
            // lb100
            // 
            this.lb100.AutoSize = true;
            this.lb100.Location = new System.Drawing.Point(885, 99);
            this.lb100.Name = "lb100";
            this.lb100.Size = new System.Drawing.Size(62, 14);
            this.lb100.TabIndex = 0;
            this.lb100.Text = "Giới tính:";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(652, 97);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(161, 24);
            this.txtSDTKH.TabIndex = 1;
            this.txtSDTKH.TextChanged += new System.EventHandler(this.txtSDTKH_TextChanged);
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            this.txtSDTKH.Leave += new System.EventHandler(this.txtSDTKH_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Khách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = " Số Điện Thoại:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(167, 30);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(268, 24);
            this.txtMaKH.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(167, 94);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(268, 24);
            this.txtTenKH.TabIndex = 0;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            this.txtTenKH.Leave += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Khách:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH.Properties.Resources.icons8_purchase_order_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(89, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 59);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 150;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 270;
            // 
            // SDTKH
            // 
            this.SDTKH.DataPropertyName = "SDTKH";
            this.SDTKH.HeaderText = "Số điện thoại";
            this.SDTKH.Name = "SDTKH";
            this.SDTKH.Width = 170;
            // 
            // GioiTinhKH
            // 
            this.GioiTinhKH.DataPropertyName = "GioiTinhKH";
            this.GioiTinhKH.HeaderText = "Giới tính";
            this.GioiTinhKH.Name = "GioiTinhKH";
            this.GioiTinhKH.Width = 120;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChiKH.DataPropertyName = "DiaChiKH";
            this.DiaChiKH.HeaderText = "Địa chỉ";
            this.DiaChiKH.Name = "DiaChiKH";
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1334, 702);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKiemkiemkh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btntimkiemkh);
            this.Controls.Add(this.btnCloseKH);
            this.Controls.Add(this.btnReloadKH);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbSDTKH);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.khachhang_FormClosing);
            this.Load += new System.EventHandler(this.khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.lbSDTKH.ResumeLayout(false);
            this.lbSDTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKiemkiemkh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btntimkiemkh;
        private System.Windows.Forms.Button btnCloseKH;
        private System.Windows.Forms.Button btnReloadKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox lbSDTKH;
        private System.Windows.Forms.TextBox txtDCKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb100;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_gt;
        private System.Windows.Forms.Label lbtenkhach;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;

    }
}