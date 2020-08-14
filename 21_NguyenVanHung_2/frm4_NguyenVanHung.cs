using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _21_NguyenVanHung_2
{
    public partial class frm4_NguyenVanHung : Form
    {
        public frm4_NguyenVanHung()
        {
            InitializeComponent();
        }

        private void frm4_NguyenVanHung_Load(object sender, EventArgs e)
        {
            load_DuLieu();
            load_CboMATS();
            btnThem.Enabled = false;

        }
        KetNoiCSDL ketnoi = new KetNoiCSDL();
        public void load_DuLieu()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.load_DuLieu("Select * from TS_SUACHUA");
            Grid_DMTS.DataSource = dta;
            hienThi();
        }
        public void hienThi()
        {
            txtMaSC.DataBindings.Clear();
            txtMaSC.DataBindings.Add("Text", Grid_DMTS.DataSource, "MASC");

            cboMaTS.DataBindings.Clear();
            cboMaTS.DataBindings.Add("Text", Grid_DMTS.DataSource, "MATS");

            txtNYC.DataBindings.Clear();
            txtNYC.DataBindings.Add("Text", Grid_DMTS.DataSource, "NGAYYC");

            txtNgayNhan.DataBindings.Clear();
            txtNgayNhan.DataBindings.Add("Text", Grid_DMTS.DataSource, "NGAYNHAN");

            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("Text", Grid_DMTS.DataSource, "TINHTRANG");

        }
        public void load_CboMATS()
        {
            ketnoi.ketNoi_duLieu();
            DataTable dt = ketnoi.load_DuLieu("Select MATS from DMTAISAN");
            cboMaTS.DataSource = dt;
            cboMaTS.DisplayMember = "MATS";
            cboMaTS.ValueMember = "MATS";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaSC.Text = "";
            txtNgayNhan.Text = "";
            txtNYC.Text = "";
            txtTinhTrang.Text = "";
            cboMaTS.Text = "";
            txtMaSC.Focus();
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql1, sql2;
            sql1 = "Insert Into TS_SUACHUA (MASC,MATS,NGAYYC,NGAYNHAN,TINHTRANG)";
            sql2 = sql1 + "Values('" + txtMaSC.Text + "','" + cboMaTS.Text + "','" + txtNYC.Text + "','" + txtNgayNhan.Text + "','" + txtTinhTrang.Text + "')";
            ketnoi.Execute(sql2);
            load_DuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "UPDATE TS_SUACHUA set MATS = '" + cboMaTS.Text + "', NGAYYC = '" + txtNYC.Text + "', NGAYNHAN = '" + txtNgayNhan.Text + "', TINHTRANG = '" + txtTinhTrang.Text + "' where MASC = '" + txtMaSC.Text + "'";
            ketnoi.Execute(sql);
            load_DuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn xoá không?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                string sql;
                sql = "Delete TS_SUACHUA where MASC = '" + txtMaSC.Text + "'";
                ketnoi.Execute(sql);
                load_DuLieu();
            }
        }
    }
}
