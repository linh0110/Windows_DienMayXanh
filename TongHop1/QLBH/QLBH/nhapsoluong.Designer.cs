namespace QLBH
{
    partial class nhapsoluong
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
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.bntok = new System.Windows.Forms.Button();
            this.bnthuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            this.SuspendLayout();
            // 
            // numsl
            // 
            this.numsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numsl.Location = new System.Drawing.Point(67, 88);
            this.numsl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numsl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(163, 53);
            this.numsl.TabIndex = 0;
            this.numsl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bntok
            // 
            this.bntok.Image = global::QLBH.Properties.Resources.icons8_checkmark_64;
            this.bntok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntok.Location = new System.Drawing.Point(276, 82);
            this.bntok.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bntok.Name = "bntok";
            this.bntok.Size = new System.Drawing.Size(138, 68);
            this.bntok.TabIndex = 1;
            this.bntok.Text = "         Xong";
            this.bntok.UseVisualStyleBackColor = true;
            this.bntok.Click += new System.EventHandler(this.bntok_Click);
            // 
            // bnthuy
            // 
            this.bnthuy.Image = global::QLBH.Properties.Resources.icons8_cancel_48;
            this.bnthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnthuy.Location = new System.Drawing.Point(276, 175);
            this.bnthuy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bnthuy.Name = "bnthuy";
            this.bnthuy.Size = new System.Drawing.Size(138, 69);
            this.bnthuy.TabIndex = 2;
            this.bnthuy.Text = "       Hủy";
            this.bnthuy.UseVisualStyleBackColor = true;
            this.bnthuy.Click += new System.EventHandler(this.bnthuy_Click);
            // 
            // nhapsoluong
            // 
            this.AcceptButton = this.bntok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(484, 308);
            this.Controls.Add(this.bnthuy);
            this.Controls.Add(this.bntok);
            this.Controls.Add(this.numsl);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "nhapsoluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Số Lượng";
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numsl;
        private System.Windows.Forms.Button bntok;
        private System.Windows.Forms.Button bnthuy;
    }
}