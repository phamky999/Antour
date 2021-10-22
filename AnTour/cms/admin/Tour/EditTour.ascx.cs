using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.Tour
{
    public partial class EditTour : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id của danh mục cần chỉnh sửa
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                LoadList();
            }
            
            HienThiThongTin(id);
            
        }

        private void HienThiThongTin(string id)
        {
            if (thaotac == "ChinhSua")
            {
                DataTable dt = new DataTable();
                dt = AnTour.AppCode.Tour.Thongtin_Tour_by_id(id);
                if (dt.Rows.Count > 0)
                {
                    txtMa.Text = dt.Rows[0]["ma"].ToString().Trim();
                    txtTenTour.Text = dt.Rows[0]["tentour"].ToString();
                    Literal1.Text = dt.Rows[0]["urlimage"].ToString();
                    txtAddr.Text = dt.Rows[0]["diadiem"].ToString();
                    txtGia.Text = dt.Rows[0]["dongia"].ToString();
                    txtSLMax.Text = dt.Rows[0]["slkhachtoida"].ToString();
                    txtSoNgay.Text = dt.Rows[0]["songaytour"].ToString();
                    txtNgayTao.Text = dt.Rows[0]["ngaytao"].ToString();
                    CKEditorControl1.Text = dt.Rows[0]["gioithieu"].ToString();
                    ltrAnhDaiDien.Text = "<img src='pictures/TourImg/" + dt.Rows[0]["urlimage"] + @"'/>";
                    hdTenAnhDaiDienCu.Value = dt.Rows[0]["urlimage"].ToString();
                }
                
            }

        }


        private void LoadList()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.Tour.List_Tour();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltlTour.Text += @"
                <tr id='maDong_" + dt.Rows[i]["ma"] + @"'>
                    <th scope='row'>" + dt.Rows[i]["ma"] + @"</th>
                    <td>" + dt.Rows[i]["tentour"] + @"</td>
                    <td>
                        <div class='container-img'>
                            <img src='/pictures/TourImgs/" + dt.Rows[i]["urlimage"] + @"' alt='Ảnh Tour' class='imgTour'>
                            <img src='/pictures/TourImgs/" + dt.Rows[i]["urlimage"] + @"' alt='Hover' class='imgTour_hover'>
                        </div>
                    </td>
                    <td>" + dt.Rows[i]["diadiem"] + @"</td>
                    <td>" + dt.Rows[i]["songaytour"] + @"</td>
                    <td>" + dt.Rows[i]["slkhachtoida"] + @"</td>
                    <td>" + dt.Rows[i]["dongia"] + @"</td>
                    <td>" + dt.Rows[i]["ngaytao"] + @"</td>
                    <td>
                        <a href='Admin.aspx?modul=Tour&thaotac=ChinhSua&id=" + dt.Rows[i]["ma"] + @"'><i class='far fa-edit' title='Chỉnh Sửa'></i></a>
                    </td>
            </tr>";
                /*
                 <td class='cotCongCu'>
                   <a href='Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ChinhSua&id=" + dt.Rows[i]["MaSP"] + @"' class='sua' title='Sửa'></a>
                   <a href='javascript:XoaSanPham(" + dt.Rows[i]["MaSP"] + @")' class='xoa' title='Xóa'></a>
               </td>
                 */

            }

        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            #region code nút chỉnh sửa
            string tenAnhDaiDien = "";

            if (fileUrl.FileContent.Length > 0)
            {
                if (fileUrl.FileName.EndsWith(".jpeg") || fileUrl.FileName.EndsWith(".jpg") || fileUrl.FileName.EndsWith(".png") || fileUrl.FileName.EndsWith(".gif"))
                {
                    fileUrl.SaveAs(Server.MapPath("pictures/TourImgs/") + fileUrl.FileName);
                    tenAnhDaiDien = fileUrl.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            AnTour.AppCode.Tour.Tour_Update(int.Parse(id), txtTenTour.Text.Trim(), tenAnhDaiDien, CKEditorControl1.Text.Trim(), txtAddr.Text.Trim(), int.Parse(txtSoNgay.Text.Trim()), int.Parse(txtSLMax.Text.Trim()), float.Parse(txtGia.Text.Trim()), txtNgayTao.Text.Trim(), 1);
            
            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=Tour&thaotac=HienThi");

            #endregion
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["NV_Quyen"] != null && Session["NV_Quyen"].ToString() == "3")
            {
                if( txtMa.Text.Trim() != "")
                {
                    AnTour.AppCode.Tour.Tour_UpdateTT(int.Parse(txtMa.Text.Trim()), 0);
                }
                else
                {
                    Literal2.Text = "<p style='color:red;'>Vui lòng chọn tour hợp lệ!</p>";
                }
                
            }
            else
            {
                Literal2.Text = "<p style='color:red;'>Bạn không có quyền thực hiện thao tác này!</p>";
            }
        }

        protected void btnHuyTour_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx?modul=Tour&thaotac=HienThi");
        }
    }
}