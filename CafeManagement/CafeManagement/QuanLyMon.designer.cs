
namespace CafeManagement
{
    partial class QuanLyMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyMon));
            this.lvMon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.lbDanhMuc = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lbMaMon = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.rdoTrangThai = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ctMenuStripQLMon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rdbTheoMa = new System.Windows.Forms.RadioButton();
            this.rdbTheoTen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMon
            // 
            this.lvMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMon.HideSelection = false;
            this.lvMon.Location = new System.Drawing.Point(0, 124);
            this.lvMon.Name = "lvMon";
            this.lvMon.Size = new System.Drawing.Size(476, 467);
            this.lvMon.TabIndex = 4;
            this.lvMon.UseCompatibleStateImageBehavior = false;
            this.lvMon.View = System.Windows.Forms.View.Details;
            this.lvMon.SelectedIndexChanged += new System.EventHandler(this.lvMon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thức uống";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thức uống";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Danh mục";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trạng thái";
            this.columnHeader6.Width = 100;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(507, 527);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(595, 172);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(210, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(595, 334);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(212, 24);
            this.cbDanhMuc.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(595, 392);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(212, 22);
            this.txtDonGia.TabIndex = 8;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(485, 394);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(66, 19);
            this.lbDonGia.TabIndex = 7;
            this.lbDonGia.Text = "Đơn Giá";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(595, 278);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(212, 22);
            this.txtTenMon.TabIndex = 8;
            // 
            // lbTenMon
            // 
            this.lbTenMon.AutoSize = true;
            this.lbTenMon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMon.Location = new System.Drawing.Point(485, 280);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(70, 19);
            this.lbTenMon.TabIndex = 7;
            this.lbTenMon.Text = "Tên Món";
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.AutoSize = true;
            this.lbDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMuc.Location = new System.Drawing.Point(485, 337);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(79, 19);
            this.lbDanhMuc.TabIndex = 5;
            this.lbDanhMuc.Text = "Danh Mục";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(595, 223);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(212, 22);
            this.txtMaMon.TabIndex = 6;
            // 
            // lbMaMon
            // 
            this.lbMaMon.AutoSize = true;
            this.lbMaMon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMon.Location = new System.Drawing.Point(485, 225);
            this.lbMaMon.Name = "lbMaMon";
            this.lbMaMon.Size = new System.Drawing.Size(67, 19);
            this.lbMaMon.TabIndex = 5;
            this.lbMaMon.Text = "Mã Món";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SandyBrown;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(617, 527);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 42);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(722, 527);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 42);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Trạng thái";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(595, 445);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(212, 22);
            this.txtSoLuong.TabIndex = 20;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(485, 447);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(70, 19);
            this.lbSoLuong.TabIndex = 19;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // rdoTrangThai
            // 
            this.rdoTrangThai.AutoSize = true;
            this.rdoTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrangThai.Location = new System.Drawing.Point(595, 493);
            this.rdoTrangThai.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rdoTrangThai.Name = "rdoTrangThai";
            this.rdoTrangThai.Size = new System.Drawing.Size(113, 23);
            this.rdoTrangThai.TabIndex = 22;
            this.rdoTrangThai.TabStop = true;
            this.rdoTrangThai.Text = "Còn phục vụ";
            this.rdoTrangThai.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(477, 1);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(355, 116);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 118);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "DANH SÁCH THỨC UỐNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctMenuStripQLMon
            // 
            this.ctMenuStripQLMon.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ctMenuStripQLMon.Name = "ctMenuStripQLMon";
            this.ctMenuStripQLMon.Size = new System.Drawing.Size(61, 4);
            // 
            // rdbTheoMa
            // 
            this.rdbTheoMa.AutoSize = true;
            this.rdbTheoMa.Location = new System.Drawing.Point(596, 134);
            this.rdbTheoMa.Name = "rdbTheoMa";
            this.rdbTheoMa.Size = new System.Drawing.Size(85, 21);
            this.rdbTheoMa.TabIndex = 30;
            this.rdbTheoMa.TabStop = true;
            this.rdbTheoMa.Text = "Theo mã";
            this.rdbTheoMa.UseVisualStyleBackColor = true;
            // 
            // rdbTheoTen
            // 
            this.rdbTheoTen.AutoSize = true;
            this.rdbTheoTen.Location = new System.Drawing.Point(719, 134);
            this.rdbTheoTen.Name = "rdbTheoTen";
            this.rdbTheoTen.Size = new System.Drawing.Size(86, 21);
            this.rdbTheoTen.TabIndex = 31;
            this.rdbTheoTen.TabStop = true;
            this.rdbTheoTen.Text = "Theo tên";
            this.rdbTheoTen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tìm món";
            // 
            // QuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(843, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbTheoTen);
            this.Controls.Add(this.rdbTheoMa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoTrangThai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lvMon);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbTenMon);
            this.Controls.Add(this.lbDanhMuc);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lbMaMon);
            this.Name = "QuanLyMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUAN LY MON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label lbDanhMuc;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lbMaMon;
        private System.Windows.Forms.ListView lvMon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.RadioButton rdoTrangThai;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ctMenuStripQLMon;
        private System.Windows.Forms.RadioButton rdbTheoMa;
        private System.Windows.Forms.RadioButton rdbTheoTen;
        private System.Windows.Forms.Label label3;
    }
}

