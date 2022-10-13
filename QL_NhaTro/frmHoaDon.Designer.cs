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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylaphoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiendathanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_no = new Guna.UI2.WinForms.Guna2Button();
            this.btn_all = new Guna.UI2.WinForms.Guna2Button();
            this.btn_thanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbtn_on = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbtn_off = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pantime = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pantime.SuspendLayout();
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
            this.idphong,
            this.tenphong,
            this.ngaylaphoadon,
            this.tongtien,
            this.sotiendathanhtoan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 40;
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
            this.dataGridView.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // khachhang
            // 
            this.khachhang.DataPropertyName = "idKH";
            this.khachhang.HeaderText = "Mã khách hàng";
            this.khachhang.Name = "khachhang";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "tenkhachhang";
            this.ten.HeaderText = "Tên khách hàng";
            this.ten.Name = "ten";
            // 
            // idphong
            // 
            this.idphong.DataPropertyName = "idphong";
            this.idphong.HeaderText = "Mã phòng";
            this.idphong.Name = "idphong";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.Name = "tenphong";
            // 
            // ngaylaphoadon
            // 
            this.ngaylaphoadon.DataPropertyName = "ngaylaphoadon";
            this.ngaylaphoadon.HeaderText = "Ngày lập đơn";
            this.ngaylaphoadon.Name = "ngaylaphoadon";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // sotiendathanhtoan
            // 
            this.sotiendathanhtoan.DataPropertyName = "sotiendathanhtoan";
            this.sotiendathanhtoan.HeaderText = "Thanh toán";
            this.sotiendathanhtoan.Name = "sotiendathanhtoan";
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
            this.btn_them.Text = "Lập hoá đơn";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
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
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
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
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
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
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
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
            // rbtn_on
            // 
            this.rbtn_on.Animated = true;
            this.rbtn_on.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_on.CheckedState.BorderThickness = 0;
            this.rbtn_on.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_on.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_on.CheckedState.Parent = this.rbtn_on;
            this.rbtn_on.Location = new System.Drawing.Point(378, 72);
            this.rbtn_on.Name = "rbtn_on";
            this.rbtn_on.ShadowDecoration.Parent = this.rbtn_on;
            this.rbtn_on.Size = new System.Drawing.Size(20, 20);
            this.rbtn_on.TabIndex = 146;
            this.rbtn_on.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_on.UncheckedState.BorderThickness = 2;
            this.rbtn_on.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_on.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtn_on.UncheckedState.Parent = this.rbtn_on;
            this.rbtn_on.CheckedChanged += new System.EventHandler(this.rbtn_on_CheckedChanged);
            // 
            // rbtn_off
            // 
            this.rbtn_off.Animated = true;
            this.rbtn_off.Checked = true;
            this.rbtn_off.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_off.CheckedState.BorderThickness = 0;
            this.rbtn_off.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_off.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_off.CheckedState.Parent = this.rbtn_off;
            this.rbtn_off.Location = new System.Drawing.Point(448, 72);
            this.rbtn_off.Name = "rbtn_off";
            this.rbtn_off.ShadowDecoration.Parent = this.rbtn_off;
            this.rbtn_off.Size = new System.Drawing.Size(20, 20);
            this.rbtn_off.TabIndex = 147;
            this.rbtn_off.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_off.UncheckedState.BorderThickness = 2;
            this.rbtn_off.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_off.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtn_off.UncheckedState.Parent = this.rbtn_off;
            this.rbtn_off.CheckedChanged += new System.EventHandler(this.rbtn_off_CheckedChanged);
            // 
            // from
            // 
            this.from.CustomFormat = "";
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from.Location = new System.Drawing.Point(60, 14);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(97, 20);
            this.from.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(342, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "On";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(411, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 150;
            this.label2.Text = "Off";
            // 
            // to
            // 
            this.to.CustomFormat = "";
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to.Location = new System.Drawing.Point(196, 14);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(97, 20);
            this.to.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(163, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 152;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 153;
            this.label4.Text = "From";
            // 
            // pantime
            // 
            this.pantime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pantime.Controls.Add(this.label4);
            this.pantime.Controls.Add(this.label3);
            this.pantime.Controls.Add(this.to);
            this.pantime.Controls.Add(this.from);
            this.pantime.Enabled = false;
            this.pantime.Location = new System.Drawing.Point(478, 58);
            this.pantime.Name = "pantime";
            this.pantime.Size = new System.Drawing.Size(306, 43);
            this.pantime.TabIndex = 154;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 565);
            this.Controls.Add(this.pantime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_off);
            this.Controls.Add(this.rbtn_on);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.tb_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pantime.ResumeLayout(false);
            this.pantime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        internal Guna.UI2.WinForms.Guna2Button btn_no;
        internal Guna.UI2.WinForms.Guna2Button btn_all;
        internal Guna.UI2.WinForms.Guna2Button btn_thanhtoan;
        internal Guna.UI2.WinForms.Guna2TextBox tb_search;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbtn_on;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbtn_off;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pantime;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylaphoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiendathanhtoan;
    }
}