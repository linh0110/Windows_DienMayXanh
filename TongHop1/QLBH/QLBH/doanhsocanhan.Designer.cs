namespace QLBH
{
    partial class doanhsocanhan
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
            this.gbxdoanhthuuser = new System.Windows.Forms.GroupBox();
            this.dgvdoanhthucanhan = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxdoanhthutong = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdoanhsocanhan = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtsodoncanhan = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoahoadon = new System.Windows.Forms.Button();
            this.txtmadoncanxoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxdoanhthuuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthucanhan)).BeginInit();
            this.gbxdoanhthutong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxdoanhthuuser
            // 
            this.gbxdoanhthuuser.Controls.Add(this.dgvdoanhthucanhan);
            this.gbxdoanhthuuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxdoanhthuuser.ForeColor = System.Drawing.Color.Blue;
            this.gbxdoanhthuuser.Location = new System.Drawing.Point(54, 209);
            this.gbxdoanhthuuser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxdoanhthuuser.Name = "gbxdoanhthuuser";
            this.gbxdoanhthuuser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxdoanhthuuser.Size = new System.Drawing.Size(1175, 463);
            this.gbxdoanhthuuser.TabIndex = 11;
            this.gbxdoanhthuuser.TabStop = false;
            this.gbxdoanhthuuser.Text = "Doanh thu cá nhân";
            // 
            // dgvdoanhthucanhan
            // 
            this.dgvdoanhthucanhan.AllowUserToAddRows = false;
            this.dgvdoanhthucanhan.AllowUserToDeleteRows = false;
            this.dgvdoanhthucanhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoanhthucanhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3});
            this.dgvdoanhthucanhan.Location = new System.Drawing.Point(44, 33);
            this.dgvdoanhthucanhan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvdoanhthucanhan.Name = "dgvdoanhthucanhan";
            this.dgvdoanhthucanhan.ReadOnly = true;
            this.dgvdoanhthucanhan.RowTemplate.Height = 24;
            this.dgvdoanhthucanhan.Size = new System.Drawing.Size(1085, 401);
            this.dgvdoanhthucanhan.TabIndex = 0;
            this.dgvdoanhthucanhan.Click += new System.EventHandler(this.dgvdoanhthucanhan_Click);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNV";
            this.Column2.HeaderText = "Mã Nhân Viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayLap";
            this.Column5.HeaderText = "Ngày Lập";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TongSoTien";
            this.Column3.HeaderText = "Tổng số tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // gbxdoanhthutong
            // 
            this.gbxdoanhthutong.Controls.Add(this.pictureBox1);
            this.gbxdoanhthutong.Controls.Add(this.txtdoanhsocanhan);
            this.gbxdoanhthutong.Controls.Add(this.label67);
            this.gbxdoanhthutong.Controls.Add(this.label30);
            this.gbxdoanhthutong.Controls.Add(this.txtsodoncanhan);
            this.gbxdoanhthutong.Controls.Add(this.label53);
            this.gbxdoanhthutong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxdoanhthutong.ForeColor = System.Drawing.Color.Blue;
            this.gbxdoanhthutong.Location = new System.Drawing.Point(54, 50);
            this.gbxdoanhthutong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxdoanhthutong.Name = "gbxdoanhthutong";
            this.gbxdoanhthutong.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxdoanhthutong.Size = new System.Drawing.Size(902, 135);
            this.gbxdoanhthutong.TabIndex = 12;
            this.gbxdoanhthutong.TabStop = false;
            this.gbxdoanhthutong.Text = "Thống Kê Cá Nhân";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH.Properties.Resources.icons8_user_48;
            this.pictureBox1.Location = new System.Drawing.Point(762, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtdoanhsocanhan
            // 
            this.txtdoanhsocanhan.BackColor = System.Drawing.Color.White;
            this.txtdoanhsocanhan.Enabled = false;
            this.txtdoanhsocanhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoanhsocanhan.Location = new System.Drawing.Point(204, 59);
            this.txtdoanhsocanhan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdoanhsocanhan.Name = "txtdoanhsocanhan";
            this.txtdoanhsocanhan.Size = new System.Drawing.Size(188, 23);
            this.txtdoanhsocanhan.TabIndex = 4;
            this.txtdoanhsocanhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(497, 63);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(131, 18);
            this.label67.TabIndex = 1;
            this.label67.Text = "Số đơn của bạn:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label30.Location = new System.Drawing.Point(405, 62);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 15);
            this.label30.TabIndex = 5;
            this.label30.Text = "VND";
            // 
            // txtsodoncanhan
            // 
            this.txtsodoncanhan.BackColor = System.Drawing.Color.White;
            this.txtsodoncanhan.Enabled = false;
            this.txtsodoncanhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodoncanhan.Location = new System.Drawing.Point(635, 60);
            this.txtsodoncanhan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsodoncanhan.Name = "txtsodoncanhan";
            this.txtsodoncanhan.Size = new System.Drawing.Size(108, 23);
            this.txtsodoncanhan.TabIndex = 4;
            this.txtsodoncanhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(41, 60);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(150, 18);
            this.label53.TabIndex = 1;
            this.label53.Text = "Doanh số của bạn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoahoadon);
            this.groupBox1.Controls.Add(this.txtmadoncanxoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(975, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 140);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnxoahoadon
            // 
            this.btnxoahoadon.Image = global::QLBH.Properties.Resources.icons8_trash_48;
            this.btnxoahoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoahoadon.Location = new System.Drawing.Point(57, 61);
            this.btnxoahoadon.Name = "btnxoahoadon";
            this.btnxoahoadon.Size = new System.Drawing.Size(176, 60);
            this.btnxoahoadon.TabIndex = 8;
            this.btnxoahoadon.Text = "       Xóa hóa đơn";
            this.btnxoahoadon.UseVisualStyleBackColor = true;
            this.btnxoahoadon.Click += new System.EventHandler(this.btnxoahoadon_Click);
            // 
            // txtmadoncanxoa
            // 
            this.txtmadoncanxoa.BackColor = System.Drawing.Color.White;
            this.txtmadoncanxoa.Enabled = false;
            this.txtmadoncanxoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadoncanxoa.Location = new System.Drawing.Point(103, 21);
            this.txtmadoncanxoa.Name = "txtmadoncanxoa";
            this.txtmadoncanxoa.Size = new System.Drawing.Size(141, 24);
            this.txtmadoncanxoa.TabIndex = 4;
            this.txtmadoncanxoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // doanhsocanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1283, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxdoanhthutong);
            this.Controls.Add(this.gbxdoanhthuuser);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "doanhsocanhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doanhsocanhan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.doanhsocanhan_FormClosing);
            this.Load += new System.EventHandler(this.doanhsocanhan_Load);
            this.gbxdoanhthuuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthucanhan)).EndInit();
            this.gbxdoanhthutong.ResumeLayout(false);
            this.gbxdoanhthutong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxdoanhthuuser;
        private System.Windows.Forms.DataGridView dgvdoanhthucanhan;
        private System.Windows.Forms.GroupBox gbxdoanhthutong;
        private System.Windows.Forms.TextBox txtdoanhsocanhan;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtsodoncanhan;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoahoadon;
        private System.Windows.Forms.TextBox txtmadoncanxoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}