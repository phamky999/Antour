using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AnTour.AppCode.SQLDatabase.LoadDDL(ddlGioiTinh, "GIOITINH", "ten", "ma");
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            DataTable tb = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_CMTND(txtcmtnd.Text.Trim());
            DataTable tb1 = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_Sdt(txtSdt.Text.Trim());
            DataTable tb2 = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_Email(txtEmail.Text.Trim());
            DataTable tb3 = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_User(txtUser.Text.Trim());
            DataTable tb4 = AnTour.AppCode.NhanVien.Thongtin_NV_by_CMTND(txtcmtnd.Text.Trim());
            DataTable tb5 = AnTour.AppCode.NhanVien.Thongtin_NV_by_Sdt(txtSdt.Text.Trim());
            DataTable tb6 = AnTour.AppCode.NhanVien.Thongtin_NV_by_Email(txtEmail.Text.Trim());
            DataTable tb7 = AnTour.AppCode.NhanVien.Thongtin_NV_by_User(txtUser.Text.Trim());
            if (tb.Rows.Count > 0 || tb4.Rows.Count > 0)
            {
                ltlMessage.Text = "<p style='color:red;'>Số CMTND đã tồn tại!<p>";
            }
            else if (tb1.Rows.Count > 0 || tb5.Rows.Count > 0)
            {
                ltlMessage.Text = "<p style='color:red;'>SĐT đã tồn tại!<p>";
            }
            else if (tb2.Rows.Count > 0 || tb6.Rows.Count > 0)
            {
                ltlMessage.Text = "<p style='color:red;'>Email đã tồn tại!<p>";
            }
            else if (tb3.Rows.Count > 0 || tb7.Rows.Count > 0)
            {
                ltlMessage.Text = "<p style='color:red;'>Tên Đăng Nhập đã tồn tại!<p>";
            }
            else
            {
                AnTour.AppCode.KhachHang.Khachang_Insert(txtHoTen.Text.Trim(), "", int.Parse(ddlGioiTinh.SelectedValue), txtcmtnd.Text.Trim(), txtSdt.Text.Trim(), txtEmail.Text.Trim(), txtaddr.Text.Trim(), txtUser.Text.Trim(), txtPass.Text.Trim(), 1);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Đăng Ký Thành Công');", true);
                Response.Redirect("Login.aspx");
            }

        }
    }
}