using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkSesionDN();
        }
        private void checkSesionDN()
        {
            if (Session["KH_DangNhap"] == null && Session["NV_DangNhap"] == null)
            {
                btnLogin.Visible = true;
                lbtnSignup.Visible = true;
                lbtnLogout.Visible = false;
                lbtnUser.Visible = false;
                lbtnAdmin.Visible = false;
            }
            else if (Session["KH_DangNhap"] != null || Session["NV_DangNhap"] != null)
            {
                btnLogin.Visible = false;
                lbtnSignup.Visible = false;
                lbtnLogout.Visible = true;
                lbtnUser.Visible = true;
            }
            if (Session["NV_DangNhap"] != null)
            {
                lbtnAdmin.Visible = true;
            }
        }

        protected void lbtnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?modul=CaNhan");
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            if (Session["KH_DangNhap"] != null && Session["KH_DangNhap"].ToString() == "1")
            {
                Session["KH_DangNhap"] = null;
                Session["KH_MaKH"] = null;
                Session["KH_TenKH"] = null;
                Session["KH_GioiTinh"] = null;
                Session["KH_CMTND"] = null;
                Session["KH_SDT"] = null;
                Session["KH_Email"] = null;
                Session["KH_TenDangNhap"] = null;
                Session["KH_MatKhau"] = null;
                Session["KH_Quyen"] = null;
            }
            else if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
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
            }
            Response.Redirect("Default.aspx");
        }

        protected void lbtnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void lbtnAdmin_Click(object sender, EventArgs e)
        {

            Response.Redirect("Admin.aspx");
        }
    }
}