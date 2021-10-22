using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.CaNhan
{
    public partial class UserTour : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadPhieuDat();
        }
        private void loadPhieuDat()
        {
            if(Session["KH_MaKH"] != null || Session["NV_MaNV"]!= null)
            {
                if(Session["KH_MaKH"] != null || Session["NV_MaNV"] == null)
                {
                    DataTable dt = AnTour.AppCode.BookingTour.Thongtin_Phieu_by_idKH(Session["KH_MaKH"].ToString());
                    if(dt.Rows.Count > 0)
                    {
                        txtHoTen.Text = dt.Rows[0]["TenKH"].ToString();
                        txtGT.Text = dt.Rows[0]["GT"].ToString();
                        txtCmtnd.Text = dt.Rows[0]["cmtnd"].ToString();
                        txtSDT.Text = dt.Rows[0]["sdt"].ToString();
                        txtEmail.Text = dt.Rows[0]["email"].ToString();
                        txtDiaChi.Text = dt.Rows[0]["diachi"].ToString();
                    }
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        ltlListBooking.Text += @"
                                                    <tr  id='maDong_"+dt.Rows[i]["maphieu"]+@"'>
                                                        <td>
                                                            <a href='Default.aspx?modul=Tours&modulphu=detail&id=" + dt.Rows[i]["matour"] + @"' >" + dt.Rows[i]["tentour"] + @"</a>
                                                        </td>
                                                        <td>" + dt.Rows[i]["DD"] + @"</td>
                                                        <td>" + dt.Rows[i]["songaytour"] + @"</td>
                                                        <td>" + dt.Rows[i]["dongia"] + @"</td>
                                                        <td>" + dt.Rows[i]["ngaydat"] + @"</td>
                                                        <td>" + dt.Rows[i]["checkin"] + @"</td>
                                                        <td>" + dt.Rows[i]["slkhach"] + @"</td>
                                                        <td>" + dt.Rows[i]["sltreem"] + @"</td>
                                                        <td>" + dt.Rows[i]["TrangThai"] + @"</td>
                                                        <td>
                                                            <a href='Default.aspx?modul=CaNhan&modulphu=PhieuDat&thaotac=ChinhSua&idPhieu=" + dt.Rows[i]["maphieu"] + @"' ><i class='fas fa-edit' title='Chỉnh Sửa Phiếu'></i></a>
                                                            <a href='javascript:XoaSanPham(" + dt.Rows[i]["maphieu"] + @")' class='xoa' title='Hủy Đặt Tour'><i class='far fa-trash-alt' title='Hủy Đặt Tour'></i></a>

                                                        </ td>
                                                    </tr>
                                                 ";
                    }
                }
                
                else if (Session["KH_MaKH"] == null || Session["NV_MaNV"] != null)
                {
                    return;
                    //DataTable dt = AnTour.AppCode.BookingTour.Thongtin_Phieu_by_idNV(Session["NV_MaNV"].ToString());
                    //if (dt.Rows.Count > 0)
                    //{
                    //    txtHoTen.Text = dt.Rows[0]["TenKH"].ToString();
                    //    txtGT.Text = dt.Rows[0]["GT"].ToString();
                    //    txtCmtnd.Text = dt.Rows[0]["cmtnd"].ToString();
                    //    txtSDT.Text = dt.Rows[0]["sdt"].ToString();
                    //    txtEmail.Text = dt.Rows[0]["email"].ToString();
                    //    txtDiaChi.Text = dt.Rows[0]["diachi"].ToString();
                    //}
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    ltlListBooking.Text += @"
                    //                                <tr  id='maDong_" + dt.Rows[i]["maphieu"] + @"'>
                    //                                    <td>
                    //                                        <a href='Default.aspx?modul=Tours&modulphu=detail&id=" + dt.Rows[i]["matour"] + @"' >" + dt.Rows[i]["tentour"] + @"</a>
                    //                                    </td>
                    //                                    <td>" + dt.Rows[i]["DD"] + @"</td>
                    //                                    <td>" + dt.Rows[i]["songaytour"] + @"</td>
                    //                                    <td>" + dt.Rows[i]["dongia"] + @"</td>
                    //                                    <td>" + dt.Rows[i]["ngaydat"] + @"</td>
                    //                                    <td>" + dt.Rows[i]["checkin"] + @"</td>
                    //                                    <td>" + dt.Rows[i]["slkhach"] + @"</td>
                    //                                    <td>" + dt.Rows[i]["sltreem"] + @"</td>
                    //                                    <td>" + dt.Rows[i]["TrangThai"] + @"</td>
                    //                                    <td>
                    //                                        <a href='Default.aspx?modul=CaNhan&modulphu=PhieuDat&thaotac=ChinhSua&_idPhieu=" + dt.Rows[i]["maphieu"] + @"' ><i class='fas fa-edit' title='Chỉnh Sửa Phiếu'></i></a>
                    //                                        <a href='javascript:XoaSanPham(" + dt.Rows[i]["maphieu"] + @")' class='xoa' ><i class='far fa-trash-alt' title='Hủy Đặt Tour'></i></a>

                    //                                      </td>
                    //                                </tr>
                    //                             ";
                    //}

                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
            
        }

        
    }
}