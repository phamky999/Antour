using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.CaNhan
{
    public partial class UserProfile : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private string gioitinh(int id)
        {
            string gioitinh = "";
            if (id == 0)
            {
                gioitinh = "Nữ";

            }
            else if (id == 1)
            {
                gioitinh = "Nam";
            }
            else if (id == 2)
            {
                gioitinh = "Khác";
            }
            return gioitinh;
        }

        private string quyendn(int id)
        {
            string quyen = "";
            if (id == 2)
            {
                quyen = "Nhân Viên";

            }
            else if (id == 3)
            {
                quyen = "Quản Trị";
            }
            return quyen;
        }

        private string trangthaiNV(int id)
        {
            string trangthai = "";
            if (id == 0)
            {
                trangthai = "Not Active";

            }
            else if (id == 1)
            {
                trangthai = "Active";
            }
            return trangthai;
        }
        private void LoadData()
        {
            if (Session["KH_DangNhap"] != null && Session["KH_DangNhap"].ToString() == "1")
            {
                plUserNhanVien.Visible = false;
                DataTable dt = AnTour.AppCode.KhachHang.Thongtin_Khachhang_by_makh(int.Parse(Session["KH_MaKH"].ToString()));
                if (dt.Rows.Count > 0)
                {
                    ltlHoten.Text += dt.Rows[0]["tenkh"].ToString();
                    ltlGioitinh.Text += gioitinh(int.Parse(dt.Rows[0]["gioitinh"].ToString()));
                    ltlCmtnd.Text += dt.Rows[0]["cmtnd"].ToString();
                    ltlSdt.Text += dt.Rows[0]["sdt"].ToString();
                    ltlEmail.Text += dt.Rows[0]["email"].ToString();
                    ltlDiachi.Text += dt.Rows[0]["diachi"].ToString();
                }
            }
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                plUserNhanVien.Visible = true;
                DataTable dt = AnTour.AppCode.NhanVien.Thongtin_NV_by_id(int.Parse(Session["NV_MaNV"].ToString()));
                if (dt.Rows.Count > 0)
                {
                    ltlHoten.Text += dt.Rows[0]["tennv"].ToString();
                    ltlGioitinh.Text += gioitinh(int.Parse(dt.Rows[0]["gioitinh"].ToString()));
                    ltlCmtnd.Text += dt.Rows[0]["cmtnd"].ToString();
                    ltlSdt.Text += dt.Rows[0]["sdt"].ToString();
                    ltlEmail.Text += dt.Rows[0]["email"].ToString();
                    ltlDiachi.Text += dt.Rows[0]["diachi"].ToString();
                    ltlQuyen.Text += quyendn(int.Parse(dt.Rows[0]["quyen"].ToString()));
                    ltlTrangthai.Text += trangthaiNV(int.Parse(dt.Rows[0]["trangthai"].ToString()));
                }
            }
            if (Session["KH_DangNhap"] == null && Session["NV_DangNhap"] == null)
            {
                Response.Redirect("Default.aspx");
            }

        }
    }
}