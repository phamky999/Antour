using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.CaNhan
{
    public partial class UserRePass : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KH_DangNhap"] != null && Session["KH_DangNhap"].ToString() == "1")
            {

            }
            if (Session["KH_DangNhap"] == null && Session["NV_DangNhap"] == null)
            {


            }
            else if (Session["KH_DangNhap"] != null || Session["NV_DangNhap"] != null)
            {
                //btnLogin.Visible = false;
                //btnLogOut.Visible = true;
            }
        }



        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?modul=CaNhan&modulphu=TaiKhoan&thaotac=HienThi");
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            if (Session["KH_DangNhap"] == null && Session["NV_DangNhap"] == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "confirm('Bạn Chưa Đăng Nhập. Chuyển Đến Tang Login?');", true);
                Response.Redirect("Login.aspx");
            }
            else if (Session["KH_DangNhap"] != null || Session["NV_DangNhap"] != null)
            {
                if (Session["KH_DangNhap"] != null && Session["NV_DangNhap"] == null)
                {
                    DataTable dt = AnTour.AppCode.KhachHang.SelectKHByUserPass(txtTenDN.Text.Trim(), txtMK.Text.Trim());
                    if (dt.Rows.Count > 0)
                    {
                        AnTour.AppCode.KhachHang.Khachang_UpdatePass(int.Parse(Session["KH_MaKH"].ToString()), txtTenDN.Text.Trim(), txtNewPass.Text.Trim());
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Thành Công. Vui Lòng Đăng Nhập Lại');", true);
                        Response.Redirect("Login.aspx");
                    }
                    else
                        ltlMsg.Text = "<p>Thông Tin Tài Khoản Không Đúng</p>";
                }
                if (Session["NV_DangNhap"] != null && Session["KH_DangNhap"] == null)
                {
                    DataTable dt = AnTour.AppCode.NhanVien.SelectNVByUserPass(txtTenDN.Text.Trim(), txtMK.Text.Trim());
                    if (dt.Rows.Count > 0)
                    {
                        AnTour.AppCode.NhanVien.NV_UpdatePass(int.Parse(Session["NV_MaNV"].ToString()), txtTenDN.Text.Trim(), txtNewPass.Text.Trim());
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Thành Công. Vui Lòng Đăng Nhập Lại');", true);
                        Response.Redirect("Login.aspx");
                    }
                    else
                        ltlMsg.Text = "<p>Thông Tin Tài Khoản Không Đúng</p>";
                }
            }
        }
    }
}