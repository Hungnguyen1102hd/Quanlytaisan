using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _21_NguyenVanHung_2
{
    class KetNoiCSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;
        public void ketNoi_duLieu()
        {
            string strKetNoi = @"Data Source= LAPTOP-TV2ACT72;Initial Catalog=n21_NguyenVanHung_2;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
        public void huy_ketNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataTable load_DuLieu(string sql)
        {
            ketNoi_duLieu();
            ada = new SqlDataAdapter(sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void Execute(string sql)
        {
            ketNoi_duLieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            huy_ketNoi();
        }
    }
}

