using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.CaNhan.ajax
{
    public partial class UserDel : System.Web.UI.Page
    {
        string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Code kiểm tra đăng nhập tại đây sau đó mới thực hiện các thao tác dưới
            //Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
            if (Session["KH_MaKH"] != null || Session["NV_MaNV"] != null)
            {
                //Đã đăng nhập
            }
            else if (Session["KH_MaKH"] == null && Session["NV_MaNV"] == null)
            {
                //Nếu chưa đăng nhập --> return để dừng không cho thực hiện các câu lệnh bên dưới
                return;
            }
            if (Request.Params["tacvu"] != null)
            {
                thaotac = Request.Params["tacvu"];
            }

            switch (thaotac)
            {
                case "XoaSanPham":
                    XoaSanPham();
                    break;

            }

        }

        private void XoaSanPham()
        {
            string MaSP = "";
            if (Request.Params["id"] != null)
            {
                MaSP = Request.Params["id"];

                //Thực hiện code xóa
                //B1: Xóa ảnh đại diện đã lưu trên server - tạm b
                //B2: Xóa dữ liệu trên sqlserver
                if(Session["KH_DangNhap"] != null)
                {
                    DataTable tb = AnTour.AppCode.BookingTour.Thongtin_TTPhieuKH_by_id(MaSP);
                    string trangthai = "";
                    if(tb.Rows.Count > 0)
                    {
                        trangthai = tb.Rows[0]["trangthai"].ToString();
                    }
                    if (trangthai == "1" || trangthai == "2")
                    {
                        AnTour.AppCode.BookingTour.BookingTour_Delete(MaSP);
                        Response.Write(1);
                    }
                    else
                        Response.Write(2);
                    
                }
                if (Session["NV_DangNhap"] != null)
                {
                    DataTable tb = AnTour.AppCode.BookingTour.Thongtin_TTPhieuNV_by_id(MaSP);
                    string trangthai = "";
                    if (tb.Rows.Count > 0)
                    {
                        trangthai = tb.Rows[0]["trangthai"].ToString();
                    }
                    if (trangthai == "1" || trangthai == "2")
                    {
                        AnTour.AppCode.BookingTour.BookingTourNV_Delete(MaSP);
                        Response.Write(1);
                    }
                    else
                        Response.Write(2);
                    
                }
                // Trả về thông báo 1 thực hiện thành công 2 thực hiện không thành công
                
            }
        }
    }
}