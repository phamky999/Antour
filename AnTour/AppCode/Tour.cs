using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AnTour.AppCode
{
    public class Tour
    {

        #region Phương thức thêm mới tour
        public static void Tour_Insert(string tentour, string urlimage, string gioithieu, string diadiem, int songaytour, int slkhachtoida, float dongia, string ngaytao, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("pro_InsertTour");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tentour", tentour);
            cmd.Parameters.AddWithValue("@urlimage", urlimage);
            cmd.Parameters.AddWithValue("@gioithieu", gioithieu);
            cmd.Parameters.AddWithValue("@diadiem", diadiem);
            cmd.Parameters.AddWithValue("@songaytour", songaytour);
            cmd.Parameters.AddWithValue("@slkhachtoida", slkhachtoida);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả Tour

        public static DataTable List_Tour()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TOUR WHERE trangthai = 1");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách 6 Tour mới nhất

        public static DataTable ListTour_New()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP(6) * FROM dbo.TOUR WHERE trangthai=1 ORDER BY ngaytao DESC");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin Tour
        public static void Tour_Update(int matour, string tentour, string urlimage, string gioithieu, string diadiem, int songaytour, int slkhachtoida, float dongia, string ngaytao, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("pro_UpdateTour");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@matour", matour);
            cmd.Parameters.AddWithValue("@tentour", tentour);
            cmd.Parameters.AddWithValue("@urlimage", urlimage);
            cmd.Parameters.AddWithValue("@gioithieu", gioithieu);
            cmd.Parameters.AddWithValue("@diadiem", diadiem);
            cmd.Parameters.AddWithValue("@songaytour", songaytour);
            cmd.Parameters.AddWithValue("@slkhachtoida", slkhachtoida);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region  Phương thức chỉnh sửa trang thai
        public static void Tour_UpdateTT(int matour, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("UPDATE dbo.TOUR SET trangthai = " + trangthai + " WHERE ma = " + matour + "");
            cmd.CommandType = CommandType.Text;
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra thông tin Tour theo id Tour
        public static DataTable Thongtin_Tour_by_id(string ma)
        {
            SqlCommand cmd = new SqlCommand("pro_selectTourbyId");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            return SQLDatabase.GetData(cmd);
        }
        #endregion




        #region Lấy danh sách sản phẩm theo mã danh mục - chỉ 3 sản phẩm đầu
        //public static DataTable Thongtin_Sanpham_by_madm(string MaDM)
        //{
        //    OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_madm");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@MaDM", MaDM);
        //    return SQLDatabase.GetData(cmd);
        //}

        //public static DataTable Thongtin_Sanpham_by_madm_tatca(string MaDM)
        //{
        //    OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_madm_tatca");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@MaDM", MaDM);
        //    return SQLDatabase.GetData(cmd);
        //}
        #endregion

        #region Phương thức xóa sản phẩm theo mã sản phẩm truyền vào
        //public static void Sanpham_Delete(string masp)
        //{
        //    OleDbCommand cmd = new OleDbCommand("sanpham_delete");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@masp", masp);
        //    SQLDatabase.ExecuteNoneQuery(cmd);
        //}
        #endregion


        #region Lấy danh sách sản phẩm theo từ khóa tìm kiếm: sẽ tìm theo tên hoặc mã sản phẩm
        //public static DataTable Thongtin_Sanpham_by_tukhoa(string tukhoa)
        //{
        //    OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_tukhoa");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@TuKhoa", tukhoa);
        //    return SQLDatabase.GetData(cmd);
        //}
        #endregion

        #region Lấy danh sách sản phẩm theo từ khóa tìm kiếm: 
        public static DataTable Thongtin_Tour_by_tukhoa(string tukhoa)
        {
            /*
             */
           
            SqlCommand cmd = new SqlCommand("EXEC dbo.thongtin_Tour_by_tukhoa @TuKhoa = N'"+tukhoa+"'");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

    }
}