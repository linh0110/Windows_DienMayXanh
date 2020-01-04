namespace QLBH
{
    partial class quanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanly));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabdsnv = new System.Windows.Forms.TabPage();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTimkiemNV = new System.Windows.Forms.Button();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabthemtk = new System.Windows.Forms.TabPage();
            this.gbxdangki = new System.Windows.Forms.GroupBox();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.rbtuser = new System.Windows.Forms.RadioButton();
            this.rbtadmin = new System.Windows.Forms.RadioButton();
            this.lbxacnhan = new System.Windows.Forms.Label();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.btndangky = new System.Windows.Forms.Button();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabdsnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabthemtk.SuspendLayout();
            this.gbxdangki.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabdsnv);
            this.tabControl1.Controls.Add(this.tabthemtk);
            this.tabControl1.Location = new System.Drawing.Point(33, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabdsnv
            // 
            this.tabdsnv.BackColor = System.Drawing.Color.Gold;
            this.tabdsnv.Controls.Add(this.btnTaiLai);
            this.tabdsnv.Controls.Add(this.label17);
            this.tabdsnv.Controls.Add(this.btnTimkiemNV);
            this.tabdsnv.Controls.Add(this.txtTIMKIEM);
            this.tabdsnv.Controls.Add(this.dgvNV);
            this.tabdsnv.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabdsnv.ForeColor = System.Drawing.Color.Blue;
            this.tabdsnv.Location = new System.Drawing.Point(4, 23);
            this.tabdsnv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabdsnv.Name = "tabdsnv";
            this.tabdsnv.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabdsnv.Size = new System.Drawing.Size(1271, 645);
            this.tabdsnv.TabIndex = 1;
            this.tabdsnv.Text = "Danh Sách Nhân Viên";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.Ivory;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.Image")));
            this.btnTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiLai.Location = new System.Drawing.Point(939, 42);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(132, 57);
            this.btnTaiLai.TabIndex = 51;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(325, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 50;
            this.label17.Text = "Tìm kiếm";
            // 
            // btnTimkiemNV
            // 
            this.btnTimkiemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemNV.Image")));
            this.btnTimkiemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiemNV.Location = new System.Drawing.Point(737, 42);
            this.btnTimkiemNV.Name = "btnTimkiemNV";
            this.btnTimkiemNV.Size = new System.Drawing.Size(168, 57);
            this.btnTimkiemNV.TabIndex = 1;
            this.btnTimkiemNV.Text = "       Tìm Kiếm";
            this.btnTimkiemNV.UseVisualStyleBackColor = true;
            this.btnTimkiemNV.Click += new System.EventHandler(this.btnTimkiemNV_Click);
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIMKIEM.Location = new System.Drawing.Point(442, 59);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(255, 23);
            this.txtTIMKIEM.TabIndex = 0;
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.NgayCapNhat});
            this.dgvNV.Location = new System.Drawing.Point(30, 145);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(1210, 453);
            this.dgvNV.TabIndex = 21;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 200;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Đia chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 250;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayCapNhat.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat.HeaderText = "Ngày Cập Nhật";
            this.NgayCapNhat.Name = "NgayCapNhat";
            // 
            // tabthemtk
            // 
            this.tabthemtk.BackColor = System.Drawing.Color.Gold;
            this.tabthemtk.Controls.Add(this.gbxdangki);
            this.tabthemtk.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabthemtk.Location = new System.Drawing.Point(4, 23);
            this.tabthemtk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabthemtk.Name = "tabthemtk";
            this.tabthemtk.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabthemtk.Size = new System.Drawing.Size(1271, 645);
            this.tabthemtk.TabIndex = 0;
            this.tabthemtk.Text = "Thêm Tài Khoản";
            // 
            // gbxdangki
            // 
            this.gbxdangki.Controls.Add(this.lbmatkhau);
            this.gbxdangki.Controls.Add(this.rbtuser);
            this.gbxdangki.Controls.Add(this.rbtadmin);
            this.gbxdangki.Controls.Add(this.lbxacnhan);
            this.gbxdangki.Controls.Add(this.lbdangnhap);
            this.gbxdangki.Controls.Add(this.btnnhaplai);
            this.gbxdangki.Controls.Add(this.btndangky);
            this.gbxdangki.Controls.Add(this.txttendangnhap);
            this.gbxdangki.Controls.Add(this.txtmanv);
            this.gbxdangki.Controls.Add(this.txtxacnhan);
            this.gbxdangki.Controls.Add(this.txtmatkhau);
            this.gbxdangki.Controls.Add(this.label44);
            this.gbxdangki.Controls.Add(this.label59);
            this.gbxdangki.Controls.Add(this.label1);
            this.gbxdangki.Controls.Add(this.label60);
            this.gbxdangki.Controls.Add(this.label62);
            this.gbxdangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxdangki.ForeColor = System.Drawing.Color.Blue;
            this.gbxdangki.Location = new System.Drawing.Point(176, 51);
            this.gbxdangki.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxdangki.Name = "gbxdangki";
            this.gbxdangki.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxdangki.Size = new System.Drawing.Size(853, 551);
            this.gbxdangki.TabIndex = 2;
            this.gbxdangki.TabStop = false;
            this.gbxdangki.Text = "Đăng Ký";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.ForeColor = System.Drawing.Color.Red;
            this.lbmatkhau.Location = new System.Drawing.Point(271, 184);
            this.lbmatkhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(0, 18);
            this.lbmatkhau.TabIndex = 8;
            // 
            // rbtuser
            // 
            this.rbtuser.AutoSize = true;
            this.rbtuser.Checked = true;
            this.rbtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtuser.Location = new System.Drawing.Point(448, 387);
            this.rbtuser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtuser.Name = "rbtuser";
            this.rbtuser.Size = new System.Drawing.Size(59, 22);
            this.rbtuser.TabIndex = 5;
            this.rbtuser.TabStop = true;
            this.rbtuser.Text = "user";
            this.rbtuser.UseVisualStyleBackColor = true;
            // 
            // rbtadmin
            // 
            this.rbtadmin.AutoSize = true;
            this.rbtadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtadmin.Location = new System.Drawing.Point(266, 386);
            this.rbtadmin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtadmin.Name = "rbtadmin";
            this.rbtadmin.Size = new System.Drawing.Size(71, 22);
            this.rbtadmin.TabIndex = 4;
            this.rbtadmin.TabStop = true;
            this.rbtadmin.Text = "admin";
            this.rbtadmin.UseVisualStyleBackColor = true;

            // 
            // lbxacnhan
            // 
            this.lbxacnhan.AutoSize = true;
            this.lbxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxacnhan.ForeColor = System.Drawing.Color.Red;
            this.lbxacnhan.Location = new System.Drawing.Point(270, 256);
            this.lbxacnhan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbxacnhan.Name = "lbxacnhan";
            this.lbxacnhan.Size = new System.Drawing.Size(0, 18);
            this.lbxacnhan.TabIndex = 0;
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.ForeColor = System.Drawing.Color.Red;
            this.lbdangnhap.Location = new System.Drawing.Point(270, 101);
            this.lbdangnhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(0, 18);
            this.lbdangnhap.TabIndex = 0;
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btnnhaplai.Image")));
            this.btnnhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhaplai.Location = new System.Drawing.Point(267, 437);
            this.btnnhaplai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(159, 63);
            this.btnnhaplai.TabIndex = 6;
            this.btnnhaplai.Text = "Nhập Lại";
            this.btnnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // btndangky
            // 
            this.btndangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangky.Image = ((System.Drawing.Image)(resources.GetObject("btndangky.Image")));
            this.btndangky.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndangky.Location = new System.Drawing.Point(473, 437);
            this.btndangky.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(149, 63);
            this.btndangky.TabIndex = 7;
            this.btndangky.Text = "     Đăng Ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txttendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendangnhap.Location = new System.Drawing.Point(264, 56);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(400, 24);
            this.txttendangnhap.TabIndex = 0;
            this.txttendangnhap.TextChanged += new System.EventHandler(this.txttendangnhap_Leave);
            this.txttendangnhap.Leave += new System.EventHandler(this.txttendangnhap_Leave);
            // 
            // txtmanv
            // 
            this.txtmanv.BackColor = System.Drawing.Color.White;
            this.txtmanv.Enabled = false;
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(268, 295);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(399, 24);
            this.txtmanv.TabIndex = 3;
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhan.Location = new System.Drawing.Point(266, 221);
            this.txtxacnhan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.Size = new System.Drawing.Size(399, 24);
            this.txtxacnhan.TabIndex = 2;
            this.txtxacnhan.UseSystemPasswordChar = true;
            this.txtxacnhan.TextChanged += new System.EventHandler(this.txtxacnhan_Leave);
            this.txtxacnhan.Leave += new System.EventHandler(this.txtxacnhan_Leave);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(264, 139);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(399, 24);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_Leave);
            this.txtmatkhau.Leave += new System.EventHandler(this.txtmatkhau_Leave);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(141, 139);
            this.label44.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(84, 18);
            this.label44.TabIndex = 0;
            this.label44.Text = "Mật Khẩu:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(97, 59);
            this.label59.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(129, 18);
            this.label59.TabIndex = 0;
            this.label59.Text = "Tên Đăng Nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(158, 387);
            this.label60.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(61, 18);
            this.label60.TabIndex = 0;
            this.label60.Text = "Quyền:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(78, 229);
            this.label62.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(162, 18);
            this.label62.TabIndex = 0;
            this.label62.Text = "Xác Nhận Mật Khẩu:";
            // 
            // quanly
            // 
            this.AcceptButton = this.btnTimkiemNV;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1331, 702);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "quanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quanly_FormClosing);
            this.Load += new System.EventHandler(this.quanly_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabdsnv.ResumeLayout(false);
            this.tabdsnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabthemtk.ResumeLayout(false);
            this.gbxdangki.ResumeLayout(false);
            this.gbxdangki.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabthemtk;
        private System.Windows.Forms.TabPage tabdsnv;
        private System.Windows.Forms.GroupBox gbxdangki;
        private System.Windows.Forms.RadioButton rbtuser;
        private System.Windows.Forms.RadioButton rbtadmin;
        private System.Windows.Forms.Label lbxacnhan;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtxacnhan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnTimkiemNV;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private System.Windows.Forms.Button btnTaiLai;
    }
}