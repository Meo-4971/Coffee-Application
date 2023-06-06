
namespace CafeManagement
{
    partial class QuanLyHoaDon
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
            this.pnHoaDon = new System.Windows.Forms.Panel();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.maHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayGio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maKHTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnQuanLyHoaDon = new System.Windows.Forms.Panel();
            this.lbQuanLyHoaDon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.pnHoaDon.SuspendLayout();
            this.pnQuanLyHoaDon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHoaDon
            // 
            this.pnHoaDon.Controls.Add(this.lvHoaDon);
            this.pnHoaDon.Location = new System.Drawing.Point(3, 67);
            this.pnHoaDon.Name = "pnHoaDon";
            this.pnHoaDon.Size = new System.Drawing.Size(1205, 553);
            this.pnHoaDon.TabIndex = 0;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.BackColor = System.Drawing.Color.PeachPuff;
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maHoaDon,
            this.ngayGio,
            this.maKHTT,
            this.maNhanVien,
            this.tongHoaDon,
            this.giamGia});
            this.lvHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(1199, 547);
            this.lvHoaDon.TabIndex = 0;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvHoaDon_SelectedIndexChanged);
            // 
            // maHoaDon
            // 
            this.maHoaDon.Text = "Mã hóa đơn";
            this.maHoaDon.Width = 100;
            // 
            // ngayGio
            // 
            this.ngayGio.Text = "Ngày giờ";
            this.ngayGio.Width = 200;
            // 
            // maKHTT
            // 
            this.maKHTT.Text = "Mã khách hàng thân thiết";
            this.maKHTT.Width = 200;
            // 
            // maNhanVien
            // 
            this.maNhanVien.Text = "Mã nhân viên";
            this.maNhanVien.Width = 140;
            // 
            // tongHoaDon
            // 
            this.tongHoaDon.Text = "Tổng hóa đơn";
            this.tongHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tongHoaDon.Width = 150;
            // 
            // giamGia
            // 
            this.giamGia.Text = "Giảm giá";
            this.giamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.giamGia.Width = 100;
            // 
            // pnQuanLyHoaDon
            // 
            this.pnQuanLyHoaDon.BackColor = System.Drawing.Color.PeachPuff;
            this.pnQuanLyHoaDon.Controls.Add(this.lbQuanLyHoaDon);
            this.pnQuanLyHoaDon.Location = new System.Drawing.Point(3, 1);
            this.pnQuanLyHoaDon.Name = "pnQuanLyHoaDon";
            this.pnQuanLyHoaDon.Size = new System.Drawing.Size(1205, 64);
            this.pnQuanLyHoaDon.TabIndex = 1;
            // 
            // lbQuanLyHoaDon
            // 
            this.lbQuanLyHoaDon.AutoSize = true;
            this.lbQuanLyHoaDon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyHoaDon.Location = new System.Drawing.Point(499, 17);
            this.lbQuanLyHoaDon.Name = "lbQuanLyHoaDon";
            this.lbQuanLyHoaDon.Size = new System.Drawing.Size(281, 32);
            this.lbQuanLyHoaDon.TabIndex = 0;
            this.lbQuanLyHoaDon.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnXemChiTiet);
            this.panel1.Location = new System.Drawing.Point(3, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 64);
            this.panel1.TabIndex = 2;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.Coral;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Location = new System.Drawing.Point(525, 18);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(228, 30);
            this.btnXemChiTiet.TabIndex = 0;
            this.btnXemChiTiet.Text = "Chi tiết hóa đơn";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnQuanLyHoaDon);
            this.Controls.Add(this.pnHoaDon);
            this.Name = "QuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            this.pnHoaDon.ResumeLayout(false);
            this.pnQuanLyHoaDon.ResumeLayout(false);
            this.pnQuanLyHoaDon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHoaDon;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader maHoaDon;
        private System.Windows.Forms.ColumnHeader maKHTT;
        private System.Windows.Forms.ColumnHeader tongHoaDon;
        private System.Windows.Forms.Panel pnQuanLyHoaDon;
        private System.Windows.Forms.Label lbQuanLyHoaDon;
        private System.Windows.Forms.ColumnHeader maNhanVien;
        private System.Windows.Forms.ColumnHeader ngayGio;
        private System.Windows.Forms.ColumnHeader giamGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}