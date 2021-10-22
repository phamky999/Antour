using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.NhanVien
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id của danh mục cần chỉnh sửa
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NV_Quyen"].ToString() == "2")
            {


                Response.Redirect("Admin.aspx");
            }
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                AnTour.AppCode.SQLDatabase.LoadDDL(ddlQuyen, "GROUPUSER", "tenquyen", "maquyen");
                AnTour.AppCode.SQLDatabase.LoadDDL(ddlTrangthai, "TRANGTHAINV", "ten", "ma");
                //loadQuyen();
                //loadTrangthai();
                selectListNV();
            }
            HienThiThongTin(id);

        }

        private void selectListNV()
        {
            DataTable tb = AnTour.AppCode.NhanVien.Thongtin_NhanVien();
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    ltlLoadListNV.Text += @"<tr>
                                       <td scope='col'>" + tb.Rows[i]["manv"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["tennv"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["gioitinh"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["cmtnd"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["sdt"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["email"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["diachi"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["tendangnhap"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["tenquyen"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["trangthai"] + @"</td>
                                       <td scope='col'><a href='Admin.aspx?modul=NhanVien&thaotac=AdEdit&id=" + tb.Rows[i]["manv"] + @"' title='Sửa'><i class='fas fa-user-edit' title='Chỉnh Sửa'></i></a></td>
                                         </tr> ";
                }
            }
        }

        private void HienThiThongTin(string id)
        {
            if (thaotac == "AdEdit")
            {


                DataTable dt = new DataTable();

                dt = AnTour.AppCode.NhanVien.Thongtin_NV_by_idnv(id);
                if (dt.Rows.Count > 0)
                {
                    txtHoten.Text = dt.Rows[0]["tennv"].ToString();
                    txtMaNV.Text = dt.Rows[0]["manv"].ToString();
                    ddlQuyen.SelectedValue = dt.Rows[0]["quyen"].ToString();
                    ddlTrangthai.SelectedValue = dt.Rows[0]["trangthai"].ToString();

                }
            }

        }

        private void loadQuyen()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.NhanVien.Thongtin_Quyen();
            ddlQuyen.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlQuyen.Items.Add(new ListItem(dt.Rows[i]["tenquyen"].ToString(), dt.Rows[i]["maquyen"].ToString()));

            }
        }
        private void loadTrangthai()
        {
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.NhanVien.Thongtin_TrangThaiNV();
            ddlTrangthai.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlTrangthai.Items.Add(new ListItem(dt.Rows[i]["ten"].ToString(), dt.Rows[i]["ma"].ToString()));

            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx?modul=NhanVien&thaotac=HienThi");
        }



        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Session["NV_DangNhap"] != null && Session["NV_DangNhap"].ToString() == "1")
            {
                if(txtMaNV.Text.Trim() != "")
                {
                    AnTour.AppCode.NhanVien.NV_AdminUpdate(int.Parse(txtMaNV.Text.Trim()), int.Parse(ddlQuyen.SelectedValue), int.Parse(ddlTrangthai.SelectedValue));
                    Response.Redirect("Admin.aspx?modul=NhanVien&thaotac=AdEdit");
                }
                else
                {
                    ltlMsg.Text += "<p>Vui lòng chọn nhân viên hợp lệ</p>";
                }
                

            }
            else
            {
                Response.Redirect("/Login.aspx");
            }


        }
    }
}