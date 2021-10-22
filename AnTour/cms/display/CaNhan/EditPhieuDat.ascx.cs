using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.CaNhan
{
    public partial class EditPhieuDat : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id của sản phẩm cần chỉnh sửa
        private string _id = "";
        private string matour;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["idPhieu"] != null)
                id = Request.QueryString["idPhieu"];
            if (Request.QueryString["_idPhieu"] != null)
                _id = Request.QueryString["_idPhieu"];
            HienThiThongTin(id, _id);
        }
        private void HienThiThongTin(string id, string _id)
        {

            if (thaotac == "ChinhSua")
            {
                if(Request.QueryString["idPhieu"] != null)
                {
                    DataTable dt = new DataTable();
                    dt = AnTour.AppCode.BookingTour.Thongtin_ThongTinPhieuKH_by_id(id);
                    
                    if (dt.Rows.Count > 0)
                    {
                        txtKH.Text = dt.Rows[0]["tenkh"].ToString().Trim();
                        txtTour.Text = dt.Rows[0]["tentour"].ToString().Trim();
                        txtNgayDat.Text = dt.Rows[0]["ngaydat"].ToString().Trim();
                        //txtNgayDi.Text = dt.Rows[0]["checkin"].ToString().Trim();
                        txtNgayDi.Text = Convert.ToDateTime(dt.Rows[0]["checkin"]).ToString("yyyy-MM-dd");
                        txtSLKhach.Text = dt.Rows[0]["slkhach"].ToString().Trim();
                        txtSLTreEm.Text = dt.Rows[0]["sltreem"].ToString().Trim();
                        matour = dt.Rows[0]["matour"].ToString().Trim();
                        var date = DateTime.Parse(txtNgayDi.Text, new CultureInfo("en-US", true));
                        var datenow = DateTime.Now;
                        if ((dt.Rows[0]["trangthai"].ToString().Trim() != "1") || (date < datenow))
                        {
                            ltlMsg.Text = "<p style='color:red;'>Phiếu Này Hiện Không Thể Chỉnh Sửa Nữa</p>";
                            txtNgayDi.Enabled = false;
                            txtSLKhach.Enabled = false;
                            txtSLTreEm.Enabled = false;
                        }
                    }

                    
                }
                if (Request.QueryString["_idPhieu"] != null)
                {
                    DataTable dt = new DataTable();
                    dt = AnTour.AppCode.BookingTour.Thongtin_ThongTinPhieuNV_by_id(_id);
                    if (dt.Rows.Count > 0)
                    {
                        txtKH.Text = dt.Rows[0]["tennv"].ToString().Trim();
                        txtTour.Text = dt.Rows[0]["tentour"].ToString().Trim();
                        txtNgayDat.Text = dt.Rows[0]["ngaydat"].ToString().Trim();
                        txtNgayDi.Text = Convert.ToDateTime(dt.Rows[0]["checkin"]).ToString("yyyy-MM-dd");
                        txtSLKhach.Text = dt.Rows[0]["slkhach"].ToString().Trim();
                        txtSLTreEm.Text = dt.Rows[0]["sltreem"].ToString().Trim();
                        matour = dt.Rows[0]["matour"].ToString().Trim();
                        var date = DateTime.Parse(txtNgayDi.Text, new CultureInfo("en-US", true));
                        var datenow = DateTime.Now;
                        if ((dt.Rows[0]["trangthai"].ToString().Trim() != "1") || (date < datenow))
                        {
                            ltlMsg.Text = "<p style='color:red;'>Phiếu Này Hiện Không Thể Chỉnh Sửa Nữa</p>";
                            txtNgayDi.Enabled = false;
                            txtSLKhach.Enabled = false;
                            txtSLTreEm.Enabled = false;
                        }
                    }
                    
                }


            }

        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?modul=CaNhan&modulphu=PhieuDat&thaotac=HienThi");
        }

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            ValidateFormBooking();
            if(ValidateFormBooking() == true)
            {
                if (Session["KH_DangNhap"] != null && Session["KH_DangNhap"].ToString() == "1")
                {
                    AnTour.AppCode.BookingTour.PhieuKH_Update(int.Parse(id), txtNgayDi.Text, int.Parse(txtSLKhach.Text.Trim()), int.Parse(txtSLTreEm.Text.Trim()));
                    ltlMsg.Text = @"<p style='color:red;'>Chỉnh Sửa Thành Công</p>";
                }
                if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
                {
                    AnTour.AppCode.BookingTour.PhieuNV_Update(int.Parse(id), txtNgayDi.Text, int.Parse(txtSLKhach.Text.Trim()), int.Parse(txtSLTreEm.Text.Trim()));
                    ltlMsg.Text = @"<p style='color:red;'>Chỉnh Sửa Thành Công</p>";
                }
            }
        }

        private bool ValidateFormBooking()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.Tour.Thongtin_Tour_by_id(matour);
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
    }
}