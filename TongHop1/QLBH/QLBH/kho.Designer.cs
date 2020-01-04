namespace QLBH
{
    partial class kho
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
            this.dgrHH = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchHH = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.bntdong = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSuaHH = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtMaHangKHO = new System.Windows.Forms.TextBox();
            this.txtTenHangKho = new System.Windows.Forms.TextBox();
            this.txtThuongHieuKho = new System.Windows.Forms.TextBox();
            this.txtDonGiaKho = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_thuonghieu = new System.Windows.Forms.Label();
            this.lb_sl = new System.Windows.Forms.Label();
            this.lb_tenhh = new System.Windows.Forms.Label();
            this.lb_mahh = new System.Windows.Forms.Label();
            this.txtSoLuongHangKho = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrHH
            // 
            this.dgrHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.ThuongHieu,
            this.DonGia,
            this.SoLuong});
            this.dgrHH.Location = new System.Drawing.Point(36, 281);
            this.dgrHH.Name = "dgrHH";
            this.dgrHH.RowTemplate.Height = 24;
            this.dgrHH.Size = new System.Drawing.Size(1126, 335);
            this.dgrHH.TabIndex = 46;
            this.dgrHH.TabStop = false;
            this.dgrHH.Click += new System.EventHandler(this.dgrHH_Click);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 140;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 250;
            // 
            // ThuongHieu
            // 
            this.ThuongHieu.DataPropertyName = "ThuongHieu";
            this.ThuongHieu.HeaderText = "Thương hiệu";
            this.ThuongHieu.Name = "ThuongHieu";
            this.ThuongHieu.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 250;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tìm kiếm:";
            // 
            // btnSearchHH
            // 
            this.btnSearchHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchHH.Image = global::QLBH.Properties.Resources.icons8_search_48;
            this.btnSearchHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchHH.Location = new System.Drawing.Point(955, 35);
            this.btnSearchHH.Name = "btnSearchHH";
            this.btnSearchHH.Size = new System.Drawing.Size(141, 45);
            this.btnSearchHH.TabIndex = 1;
            this.btnSearchHH.Text = "      Tìm Kiếm";
            this.btnSearchHH.UseVisualStyleBackColor = true;
            this.btnSearchHH.Click += new System.EventHandler(this.btnSearchHH_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(764, 46);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(169, 22);
            this.txttim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(101, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "DANH MỤC KHO";
            // 
            // btnThemHang
            // 
            this.btnThemHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHang.Location = new System.Drawing.Point(113, 637);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(221, 32);
            this.btnThemHang.TabIndex = 2;
            this.btnThemHang.Text = "Thêm";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // bntdong
            // 
            this.bntdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntdong.Location = new System.Drawing.Point(899, 637);
            this.bntdong.Name = "bntdong";
            this.bntdong.Size = new System.Drawing.Size(204, 32);
            this.bntdong.TabIndex = 5;
            this.bntdong.Text = "Đóng";
            this.bntdong.UseVisualStyleBackColor = true;
            this.bntdong.Click += new System.EventHandler(this.bntdong_Click);
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(638, 637);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(204, 32);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Tải Lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSuaHH
            // 
            this.btnSuaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHH.Location = new System.Drawing.Point(383, 637);
            this.btnSuaHH.Name = "btnSuaHH";
            this.btnSuaHH.Size = new System.Drawing.Size(204, 32);
            this.btnSuaHH.TabIndex = 3;
            this.btnSuaHH.Text = "Sửa";
            this.btnSuaHH.UseVisualStyleBackColor = true;
            this.btnSuaHH.Click += new System.EventHandler(this.btnSuaHH_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(43, 111);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(115, 18);
            this.label33.TabIndex = 0;
            this.label33.Text = "Tên Hàng Hóa:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(43, 50);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(110, 18);
            this.label32.TabIndex = 0;
            this.label32.Text = "Mã Hàng Hóa:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(543, 50);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 18);
            this.label31.TabIndex = 0;
            this.label31.Text = "Số Lượng:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(520, 111);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(106, 18);
            this.label35.TabIndex = 0;
            this.label35.Text = "Thương Hiệu:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(860, 50);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(72, 18);
            this.label34.TabIndex = 0;
            this.label34.Text = "Đơn Giá:";
            // 
            // txtMaHangKHO
            // 
            this.txtMaHangKHO.BackColor = System.Drawing.Color.White;
            this.txtMaHangKHO.Location = new System.Drawing.Point(162, 47);
            this.txtMaHangKHO.Name = "txtMaHangKHO";
            this.txtMaHangKHO.Size = new System.Drawing.Size(280, 25);
            this.txtMaHangKHO.TabIndex = 0;
            this.txtMaHangKHO.TextChanged += new System.EventHandler(this.txtMaHangKHO_TextChanged);
            this.txtMaHangKHO.Leave += new System.EventHandler(this.txtMaHangKHO_TextChanged);
            // 
            // txtTenHangKho
            // 
            this.txtTenHangKho.Location = new System.Drawing.Point(162, 109);
            this.txtTenHangKho.Name = "txtTenHangKho";
            this.txtTenHangKho.Size = new System.Drawing.Size(280, 25);
            this.txtTenHangKho.TabIndex = 1;
            this.txtTenHangKho.TextChanged += new System.EventHandler(this.txtTenHangKho_TextChanged);
            this.txtTenHangKho.Leave += new System.EventHandler(this.txtTenHangKho_TextChanged);
            // 
            // txtThuongHieuKho
            // 
            this.txtThuongHieuKho.Location = new System.Drawing.Point(632, 105);
            this.txtThuongHieuKho.Name = "txtThuongHieuKho";
            this.txtThuongHieuKho.Size = new System.Drawing.Size(211, 25);
            this.txtThuongHieuKho.TabIndex = 3;
            this.txtThuongHieuKho.TextChanged += new System.EventHandler(this.txtThuongHieuKho_TextChanged);
            this.txtThuongHieuKho.Leave += new System.EventHandler(this.txtThuongHieuKho_TextChanged);
            // 
            // txtDonGiaKho
            // 
            this.txtDonGiaKho.Location = new System.Drawing.Point(944, 47);
            this.txtDonGiaKho.Name = "txtDonGiaKho";
            this.txtDonGiaKho.Size = new System.Drawing.Size(151, 25);
            this.txtDonGiaKho.TabIndex = 4;
            this.txtDonGiaKho.TextChanged += new System.EventHandler(this.txtDonGiaKho_TextChanged);
            this.txtDonGiaKho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaKho_KeyPress);
            this.txtDonGiaKho.Leave += new System.EventHandler(this.txtDonGiaKho_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb_dongia);
            this.groupBox1.Controls.Add(this.lb_thuonghieu);
            this.groupBox1.Controls.Add(this.lb_sl);
            this.groupBox1.Controls.Add(this.lb_tenhh);
            this.groupBox1.Controls.Add(this.lb_mahh);
            this.groupBox1.Controls.Add(this.txtSoLuongHangKho);
            this.groupBox1.Controls.Add(this.txtDonGiaKho);
            this.groupBox1.Controls.Add(this.txtThuongHieuKho);
            this.groupBox1.Controls.Add(this.txtTenHangKho);
            this.groupBox1.Controls.Add(this.txtMaHangKHO);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(36, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 177);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.ForeColor = System.Drawing.Color.Red;
            this.lb_dongia.Location = new System.Drawing.Point(906, 82);
            this.lb_dongia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(0, 18);
            this.lb_dongia.TabIndex = 10;
            // 
            // lb_thuonghieu
            // 
            this.lb_thuonghieu.AutoSize = true;
            this.lb_thuonghieu.ForeColor = System.Drawing.Color.Red;
            this.lb_thuonghieu.Location = new System.Drawing.Point(612, 140);
            this.lb_thuonghieu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_thuonghieu.Name = "lb_thuonghieu";
            this.lb_thuonghieu.Size = new System.Drawing.Size(0, 18);
            this.lb_thuonghieu.TabIndex = 9;
            // 
            // lb_sl
            // 
            this.lb_sl.AutoSize = true;
            this.lb_sl.ForeColor = System.Drawing.Color.Red;
            this.lb_sl.Location = new System.Drawing.Point(597, 80);
            this.lb_sl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_sl.Name = "lb_sl";
            this.lb_sl.Size = new System.Drawing.Size(0, 18);
            this.lb_sl.TabIndex = 8;
            // 
            // lb_tenhh
            // 
            this.lb_tenhh.AutoSize = true;
            this.lb_tenhh.ForeColor = System.Drawing.Color.Red;
            this.lb_tenhh.Location = new System.Drawing.Point(164, 143);
            this.lb_tenhh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_tenhh.Name = "lb_tenhh";
            this.lb_tenhh.Size = new System.Drawing.Size(0, 18);
            this.lb_tenhh.TabIndex = 7;
            // 
            // lb_mahh
            // 
            this.lb_mahh.AutoSize = true;
            this.lb_mahh.ForeColor = System.Drawing.Color.Red;
            this.lb_mahh.Location = new System.Drawing.Point(170, 84);
            this.lb_mahh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_mahh.Name = "lb_mahh";
            this.lb_mahh.Size = new System.Drawing.Size(0, 18);
            this.lb_mahh.TabIndex = 6;
            // 
            // txtSoLuongHangKho
            // 
            this.txtSoLuongHangKho.Location = new System.Drawing.Point(627, 47);
            this.txtSoLuongHangKho.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSoLuongHangKho.Name = "txtSoLuongHangKho";
            this.txtSoLuongHangKho.Size = new System.Drawing.Size(210, 25);
            this.txtSoLuongHangKho.TabIndex = 2;
            this.txtSoLuongHangKho.TextChanged += new System.EventHandler(this.txtSoLuongHangKho_TextChanged);
            this.txtSoLuongHangKho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongHangKho_KeyPress);
            this.txtSoLuongHangKho.Leave += new System.EventHandler(this.txtSoLuongHangKho_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH.Properties.Resources.icons8_purchase_order_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(36, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1211, 702);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThemHang);
            this.Controls.Add(this.bntdong);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSuaHH);
            this.Controls.Add(this.dgrHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchHH);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kho_FormClosing);
            this.Load += new System.EventHandler(this.kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrHH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchHH;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Button bntdong;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSuaHH;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtMaHangKHO;
        private System.Windows.Forms.TextBox txtTenHangKho;
        private System.Windows.Forms.TextBox txtThuongHieuKho;
        private System.Windows.Forms.TextBox txtDonGiaKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuongHangKho;
        private System.Windows.Forms.Label lb_mahh;
        private System.Windows.Forms.Label lb_tenhh;
        private System.Windows.Forms.Label lb_sl;
        private System.Windows.Forms.Label lb_thuonghieu;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}