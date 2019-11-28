using System;
using System.Collections.Generic;
using System.Linq;
using E_Commerce_Portal.Models;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce_Portal
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Gazebo> GetGazebo()
        {
            var _db = new E_Commerce_Portal.Models.GazeboContext();
            IQueryable<Gazebo> query = _db.Gazebos;
            return query;
        }
    }
}