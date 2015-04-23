using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
     ShowTrackerEntities db = new ShowTrackerEntities();   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var artists = from a in db.Artists
                              orderby a.ArtistName
                              select new { a.ArtistName, a.ArtistKey };
                
                DropDownList1.DataSource = artists.ToList();
                // ArtistName has to match the a.ArtistName from the above query
                DropDownList1.DataTextField = "ArtistName";
                // it will display the ArtistName but store the ArtistKey
                DropDownList1.DataValueField = "ArtistKey";
                // not sure why this is needed but ask rick> or look online
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            var shows = from s in db.Shows
                        // create an inner join here
                        //from a in s.
                        orderby s.ShowName
                        // why can't I reference the above a.ArtistName???
                        //where a.ArtistKey == key
                        where s.ShowKey == key
                        select new
                        {
                            s.ShowName,
                            //a.ArtistName,
                            s.ShowDate,
                            s.ShowTime
                        };
            GridView1.DataSource = shows.ToList();
            GridView1.DataBind();
        }
    }
}