using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.Tour
{
    public partial class TourLoad : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadList();
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

            }

        }
    }
}