namespace TourDuLich
{
    partial class frm_HienThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_ThemTour = new System.Windows.Forms.Button();
            this.gridDiaDiem = new System.Windows.Forms.DataGridView();
            this.gridTour = new System.Windows.Forms.DataGridView();
            this.contextMenuStripTour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaTour = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.gridKhachHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gridNhanVien = new System.Windows.Forms.DataGridView();
            this.contextMenuStripKH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáKH = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáNV = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaTour = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTour)).BeginInit();
            this.contextMenuStripTour.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            this.contextMenuStripKH.SuspendLayout();
            this.contextMenuStripNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btn_Load);
            this.panel1.Controls.Add(this.btn_ThemTour);
            this.panel1.Controls.Add(this.gridDiaDiem);
            this.panel1.Controls.Add(this.gridTour);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 557);
            this.panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(499, 34);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Gold;
            this.btn_Load.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(256, 280);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(247, 62);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "LOAD TOUR";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_ThemTour
            // 
            this.btn_ThemTour.BackColor = System.Drawing.Color.Gold;
            this.btn_ThemTour.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTour.Location = new System.Drawing.Point(3, 280);
            this.btn_ThemTour.Name = "btn_ThemTour";
            this.btn_ThemTour.Size = new System.Drawing.Size(247, 62);
            this.btn_ThemTour.TabIndex = 3;
            this.btn_ThemTour.Text = "THÊM TOUR";
            this.btn_ThemTour.UseVisualStyleBackColor = false;
            this.btn_ThemTour.Click += new System.EventHandler(this.btn_ThemTour_Click);
            // 
            // gridDiaDiem
            // 
            this.gridDiaDiem.AllowUserToAddRows = false;
            this.gridDiaDiem.AllowUserToDeleteRows = false;
            this.gridDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDiaDiem.BackgroundColor = System.Drawing.Color.Gold;
            this.gridDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiaDiem.Location = new System.Drawing.Point(4, 348);
            this.gridDiaDiem.Name = "gridDiaDiem";
            this.gridDiaDiem.ReadOnly = true;
            this.gridDiaDiem.RowTemplate.Height = 24;
            this.gridDiaDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiaDiem.Size = new System.Drawing.Size(499, 202);
            this.gridDiaDiem.TabIndex = 2;
            // 
            // gridTour
            // 
            this.gridTour.AllowUserToAddRows = false;
            this.gridTour.AllowUserToDeleteRows = false;
            this.gridTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTour.BackgroundColor = System.Drawing.Color.Gold;
            this.gridTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTour.ContextMenuStrip = this.contextMenuStripTour;
            this.gridTour.Location = new System.Drawing.Point(4, 46);
            this.gridTour.Name = "gridTour";
            this.gridTour.ReadOnly = true;
            this.gridTour.RowTemplate.Height = 24;
            this.gridTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTour.Size = new System.Drawing.Size(499, 228);
            this.gridTour.TabIndex = 0;
            this.gridTour.SelectionChanged += new System.EventHandler(this.gridTour_SelectionChanged);
            // 
            // contextMenuStripTour
            // 
            this.contextMenuStripTour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaTour,
            this.sửaTour});
            this.contextMenuStripTour.Name = "contextMenuStrip1";
            this.contextMenuStripTour.Size = new System.Drawing.Size(153, 74);
            // 
            // xóaTour
            // 
            this.xóaTour.Name = "xóaTour";
            this.xóaTour.Size = new System.Drawing.Size(152, 24);
            this.xóaTour.Text = "Xóa";
            this.xóaTour.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.btn_ThemKH);
            this.panel2.Controls.Add(this.gridKhachHang);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.gridNhanVien);
            this.panel2.Location = new System.Drawing.Point(524, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 557);
            this.panel2.TabIndex = 1;
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.BackColor = System.Drawing.Color.Gold;
            this.btn_ThemKH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemKH.Location = new System.Drawing.Point(768, 280);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(229, 270);
            this.btn_ThemKH.TabIndex = 3;
            this.btn_ThemKH.Text = "THÊM KHÁCH HÀNG";
            this.btn_ThemKH.UseVisualStyleBackColor = false;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // gridKhachHang
            // 
            this.gridKhachHang.AllowUserToAddRows = false;
            this.gridKhachHang.AllowUserToDeleteRows = false;
            this.gridKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKhachHang.BackgroundColor = System.Drawing.Color.Gold;
            this.gridKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKhachHang.ContextMenuStrip = this.contextMenuStripKH;
            this.gridKhachHang.Location = new System.Drawing.Point(4, 280);
            this.gridKhachHang.Name = "gridKhachHang";
            this.gridKhachHang.ReadOnly = true;
            this.gridKhachHang.RowTemplate.Height = 24;
            this.gridKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKhachHang.Size = new System.Drawing.Size(758, 270);
            this.gridKhachHang.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(768, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 270);
            this.button1.TabIndex = 1;
            this.button1.Text = "THÊM NHÂN VIÊN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.AllowUserToAddRows = false;
            this.gridNhanVien.AllowUserToDeleteRows = false;
            this.gridNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNhanVien.BackgroundColor = System.Drawing.Color.Gold;
            this.gridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNhanVien.ContextMenuStrip = this.contextMenuStripNV;
            this.gridNhanVien.Location = new System.Drawing.Point(4, 4);
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.ReadOnly = true;
            this.gridNhanVien.RowTemplate.Height = 24;
            this.gridNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNhanVien.Size = new System.Drawing.Size(758, 270);
            this.gridNhanVien.TabIndex = 0;
            // 
            // contextMenuStripKH
            // 
            this.contextMenuStripKH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáKH});
            this.contextMenuStripKH.Name = "contextMenuStripKH";
            this.contextMenuStripKH.Size = new System.Drawing.Size(105, 28);
            // 
            // xoáKH
            // 
            this.xoáKH.Name = "xoáKH";
            this.xoáKH.Size = new System.Drawing.Size(104, 24);
            this.xoáKH.Text = "Xoá";
            this.xoáKH.Click += new System.EventHandler(this.xoáKH_Click);
            // 
            // contextMenuStripNV
            // 
            this.contextMenuStripNV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáNV});
            this.contextMenuStripNV.Name = "contextMenuStripNV";
            this.contextMenuStripNV.Size = new System.Drawing.Size(105, 28);
            // 
            // xoáNV
            // 
            this.xoáNV.Name = "xoáNV";
            this.xoáNV.Size = new System.Drawing.Size(104, 24);
            this.xoáNV.Text = "Xoá";
            this.xoáNV.Click += new System.EventHandler(this.xoáNV_Click);
            // 
            // sửaTour
            // 
            this.sửaTour.Name = "sửaTour";
            this.sửaTour.Size = new System.Drawing.Size(152, 24);
            this.sửaTour.Text = "Sửa";
            this.sửaTour.Click += new System.EventHandler(this.sửaTour_Click);
            // 
            // frm_HienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1529, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_HienThi";
            this.Text = "frm_HienThi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTour)).EndInit();
            this.contextMenuStripTour.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            this.contextMenuStripKH.ResumeLayout(false);
            this.contextMenuStripNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridTour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridNhanVien;
        private System.Windows.Forms.DataGridView gridDiaDiem;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.DataGridView gridKhachHang;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_ThemTour;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTour;
        private System.Windows.Forms.ToolStripMenuItem xóaTour;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripKH;
        private System.Windows.Forms.ToolStripMenuItem xoáKH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNV;
        private System.Windows.Forms.ToolStripMenuItem xoáNV;
        private System.Windows.Forms.ToolStripMenuItem sửaTour;

    }
}