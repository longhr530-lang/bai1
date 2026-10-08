namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn giá dịch vụ:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(180, 20);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(160, 27);
            this.txtDonGia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng khách:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(180, 60);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(160, 27);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã giảm giá (%):";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(180, 100);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(160, 27);
            this.txtGiamGia.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTien.Location = new System.Drawing.Point(24, 150);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(316, 40);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền: 0.00";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(24, 210);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(150, 35);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính tiền";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(190, 210);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 35);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(370, 270);
            Controls.Add(this.btnLamMoi);
            Controls.Add(this.btnTinh);
            Controls.Add(this.lblTongTien);
            Controls.Add(this.txtGiamGia);
            Controls.Add(this.label3);
            Controls.Add(this.txtSoLuong);
            Controls.Add(this.label2);
            Controls.Add(this.txtDonGia);
            Controls.Add(this.label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Máy tính cước dịch vụ";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
