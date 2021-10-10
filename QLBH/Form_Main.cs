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
    public partial class Form_Main : Form
    {
        DataTable tblHD; // Chứa dữ liệu bảng HOADON
        DataTable tblDThu; // Chứa dữ liệu thống kê doanh thu
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //Mở kết nối
            Source.Functions.Connect();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Đóng kết nối
            Source.Functions.Disconnect();

            //Thoát
            Application.Exit();
        }

        
    }
}
