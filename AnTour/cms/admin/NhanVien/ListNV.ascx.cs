using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.NhanVien
{
    public partial class ListNV : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                selectListNV();
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

    }
}