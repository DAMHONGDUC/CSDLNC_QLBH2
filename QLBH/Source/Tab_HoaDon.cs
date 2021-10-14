using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QLBH
{
    public partial class Form_Main : Form
    {
        Form_Loading form_loading = new Form_Loading();
        private void setFont_HD() // set Font cho các textBox 
        {
            txtBox_mahd_HD.Font = new Font("Time New Roman", 12);
            txtBox_makh_HD.Font = new Font("Time New Roman", 12);
            txtBox_tongtien_HD.Font = new Font("Time New Roman", 12);
            dTP_ngaylap_HD.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_HD() // reset giá trị cho các mục 
        {
            dTP_ngaylap_HD.CustomFormat = " ";
            txtBox_mahd_HD.Text = "";
            txtBox_makh_HD.Text = "";
            txtBox_tongtien_HD.Text = "";        
        }
      
        private void LoadData_HoaDon() // tải dữ liệu vào DataGridView
        {          
            string sql = "SELECT MAHD, MAKH_HD, NGAYLAP, TONGTIEN FROM HOADON ";
            tblHD = Source.Functions.GetDataToTable(sql);
            dgv_HD.DataSource = tblHD;

            // set Font cho tên cột
            dgv_HD.Font = new Font("Time New Roman", 13);
            dgv_HD.Columns[0].HeaderText = "Mã Hoá Đơn";
            dgv_HD.Columns[1].HeaderText = "Mã Khách Hàng";
            dgv_HD.Columns[2].HeaderText = "Ngày Lập";
            dgv_HD.Columns[3].HeaderText = "Tổng Tiền";      

            // set Font cho dữ liệu hiển thị trong cột
            dgv_HD.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_HD.Columns[0].Width = 220;
            dgv_HD.Columns[1].Width = 220;
            dgv_HD.Columns[2].Width = 220;
            dgv_HD.Columns[3].Width = 220;         

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_HD.AllowUserToAddRows = false;
            dgv_HD.EditMode = DataGridViewEditMode.EditProgrammatically;

            form_loading.Close_Form();
        }

        private void tabHoaDon_Enter(object sender, EventArgs e) // tải dữ liệu khi vào tab
        {           
            Thread t = new Thread(() =>
            {              
                form_loading.StartPosition = FormStartPosition.CenterParent;
                form_loading.ShowDialog();                
            });

            setFont_HD();
            ResetValues_HD();
            

            // show form loading         
            t.Start();       
            
            LoadData_HoaDon();
            btn_xemchitiet_HD.Enabled = false;
        }

        private void dgv_HD_Click(object sender, EventArgs e) // xử lí khi click vào dataGridView
        {
            btn_xemchitiet_HD.Enabled = true;
            //Nếu không có dữ liệu
            if (tblHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các txtBox     
            dTP_ngaylap_HD.CustomFormat = "yyyy-MM-dd";
            txtBox_mahd_HD.Text = dgv_HD.CurrentRow.Cells["MAHD"].Value.ToString().Trim();
            txtBox_makh_HD.Text = dgv_HD.CurrentRow.Cells["MAKH_HD"].Value.ToString().Trim();
            dTP_ngaylap_HD.Text = dgv_HD.CurrentRow.Cells["NGAYLAP"].Value.ToString().Trim();
            txtBox_tongtien_HD.Text = dgv_HD.CurrentRow.Cells["TONGTIEN"].Value.ToString().Trim();
        }

        private void btn_xemchitiet_HD_Click(object sender, EventArgs e) // xử lí khi click vào nút xem chi tiết
        {

            // load form chi tiết hoá đơn lên
            Form_ChiTietHoaDon form_chitiethoadon = new Form_ChiTietHoaDon();
            form_chitiethoadon.StartPosition = FormStartPosition.CenterParent;
            form_chitiethoadon.mode_chitiethoadon_CTDH = true;
            form_chitiethoadon.mahd_CTHD = txtBox_mahd_HD.Text.Trim().ToString();
            form_chitiethoadon.ShowDialog();
        }

        private void btn_them_HD_Click(object sender, EventArgs e) // xử lí khi click vào nút thêm
        {
            // load form thêm hoá đơn lên
            Form_ChiTietHoaDon form_chitiethoadon = new Form_ChiTietHoaDon();
            form_chitiethoadon.StartPosition = FormStartPosition.CenterParent;
            form_chitiethoadon.mode_themhoadon_CTDH = true;
            form_chitiethoadon.ShowDialog();

            // nếu có thêm thì load lại dữ liệu vào dataGridView
            if (form_chitiethoadon.is_themthanhcong)
            {
                Thread t = new Thread(() =>
                {
                    form_loading.StartPosition = FormStartPosition.CenterParent;
                    form_loading.ShowDialog();
                });
                form_chitiethoadon.is_themthanhcong = false;

                // show form loading         
                t.Start();

                LoadData_HoaDon();
                ResetValues_HD();
                btn_xemchitiet_HD.Enabled = false;
            }
        }

        private void btn_huy_HD_Click(object sender, EventArgs e) // xử khi khi click nút huỷ
        {
            ResetValues_HD();
            btn_xemchitiet_HD.Enabled = false;
        }
    }
}
