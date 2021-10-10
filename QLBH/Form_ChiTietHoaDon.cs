using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Form_ChiTietHoaDon : Form
    {
        public bool mode_chitiethoadon_CTDH = false;
        public bool mode_themhoadon_CTDH = false;
        public bool is_themthanhcong = false;
        public string mahd_CTHD = "";
        bool mode_themmoiKH = true;
        int soluongcu = 0;
        
        public Form_ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void SetFont_CTHD() // set Font cho các textBox 
        {
            dTP_ngaysinh_CTHD.Font = new Font("Time New Roman", 12);
            dTP_ngaylap_CTHD.Font = new Font("Time New Roman", 12);

            txtBox_mahd_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_masp_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_tensp_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_slton_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_giaban_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_soluongban_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_giamgia_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_thanhtien_CTHD.Font = new Font("Time New Roman", 12);

            txtBox_makh_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_ho_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_ten_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_sonha_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_duong_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_phuong_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_quan_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_thanhpho_CTHD.Font = new Font("Time New Roman", 12);
            txtBox_dienthoai_CTHD.Font = new Font("Time New Roman", 12);
        }

        private void Resetvalues_modeThemKH_CTHD() // reset giá trị cho các mục mode thêm KH
        {
            txtBox_makh_CTHD.Text = "";
            txtBox_ho_CTHD.Text = "";
            txtBox_ten_CTHD.Text = "";
            dTP_ngaysinh_CTHD.Text = "";
            txtBox_sonha_CTHD.Text = "";
            txtBox_duong_CTHD.Text = "";
            txtBox_phuong_CTHD.Text = "";
            txtBox_quan_CTHD.Text = "";
            txtBox_thanhpho_CTHD.Text = "";
            txtBox_dienthoai_CTHD.Text = "";
        }
        private void Resetvalues_CTHD() // reset giá trị cho các mục 
        {
            txtBox_mahd_CTHD.Text = "";
            dTP_ngaylap_CTHD.Text = "";
            txtBox_masp_CTHD.Text = "";
            txtBox_tensp_CTHD.Text = "";
            txtBox_slton_CTHD.Text = "";
            txtBox_giaban_CTHD.Text = "";
            txtBox_soluongban_CTHD.Text = "";
            txtBox_giamgia_CTHD.Text = "";
            txtBox_thanhtien_CTHD.Text = "";

            txtBox_makh_CTHD.Text = "";
            txtBox_ho_CTHD.Text = "";
            txtBox_ten_CTHD.Text = "";
            dTP_ngaysinh_CTHD.Text = "";
            txtBox_sonha_CTHD.Text = "";
            txtBox_duong_CTHD.Text = "";
            txtBox_phuong_CTHD.Text = "";
            txtBox_quan_CTHD.Text = "";
            txtBox_thanhpho_CTHD.Text = "";
            txtBox_dienthoai_CTHD.Text = "";

            if (mode_chitiethoadon_CTDH)
            {
                btn_autotongtien_CTHD.Enabled = false;
                btn_luu_CTHD.Enabled = false;
                btn_modeKH_CTHD.Enabled = false;
            }

            if (mode_themhoadon_CTDH)
                dTP_ngaylap_CTHD.CustomFormat = "yyyy-MM-dd";
        }      

        private void set_Enable() // xử lí enable các Textbox khi ở mode thêm
        {
            txtBox_tensp_CTHD.Enabled = false;
            txtBox_slton_CTHD.Enabled = false;
            txtBox_giaban_CTHD.Enabled = false;
        }

        private void set_Enable_ThemMoiKH() // xử lí Enable các nút khi thêm mới KH
        {            
            dTP_ngaysinh_CTHD.CustomFormat = "yyyy-MM-dd";
            dTP_ngaysinh_CTHD.Enabled = true;        

            txtBox_ho_CTHD.Enabled = true;
            txtBox_ten_CTHD.Enabled = true;
            txtBox_sonha_CTHD.Enabled = true;
            txtBox_duong_CTHD.Enabled = true;
            txtBox_phuong_CTHD.Enabled = true;
            txtBox_quan_CTHD.Enabled = true;
            txtBox_thanhpho_CTHD.Enabled = true;
            txtBox_dienthoai_CTHD.Enabled = true;
        }

        private void set_Enable_ChonKHCu() // xử lí Enable các nút khi chọn KH Cũ
        {
            dTP_ngaysinh_CTHD.CustomFormat = " ";
            dTP_ngaysinh_CTHD.Enabled = false;

            txtBox_ho_CTHD.Enabled = false;
            txtBox_ten_CTHD.Enabled = false;
            txtBox_sonha_CTHD.Enabled = false;
            txtBox_duong_CTHD.Enabled = false;
            txtBox_phuong_CTHD.Enabled = false;
            txtBox_quan_CTHD.Enabled = false;
            txtBox_thanhpho_CTHD.Enabled = false;
            txtBox_dienthoai_CTHD.Enabled = false;
        }

        private void LoadData_CTHD() // tải dữ liệu vào DataGridView
        {
            DataTable tblCTHD; // table để chứa dữ liệu truy vấn

            // set text cho các Text Box
            string sql = "SELECT HD.MAHD, HD.MAKH_HD, HD.NGAYLAP, " +
                "CTHD.SOLUONG, CTHD.GIAGIAM, CTHD.THANHTIEN, CTHD.MASP_CT " +
                "FROM HOADON HD, CT_HOADON CTHD " +
                "WHERE HD.MAHD = CTHD.MAHD_CT " +
                "AND MAHD = '" + mahd_CTHD + "' ";
            tblCTHD = Source.Functions.GetDataToTable(sql);

            txtBox_mahd_CTHD.Text = tblCTHD.Rows[0].Field<string>(0).Trim();
            txtBox_makh_CTHD.Text = tblCTHD.Rows[0].Field<string>(1).Trim();
            dTP_ngaylap_CTHD.CustomFormat = "yyyy-MM-dd";
            dTP_ngaylap_CTHD.Text = tblCTHD.Rows[0].Field<DateTime>(2).ToString().Trim();
            txtBox_soluongban_CTHD.Text = tblCTHD.Rows[0].Field<Int32>(3).ToString().Trim();
            txtBox_giamgia_CTHD.Text = tblCTHD.Rows[0].Field<Int32>(4).ToString().Trim();
            txtBox_thanhtien_CTHD.Text = tblCTHD.Rows[0].Field<Int32>(5).ToString().Trim();
            txtBox_masp_CTHD.Text = tblCTHD.Rows[0].Field<string>(6).Trim();
        }

        private void Form_ChiTietHoaDon_Load(object sender, EventArgs e) // xử lí load form
        {
            SetFont_CTHD();
            Resetvalues_CTHD();
            set_Enable_ThemMoiKH();

            if (mode_chitiethoadon_CTDH)
            {
                LoadData_CTHD();
                this.ActiveControl = btn_quaylai_CTHD;
            }
            if (mode_themhoadon_CTDH)
            {
                set_Enable();
                this.ActiveControl = txtBox_mahd_CTHD;
            }
        }

        private void txtBox_masp_CTHD_TextChanged(object sender, EventArgs e) // xử lí khi có MASP
        {
            string sql = "SELECT TENSP, SOLUONGTON, GIA " +
                "FROM SANPHAM " +
                "WHERE MASP = '" + txtBox_masp_CTHD.Text.Trim().ToString() + "' ";
            DataTable tblSP = Source.Functions.GetDataToTable(sql);

            if (tblSP.Rows.Count != 0)
            {
                txtBox_tensp_CTHD.Text = tblSP.Rows[0].Field<string>(0);
                txtBox_slton_CTHD.Text = tblSP.Rows[0].Field<Int32>(1).ToString().Trim();
                txtBox_giaban_CTHD.Text = tblSP.Rows[0].Field<Int32>(2).ToString().Trim();
                soluongcu = Int32.Parse(tblSP.Rows[0].Field<Int32>(1).ToString().Trim());
            }
            else
            {
                txtBox_tensp_CTHD.Text = "";
                txtBox_slton_CTHD.Text = "";
                txtBox_giaban_CTHD.Text = "";
                soluongcu = 0;
            }
        }

        private void txtBox_makh_CTHD_TextChanged(object sender, EventArgs e) // xử lí khi có MAKH
        {
            if (!mode_themmoiKH | mode_chitiethoadon_CTDH)
            {
                string sql = "SELECT HO, TEN, NGSINH, SONHA, DUONG , PHUONG, QUAN , TPHO, DIENTHOAI " +
                    "FROM KHACHHANG " +
                    "WHERE MAKH = '" + txtBox_makh_CTHD.Text.Trim().ToString() + "' ";
                DataTable tblKH = Source.Functions.GetDataToTable(sql);

                if (tblKH.Rows.Count != 0)
                {
                    txtBox_ho_CTHD.Text = tblKH.Rows[0].Field<string>(0).Trim();
                    txtBox_ten_CTHD.Text = tblKH.Rows[0].Field<string>(1).Trim();
                    txtBox_sonha_CTHD.Text = tblKH.Rows[0].Field<string>(3).Trim();
                    txtBox_duong_CTHD.Text = tblKH.Rows[0].Field<string>(4).Trim();
                    txtBox_phuong_CTHD.Text = tblKH.Rows[0].Field<string>(5).Trim();
                    txtBox_quan_CTHD.Text = tblKH.Rows[0].Field<string>(6).Trim();
                    txtBox_thanhpho_CTHD.Text = tblKH.Rows[0].Field<string>(7).Trim();
                    txtBox_dienthoai_CTHD.Text = tblKH.Rows[0].Field<string>(8).Trim();

                    dTP_ngaysinh_CTHD.CustomFormat = "yyyy-MM-dd";
                    dTP_ngaysinh_CTHD.Text = tblKH.Rows[0].Field<DateTime>(2).ToString().Trim();
                }
                else
                {
                    txtBox_ho_CTHD.Text = "";
                    txtBox_ten_CTHD.Text = "";
                    txtBox_sonha_CTHD.Text = "";
                    txtBox_duong_CTHD.Text = "";
                    txtBox_phuong_CTHD.Text = "";
                    txtBox_quan_CTHD.Text = "";
                    txtBox_thanhpho_CTHD.Text = "";
                    txtBox_dienthoai_CTHD.Text = "";
                    dTP_ngaysinh_CTHD.CustomFormat = " ";
                }
            }
        }

        private void btn_quaylai_CTHD_Click(object sender, EventArgs e) // xử lí khi click vào nút quay lại
        {
            this.Close();
        }
     
        private bool is_enoughData() // kiểm tra có đủ data để tính auto tổng tiền hay k
        {
            // TH chưa nhập đầy đủ dữ liệu
            if (txtBox_giamgia_CTHD.Text.Trim().Length == 0 | txtBox_mahd_CTHD.Text.Trim().Length == 0 |
                dTP_ngaylap_CTHD.Text.Trim().Length == 0 | txtBox_masp_CTHD.Text.Trim().Length == 0 |
            txtBox_tensp_CTHD.Text.Trim().Length == 0 | txtBox_slton_CTHD.Text.Trim().Length == 0 |
            txtBox_giaban_CTHD.Text.Trim().Length == 0 | txtBox_soluongban_CTHD.Text.Trim().Length == 0 |
            txtBox_giamgia_CTHD.Text.Trim().Length == 0 | 
            txtBox_makh_CTHD.Text.Trim().Length == 0 | txtBox_ho_CTHD.Text.Trim().Length == 0 |
            txtBox_ten_CTHD.Text.Trim().Length == 0 | dTP_ngaysinh_CTHD.Text.Trim().Length == 0 |
            txtBox_sonha_CTHD.Text.Trim().Length == 0 | txtBox_duong_CTHD.Text.Trim().Length == 0 |
            txtBox_quan_CTHD.Text.Trim().Length == 0 | txtBox_thanhpho_CTHD.Text.Trim().Length == 0 |
            txtBox_dienthoai_CTHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            int slban = Int32.Parse(txtBox_soluongban_CTHD.Text.Trim().ToString());
            if (slban <= 0)
            {
                MessageBox.Show("Số lượng bán không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btn_luu_CTHD_Click(object sender, EventArgs e) // xử lí khi click vào nút lưu
        {
            // kiểm tra có nhập đầy đủ dữ liệu chưa         
            if (txtBox_giamgia_CTHD.Text.Trim().Length == 0 | txtBox_mahd_CTHD.Text.Trim().Length == 0 |
                dTP_ngaylap_CTHD.Text.Trim().Length == 0 | txtBox_masp_CTHD.Text.Trim().Length == 0 |
            txtBox_tensp_CTHD.Text.Trim().Length == 0 | txtBox_slton_CTHD.Text.Trim().Length == 0 |
            txtBox_giaban_CTHD.Text.Trim().Length == 0 | txtBox_soluongban_CTHD.Text.Trim().Length == 0 |
            txtBox_giamgia_CTHD.Text.Trim().Length == 0 | txtBox_thanhtien_CTHD.Text.Trim().Length == 0 |
            txtBox_makh_CTHD.Text.Trim().Length == 0 | txtBox_ho_CTHD.Text.Trim().Length == 0 |
            txtBox_ten_CTHD.Text.Trim().Length == 0 | dTP_ngaysinh_CTHD.Text.Trim().Length == 0 |
            txtBox_sonha_CTHD.Text.Trim().Length == 0 | txtBox_duong_CTHD.Text.Trim().Length == 0 |
            txtBox_quan_CTHD.Text.Trim().Length == 0 | txtBox_thanhpho_CTHD.Text.Trim().Length == 0 |
            txtBox_dienthoai_CTHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nhập số lượng bán sai
            int slban = Int32.Parse(txtBox_soluongban_CTHD.Text.Trim().ToString());
            if (slban <= 0)
            {
                MessageBox.Show("Số lượng bán không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //TH nếu MAHD đã tồn tại
            string sql = "SELECT MAHD " +
                "FROM " +
                "HOADON " +
                "WHERE MAHD = '" + txtBox_mahd_CTHD.Text.Trim().ToString() + "'";
            if (Source.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_mahd_CTHD.Focus();
                return;
            }     

            // TH nếu trong mode thêm mới KH
            if (mode_themmoiKH)
            {
                //TH nếu MAKH đã tồn tại
                sql = "SELECT MAKH " +
                    "FROM " +
                    "KHACHHANG " +
                    "WHERE MAKH = '" + txtBox_makh_CTHD.Text.Trim().ToString() + "'";
                if (Source.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBox_mahd_CTHD.Focus();
                    return;
                }
            }

            // TH nếu mode thêm mới KH thì xử lí thêm KH
            if (mode_themmoiKH)
            {
                sql = "INSERT INTO KHACHHANG " +
                "VALUES(N'" + txtBox_makh_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_ho_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_ten_CTHD.Text.Trim().ToString() +
                "',N'" + dTP_ngaysinh_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_sonha_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_duong_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_phuong_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_quan_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_thanhpho_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_dienthoai_CTHD.Text.Trim() + "')";
                Source.Functions.RunSQL(sql);
            }
                                           
            // xử lí thêm bảng HOADON
            sql = "INSERT INTO HOADON " +
                "VALUES(N'" + txtBox_mahd_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_makh_CTHD.Text.Trim().ToString() +
                "',N'" + dTP_ngaylap_CTHD.Text.Trim().ToString() +
                "',N'" + txtBox_thanhtien_CTHD.Text.Trim() + "')";          
            Source.Functions.RunSQL(sql);

            // xử lí thêm bảng CT_HOADON
            sql = "INSERT INTO CT_HOADON " +
                   "VALUES(N'" + txtBox_mahd_CTHD.Text.Trim().ToString() +
                   "',N'" + txtBox_masp_CTHD.Text.Trim().ToString() +
                   "',N'" + txtBox_soluongban_CTHD.Text.Trim().ToString() +
                   "',N'" + txtBox_giaban_CTHD.Text.Trim().ToString() +
                   "',N'" + txtBox_giamgia_CTHD.Text.Trim().ToString() +
                   "',N'" + txtBox_thanhtien_CTHD.Text.Trim() + "')";
            Source.Functions.RunSQL(sql);

            // xử lí cập nhật số lượng hàng
            int soluongban = Int32.Parse(txtBox_soluongban_CTHD.Text.Trim().ToString());
            String soluongmoi = (soluongcu - soluongban).ToString();
            sql = "UPDATE SANPHAM " +
                "SET SOLUONGTON = N'" + soluongmoi + "' " +
                "WHERE MASP = '" + txtBox_masp_CTHD.Text.Trim().ToString() + "'";
            Source.Functions.RunSQL(sql);       

            // thông báo thêm thành công
            MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // xử lí enable các nút         
            btn_luu_CTHD.Enabled = false;
            btn_autotongtien_CTHD.Enabled = false;
            btn_modeKH_CTHD.Enabled = false;
            is_themthanhcong = true;
            txtBox_slton_CTHD.Text = soluongmoi;
        }

        private void btn_modeKH_CTHD_Click(object sender, EventArgs e) // thay đổi mode chọn khách hàng đã có/thêm mới khách hàng
        {
            if (mode_themmoiKH)
            {
                mode_themmoiKH = false;
                btn_modeKH_CTHD.Text = "Thêm Khách Hàng Mới";
                Resetvalues_modeThemKH_CTHD();
                set_Enable_ChonKHCu();
            }
            else
            {
                mode_themmoiKH = true;
                btn_modeKH_CTHD.Text = "Chọn Khách Hàng Cũ";
                Resetvalues_modeThemKH_CTHD();
                set_Enable_ThemMoiKH();
            }
        }

        private void btn_autotongtien_CTHD_Click(object sender, EventArgs e) //xử lí tính auto tổng tiền
        {
            int slban = Int32.Parse(txtBox_soluongban_CTHD.Text.Trim().ToString());
            int slton = Int32.Parse(txtBox_slton_CTHD.Text.Trim().ToString());
            if (is_enoughData())
            {
                if (slban <= slton)
                {
                    int giaban = Int32.Parse(txtBox_giaban_CTHD.Text.Trim().ToString());
                    int giamgia = giamgia = Int32.Parse(txtBox_giamgia_CTHD.Text.Trim().ToString());

                    float tongtien = (slban * (giaban - giamgia));
                    txtBox_thanhtien_CTHD.Text = ((int)tongtien).ToString();
                }
                else
                {
                    MessageBox.Show("Không Đủ Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBox_soluongban_CTHD.Text = "";
                    txtBox_soluongban_CTHD.Focus();
                }
            }
        }

        private void Form_ChiTietHoaDon_FormClosed(object sender, FormClosedEventArgs e) // xử lí khi đóng form
        {
            mode_chitiethoadon_CTDH = false;
            mode_themhoadon_CTDH = false;         
        }
    }
}
