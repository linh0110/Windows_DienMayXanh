namespace QLBH
{
    partial class khuyenmai
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
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.ForeColor = System.Drawing.Color.Blue;
            this.rd1.Location = new System.Drawing.Point(75, 96);
            this.rd1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(281, 22);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "Pin dự phòng Romoss 10000 mAh";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.ForeColor = System.Drawing.Color.Blue;
            this.rd2.Location = new System.Drawing.Point(75, 127);
            this.rd2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(152, 22);
            this.rd2.TabIndex = 0;
            this.rd2.TabStop = true;
            this.rd2.Text = "Ấm đun siêu tốc ";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.ForeColor = System.Drawing.Color.Blue;
            this.rd3.Location = new System.Drawing.Point(75, 161);
            this.rd3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(132, 22);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "Bàn ủi Phillips";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.Blue;
            this.btnok.Location = new System.Drawing.Point(115, 207);
            this.btnok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(94, 41);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "Chọn";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn 1 sản phẩm khuyến mãi";
            // 
            // khuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(385, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "khuyenmai";
            this.Text = "Khuyến Mãi";
            this.Load += new System.EventHandler(this.khuyenmai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
    }
}