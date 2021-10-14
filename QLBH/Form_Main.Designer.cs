namespace QLBH
{
    partial class Form_Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.dgv_HD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_them_HD = new System.Windows.Forms.Button();
            this.btn_xemchitiet_HD = new System.Windows.Forms.Button();
            this.btn_huy_HD = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dTP_ngaylap_HD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_tongtien_HD = new System.Windows.Forms.TextBox();
            this.txtBox_makh_HD = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBox_mahd_HD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.btn_search_TK = new System.Windows.Forms.Button();
            this.cbBox_nam_TK = new System.Windows.Forms.ComboBox();
            this.txtBox_thang_TK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_slhangdaban_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DThu = new System.Windows.Forms.DataGridView();
            this.txtBox_slhoadon_TK = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtBox_doanhthu_TK = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtBox_loinhuan_TK = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DThu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHoaDon);
            this.tabControl1.Controls.Add(this.tabThongKe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 753);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.dgv_HD);
            this.tabHoaDon.Controls.Add(this.panel1);
            this.tabHoaDon.Controls.Add(this.panel7);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 34);
            this.tabHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.tabHoaDon.Size = new System.Drawing.Size(955, 715);
            this.tabHoaDon.TabIndex = 0;
            this.tabHoaDon.Text = "   Hoá Đơn      ";
            this.tabHoaDon.UseVisualStyleBackColor = true;
            this.tabHoaDon.Enter += new System.EventHandler(this.tabHoaDon_Enter);
            // 
            // dgv_HD
            // 
            this.dgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HD.Location = new System.Drawing.Point(5, 284);
            this.dgv_HD.Name = "dgv_HD";
            this.dgv_HD.RowHeadersWidth = 51;
            this.dgv_HD.RowTemplate.Height = 24;
            this.dgv_HD.Size = new System.Drawing.Size(945, 358);
            this.dgv_HD.TabIndex = 21;
            this.dgv_HD.Click += new System.EventHandler(this.dgv_HD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_them_HD);
            this.panel1.Controls.Add(this.btn_xemchitiet_HD);
            this.panel1.Controls.Add(this.btn_huy_HD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 642);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 68);
            this.panel1.TabIndex = 2;
            // 
            // btn_them_HD
            // 
            this.btn_them_HD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_HD.Location = new System.Drawing.Point(402, 18);
            this.btn_them_HD.Name = "btn_them_HD";
            this.btn_them_HD.Size = new System.Drawing.Size(130, 40);
            this.btn_them_HD.TabIndex = 24;
            this.btn_them_HD.Text = "Thêm";
            this.btn_them_HD.UseVisualStyleBackColor = true;
            this.btn_them_HD.Click += new System.EventHandler(this.btn_them_HD_Click);
            // 
            // btn_xemchitiet_HD
            // 
            this.btn_xemchitiet_HD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xemchitiet_HD.Location = new System.Drawing.Point(94, 18);
            this.btn_xemchitiet_HD.Name = "btn_xemchitiet_HD";
            this.btn_xemchitiet_HD.Size = new System.Drawing.Size(130, 40);
            this.btn_xemchitiet_HD.TabIndex = 22;
            this.btn_xemchitiet_HD.Text = "Xem Chi Tiết";
            this.btn_xemchitiet_HD.UseVisualStyleBackColor = true;
            this.btn_xemchitiet_HD.Click += new System.EventHandler(this.btn_xemchitiet_HD_Click);
            // 
            // btn_huy_HD
            // 
            this.btn_huy_HD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huy_HD.Location = new System.Drawing.Point(710, 18);
            this.btn_huy_HD.Name = "btn_huy_HD";
            this.btn_huy_HD.Size = new System.Drawing.Size(130, 40);
            this.btn_huy_HD.TabIndex = 21;
            this.btn_huy_HD.Text = "Hủy";
            this.btn_huy_HD.UseVisualStyleBackColor = true;
            this.btn_huy_HD.Click += new System.EventHandler(this.btn_huy_HD_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dTP_ngaylap_HD);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtBox_tongtien_HD);
            this.panel7.Controls.Add(this.txtBox_makh_HD);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.txtBox_mahd_HD);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.MinimumSize = new System.Drawing.Size(4, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(945, 279);
            this.panel7.TabIndex = 1;
            // 
            // dTP_ngaylap_HD
            // 
            this.dTP_ngaylap_HD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_ngaylap_HD.Location = new System.Drawing.Point(370, 159);
            this.dTP_ngaylap_HD.MinimumSize = new System.Drawing.Size(4, 33);
            this.dTP_ngaylap_HD.Name = "dTP_ngaylap_HD";
            this.dTP_ngaylap_HD.Size = new System.Drawing.Size(247, 33);
            this.dTP_ngaylap_HD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(247, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày Lập";
            // 
            // txtBox_tongtien_HD
            // 
            this.txtBox_tongtien_HD.Location = new System.Drawing.Point(370, 205);
            this.txtBox_tongtien_HD.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtBox_tongtien_HD.Multiline = true;
            this.txtBox_tongtien_HD.Name = "txtBox_tongtien_HD";
            this.txtBox_tongtien_HD.Size = new System.Drawing.Size(247, 33);
            this.txtBox_tongtien_HD.TabIndex = 13;
            // 
            // txtBox_makh_HD
            // 
            this.txtBox_makh_HD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_makh_HD.Location = new System.Drawing.Point(370, 114);
            this.txtBox_makh_HD.Multiline = true;
            this.txtBox_makh_HD.Name = "txtBox_makh_HD";
            this.txtBox_makh_HD.Size = new System.Drawing.Size(247, 33);
            this.txtBox_makh_HD.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(243, 208);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 25);
            this.label21.TabIndex = 7;
            this.label21.Text = "Tổng Tiền";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(196, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "Mã khách Hàng";
            // 
            // txtBox_mahd_HD
            // 
            this.txtBox_mahd_HD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBox_mahd_HD.Location = new System.Drawing.Point(370, 69);
            this.txtBox_mahd_HD.Multiline = true;
            this.txtBox_mahd_HD.Name = "txtBox_mahd_HD";
            this.txtBox_mahd_HD.Size = new System.Drawing.Size(247, 33);
            this.txtBox_mahd_HD.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(218, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mã Hoá Đơn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(364, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(307, 33);
            this.label16.TabIndex = 0;
            this.label16.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.btn_search_TK);
            this.tabThongKe.Controls.Add(this.cbBox_nam_TK);
            this.tabThongKe.Controls.Add(this.txtBox_thang_TK);
            this.tabThongKe.Controls.Add(this.label3);
            this.tabThongKe.Controls.Add(this.txtBox_slhangdaban_TK);
            this.tabThongKe.Controls.Add(this.label2);
            this.tabThongKe.Controls.Add(this.dgv_DThu);
            this.tabThongKe.Controls.Add(this.txtBox_slhoadon_TK);
            this.tabThongKe.Controls.Add(this.label46);
            this.tabThongKe.Controls.Add(this.txtBox_doanhthu_TK);
            this.tabThongKe.Controls.Add(this.label45);
            this.tabThongKe.Controls.Add(this.txtBox_loinhuan_TK);
            this.tabThongKe.Controls.Add(this.label39);
            this.tabThongKe.Controls.Add(this.label38);
            this.tabThongKe.Controls.Add(this.label37);
            this.tabThongKe.Location = new System.Drawing.Point(4, 34);
            this.tabThongKe.Margin = new System.Windows.Forms.Padding(5);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(5);
            this.tabThongKe.Size = new System.Drawing.Size(955, 715);
            this.tabThongKe.TabIndex = 1;
            this.tabThongKe.Text = "   Thống Kê   ";
            this.tabThongKe.UseVisualStyleBackColor = true;
            this.tabThongKe.Enter += new System.EventHandler(this.tabThongKe_Enter);
            // 
            // btn_search_TK
            // 
            this.btn_search_TK.Image = global::QLBH.Properties.Resources.search;
            this.btn_search_TK.Location = new System.Drawing.Point(814, 95);
            this.btn_search_TK.Name = "btn_search_TK";
            this.btn_search_TK.Size = new System.Drawing.Size(45, 29);
            this.btn_search_TK.TabIndex = 57;
            this.btn_search_TK.UseVisualStyleBackColor = true;
            this.btn_search_TK.Click += new System.EventHandler(this.btn_search_TK_Click);
            // 
            // cbBox_nam_TK
            // 
            this.cbBox_nam_TK.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbBox_nam_TK.FormattingEnabled = true;
            this.cbBox_nam_TK.ItemHeight = 22;
            this.cbBox_nam_TK.Location = new System.Drawing.Point(627, 95);
            this.cbBox_nam_TK.Name = "cbBox_nam_TK";
            this.cbBox_nam_TK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbBox_nam_TK.Size = new System.Drawing.Size(181, 30);
            this.cbBox_nam_TK.TabIndex = 56;
            this.cbBox_nam_TK.Text = "2021";
            this.cbBox_nam_TK.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbBox_nam_TK_DrawItem);
            // 
            // txtBox_thang_TK
            // 
            this.txtBox_thang_TK.Location = new System.Drawing.Point(256, 95);
            this.txtBox_thang_TK.Multiline = true;
            this.txtBox_thang_TK.Name = "txtBox_thang_TK";
            this.txtBox_thang_TK.Size = new System.Drawing.Size(181, 33);
            this.txtBox_thang_TK.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(173, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tháng ";
            // 
            // txtBox_slhangdaban_TK
            // 
            this.txtBox_slhangdaban_TK.Location = new System.Drawing.Point(256, 220);
            this.txtBox_slhangdaban_TK.Multiline = true;
            this.txtBox_slhangdaban_TK.Name = "txtBox_slhangdaban_TK";
            this.txtBox_slhangdaban_TK.Size = new System.Drawing.Size(181, 33);
            this.txtBox_slhangdaban_TK.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(41, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Số Lượng Hàng Đã Bán";
            // 
            // dgv_DThu
            // 
            this.dgv_DThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DThu.Location = new System.Drawing.Point(5, 283);
            this.dgv_DThu.Name = "dgv_DThu";
            this.dgv_DThu.RowHeadersWidth = 51;
            this.dgv_DThu.RowTemplate.Height = 24;
            this.dgv_DThu.Size = new System.Drawing.Size(945, 427);
            this.dgv_DThu.TabIndex = 51;
            this.dgv_DThu.Click += new System.EventHandler(this.dgv_DTh_Click);
            // 
            // txtBox_slhoadon_TK
            // 
            this.txtBox_slhoadon_TK.Location = new System.Drawing.Point(256, 158);
            this.txtBox_slhoadon_TK.Multiline = true;
            this.txtBox_slhoadon_TK.Name = "txtBox_slhoadon_TK";
            this.txtBox_slhoadon_TK.Size = new System.Drawing.Size(181, 33);
            this.txtBox_slhoadon_TK.TabIndex = 49;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label46.ForeColor = System.Drawing.Color.Blue;
            this.label46.Location = new System.Drawing.Point(78, 165);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(183, 25);
            this.label46.TabIndex = 48;
            this.label46.Text = "Số Lượng Hoá Đơn";
            // 
            // txtBox_doanhthu_TK
            // 
            this.txtBox_doanhthu_TK.Location = new System.Drawing.Point(627, 157);
            this.txtBox_doanhthu_TK.Multiline = true;
            this.txtBox_doanhthu_TK.Name = "txtBox_doanhthu_TK";
            this.txtBox_doanhthu_TK.Size = new System.Drawing.Size(181, 33);
            this.txtBox_doanhthu_TK.TabIndex = 47;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label45.ForeColor = System.Drawing.Color.Blue;
            this.label45.Location = new System.Drawing.Point(514, 163);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(110, 25);
            this.label45.TabIndex = 46;
            this.label45.Text = "Doanh Thu";
            // 
            // txtBox_loinhuan_TK
            // 
            this.txtBox_loinhuan_TK.Location = new System.Drawing.Point(627, 219);
            this.txtBox_loinhuan_TK.Multiline = true;
            this.txtBox_loinhuan_TK.Name = "txtBox_loinhuan_TK";
            this.txtBox_loinhuan_TK.Size = new System.Drawing.Size(181, 33);
            this.txtBox_loinhuan_TK.TabIndex = 45;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label39.ForeColor = System.Drawing.Color.Blue;
            this.label39.Location = new System.Drawing.Point(529, 225);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(91, 25);
            this.label39.TabIndex = 44;
            this.label39.Text = "Lợi Luận";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label38.ForeColor = System.Drawing.Color.Blue;
            this.label38.Location = new System.Drawing.Point(547, 101);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 25);
            this.label38.TabIndex = 43;
            this.label38.Text = "Năm";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label37.Location = new System.Drawing.Point(404, 17);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(152, 33);
            this.label37.TabIndex = 42;
            this.label37.Text = "THỐNG KÊ";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 753);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng Dụng Quản Lí Bán Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBox_tongtien_HD;
        private System.Windows.Forms.TextBox txtBox_makh_HD;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBox_mahd_HD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_HD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_them_HD;
        private System.Windows.Forms.Button btn_xemchitiet_HD;
        private System.Windows.Forms.Button btn_huy_HD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DThu;
        private System.Windows.Forms.TextBox txtBox_slhoadon_TK;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtBox_doanhthu_TK;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtBox_loinhuan_TK;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DateTimePicker dTP_ngaylap_HD;
        private System.Windows.Forms.TextBox txtBox_slhangdaban_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBox_nam_TK;
        private System.Windows.Forms.TextBox txtBox_thang_TK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search_TK;
    }
}

