using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnTour.cms.display.Tours
{
    public partial class TourLoad : System.Web.UI.UserControl
    {
        private string modul = "";
        private string modulphu = "";
        private string thaotac = "";
        private string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];

            switch (modulphu)
            {
                case "List":
                    plLoadControl.Controls.Add(LoadControl("ListTours.ascx"));
                    break;
                case "Search":
                    plLoadControl.Controls.Add(LoadControl("SearchTour.ascx"));
                    break;
                case "detail":
                    plLoadControl.Controls.Add(LoadControl("TourDetail.ascx"));
                    break;
                default:
                    plLoadControl.Controls.Add(LoadControl("ListTour.ascx"));
                    break;

            }
        }

    }
}