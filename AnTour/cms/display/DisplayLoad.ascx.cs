using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display
{
    public partial class DisplayLoad : System.Web.UI.UserControl
    {
        private string modul = "";
        private string modulphu = "";
        private string thaotac = "";
        private string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            switch (modul)
            {
                case "CaNhan":
                    plLoadControl.Controls.Add(LoadControl("CaNhan/UserLoad.ascx"));
                    break;
                case "Home":
                    plLoadControl.Controls.Add(LoadControl("TrangChu/HomeLoad.ascx"));
                    break;
                case "Tours":
                    plLoadControl.Controls.Add(LoadControl("Tours/TourLoad.ascx"));
                    break;
                default:
                    plLoadControl.Controls.Add(LoadControl("TrangChu/HomeLoad.ascx"));
                    break;

            }

        }

        private void Load_Control()
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (modul == "KhachHang")
            {
                plLoadControl.Controls.Add(LoadControl("cms/admin/KhachHang/ListKH.ascx"));
                
            }
            if (modul == "NhanVien")
            {
                if (thaotac == "HienThi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/ListNV.ascx"));
                    
                }
                if (thaotac == "ThemMoi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/InsertNV.ascx"));
                    
                }
                if (thaotac == "AdEdit")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/NhanVien/AdEditNV.ascx"));
                    
                }
            }
            if (modul == "Tour")
            {
                if (thaotac == "HienThi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/Tour/ListTour.ascx"));
                    
                }
                if (thaotac == "ThemMoi")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/Tour/InsertTour.ascx"));
                    
                }
                if (thaotac == "ChinhSua")
                {
                    plLoadControl.Controls.Add(LoadControl("cms/admin/Tour/EditTour.ascx"));
                    
                }
            }
        }

    }
}