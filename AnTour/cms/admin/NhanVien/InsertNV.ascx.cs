using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.NhanVien
{
    public partial class InsertNV : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //loadGioiTinh();
                AnTour.AppCode.SQLDatabase.LoadDDL(ddlGioitinh, "GIOITINH", "ten", "ma");
            }
        }
        private void loadGioiTinh()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.KhachHang.Thongtin_GioiTinh();
            ddlGioitinh.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlGioitinh.Items.Add(new ListItem(dt.Rows[i]["ten"].ToString(), dt.Rows[i]["ma"].ToString()));

            }
        }


        private void ResetControl()
        {
            txtAddr.Text = null;
            txtCmtnd.Text = null;
            txtEmail.Text = null;
            txtHoten.Text = null;
            txtPass.Text = null;
            txtSdt.Text = null;
            txtTK.Text = null;
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            DataTable tb = AnTour.AppCode.NhanVien.Thongtin_NV_by_CMTND(txtCmtnd.Text.Trim());
            DataTable tb1 = AnTour.AppCode.NhanVien.Thongtin_NV_by_Sdt(txtSdt.Text.Trim());
            DataTable tb2 = AnTour.AppCode.NhanVien.Thongtin_NV_by_Email(txtEmail.Text.Trim());
            DataTable tb3 = AnTour.AppCode.NhanVien.Thongtin_NV_by_User(txtTK.Text.Trim());
            DataTable tb4 = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_CMTND(txtCmtnd.Text.Trim());
            DataTable tb5 = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_Sdt(txtSdt.Text.Trim());
            DataTable tb6 = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_Email(txtEmail.Text.Trim());
            DataTable tb7 = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_User(txtTK.Text.Trim());
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                if (tb.Rows.Count > 0 || tb4.Rows.Count > 0)
                {
                    ltlMsg.Text = "<p style='color:red;'>Số CMTND đã tồn tại!<p>";
                }
                else if (tb1.Rows.Count > 0 || tb5.Rows.Count > 0)
                {
                    ltlMsg.Text = "<p style='color:red;'>SĐT đã tồn tại!<p>";
                }
                else if (tb2.Rows.Count > 0 || tb6.Rows.Count > 0)
                {
                    ltlMsg.Text = "<p style='color:red;'>Email đã tồn tại!<p>";
                }
                else if (tb3.Rows.Count > 0 || tb7.Rows.Count > 0)
                {
                    ltlMsg.Text = "<p style='color:red;'>Tên Tài Khoản đã tồn tại!<p>";
                }
                else
                {
                    AnTour.AppCode.NhanVien.Nhanvien_Inser(txtHoten.Text.Trim(), "", int.Parse(ddlGioitinh.SelectedValue), txtCmtnd.Text.Trim(), txtSdt.Text.Trim(), txtEmail.Text.Trim(), txtAddr.Text.Trim(), txtTK.Text.Trim(), txtPass.Text.Trim(), 2, 1);
                    ltlMsg.Text = "<p>Thêm nhân viên thành công!<p>";
                    if (cbCtn.Checked)
                    {
                        txtAddr.Text = null;
                        txtCmtnd.Text = null;
                        txtEmail.Text = null;
                        txtHoten.Text = null;
                        txtPass.Text = null;
                        txtSdt.Text = null;
                        txtTK.Text = null;
                    }
                    else
                    {
                        Response.Redirect("Admin.aspx?modul=NhanVien&thaotac=HienThi");
                    }

                }
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtAddr.Text = null;
            txtCmtnd.Text = null;
            txtEmail.Text = null;
            txtHoten.Text = null;
            txtPass.Text = null;
            txtSdt.Text = null;
            txtTK.Text = null;
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx?modul=NhanVien&thaotac=HienThi");
        }
    }
}