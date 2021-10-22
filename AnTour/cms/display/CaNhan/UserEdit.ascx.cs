using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.CaNhan
{
    public partial class UserEdit : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                loadGioiTinh();
                LoadData();

            }

        }
        private void loadGioiTinh()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.KhachHang.Thongtin_GioiTinh();
            ddlGioiTinh.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlGioiTinh.Items.Add(new ListItem(dt.Rows[i]["ten"].ToString(), dt.Rows[i]["ma"].ToString()));

            }
        }

        private void LoadData()
        {
            if (Session["KH_DangNhap"] != null && Session["KH_DangNhap"].ToString() == "1")
            {

                DataTable dt = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_makh(int.Parse(Session["KH_MaKH"].ToString()));
                if (dt.Rows.Count > 0)
                {
                    txtHoten.Text = dt.Rows[0]["tenkh"].ToString();
                    ddlGioiTinh.SelectedValue = dt.Rows[0]["gioitinh"].ToString();
                    txtCmtnd.Text = dt.Rows[0]["cmtnd"].ToString().Trim();
                    txtSdt.Text = dt.Rows[0]["sdt"].ToString().Trim();
                    txtEmail.Text = dt.Rows[0]["email"].ToString();
                    txtDiachi.Text = dt.Rows[0]["diachi"].ToString();
                }
            }
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {

                DataTable dt = AnTour.AppCode.NhanVien.Thongtin_NV_by_id(int.Parse(Session["NV_MaNV"].ToString()));
                if (dt.Rows.Count > 0)
                {
                    txtHoten.Text = dt.Rows[0]["tennv"].ToString();
                    ddlGioiTinh.SelectedValue = dt.Rows[0]["gioitinh"].ToString();
                    txtCmtnd.Text = dt.Rows[0]["cmtnd"].ToString().Trim();
                    txtSdt.Text = dt.Rows[0]["sdt"].ToString().Trim();
                    txtEmail.Text = dt.Rows[0]["email"].ToString();
                    txtDiachi.Text = dt.Rows[0]["diachi"].ToString();

                }
            }
            if (Session["KH_DangNhap"] == null && Session["NV_DangNhap"] == null)
            {
                Response.Redirect("Default.aspx");
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
                        if (Session["KH_TenDangNhap"] != null && Session["KH_TenDangNhap"].ToString() == dt.Rows[0]["tendangnhap"].ToString())
                        {
                            AnTour.AppCode.KhachHang.KH_UpdateProfile(int.Parse(Session["KH_MaKH"].ToString()), txtHoten.Text.Trim(), "", int.Parse(ddlGioiTinh.SelectedValue), txtCmtnd.Text.Trim(), txtSdt.Text.Trim(), txtEmail.Text.Trim(), txtDiachi.Text.Trim(), Session["KH_TenDangNhap"].ToString());

                            Response.Redirect("Default.aspx?modul=CaNhan&modulphu=TaiKhoan&thaotac=HienThi");
                        }
                        else
                            ltlMsg.Text = "<p>Vui lòng nhập tài khoản của bạn</p>";

                    }
                    else
                        ltlMsg.Text = "<p>Thông Tin Tài Khoản Của Bạn Không Đúng</p>";
                }
                if (Session["NV_DangNhap"] != null && Session["KH_DangNhap"] == null)
                {
                    DataTable dt = AnTour.AppCode.NhanVien.SelectNVByUserPass(txtTenDN.Text.Trim(), txtMK.Text.Trim());

                    if (dt.Rows.Count > 0)
                    {
                        if (Session["NV_TenDangNhap"] != null && Session["NV_TenDangNhap"].ToString() == dt.Rows[0]["tendangnhap"].ToString())
                        {
                            AnTour.AppCode.NhanVien.NV_UpdateProfile(int.Parse(Session["NV_MaNV"].ToString()), txtHoten.Text.Trim(), "", int.Parse(ddlGioiTinh.SelectedValue), txtCmtnd.Text.Trim(), txtSdt.Text.Trim(), txtEmail.Text.Trim(), txtDiachi.Text.Trim(), Session["NV_TenDangNhap"].ToString());

                            Response.Redirect("Default.aspx?modul=CaNhan&modulphu=TaiKhoan&thaotac=HienThi");
                        }
                        else
                            ltlMsg.Text = "<p>Vui lòng nhập tài khoản của bạn</p>";

                    }
                    else
                        ltlMsg.Text = "<p>Thông Tin Tài Khoản Của Bạn Không Đúng</p>";


                }
            }
        }
    }
}