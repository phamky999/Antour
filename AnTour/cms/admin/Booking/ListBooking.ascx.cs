using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.Booking
{
    public partial class ListBooking : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";
        private string _id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (Request.QueryString["_id"] != null)
                _id = Request.QueryString["_id"];
            if (!IsPostBack)
            {
                LoadListKH();
                //LoadListNV();

            }

            HienThiThongTin(id, _id);


        }
        int loaiKH = 0;
        private void HienThiThongTin(string id, string _id)
        {
            if (thaotac == "HienThi")
            {
                if (Request.QueryString["id"] != null)
                {
                    DataTable dt = new DataTable();
                    dt = AnTour.AppCode.BookingTour.Thongtin_PhieuKH_by_id(id);
                    if (dt.Rows.Count > 0)
                    {
                        txtMaPhieu.Text = dt.Rows[0]["maphieu"].ToString().Trim();
                        txtMaTour.Text = dt.Rows[0]["MaTour"].ToString();
                        txtTenTour.Text = dt.Rows[0]["tentour"].ToString();
                        txtGia.Text = dt.Rows[0]["dongia"].ToString();
                        txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
                        txtHoTen.Text = dt.Rows[0]["TenKH"].ToString();
                        txtNgayDat.Text = dt.Rows[0]["ngaydat"].ToString();
                        txtNgayDi.Text = dt.Rows[0]["checkin"].ToString();
                        txtSLKhach.Text = dt.Rows[0]["slkhach"].ToString();
                        txtSLTreEm.Text = dt.Rows[0]["sltreem"].ToString();
                        txtTrangThai.Text = dt.Rows[0]["TrangThai"].ToString();

                    }
                    loaiKH = 1;
                }
                if (Request.QueryString["_id"] != null)
                {
                    DataTable dt = new DataTable();
                    dt = AnTour.AppCode.BookingTour.Thongtin_PhieuNV_by_id(_id);
                    if (dt.Rows.Count > 0)
                    {
                        txtMaPhieu.Text = dt.Rows[0]["maphieu"].ToString().Trim();
                        txtMaTour.Text = dt.Rows[0]["MaTour"].ToString();
                        txtTenTour.Text = dt.Rows[0]["tentour"].ToString();
                        txtGia.Text = dt.Rows[0]["dongia"].ToString();
                        txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
                        txtHoTen.Text = dt.Rows[0]["TenKH"].ToString();
                        txtNgayDat.Text = dt.Rows[0]["ngaydat"].ToString();
                        txtNgayDi.Text = dt.Rows[0]["checkin"].ToString();
                        txtSLKhach.Text = dt.Rows[0]["slkhach"].ToString();
                        txtSLTreEm.Text = dt.Rows[0]["sltreem"].ToString();
                        txtTrangThai.Text = dt.Rows[0]["TrangThai"].ToString();

                    }
                    loaiKH = 2;
                }


            }

        }


        private void LoadListKH()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.BookingTour.Thongtin_ListPhieuKH();
            LtlMsg.Text = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                ltlTour.Text += @"
<tr id='maDong_" + dt.Rows[i]["maphieu"] + @"'>
                <th scope='col'>" + dt.Rows[i]["maphieu"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["MaTour"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["tentour"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["dongia"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["MaKH"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["TenKH"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["ngaydat"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["checkin"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["slkhach"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["sltreem"] + @"</th>
                <th scope='col'>" + dt.Rows[i]["TrangThai"] + @"</th>
                <th scope='col'><a href='Admin.aspx?modul=PhieuDat&thaotac=HienThi&id=" + dt.Rows[i]["maphieu"] + @"'><i class='far fa-edit' title='Chỉnh Sửa'></i></a></th>
            </tr>

";

            }

        }

