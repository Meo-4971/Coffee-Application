
namespace CafeManagement
{
    partial class DangKyKhachHangThanThiet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDangKyKhachHangThanThiet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDangKyKhachHangThanThiet);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 83);
            this.panel1.TabIndex = 3;
            // 
            // lbDangKyKhachHangThanThiet
            // 
            this.lbDangKyKhachHangThanThiet.AutoSize = true;
            this.lbDangKyKhachHangThanThiet.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKyKhachHangThanThiet.Location = new System.Drawing.Point(14, 25);
            this.lbDangKyKhachHangThanThiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDangKyKhachHangThanThiet.Name = "lbDangKyKhachHangThanThiet";
            this.lbDangKyKhachHangThanThiet.Size = new System.Drawing.Size(412, 35);
            this.lbDangKyKhachHangThanThiet.TabIndex = 1;
            this.lbDangKyKhachHangThanThiet.Text = "Đăng ký Khách hàng thân thiết";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.lbHoTen);
            this.panel2.Controls.Add(this.txtTenKhachHang);
            this.panel2.Location = new System.Drawing.Point(4, 97);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 83);
            this.panel2.TabIndex = 4;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(20, 30);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(104, 25);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(132, 25);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(276, 31);
            this.txtTenKhachHang.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDangKy);
            this.panel3.Location = new System.Drawing.Point(4, 189);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 83);
            this.panel3.TabIndex = 4;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDangKy.Location = new System.Drawing.Point(126, 11);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(192, 61);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // DangKyKhachHangThanThiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(452, 272);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DangKyKhachHangThanThiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký khách hàng thân thiết";
            this.Load += new System.EventHandler(this.DangKyKhachHangThanThiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDangKyKhachHangThanThiet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangKy;
    }
}