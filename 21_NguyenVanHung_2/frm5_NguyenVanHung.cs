using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _21_NguyenVanHung_2
{
    public partial class frm5_NguyenVanHung : Form
    {
        public frm5_NguyenVanHung()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm5_NguyenVanHung_Load(object sender, EventArgs e)
        {
            load_CboMaDV();
        }
        public void load_CboMaDV()
        {
            ketnoi.ketNoi_duLieu();
            DataTable dt = ketnoi.load_DuLieu("Select DVQLY from LOAITAISAN");
            cboMaDV.DataSource = dt;
            cboMaDV.DisplayMember = "DVQLY";
            cboMaDV.ValueMember = "DVQLY";
        }
        KetNoiCSDL ketnoi = new KetNoiCSDL();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql;
            if(radDV.Checked == true)
            {
                sql = "Select * from LOAITAISAN where DVQLY like '" + cboMaDV.Items + "'";
                dt = ketnoi.load_DuLieu(sql);

            }
            else if(radTenLoai.Checked == true)
            {
                sql = "Select * from LOAITAISAN where TENLOAI like '" + txtTenLoai.Text + "'";
                dt = ketnoi.load_DuLieu(sql);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn trường tìm kiếm");
            }    
            grid_KetQua.DataSource = dt;
        }
    }
}
