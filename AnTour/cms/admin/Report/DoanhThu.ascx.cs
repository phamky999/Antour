using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace AnTour.cms.admin.Report
{
    public partial class DoanhThu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            
        }
        private void getChartData(string a, string b)
        {
            Series series = ChartDoanhThuThang.Series["Series1"];
            DataTable tb = AnTour.AppCode.Reports.DoanhThu_Month(a, b);
            if(tb.Rows.Count > 0)
            {
                for(int i = 0; i < tb.Rows.Count; i++)
                {
                    series.Points.AddXY(tb.Rows[i]["ngaydat"], tb.Rows[i]["DoanhThu"]);
                }
            }
            
        }

        protected void btnXem_Click(object sender, EventArgs e)
        {
            if(txtDay.Text.Trim() == "")
            {
                ltlMsg.Text = "<p style='color:red;'>Vui Lòng Chọn Ngày</p>";

            }
            else if (DateTime.Parse(txtDay.Text, new CultureInfo("en-US", true)) > DateTime.Now)
            {
                ltlMsg.Text = "<p style='color:red;'>Vui Lòng Chọn Ngày Hợp Lệ</p>";
            }
            else if (DateTime.Parse(txtDay.Text, new CultureInfo("en-US", true)) <= DateTime.Now)
            {
                ltlMsg.Text = "";
                DataTable tb = AnTour.AppCode.Reports.DoanhThu_Ngay(txtDay.Text.Trim());
                if (tb.Rows.Count > 0)
                {
                    txtDoanhThu.Text = tb.Rows[0]["DoanhThu"].ToString().Trim();
                    txtSLPhieu.Text = tb.Rows[0]["SoPhieu"].ToString().Trim();
                }
                else
                {
                    txtDoanhThu.Text = "0";
                    txtSLPhieu.Text = "0";
                }
                DataTable dt = AnTour.AppCode.Reports.ListPhieu_Ngay(txtDay.Text.Trim());
                ltlLoadListPhieu.Text = "";
                if(dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        ltlLoadListPhieu.Text += @"<tr>
                                       <td scope='col'>" + dt.Rows[i]["maphieu"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["TenKH"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["tentour"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["dongia"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["ngaydat"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["checkin"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["slkhach"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["sltreem"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["TrangThai"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["giatien"] + @"</td>
                                       </tr> ";
                    }
                }
            }
            PlLoadTable.Visible = true;
            //ltlMsg.Text = "" + DateTime.Parse(txtDay.Text, new CultureInfo("en-US", true)) + " and now: " +DateTime.Now + " and "+Convert.ToDateTime("2011-01-30")+"";
            

        }

        protected void btnXemMonth_Click(object sender, EventArgs e)
        {
            double sumDoanhThu = 0;
            double sumPhieu = 0;
            Series series = ChartDoanhThuThang.Series["Series1"];
            DataTable tb = AnTour.AppCode.Reports.DoanhThu_Month(ddlMonth.SelectedValue, txtYear.Text.Trim());
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    sumDoanhThu += double.Parse(tb.Rows[i]["DoanhThu"].ToString().Trim());
                    sumPhieu += double.Parse(tb.Rows[i]["SoPhieu"].ToString().Trim());
                    series.Points.AddXY(tb.Rows[i]["ngaydat"], tb.Rows[i]["DoanhThu"]);
                }
                txtTongDThu.Text = "" + sumDoanhThu;
                txtTongPDat.Text = "" + sumPhieu;
                DataTable dt = AnTour.AppCode.Reports.ListPhieu_Thang(ddlMonth.SelectedValue,txtYear.Text.Trim());
                ltlLoadListMonth.Text = "";
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ltlLoadListMonth.Text += @"<tr>
                                       <td scope='col'>" + dt.Rows[i]["maphieu"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["TenKH"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["tentour"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["dongia"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["ngaydat"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["checkin"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["slkhach"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["sltreem"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["TrangThai"] + @"</td>
                                       <td scope='col'>" + dt.Rows[i]["giatien"] + @"</td>
                                       </tr> ";
                    }
                }
            }
            //bool matchs = Regex.IsMatch(txtYear.Text.Trim(), @"^\d+[^\D]+\d$");
            //if(matchs == false)
            //{
            //    Response.Redirect("Admin.aspx?modul=Report&modulphu=DoanhThu&thaotac=HienThi");
            //    ltlMessage.Text = "false";

            //}
            //else
            //{
            //    Response.Redirect("Admin.aspx?modul=Report&modulphu=DoanhThu&thaotac=HienThi");
            //    ltlMessage.Text = "true";
            //}

        }

    }
}