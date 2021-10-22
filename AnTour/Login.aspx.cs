using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace AnTour
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = AnTour.AppCode.KhachHang.SelectKHByUserPass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                Session["KH_DangNhap"] = "1";
                Session["KH_MaKH"] = dt.Rows[0]["makh"];
                Session["KH_TenKH"] = dt.Rows[0]["tenkh"];
                Session["KH_GioiTinh"] = dt.Rows[0]["gioitinh"];
                Session["KH_CMTND"] = dt.Rows[0]["cmtnd"];
                Session["KH_SDT"] = dt.Rows[0]["sdt"];
                Session["KH_Email"] = dt.Rows[0]["email"];
                Session["KH_TenDangNhap"] = dt.Rows[0]["tendangnhap"];
                Session["KH_MatKhau"] = dt.Rows[0]["matkhau"];
                Session["KH_Quyen"] = dt.Rows[0]["quyen"];

                Response.Redirect("Default.aspx");
            }
            else
            {
                dt.Dispose();
                DataTable dt1 = AnTour.AppCode.NhanVien.SelectNVByUserPass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (dt1.Rows.Count > 0)
                {
                    Session["NV_DangNhap"] = "1";
                    Session["NV_MaNV"] = dt1.Rows[0]["manv"];
                    Session["NV_TenNV"] = dt1.Rows[0]["tennv"];
                    Session["NV_GioiTinh"] = dt1.Rows[0]["gioitinh"];
                    Session["NV_CMTND"] = dt1.Rows[0]["cmtnd"];
                    Session["NV_SDT"] = dt1.Rows[0]["sdt"];
                    Session["NV_Email"] = dt1.Rows[0]["email"];
                    Session["NV_TenDangNhap"] = dt1.Rows[0]["tendangnhap"];
                    Session["NV_MatKhau"] = dt1.Rows[0]["matkhau"];
                    Session["NV_Quyen"] = dt1.Rows[0]["quyen"];
                    Session["NV_TrangThai"] = dt1.Rows[0]["trangthai"].ToString();

                    if (Session["NV_TrangThai"].ToString() == "1")
                    {
                        Response.Redirect("Admin.aspx");
                    }
                    else
                        Response.Redirect("Default.aspx");
                }
                else
                    ltlMsg.Text = "<div style='color:red;'>Tên đăng nhập hoặc mật khẩu không chính xác!</div>";
            }


        }
    }
}