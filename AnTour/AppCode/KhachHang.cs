using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace AnTour.AppCode
{

    public class KhachHang
    {
        #region Lấy thông tin KH theo tài khoản và mật khẩu
        public static DataTable SelectKHByUserPass(string tk, string mk)
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.pro_SelectKHByUserPass @user = N'" + tk + "', @pass = N'" + mk + "' ");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }

        #endregion

        #region Phương thức thêm mới Khachang vào Khachang
        public static void Khachang_Insert(string tenkh, string urlimage, int gioitinh, string cmtnd, string sdt, string email, string diachi, string tendangnhap, string matkhau, int quyen)
        {
            SqlCommand cmd = new SqlCommand("pro_InsertKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@urlimage", urlimage);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@cmtnd", cmtnd);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@quyen", quyen);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang theo CMTND

        public static DataTable Thongtin_Khachhang_by_CMTND(string cmtnd)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectKHByCMTND");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cmtnd", cmtnd);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang theo sdt

        public static DataTable Thongtin_Khachhang_by_Sdt(string sdt)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectKHBySDT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sdt", sdt);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang theo email

        public static DataTable Thongtin_Khachhang_by_Email(string email)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectKHByEmail");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang theo tai khoan

        public static DataTable Thongtin_Khachhang_by_User(string user)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectKHByUser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lay gioi tinh
        public static DataTable Thongtin_GioiTinh()
        {
            SqlCommand cmd = new SqlCommand("pro_selectGioiTinh");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả KhachHang
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Khachhang()
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.pro_selectListKH");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa PROFILE

        public static void KH_UpdateProfile(int ma, string tenkh, string url, int gioitinh, string cmtnd, string sdt, string email, string diachi, string tendangnhap)
        {
            SqlCommand cmd = new SqlCommand("pro_KHUpdate");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@urlimage", url);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@cmtnd", cmtnd);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang theo mã KH
        public static DataTable Thongtin_Khachhang_by_makh(int makh)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectKHById");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", makh);
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region  Phương thức chỉnh sửa mật khẩu khách hàng
        public static void Khachang_UpdatePass(int makh, string tentk, string matkhau)
        {
            SqlCommand cmd = new SqlCommand("pro_KHUpdatePass");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", makh);
            cmd.Parameters.AddWithValue("@tendangnhap", tentk);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion


    }

}