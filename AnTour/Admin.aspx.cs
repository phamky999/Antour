using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour
{
    public partial class Admin : System.Web.UI.Page
    {

        private string modul = "";
        private string modulphu = "";
        private string thaotac = "";
        private string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            //Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                //Đã đăng nhập
            }
            else
            {
                //Nếu chưa đăng nhập --> đẩy về trang login
                Response.Redirect("/Login.aspx");
            }
            if (!IsPostBack)
                ltlName.Text = Session["NV_TenNV"].ToString();

            Load_Control();
        }

        private void Load_Control()
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (modul == "KhachHang")
            {
                plLoadControl.Controls.Add(LoadControl("cms/admin/KhachHang/ListKH.ascx"));
                ltlTitle.Text = "<h3 class='mb-4'>Danh Sách Khách Hàng:</h3>";
            }
            if (modul == "NhanVien")
            {
                if (thaotac == "HienThi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/ListNV.ascx"));
                    ltlTitle.Text = "<h3 class='mb-4'>Danh Sách Nhân Viên:</h3>";
                }
                if (thaotac == "ThemMoi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/InsertNV.ascx"));
                    ltlTitle.Text = "<h3 class='mb-4'>Thêm Mới Nhân Viên:</h3>";
                }
                if (thaotac == "AdEdit")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/AdEditNV.ascx"));
                    ltlTitle.Text = "<h3 class='mb-4'>Chỉnh Sửa Quyền, Trạng Thái Của Nhân Viên:</h3>";
                }
            }
            if (modul == "Tour")
            {
                if (thaotac == "HienThi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/Tour/ListTour.ascx"));
                    ltlTitle.Text = "<h3 class='mb-4'>Danh Sách Tour:</h3>";
                }
                if (thaotac == "ThemMoi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/Tour/InsertTour.ascx"));
                    ltlTitle.Text = "<h3 class='mb-4'>Thêm Mới Tour:</h3>";
                }
                if (thaotac == "ChinhSua")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/Tour/EditTour.ascx"));
                    ltlTitle.Text = "<h3 class='mb-4'>Chỉnh Sửa Tour:</h3>";
                }
            }
            if (modul == "PhieuDat")
            {
                if (thaotac == "HienThi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/Booking/ListBooking.ascx"));
                    ltlTitle.Text = "<h3 class='mb-4'>Danh Sách Phiếu Đặt Tour:</h3>";
                }
            }
            if (modul == "Report")
            {
                if(modulphu == "DoanhThu")
                {
                    if (thaotac == "HienThi")
                    {
                        plLoadControl.Controls.Add(LoadControl("cms/admin/Report/DoanhThu.ascx"));
                        ltlTitle.Text = "";
                    }
                }
                
            }
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session["NV_DangNhap"] = null;
            Session["NV_MaNV"] = null;
            Session["NV_TenNV"] = null;
            Session["NV_GioiTinh"] = null;
            Session["NV_CMTND"] = null;
            Session["NV_SDT"] = null;
            Session["NV_Email"] = null;
            Session["NV_TenDangNhap"] = null;
            Session["NV_MatKhau"] = null;
            Session["NV_Quyen"] = null;
            Session["NV_TrangThai"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}