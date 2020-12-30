using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class HangHoaDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public HangHoaDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<HangHoaDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [dbo].[LOAIHANG].[TenLoaiHang], [dbo].[NHASANXUAT].[TenNhaSanXuat], [dbo].[HANGHOA].[MaHangHoa], [dbo].[HANGHOA].[MoTa], [dbo].[HANGHOA].[Gia], [dbo].[HANGHOA].[ThoiGianBaoHanh], [dbo].[HANGHOA].[Ten]";
            query += "FROM [dbo].[HANGHOA], [dbo].[LOAIHANG], [dbo].[NHASANXUAT]";
            query += "WHERE ([dbo].[HANGHOA].[MaNhaSanXuat] = [dbo].[NHASANXUAT].[MaNhaSanXuat])";
            query += "AND ([dbo].[HANGHOA].[MaLoaiHang] = [dbo].[LOAIHANG].[MaLoaiHang])";

           /* query += "SELECT [MaHangHoa], [Gia], [MoTa], [ThoiGianBaoHanh]";
            query += "FROM [dbo].[HANGHOA]";*/
           
            List<HangHoaDTO> lsHangHoa = new List<HangHoaDTO>();
            List<LoaiHangDTO> lsLoaiHang = new List<LoaiHangDTO>();
            List<NSXDTO> lsNSX = new List<NSXDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
      
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HangHoaDTO hanghoa = new HangHoaDTO();
                                hanghoa.MAHANGHOA = reader["MaHangHoa"].ToString();
                                hanghoa.Mota = reader["MoTa"].ToString();   
                                hanghoa.GIA = reader["Gia"].ToString();
                                hanghoa.THOIGIANBAOHANH = reader["ThoiGianBaoHanh"].ToString();
                                hanghoa.MANHASANXUAT = reader["TenNhaSanXuat"].ToString();
                                hanghoa.MALOAIHANG = reader["TenLoaiHang"].ToString();
                                hanghoa.TEN = reader["Ten"].ToString();
                                lsHangHoa.Add(hanghoa);

                               /* LoaiHangDTO loaihang = new LoaiHangDTO();
                                loaihang.TENLOAIHANG = reader["TenLoaiHang"].ToString();
                                lsLoaiHang.Add(loaihang);*/


                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsHangHoa;
        }

        public List<HangHoaDTO> timkiem(string key)
        {
            string query = string.Empty;
            query += " SELECT [dbo].[HANGHOA].[MaHangHoa], [dbo].[HANGHOA].[Ten], [dbo].[HANGHOA].[Gia], [dbo].[HANGHOA].[ThoiGianBaoHanh]";
            query += " FROM [dbo].[HANGHOA], [dbo].[LOAIHANG]";
            query += " WHERE ([dbo].[HANGHOA].[MaLoaiHang] = [dbo].[LOAIHANG].[MaLoaiHang])";
            query += " AND ([dbo].[LOAIHANG].[TenLoaiHang] LIKE CONCAT('%',@key,'%'))";

            List<HangHoaDTO> lshanghoa = new List<HangHoaDTO>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@key", key);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HangHoaDTO hh = new HangHoaDTO();
                                hh.MAHANGHOA = reader["MaHangHoa"].ToString();
                                hh.TEN = reader["Ten"].ToString();
                                hh.GIA = reader["Gia"].ToString();
                                hh.THOIGIANBAOHANH = reader["ThoiGianBaoHanh"].ToString();
                                lshanghoa.Add(hh);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }

                    catch (Exception)

                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lshanghoa;
        }
    }
}
