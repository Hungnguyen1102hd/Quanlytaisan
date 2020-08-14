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
    public partial class frm6_NguyenVanHung : Form
    {
        public frm6_NguyenVanHung()
        {
            InitializeComponent();
        }
        KetNoiCSDL ketnoi = new KetNoiCSDL();
        private void frm6_NguyenVanHung_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ketnoi.load_DuLieu("select * from TS_SUACHUA");
            BAOCAOTAISAN bc = new BAOCAOTAISAN();
            bc.SetDataSource(dt);
            crs_BaoCao.ReportSource = bc;
        }
    }
}
