using eCommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity.Owin;

namespace eCommerce.UI.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            var manager = new UserManager();
            var user = new ApplicationUser();
            user.UserName = txtUserName.Text;
            user.Direccion = txtDireccion.Text; 
            manager.CreateAsync(user);

        }
    }
}