//        private void LoadListNV()
//        {
//            DataTable dt = new DataTable();
//            dt = AnTour.AppCode.BookingTour.Thongtin_ListPhieuNV();
//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                Literal1.Text += @"
//<tr id='maDong_" + dt.Rows[i]["maphieu"] + @"'>
//                <th scope='col'>" + dt.Rows[i]["maphieu"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["MaTour"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["tentour"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["dongia"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["MaKH"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["TenKH"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["ngaydat"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["checkin"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["slkhach"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["sltreem"] + @"</th>
//                <th scope='col'>" + dt.Rows[i]["TrangThai"] + @"</th>
//                <th scope='col'><a href='Admin.aspx?modul=PhieuDat&thaotac=HienThi&_id=" + dt.Rows[i]["maphieu"] + @"'><i class='far fa-edit' title='Chỉnh Sửa'></i></a></th>
//            </tr>

//";

//            }

//        }


       
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                if (txtTrangThai.Text.Trim() == "Thanh Toán")
                {
                    if (txtNgayDi.Text.Trim() != "")
                    {
                        var date = DateTime.Parse(txtNgayDi.Text, new CultureInfo("en-US", true));
                        var datenow = DateTime.Now;
                        if (date < datenow)
                        {
                            LtlMsg.Text = "<p style='color:red;'>Tour Này Đã Thanh Toán Và Đã Được Di Chuyển</p>";
                        }
                        else
                        {

                            if (loaiKH == 1)
                            {
                                AnTour.AppCode.BookingTour.BookingTourKH_Update(int.Parse(txtMaPhieu.Text.Trim()), 0);
                                Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi&id=" + txtMaPhieu.Text.Trim());
                            }
                            if (loaiKH == 2)
                            {
                                if (txtMaKH.Text.Trim() == Session["NV_MaNV"].ToString())
                                {
                                    LtlMsg.Text = "<p style='color:red;'>Bạn Không Được Thao Tác Với Phiếu Đặt Của Chính Bạn</p>";
                                }
                                else
                                {
                                    AnTour.AppCode.BookingTour.BookingTourNV_Update(int.Parse(txtMaPhieu.Text.Trim()), 0);
                                    Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi&_id=" + txtMaPhieu.Text.Trim());
                                }

                            }
                        }

                    }

                }
                else if (txtTrangThai.Text.Trim() == "Hủy")
                {
                    LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Này Đã Được Thanh Toán Và Đã Hủy</p>";
                }
                else
                {
                    LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Này Chưa Được Thanh Toán</p>";
                }

            }
        }

        protected void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                if (txtNgayDi.Text.Trim() != "")
                {
                    var date = DateTime.Parse(txtNgayDi.Text, new CultureInfo("en-US", true));
                    var datenow = DateTime.Now;
                    if (date < datenow)
                    {
                        LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Hết Hạn Do Ngày Đi Nhỏ Hơn Ngày Hiện Tại</p>";
                    }
                    else
                    {
                        if (txtTrangThai.Text.Trim() == "Đăng Ký")
                        {
                            if (loaiKH == 1)
                            {

                                AnTour.AppCode.BookingTour.BookingTourKH_Update(int.Parse(txtMaPhieu.Text.Trim()), 2);
                                Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi&id=" + txtMaPhieu.Text.Trim());
                                LtlMsg.Text = "<p style='color:red;'>Xác Nhận Thành Công</p>";
                            }
                            if (loaiKH == 2)
                            {
                                AnTour.AppCode.BookingTour.BookingTourNV_Update(int.Parse(txtMaPhieu.Text.Trim()), 2);
                                Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi&_id=" + txtMaPhieu.Text.Trim());
                                LtlMsg.Text = "<p style='color:red;'>Xác Nhận Thành Công</p>";
                            }
                        }
                        else if (txtTrangThai.Text.Trim() == "Hủy")
                        {
                            LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Này Đã Được Thanh Toán Và Đã Hủy</p>";
                        }
                        else if (txtTrangThai.Text.Trim() == "Xác Nhận")
                        {
                            LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Này Đã Được Xác Nhận</p>";
                        }
                        else if (txtTrangThai.Text.Trim() == "Thanh Toán")
                        {
                            LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Này Đã Được Thanh Toán</p>";
                        }
                    }
                }

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnXacNhanTT_Click(object sender, EventArgs e)
        {
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                if (txtNgayDi.Text.Trim() != "")
                {
                    var date = DateTime.Parse(txtNgayDi.Text, new CultureInfo("en-US", true));
                    var datenow = DateTime.Now;
                    if (date < datenow)
                    {
                        LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Hết Hạn Do Ngày Đi Nhỏ Hơn Ngày Hiện Tại</p>";
                    }
                    else
                    {
                        if (txtTrangThai.Text.Trim() == "Đăng Ký" || txtTrangThai.Text.Trim() == "Xác Nhận")
                        {
                            if (loaiKH == 1)
                            {
                                //update trang thai
                                AnTour.AppCode.BookingTour.BookingTourKH_Update(int.Parse(txtMaPhieu.Text.Trim()), 3);
                                //update ngay dat la ngay thanh toan:
                                AnTour.AppCode.BookingTour.BookingTourKH_UpdateNgDat(int.Parse(txtMaPhieu.Text.Trim()), DateTime.Now.ToString("MM/dd/yyyy"));
                                Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi&id=" + txtMaPhieu.Text.Trim());
                            }
                            if (loaiKH == 2)
                            {
                                if (txtMaKH.Text.Trim() == Session["NV_MaNV"].ToString())
                                {
                                    LtlMsg.Text = "<p style='color:red;'>Bạn Không Được Thao Tác Với Phiếu Đặt Của Chính Bạn</p>";
                                }
                                else
                                {
                                    AnTour.AppCode.BookingTour.BookingTourNV_Update(int.Parse(txtMaPhieu.Text.Trim()), 3);
                                    AnTour.AppCode.BookingTour.BookingTourNV_UpdateNgDat(int.Parse(txtMaPhieu.Text.Trim()), DateTime.Now.ToString("MM/dd/yyyy"));
                                    Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi&_id=" + txtMaPhieu.Text.Trim());

                                }
                            }
                        }


                        if (txtTrangThai.Text.Trim() == "Hủy")
                        {
                            LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Này Đã Thanh Toán Và Đã Được Hủy</p>";
                        }
                        else if (txtTrangThai.Text.Trim() == "Thanh Toán")
                        {
                            LtlMsg.Text = "<p style='color:red;'>Phiếu Đặt Này Đã Được Thanh Toán</p>";
                        }
                    }
                }


            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                if (txtNgayDi.Text.Trim() != "")
                {
                    var date = DateTime.Parse(txtNgayDi.Text, new CultureInfo("en-US", true));
                    var datenow = DateTime.Now;
                    if (date < datenow)
                    {
                        if (txtTrangThai.Text.Trim() == "Đăng Ký" || txtTrangThai.Text.Trim() == "Xác Nhận")
                        {
                            if (loaiKH == 1)
                            {
                                AnTour.AppCode.BookingTour.BookingTour_Delete(txtMaPhieu.Text.Trim());
                                AnTour.AppCode.BookingTour.BookingTourKH_Update(int.Parse(txtMaPhieu.Text.Trim()), 2);
                                Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi");
                                LtlMsg.Text = "<p style='color:red;'>Xóa Thành Công</p>";
                            }
                            if (loaiKH == 2)
                            {
                                AnTour.AppCode.BookingTour.BookingTourNV_Delete(txtMaPhieu.Text.Trim());
                                AnTour.AppCode.BookingTour.BookingTourNV_Update(int.Parse(txtMaPhieu.Text.Trim()), 2);
                                Response.Redirect("Admin.aspx?modul=PhieuDat&thaotac=HienThi");
                                LtlMsg.Text = "<p style='color:red;'>Xóa Thành Công</p>";
                            }
                        }
                        else if (txtTrangThai.Text.Trim() == "Hủy" || txtTrangThai.Text.Trim() == "Thanh Toán")
                        {
                            LtlMsg.Text = "<p style='color:red;'>Tour Này Đã Hoàn Thành</p>";
                        }
                    }
                    else
                    {
                        LtlMsg.Text = "<p style='color:red;'>Không Thể Xóa Phiếu Này - Chờ Phản Hồi Từ Khách Hàng</p>";
                    }
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}