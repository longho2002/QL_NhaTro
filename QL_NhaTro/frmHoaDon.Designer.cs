namespace QL_NhaTro
{
    partial class frmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_no = new Guna.UI2.WinForms.Guna2Button();
            this.btn_all = new Guna.UI2.WinForms.Guna2Button();
            this.btn_thanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylaphoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiendathanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 59;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.khachhang,
            this.ten,
            this.phong,
            this.tenphong,
            this.ngaylaphoadon,
            this.tongtien,
            this.sotiendathanhtoan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 108);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(920, 445);
            this.dataGridView.TabIndex = 145;
            this.dataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 59;
            this.dataGridView.ThemeStyle.ReadOnly = false;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_them
            // 
            this.btn_them.BorderRadius = 5;
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(798, 17);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(135, 39);
            this.btn_them.TabIndex = 144;
            this.btn_them.Text = "Thêm hợp đồng";
            // 
            // btn_no
            // 
            this.btn_no.Animated = true;
            this.btn_no.BackColor = System.Drawing.Color.Transparent;
            this.btn_no.BorderRadius = 13;
            this.btn_no.CheckedState.Parent = this.btn_no;
            this.btn_no.CustomImages.Parent = this.btn_no;
            this.btn_no.FillColor = System.Drawing.Color.Transparent;
            this.btn_no.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_no.ForeColor = System.Drawing.Color.DimGray;
            this.btn_no.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btn_no.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_no.HoverState.Parent = this.btn_no;
            this.btn_no.Location = new System.Drawing.Point(202, 62);
            this.btn_no.Name = "btn_no";
            this.btn_no.ShadowDecoration.Parent = this.btn_no;
            this.btn_no.Size = new System.Drawing.Size(89, 40);
            this.btn_no.TabIndex = 143;
            this.btn_no.Text = "Đang nợ";
            // 
            // btn_all
            // 
            this.btn_all.Animated = true;
            this.btn_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_all.BorderRadius = 13;
            this.btn_all.CheckedState.Parent = this.btn_all;
            this.btn_all.CustomImages.Parent = this.btn_all;
            this.btn_all.FillColor = System.Drawing.Color.Transparent;
            this.btn_all.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_all.ForeColor = System.Drawing.Color.DimGray;
            this.btn_all.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btn_all.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_all.HoverState.Parent = this.btn_all;
            this.btn_all.Location = new System.Drawing.Point(12, 62);
            this.btn_all.Name = "btn_all";
            this.btn_all.ShadowDecoration.Parent = this.btn_all;
            this.btn_all.Size = new System.Drawing.Size(89, 40);
            this.btn_all.TabIndex = 141;
            this.btn_all.Text = "All";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Animated = true;
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_thanhtoan.BorderRadius = 13;
            this.btn_thanhtoan.CheckedState.Parent = this.btn_thanhtoan;
            this.btn_thanhtoan.CustomImages.Parent = this.btn_thanhtoan;
            this.btn_thanhtoan.FillColor = System.Drawing.Color.Transparent;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.DimGray;
            this.btn_thanhtoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btn_thanhtoan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.HoverState.Parent = this.btn_thanhtoan;
            this.btn_thanhtoan.Location = new System.Drawing.Point(107, 62);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.ShadowDecoration.Parent = this.btn_thanhtoan;
            this.btn_thanhtoan.Size = new System.Drawing.Size(89, 40);
            this.btn_thanhtoan.TabIndex = 140;
            this.btn_thanhtoan.Text = "Đã thanh toán";
            // 
            // tb_search
            // 
            this.tb_search.Animated = true;
            this.tb_search.BorderRadius = 20;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.Parent = this.tb_search;
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.FocusedState.Parent = this.tb_search;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.HoverState.Parent = this.tb_search;
            this.tb_search.Location = new System.Drawing.Point(12, 12);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "Search..............";
            this.tb_search.SelectedText = "";
            this.tb_search.ShadowDecoration.Parent = this.tb_search;
            this.tb_search.Size = new System.Drawing.Size(447, 44);
            this.tb_search.TabIndex = 139;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // khachhang
            // 
            this.khachhang.HeaderText = "Mã khách hàng";
            this.khachhang.Name = "khachhang";
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên khách hàng";
            this.ten.Name = "ten";
            // 
            // phong
            // 
            this.phong.HeaderText = "Mã phòng";
            this.phong.Name = "phong";
            // 
            // tenphong
            // 
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.Name = "tenphong";
            // 
            // ngaylaphoadon
            // 
            this.ngaylaphoadon.HeaderText = "Ngày lập đơn";
            this.ngaylaphoadon.Name = "ngaylaphoadon";
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // sotiendathanhtoan
            // 
            this.sotiendathanhtoan.HeaderText = "Thanh toán";
            this.sotiendathanhtoan.Name = "sotiendathanhtoan";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 565);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.tb_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylaphoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiendathanhtoan;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        internal Guna.UI2.WinForms.Guna2Button btn_no;
        internal Guna.UI2.WinForms.Guna2Button btn_all;
        internal Guna.UI2.WinForms.Guna2Button btn_thanhtoan;
        internal Guna.UI2.WinForms.Guna2TextBox tb_search;
    }
}