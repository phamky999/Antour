using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.KhachHang
{
    public partial class ListKH : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                selectListKH();
        }
        private void selectListKH()
        {
            DataTable tb = AnTour.AppCode.KhachHang.Thongtin_Khachhang();
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    ltlKhachHang.Text += @"<tr>
                                       <td scope='col'>" + tb.Rows[i]["makh"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["tenkh"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["gioitinh"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["cmtnd"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["sdt"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["email"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["diachi"] + @"</td>
                                       <td scope='col'>" + tb.Rows[i]["tendangnhap"] + @"</td>
                                       </tr> ";
                }
            }
        }
    }
}