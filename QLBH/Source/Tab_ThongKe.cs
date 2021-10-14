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
        Form_Loading form_loading2 = new Form_Loading();
        String[] year = { "2020", "2021" };
        String currYear = "2021";
        private void setFont_DThu() // set Font cho các textBox 
        {
            txtBox_thang_TK.Font = new Font("Time New Roman", 12);
            txtBox_slhoadon_TK.Font = new Font("Time New Roman", 12);
            txtBox_doanhthu_TK.Font = new Font("Time New Roman", 12);
            txtBox_loinhuan_TK.Font = new Font("Time New Roman", 12);
            txtBox_slhangdaban_TK.Font = new Font("Time New Roman", 12);
            cbBox_nam_TK.Font = new Font("Time New Roman", 12);           
        }

        private void ResetValues_DThu() // reset giá trị cho các mục 
        {
            txtBox_thang_TK.Text = "";
            txtBox_slhoadon_TK.Text = "";
            txtBox_doanhthu_TK.Text = "";
            txtBox_loinhuan_TK.Text = "";
            txtBox_slhangdaban_TK.Text = "";
            cbBox_nam_TK.Text = year[year.Length - 1];
        }

        private void getData_DThu_WithYear() // lấy dữ liệu đổ vào bảng
        {
            currYear = cbBox_nam_TK.Text.Trim().ToString();

            tblDThu = new DataTable();

            // add các cột
            tblDThu.Columns.Add("THANG", typeof(string));
            tblDThu.Columns.Add("SLHOADON", typeof(string));
            tblDThu.Columns.Add("SLHANGDABAN", typeof(string));
            tblDThu.Columns.Add("DOANHTHU", typeof(string));
            tblDThu.Columns.Add("LOINHUAN", typeof(string));

            for (int i = 1; i <= 12; i++)
            {
                String sql = "";
                String doanhthu = "0";
                String sl_hangdaban = "0";

                // lấy số lượng hoá đơn theo tháng
                sql = "SELECT COUNT(HD.MAHD) " +
                    "FROM HOADON HD, CT_HOADON CTHD " +
                    "WHERE HD.MAHD = CTHD.MAHD_CT " +
                    "AND YEAR(HD.NGAYLAP) = '" + currYear + "' " +
                    "AND MONTH(HD.NGAYLAP) = '" + i + "'";

                String sl_hoadon = Source.Functions.GetFieldValues(sql);
                if (sl_hoadon.Length == 0)
                    sl_hoadon = "0";

                // lấy doanh thu, số lượng hàng đã bán, số lượng hoá đơn
                sql = "SELECT SUM(CAST(HD.TONGTIEN AS BIGINT)) , SUM(CAST(CTHD.SOLUONG AS BIGINT)) " +
                    "FROM HOADON HD, CT_HOADON CTHD " +
                    "WHERE HD.MAHD = CTHD.MAHD_CT " +
                    "AND YEAR(HD.NGAYLAP) = '" + currYear + "' " +
                    "AND MONTH(HD.NGAYLAP) = '" + i + "'";
                DataTable tbl = Source.Functions.GetDataToTable(sql);
                if (!sl_hoadon.Equals("0"))
                {
                    doanhthu = tbl.Rows[0].Field<Int64>(0).ToString().Trim();
                    sl_hangdaban = tbl.Rows[0].Field<Int64>(1).ToString().Trim();
                }

                // lấy tổng chi phí bỏ ra 
                sql = "SELECT SUM(CAST((SP.GIA*CTHD.SOLUONG) AS BIGINT)) " +
                    "FROM CT_HOADON CTHD, SANPHAM SP, HOADON HD " +
                    "WHERE CTHD.MASP_CT = SP.MASP " +
                    "AND CTHD.MAHD_CT = HD.MAHD " +
                    "AND YEAR(HD.NGAYLAP) = '" + currYear + "' " +
                    "AND MONTH(HD.NGAYLAP) = '" + i + "'";
                String tongchiphi = Source.Functions.GetFieldValues(sql);
                if (tongchiphi.Length == 0)
                    tongchiphi = "0";

                tblDThu.Rows.Add(new object[] { i.ToString(), sl_hoadon, sl_hangdaban, doanhthu, (Int64.Parse(doanhthu) - Int64.Parse(tongchiphi)).ToString() });
            }
            dgv_DThu.DataSource = tblDThu;
        }

        private void LoadData_DThu() // tải dữ liệu cho dataGridView
        {
            getData_DThu_WithYear();

            // set Font cho tên cột
            dgv_DThu.Font = new Font("Time New Roman", 13);
            dgv_DThu.Columns[0].HeaderText = "Tháng";
            dgv_DThu.Columns[1].HeaderText = "SL Hoá Đơn";
            dgv_DThu.Columns[2].HeaderText = "SL Hàng Đã Bán";
            dgv_DThu.Columns[3].HeaderText = "Doanh Thu";
            dgv_DThu.Columns[4].HeaderText = "Lợi Nhuận";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_DThu.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_DThu.Columns[0].Width = 175;
            dgv_DThu.Columns[1].Width = 180;
            dgv_DThu.Columns[2].Width = 180;
            dgv_DThu.Columns[3].Width = 180;
            dgv_DThu.Columns[4].Width = 180;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_DThu.AllowUserToAddRows = false;
            dgv_DThu.EditMode = DataGridViewEditMode.EditProgrammatically;

            form_loading2.Close_Form();
        }
        private void dgv_DTh_Click(object sender, EventArgs e) // khi click vào dataGridView
        {
            //Nếu không có dữ liệu
            if (tblDThu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục 
            txtBox_thang_TK.Text = dgv_DThu.CurrentRow.Cells["THANG"].Value.ToString();
            txtBox_slhoadon_TK.Text = dgv_DThu.CurrentRow.Cells["SLHOADON"].Value.ToString();
            txtBox_slhangdaban_TK.Text = dgv_DThu.CurrentRow.Cells["SLHANGDABAN"].Value.ToString();
            txtBox_doanhthu_TK.Text = dgv_DThu.CurrentRow.Cells["DOANHTHU"].Value.ToString();
            txtBox_loinhuan_TK.Text = dgv_DThu.CurrentRow.Cells["LOINHUAN"].Value.ToString();
            cbBox_nam_TK.Text = currYear;
        }

        private void tabThongKe_Enter(object sender, EventArgs e) // tải dữ liệu cho tab
        {
            // set giá trị cho comboBox         
            for (int i = 0; i < year.Length; i++)
                cbBox_nam_TK.Items.Add(year[i]);

            setFont_DThu();
            ResetValues_DThu();

            Thread t = new Thread(() =>
            {
                form_loading2.StartPosition = FormStartPosition.CenterParent;
                form_loading2.ShowDialog();
            });

            // show form loading         
            t.Start();

            LoadData_DThu();
        }

        private void btn_search_TK_Click(object sender, EventArgs e) // xử lí thống kê theo năm
        {
            // TH nếu chưa chọn năm
            if (cbBox_nam_TK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Thread t = new Thread(() =>
            {
                form_loading2.StartPosition = FormStartPosition.CenterParent;
                form_loading2.ShowDialog();
            });

            // show form loading         
            t.Start();

            LoadData_DThu();
        }

        private void cbBox_nam_TK_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Font f = cbBox_nam_TK.Font;
            int yOffset = 50;

            if ((e.State & DrawItemState.Focus) == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                e.Graphics.DrawString(cbBox_nam_TK.Items[e.Index].ToString(), f, Brushes.Black,
                                      new Point(e.Bounds.X, e.Bounds.Y + yOffset));
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
                e.Graphics.DrawString(cbBox_nam_TK.Items[e.Index].ToString(), f, Brushes.White,
                                      new Point(e.Bounds.X, e.Bounds.Y + yOffset));
            }
        }
    }
}
