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

    public class NhanVien
    {
        #region Lấy thông tin nhân viên theo tài khoản và mật khẩu
        public static DataTable SelectNVByUserPass(string tk, string mk)
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.pro_SelectNVByUserPass @user = N'" + tk + "', @pass = N'" + mk + "' ");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }

        #endregion

        #region lay ra danh sach nhan vien:
        public static DataTable Thongtin_NhanVien()
        {
            SqlCommand cmd = new SqlCommand("dbo.pro_selectListNV");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin nhân viên theo id

        public static DataTable Thongtin_NV_by_id(int manv)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectNVById");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", manv);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức lấy ra thông tin nhân viên theo id

        public static DataTable Thongtin_NV_by_idnv(string manv)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectNVById");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", manv);
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Phương thức lấy ra danh sách tất cả NV theo CMTND

        public static DataTable Thongtin_NV_by_CMTND(string cmtnd)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectNVByCMTND");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cmtnd", cmtnd);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả NV theo sdt

        public static DataTable Thongtin_NV_by_Sdt(string sdt)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectNVBySDT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sdt", sdt);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả NV theo email

        public static DataTable Thongtin_NV_by_Email(string email)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectNVByEmail");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả NV theo tai khoan

        public static DataTable Thongtin_NV_by_User(string user)
        {
            SqlCommand cmd = new SqlCommand("pro_SelectNVByUser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức thêm mới Nhanvien vào bảng Nhanvien
        public static void Nhanvien_Inser(string tennv, string url, int gioitinh, string cmtnd, string sdt, string email, string diachi, string tendangnhap, string matkhau, int quyen, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("dbo.pro_InsertNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@urlimage", url);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@cmtnd", cmtnd);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@quyen", quyen);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region lấy quyền 
        public static DataTable Thongtin_Quyen()
        {
            SqlCommand cmd = new SqlCommand("pro_SelectQuyen");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lay trạng thái nhân viên
        public static DataTable Thongtin_TrangThaiNV()
        {
            SqlCommand cmd = new SqlCommand("pro_SelectTTNV");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa QUYỀN , TRẠNG THÁI
        public static void NV_AdminUpdate(int ma, int quyen, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("pro_AdminUpdateNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@quyen", quyen);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region  Phương thức chỉnh sửa PROFILE

        public static void NV_UpdateProfile(int ma, string tennv, string url, int gioitinh, string cmtnd, string sdt, string email, string diachi, string tendangnhap)
        {
            SqlCommand cmd = new SqlCommand("pro_UseUpdate");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@tennv", tennv);
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

        #region  Phương thức chỉnh sửa password

        public static void NV_UpdatePass(int ma, string tendangnhap, string matkhau)
        {
            SqlCommand cmd = new SqlCommand("pro_UseUpdatePass");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion
    }

}