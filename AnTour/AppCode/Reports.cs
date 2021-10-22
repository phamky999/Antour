using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AnTour.AppCode
{
    public class Reports
    {
        #region thống kê doanh thu và số phiếu theo ngày:
        public static DataTable DoanhThu_Ngay(string ngay)
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.pro_DoanhThuTheoNgay @ngay = '" + ngay + "'");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region thống kê ds phiếu theo ngày:
        public static DataTable ListPhieu_Ngay(string ngay)
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.pro_ListPhieuTheoNgay @ngay = '"+ngay+"'");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region thống kê ds phiếu theo tháng
        public static DataTable ListPhieu_Thang(string thang, string nam)
        {
            string query = @"SELECT kh.makh AS [MaKH],kh.tenkh AS [TenKH],gt.ten AS [GT],kh.cmtnd,kh.sdt,kh.email,kh.diachi,t.ma AS [MaTour],t.tentour,t.diadiem AS [DD],t.songaytour,t.dongia,ph.maphieu,ph.ngaydat,ph.checkin,ph.slkhach,ph.sltreem,tt.ten AS [TrangThai],ph.giatien
	                            FROM ((((dbo.KHACHHANG AS kh
	                            INNER JOIN dbo.GIOITINH AS gt ON kh.gioitinh = gt.ma)
	                            INNER JOIN dbo.PHIEUDAT AS ph ON ph.makh = kh.makh)
	                            INNER JOIN dbo.TOUR AS t ON ph.matour = t.ma)
	                            INNER JOIN dbo.TRANGTHAI_PHIEU AS tt ON ph.trangthai = tt.ma)
	                            WHERE ph.ngaydat LIKE '"+nam+"-"+thang+"-__' AND ph.trangthai = 3";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region thống kê theo 1 tháng
        /*
         SELECT ngaydat, COUNT(maphieu) AS [SoPhieu] FROM dbo.PHIEUDAT WHERE trangthai=3 AND ngaydat LIKE '2021-03-__' GROUP BY ngaydat
         */
        public static DataTable DoanhThu_Month(string month, string year)
        {
            SqlCommand cmd = new SqlCommand("SELECT ngaydat, COUNT(maphieu) AS [SoPhieu],SUM(giatien) AS [DoanhThu] FROM dbo.PHIEUDAT WHERE trangthai=3 AND ngaydat LIKE '" + year+"-"+month+"-__' GROUP BY ngaydat");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}