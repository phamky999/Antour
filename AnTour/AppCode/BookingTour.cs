using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AnTour.AppCode
{
    public class BookingTour
    {

        #region Phương thức thêm mới phieu dat kh
        //
        public static void BookingTour_Insert(int makh ,int matour ,string ngaydat , string checkin ,int slkhach , int sltreem , int trangthai)
        {
            SqlCommand cmd = new SqlCommand("pro_InsertPhieuDatKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@matour", matour);
            cmd.Parameters.AddWithValue("@ngaydat", ngaydat);
            cmd.Parameters.AddWithValue("@checkin", checkin);
            cmd.Parameters.AddWithValue("@slkhach", slkhach);
            cmd.Parameters.AddWithValue("@sltreem", sltreem);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới phieu dat nv
        //
        public static void BookingTour_Insert_NV(int manv, int matour, string ngaydat, string checkin, int slkhach, int sltreem, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("pro_InsertPhieuDatNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@matour", matour);
            cmd.Parameters.AddWithValue("@ngaydat", ngaydat);
            cmd.Parameters.AddWithValue("@checkin", checkin);
            cmd.Parameters.AddWithValue("@slkhach", slkhach);
            cmd.Parameters.AddWithValue("@sltreem", sltreem);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra phiếu đặt theo id khách hàng
        public static DataTable Thongtin_Phieu_by_idKH(string ma)
        {
            SqlCommand cmd = new SqlCommand("pro_selectPhieuDatKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", ma);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra phiếu đặt theo id nhân viên 
        public static DataTable Thongtin_Phieu_by_idNV(string ma)
        {
            SqlCommand cmd = new SqlCommand("pro_selectPhieuDatNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", ma);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra phiếu đặt theo id phiếu
        public static DataTable Thongtin_PhieuKH_by_id(string ma)
        {
            SqlCommand cmd = new SqlCommand("pro_selectPhieuDatKH_byIDPhieu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maphieu", ma);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable Thongtin_PhieuNV_by_id(string ma)
        {
            SqlCommand cmd = new SqlCommand("pro_selectPhieuDatNV_byIDPhieu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maphieu", ma);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra list phiếu đặt  khách hàng
        public static DataTable Thongtin_ListPhieuKH()
        {
            SqlCommand cmd = new SqlCommand("pro_selectListPhieuDatKH");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra list phiếu đặt  nv
        public static DataTable Thongtin_ListPhieuNV()
        {
            SqlCommand cmd = new SqlCommand("pro_selectListPhieuDatNV");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Phương thức lấy ra trang thai phiếu đặt theo id phiếu
        public static DataTable Thongtin_TTPhieuKH_by_id(string ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.PHIEUDAT.trangthai FROM dbo.PHIEUDAT WHERE maphieu = "+ ma);
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable Thongtin_TTPhieuNV_by_id(string ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.PHIEUDAT_NV.trangthai FROM dbo.PHIEUDAT_NV WHERE maphieu= "+ma);
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Phương thức lấy ra thong tin phiếu đặt theo id phiếu
        public static DataTable Thongtin_ThongTinPhieuKH_by_id(string ma)
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.pro_SelectPDKHByid @ma = " + ma);
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable Thongtin_ThongTinPhieuNV_by_id(string ma)
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.pro_SelectPDNVByid @ma = " + ma);
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region  Phương thức chỉnh sửa thông tin PHIẾU theo id phiếu
        public static void PhieuKH_Update(int ma,  string checkin, int slkhach, int sltreem)
        {
            SqlCommand cmd = new SqlCommand("pro_updatePDKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@checkin", checkin);
            cmd.Parameters.AddWithValue("@slkhach", slkhach);
            cmd.Parameters.AddWithValue("@sltreem", sltreem);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void PhieuNV_Update(int ma, string checkin, int slkhach, int sltreem)
        {
            SqlCommand cmd = new SqlCommand("pro_updatePDNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@checkin", checkin);
            cmd.Parameters.AddWithValue("@slkhach", slkhach);
            cmd.Parameters.AddWithValue("@sltreem", sltreem);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        #endregion

        #region Phương thức update trang thai
        //
        public static void BookingTourKH_Update(int maphieu, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("pro_updateTTPhieu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", maphieu);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void BookingTourNV_Update(int maphieu, int trangthai)
        {
            SqlCommand cmd = new SqlCommand("pro_updateTTPhieuNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", maphieu);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức update NGAYDAT
        //
        public static void BookingTourKH_UpdateNgDat(int maphieu, string ngaydat)
        {
            SqlCommand cmd = new SqlCommand("pro_UpdateNgayDat");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", maphieu);
            cmd.Parameters.AddWithValue("@ngaydat", ngaydat);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void BookingTourNV_UpdateNgDat(int maphieu, string ngaydat)
        {
            SqlCommand cmd = new SqlCommand("pro_UpdateNgayDatNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", maphieu);
            cmd.Parameters.AddWithValue("@ngaydat", ngaydat);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức xóa phiéu theo mã truyền vào
        public static void BookingTour_Delete(string masp)
        {
            SqlCommand cmd = new SqlCommand(" DELETE FROM dbo.PHIEUDAT WHERE maphieu = "+ masp);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@masp", masp);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        public static void BookingTourNV_Delete(string masp)
        {
            SqlCommand cmd = new SqlCommand(" DELETE FROM dbo.PHIEUDAT_NV WHERE maphieu = " + masp);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@masp", masp);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

    }
}