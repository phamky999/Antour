using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.Tours
{
    public partial class TourDetail : System.Web.UI.UserControl
    {
        protected string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (!IsPostBack)
                ChiTietTour(id);
            LoadFormBooking();
        }
        private void ChiTietTour(string id)
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.Tour.Thongtin_Tour_by_id(id);

            if (dt.Rows.Count > 0)
            {
                int sltreem = int.Parse(dt.Rows[0]["slkhachtoida"].ToString()) / 2;
                float dongiaTreem = float.Parse(dt.Rows[0]["dongia"].ToString()) / 2;
                ltlTourDetail.Text = @"
                                        <h3>Thông Tin Chi Tiết Của " + dt.Rows[0]["tentour"] + @": </h3>
                                        <img class='imgsp' src='/pictures/TourImgs/" + dt.Rows[0]["urlimage"] + @"' alt='" + dt.Rows[0]["tentour"] + @"' />
                                        <br/>
                                        <p style='text-align:center;'><i>Ảnh Tour " + dt.Rows[0]["tentour"] + @" </i></p>
                                        <p>Tên Tour: " + dt.Rows[0]["tentour"] + @"</p>
                                        <p>Địa Điểm: " + dt.Rows[0]["diadiem"] + @"</p>
                                        <p>Số Ngày Tour: " + dt.Rows[0]["songaytour"] + @" Ngày</p>  
                                        <p>Số Lượng Khách Tối Đa: " + dt.Rows[0]["slkhachtoida"] + @" người lớn cùng với " + sltreem + @" trẻ em đi cùng</p>  
                                        <p>Đơn Giá: " + dt.Rows[0]["dongia"] + @" VNĐ - 1 Người lớn. <br/> Giá áp dụng với trẻ em:  " + dongiaTreem + @" VNĐ - 1 Trẻ em </p>  
                                        <h4>Thông Tin Chi Tiết: </h4>
                                        <div>
                                            " + dt.Rows[0]["gioithieu"] + @"
                                        </div>             
";

            }
        }
        private void LoadFormBooking()
        {
            txtNgayDat.Text = DateTime.Now.ToString("MM/dd/yyyy");
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.Tour.Thongtin_Tour_by_id(id);

            if (dt.Rows.Count > 0)
            {
                txtTour.Text = dt.Rows[0]["tentour"].ToString();
            }
            if (Session["KH_DangNhap"] != null && Session["KH_DangNhap"].ToString() == "1")
            {
                txtKH.Text = Session["KH_TenKH"].ToString().Trim();
            }
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                txtKH.Text = Session["NV_TenNV"].ToString().Trim();
            }
        }
        private bool ValidateFormBooking()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.Tour.Thongtin_Tour_by_id(id);
            int slkhach = int.Parse(dt.Rows[0]["slkhachtoida"].ToString());
            int sltreem = int.Parse(dt.Rows[0]["slkhachtoida"].ToString()) / 2;
            if (txtKH.Text.Trim() == "")
            {
                ltlMsg.Text = @"<p style='color:red;'>Vui Lòng Đăng Nhập Để Tiếp Tục</p>";
                return false;
            }
            else if (txtNgayDi.Text.Trim() == "")
            {
                ltlMsg.Text = @"<p style='color:red;'>Vui Lòng Chọn Ngày Khởi Hành</p>";
                return false;
            }
            else if (DateTime.Parse(txtNgayDi.Text, new CultureInfo("en-US", true)) <= DateTime.Now)
            {
                ltlMsg.Text = @"<p style='color:red;'>Ngày Khởi Hành Không Hợp Lệ</p>";
                return false;
            }
            else if (txtSLKhach.Text.Trim() == "")
            {
                ltlMsg.Text = @"<p style='color:red;'>Vui Lòng Nhập Số Lượng Khách</p>";
                return false;
            }
            else if (int.Parse(txtSLKhach.Text) > slkhach)
            {
                ltlMsg.Text = @"<p style='color:red;'>Vượt Quá Số Lượng Cho Phép! Vui Lòng Lựa Chọn Tour Khác Hoặc Nhập Lại</p>";
                return false;
            }
            else if (txtSLTreEm.Text.Trim() != "" && (int.Parse(txtSLTreEm.Text) > sltreem))
            {
                ltlMsg.Text = @"<p style='color:red;'>Vượt Quá Số Lượng Trẻ Em Cho Phép! Vui Lòng Lựa Chọn Tour Khác Hoặc Nhập Lại</p>";
                return false;
            }
            else
                return true;
        }
        protected void btnBooking_Click(object sender, EventArgs e)
        {
            ValidateFormBooking();
            if (ValidateFormBooking() == true)
            {
                if (Session["KH_DangNhap"] != null && Session["KH_DangNhap"].ToString() == "1")
                {
                    AnTour.AppCode.BookingTour.BookingTour_Insert(int.Parse(Session["KH_MaKH"].ToString()), int.Parse(id), txtNgayDat.Text.Trim(), txtNgayDi.Text.Trim(), int.Parse(txtSLKhach.Text.Trim()), int.Parse(txtSLTreEm.Text.Trim()), 1);
                    ltlMsg.Text = @"<p style='color:red;'>Tạo phiếu đặt tour thành công</p>";
                }
                if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
                {
                    //AnTour.AppCode.BookingTour.BookingTour_Insert_NV(int.Parse(Session["NV_MaNV"].ToString()), int.Parse(id), txtNgayDat.Text.Trim(), txtNgayDi.Text.Trim(), int.Parse(txtSLKhach.Text.Trim()), int.Parse(txtSLTreEm.Text.Trim()), 1);
                    ltlMsg.Text = @"<p style='color:red;'>Bạn đang đăng nhập với tài khoản nhân viên</p>";
                }
            }
        }
    }
}