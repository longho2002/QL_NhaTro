namespace QL_NhaTro
{
    partial class frmThongTinHopDong
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
            this.tb_coc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dskh = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ngthue = new System.Windows.Forms.DateTimePicker();
            this.cb_phong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_tien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ngtra = new System.Windows.Forms.DateTimePicker();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_kh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_capnhat = new Guna.UI2.WinForms.Guna2Button();
            this.numMonth = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_giahan = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_traphong = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_trangthai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_coc
            // 
            this.tb_coc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_coc.Location = new System.Drawing.Point(212, 292);
            this.tb_coc.Name = "tb_coc";
            this.tb_coc.Size = new System.Drawing.Size(218, 26);
            this.tb_coc.TabIndex = 234;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(59, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 233;
            this.label2.Text = "Tiền đặt cọc:";
            // 
            // btn_dskh
            // 
            this.btn_dskh.Animated = true;
            this.btn_dskh.BackColor = System.Drawing.Color.Transparent;
            this.btn_dskh.BorderRadius = 14;
            this.btn_dskh.CheckedState.Parent = this.btn_dskh;
            this.btn_dskh.CustomImages.Parent = this.btn_dskh;
            this.btn_dskh.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_dskh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dskh.ForeColor = System.Drawing.Color.White;
            this.btn_dskh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btn_dskh.HoverState.Parent = this.btn_dskh;
            this.btn_dskh.Location = new System.Drawing.Point(437, 106);
            this.btn_dskh.Name = "btn_dskh";
            this.btn_dskh.ShadowDecoration.Parent = this.btn_dskh;
            this.btn_dskh.Size = new System.Drawing.Size(48, 26);
            this.btn_dskh.TabIndex = 232;
            this.btn_dskh.Text = "Chọn";
            this.btn_dskh.Click += new System.EventHandler(this.btn_dskh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(61, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 231;
            this.label1.Text = "Ngày thuê:";
            // 
            // ngthue
            // 
            this.ngthue.Location = new System.Drawing.Point(213, 202);
            this.ngthue.Name = "ngthue";
            this.ngthue.Size = new System.Drawing.Size(219, 20);
            this.ngthue.TabIndex = 230;
            // 
            // cb_phong
            // 
            this.cb_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phong.FormattingEnabled = true;
            this.cb_phong.Items.AddRange(new object[] {
            "Còn ở",
            "Chuyển đi"});
            this.cb_phong.Location = new System.Drawing.Point(210, 138);
            this.cb_phong.Name = "cb_phong";
            this.cb_phong.Size = new System.Drawing.Size(220, 28);
            this.cb_phong.TabIndex = 227;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(61, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 226;
            this.label4.Text = "Phòng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(60, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 225;
            this.label12.Text = "Ngày trả phòng:";
            // 
            // tb_tien
            // 
            this.tb_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tien.Location = new System.Drawing.Point(213, 260);
            this.tb_tien.Name = "tb_tien";
            this.tb_tien.Size = new System.Drawing.Size(218, 26);
            this.tb_tien.TabIndex = 224;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 34);
            this.label8.TabIndex = 223;
            this.label8.Text = "Chỉnh sửa hợp đồng";
            // 
            // ngtra
            // 
            this.ngtra.Location = new System.Drawing.Point(212, 172);
            this.ngtra.Name = "ngtra";
            this.ngtra.Size = new System.Drawing.Size(219, 20);
            this.ngtra.TabIndex = 222;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(213, 228);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(219, 26);
            this.tb_Phone.TabIndex = 221;
            // 
            // tb_kh
            // 
            this.tb_kh.Enabled = false;
            this.tb_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kh.Location = new System.Drawing.Point(211, 106);
            this.tb_kh.Name = "tb_kh";
            this.tb_kh.Size = new System.Drawing.Size(220, 26);
            this.tb_kh.TabIndex = 220;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(60, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 219;
            this.label7.Text = "Giá thuê:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(60, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 218;
            this.label6.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(60, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 217;
            this.label3.Text = "Khách hàng:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Animated = true;
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.BorderRadius = 14;
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(62, 494);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(182, 45);
            this.btn_xoa.TabIndex = 236;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Animated = true;
            this.btn_capnhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_capnhat.BorderRadius = 14;
            this.btn_capnhat.CheckedState.Parent = this.btn_capnhat;
            this.btn_capnhat.CustomImages.Parent = this.btn_capnhat;
            this.btn_capnhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btn_capnhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_capnhat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btn_capnhat.HoverState.Parent = this.btn_capnhat;
            this.btn_capnhat.Location = new System.Drawing.Point(250, 494);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.ShadowDecoration.Parent = this.btn_capnhat;
            this.btn_capnhat.Size = new System.Drawing.Size(182, 45);
            this.btn_capnhat.TabIndex = 235;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // numMonth
            // 
            this.numMonth.BackColor = System.Drawing.Color.Transparent;
            this.numMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numMonth.DisabledState.Parent = this.numMonth;
            this.numMonth.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numMonth.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numMonth.FocusedState.Parent = this.numMonth;
            this.numMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numMonth.Location = new System.Drawing.Point(66, 391);
            this.numMonth.Name = "numMonth";
            this.numMonth.ShadowDecoration.Parent = this.numMonth;
            this.numMonth.Size = new System.Drawing.Size(77, 36);
            this.numMonth.TabIndex = 238;
            // 
            // btn_giahan
            // 
            this.btn_giahan.Animated = true;
            this.btn_giahan.BackColor = System.Drawing.Color.Transparent;
            this.btn_giahan.BorderRadius = 14;
            this.btn_giahan.CheckedState.Parent = this.btn_giahan;
            this.btn_giahan.CustomImages.Parent = this.btn_giahan;
            this.btn_giahan.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_giahan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giahan.ForeColor = System.Drawing.Color.White;
            this.btn_giahan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btn_giahan.HoverState.Parent = this.btn_giahan;
            this.btn_giahan.Location = new System.Drawing.Point(172, 391);
            this.btn_giahan.Name = "btn_giahan";
            this.btn_giahan.ShadowDecoration.Parent = this.btn_giahan;
            this.btn_giahan.Size = new System.Drawing.Size(260, 36);
            this.btn_giahan.TabIndex = 239;
            this.btn_giahan.Text = "Gia hạn";
            this.btn_giahan.Click += new System.EventHandler(this.btn_GiaHan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(63, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 240;
            this.label5.Text = "Số tháng";
            // 
            // btn_traphong
            // 
            this.btn_traphong.Animated = true;
            this.btn_traphong.BackColor = System.Drawing.Color.Transparent;
            this.btn_traphong.BorderRadius = 14;
            this.btn_traphong.CheckedState.Parent = this.btn_traphong;
            this.btn_traphong.CustomImages.Parent = this.btn_traphong;
            this.btn_traphong.FillColor = System.Drawing.Color.Teal;
            this.btn_traphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traphong.ForeColor = System.Drawing.Color.White;
            this.btn_traphong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btn_traphong.HoverState.Parent = this.btn_traphong;
            this.btn_traphong.Location = new System.Drawing.Point(67, 443);
            this.btn_traphong.Name = "btn_traphong";
            this.btn_traphong.ShadowDecoration.Parent = this.btn_traphong;
            this.btn_traphong.Size = new System.Drawing.Size(365, 36);
            this.btn_traphong.TabIndex = 241;
            this.btn_traphong.Text = "Trả phòng";
            this.btn_traphong.Click += new System.EventHandler(this.btn_traphong_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(63, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 242;
            this.label9.Text = "Trạng thái:";
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangthai.ForeColor = System.Drawing.Color.Crimson;
            this.lb_trangthai.Location = new System.Drawing.Point(209, 330);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(93, 20);
            this.lb_trangthai.TabIndex = 243;
            this.lb_trangthai.Text = "Đang thuê";
            // 
            // frmThongTinHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 590);
            this.Controls.Add(this.lb_trangthai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_traphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_giahan);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.tb_coc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dskh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngthue);
            this.Controls.Add(this.cb_phong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_tien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ngtra);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_kh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "frmThongTinHopDong";
            this.Text = "frmThongTinHopDong";
            this.Load += new System.EventHandler(this.frmThongTinHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_coc;
        protected System.Windows.Forms.Label label2;
        internal Guna.UI2.WinForms.Guna2Button btn_dskh;
        protected System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker ngthue;
        private System.Windows.Forms.ComboBox cb_phong;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tb_tien;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker ngtra;
        public System.Windows.Forms.TextBox tb_Phone;
        public System.Windows.Forms.TextBox tb_kh;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label3;
        internal Guna.UI2.WinForms.Guna2Button btn_xoa;
        internal Guna.UI2.WinForms.Guna2Button btn_capnhat;
        private Guna.UI2.WinForms.Guna2NumericUpDown numMonth;
        internal Guna.UI2.WinForms.Guna2Button btn_giahan;
        protected System.Windows.Forms.Label label5;
        internal Guna.UI2.WinForms.Guna2Button btn_traphong;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label lb_trangthai;
    }
}