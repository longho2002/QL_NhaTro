namespace QL_NhaTro
{
    partial class frmThemHopDong
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
            this.cb_phong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_tien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ngtra = new System.Windows.Forms.DateTimePicker();
            this.tb_kh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ngthue = new System.Windows.Forms.DateTimePicker();
            this.btn_dskh = new Guna.UI2.WinForms.Guna2Button();
            this.tb_coc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_phong
            // 
            this.cb_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phong.FormattingEnabled = true;
            this.cb_phong.Items.AddRange(new object[] {
            "Còn ở",
            "Chuyển đi"});
            this.cb_phong.Location = new System.Drawing.Point(201, 163);
            this.cb_phong.Name = "cb_phong";
            this.cb_phong.Size = new System.Drawing.Size(220, 28);
            this.cb_phong.TabIndex = 209;
            this.cb_phong.SelectedIndexChanged += new System.EventHandler(this.cb_phong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(52, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 208;
            this.label4.Text = "Phòng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(52, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 206;
            this.label12.Text = "Ngày trả phòng:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tb_tien
            // 
            this.tb_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tien.Location = new System.Drawing.Point(204, 255);
            this.tb_tien.Name = "tb_tien";
            this.tb_tien.Size = new System.Drawing.Size(218, 26);
            this.tb_tien.TabIndex = 200;
            this.tb_tien.TextChanged += new System.EventHandler(this.tb_tien_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(143, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 34);
            this.label8.TabIndex = 192;
            this.label8.Text = "Thêm hợp đồng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ngtra
            // 
            this.ngtra.Location = new System.Drawing.Point(204, 229);
            this.ngtra.Name = "ngtra";
            this.ngtra.Size = new System.Drawing.Size(219, 20);
            this.ngtra.TabIndex = 191;
            this.ngtra.ValueChanged += new System.EventHandler(this.ngtra_ValueChanged);
            // 
            // tb_kh
            // 
            this.tb_kh.Enabled = false;
            this.tb_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kh.Location = new System.Drawing.Point(202, 131);
            this.tb_kh.Name = "tb_kh";
            this.tb_kh.Size = new System.Drawing.Size(220, 26);
            this.tb_kh.TabIndex = 187;
            this.tb_kh.TextChanged += new System.EventHandler(this.tb_kh_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(51, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 186;
            this.label7.Text = "Giá thuê:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(51, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 183;
            this.label3.Text = "Khách hàng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Animated = true;
            this.btn_huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_huy.BorderRadius = 14;
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(102, 344);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.Parent = this.btn_huy;
            this.btn_huy.Size = new System.Drawing.Size(133, 45);
            this.btn_huy.TabIndex = 211;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_them
            // 
            this.btn_them.Animated = true;
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.BorderRadius = 14;
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(268, 344);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(133, 45);
            this.btn_them.TabIndex = 210;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(52, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 213;
            this.label1.Text = "Ngày thuê:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ngthue
            // 
            this.ngthue.Location = new System.Drawing.Point(204, 203);
            this.ngthue.Name = "ngthue";
            this.ngthue.Size = new System.Drawing.Size(219, 20);
            this.ngthue.TabIndex = 212;
            this.ngthue.ValueChanged += new System.EventHandler(this.ngthue_ValueChanged);
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
            this.btn_dskh.Location = new System.Drawing.Point(428, 131);
            this.btn_dskh.Name = "btn_dskh";
            this.btn_dskh.ShadowDecoration.Parent = this.btn_dskh;
            this.btn_dskh.Size = new System.Drawing.Size(48, 26);
            this.btn_dskh.TabIndex = 214;
            this.btn_dskh.Text = "Chọn";
            this.btn_dskh.Click += new System.EventHandler(this.btn_dskh_Click);
            // 
            // tb_coc
            // 
            this.tb_coc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_coc.Location = new System.Drawing.Point(203, 287);
            this.tb_coc.Name = "tb_coc";
            this.tb_coc.Size = new System.Drawing.Size(218, 26);
            this.tb_coc.TabIndex = 216;
            this.tb_coc.TextChanged += new System.EventHandler(this.tb_coc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(50, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 215;
            this.label2.Text = "Tiền đặt cọc:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmThemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(502, 428);
            this.Controls.Add(this.tb_coc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dskh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngthue);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cb_phong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_tien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ngtra);
            this.Controls.Add(this.tb_kh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Name = "frmThemHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemHopDong";
            this.Load += new System.EventHandler(this.frmThemHopDong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_phong;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tb_tien;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker ngtra;
        public System.Windows.Forms.TextBox tb_kh;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label3;
        internal Guna.UI2.WinForms.Guna2Button btn_huy;
        internal Guna.UI2.WinForms.Guna2Button btn_them;
        protected System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker ngthue;
        internal Guna.UI2.WinForms.Guna2Button btn_dskh;
        public System.Windows.Forms.TextBox tb_coc;
        protected System.Windows.Forms.Label label2;
    }
}