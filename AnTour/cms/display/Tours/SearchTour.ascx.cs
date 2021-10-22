using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.Tours
{
    public partial class SearchTour : System.Web.UI.UserControl
    {
        protected string tukhoa = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["tukhoa"] != null)
                tukhoa = Request.QueryString["tukhoa"];
            if (!IsPostBack)
            {
                ltlListTours.Text = LoadListTours();
            }
        }

        private string LoadListTours()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = AnTour.AppCode.Tour.Thongtin_Tour_by_tukhoa(tukhoa);
            string link = "";
            if(dt.Rows.Count > 0)
            {
                LtlMsgSearch.Text = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    link = "Default.aspx?modul=Tours&modulphu=detail&id=" + dt.Rows[i]["ma"] + "";
                    s += @"
                        <div class='col-md-4 col-sm-6 p-3'>
                            <div class='single-package-item'>
                                <div style='width:95%; height:auto; margin-left:auto; margin-right:auto;'>
                                    <img src='../../../pictures/TourImgs/" + dt.Rows[i]["urlimage"] + @"' alt='" + dt.Rows[i]["tentour"] + @"' style='max-width:100%; max-height:100%;'>
                                </div>
                                
                                <div class='single-package-item-txt' style='width:95%; height:auto; margin-left:auto; margin-right:auto;'>
                                    <h3>" + dt.Rows[i]["tentour"] + @"</h3>
                                    <div class='packages-para'>
                                        <p>
                                            <span>
                                                <i class='fa fa-angle-right'></i>Giá: " + dt.Rows[i]["dongia"] + @" vnđ
                                            </span>
                                            
                                            <span class='float-right'>
                                                <i class='fa fa-angle-right'></i>Số Ngày: " + dt.Rows[i]["songaytour"] + @"
                                            </span>
                                        </p>
                                        <p>
                                            <span>
                                                <i class='fa fa-angle-right'></i>Địa Điểm: " + dt.Rows[i]["diadiem"] + @"
                                            </span>
                                            <span class='float-right'>
                                                <i class='fa fa-angle-right'></i> Tối Đa: " + dt.Rows[i]["slkhachtoida"] + @" Người
                                            </span>
                                            
                                        </p>
                                    </div>
                                    <div class='packages-review'>
                                        <p>
                                            <i class='fa fa-star'></i>
                                            <i class='fa fa-star'></i>
                                            <i class='fa fa-star'></i>
                                            <i class='fa fa-star'></i>
                                            <i class='fa fa-star'></i>
                                            <span>2544 review</span>
                                        </p>
                                    </div>
                                    <div class='about-btn row'>
                                        <a href='" + link + @"' title='" + dt.Rows[i]["tentour"] + @"' class='about-view packages-btn btn btn-info col' role='button'>Chi Tiết</a>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                        ";
                }
            }
            else
            {
                LtlMsgSearch.Text = "Không có dữ liệu tour phù hợp cho từ khóa: " + tukhoa + "";
            }
            
            return s;
        }

    }
}