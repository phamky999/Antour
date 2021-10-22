using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.CaNhan
{
    public partial class UserLoad : System.Web.UI.UserControl
    {
        private string modul = "";
        private string modulphu = "";
        private string thaotac = "";
        private string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {
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
            //if (Request.QueryString["id"] != null)
            //    id = Request.QueryString["id"];
            switch (modulphu)
            {
                case "TaiKhoan":
                    if (thaotac == "HienThi")
                    {
                        userloadcontrol.Controls.Add(LoadControl("UserProfile.ascx"));
                    }
                    if (thaotac == "Edit")
                    {
                        userloadcontrol.Controls.Add(LoadControl("UserEdit.ascx"));
                    }
                    if (thaotac == "RePass")
                    {
                        userloadcontrol.Controls.Add(LoadControl("UserRepass.ascx"));
                    }
                    break;
                case "PhieuDat":
                    if (Session["KH_MaKH"] != null || Session["NV_MaNV"] == null)
                    {
                        if (thaotac == "ChinhSua")
                        {
                            userloadcontrol.Controls.Add(LoadControl("EditPhieuDat.ascx"));
                        }
                        if (thaotac == "HienThi")
                        {
                            userloadcontrol.Controls.Add(LoadControl("UserTour.ascx"));
                        }
                    }
                    else if (Session["KH_MaKH"] == null || Session["NV_MaNV"] != null)
                    {
                        userloadcontrol.Controls.Add(LoadControl("UserProfile.ascx"));
                    }


                        break;
               
                default:
                    userloadcontrol.Controls.Add(LoadControl("UserProfile.ascx"));
                    break;
            }
            //if (modul == "CaNhan")
            //{
            //    if (modulphu == "TaiKhoan")
            //    {
            //        if (thaotac == "HienThi")
            //        {
            //            userloadcontrol.Controls.Add(LoadControl("UserProfile.ascx"));
            //        }
            //        if (thaotac == "Edit")
            //        {
            //            userloadcontrol.Controls.Add(LoadControl("UserEdit.ascx"));
            //        }
            //        if (thaotac == "RePass")
            //        {
            //            userloadcontrol.Controls.Add(LoadControl("UserRepass.ascx"));
            //        }
            //    }
            //    if (modulphu == "PhieuDat")
            //    {
            //        userloadcontrol.Controls.Add(LoadControl("UserTour.ascx"));
            //    }


            //}

            //if (modul == "KhachHang")
            //{
            //    plDefaultLoadControl.Controls.Add(LoadControl("cms/admin/KhachHang.ascx"));

            //}
            //if (modul == "NhanVien")
            //{
            //    if (thaotac == "HienThi")
            //    {
            //        plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/ListNhanVien.ascx"));
            //        ltlTitle.Text = "<h3 class='mb-4'>Danh Sách Nhân Viên:</h3>";
            //    }
            //    if (thaotac == "ThemMoi")
            //    {
            //        plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/InsertNhanVien.ascx"));
            //        ltlTitle.Text = "<h3 class='mb-4'>Thêm Mới Nhân Viên:</h3>";
            //    }
            //    if (thaotac == "AdEdit")
            //    {
            //        plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/AdminEditNV.ascx"));
            //        ltlTitle.Text = "<h3 class='mb-4'>Chỉnh Sửa Quyền, Trạng Thái Của Nhân Viên:</h3>";
            //    }
            //}
        }
    }
}