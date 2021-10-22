using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.Tour
{
    public partial class InsertTour : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id của sản phẩm cần chỉnh sửa
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                txtNgayTao.Text = DateTime.Now.ToString("MM/dd/yyyy");


            }

        }
      
        private void ResetControl()
        {
            txtAddr.Text = "";
            txtGia.Text = "";
            txtNgayTao.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtSLMax.Text = "";
            txtSoNgay.Text = "";
            txtTenTour.Text = "";
            CKEditorControl1.Text = "";
        }
       

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                if(thaotac == "ThemMoi")
                {
                    #region code nút thêm mới
                    if (fileUrl.FileContent.Length > 0)
                    {
                        if (fileUrl.FileName.EndsWith(".jpeg") || fileUrl.FileName.EndsWith(".jpg") || fileUrl.FileName.EndsWith(".png") || fileUrl.FileName.EndsWith(".gif"))
                        {
                            fileUrl.SaveAs(Server.MapPath("pictures/TourImgs/") + fileUrl.FileName);
                        }
                    }
                    //else ltrThongBao.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";

                    AnTour.AppCode.Tour.Tour_Insert(txtTenTour.Text.Trim(), fileUrl.FileName, CKEditorControl1.Text, txtAddr.Text.Trim(), int.Parse(txtSoNgay.Text.Trim()), int.Parse(txtSLMax.Text.Trim()), int.Parse(txtGia.Text.Trim()), txtNgayTao.Text, 1);
                    LtlMsg.Text = "<div>Đã tạo " + txtTenTour.Text + " thành công!</div>";

                    if (cbAdd.Checked)
                    {
                        //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                        ResetControl();
                    }

                    else
                    {
                        //đẩy trang về trang danh sách các damnh mục đã tạo

                        Response.Redirect("Admin.aspx?modul=Tour&thaotac=HienThi");
                    }
                    #endregion
                }
            }
        }


        protected void btnHuyTour_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}