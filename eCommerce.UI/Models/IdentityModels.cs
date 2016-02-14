using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.UI.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Direccion { get; set; }
    }

    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("dbeCommerce")
        {

        }
    }

    public class UserManager: UserManager<ApplicationUser>
    {
        public UserManager()
            :base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }
    }

}