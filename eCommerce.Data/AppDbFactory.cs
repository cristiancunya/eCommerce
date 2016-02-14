using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Data
{
    public class AppDbFactory
    {

        public Database AppDatabase { get; private set; }

        public AppDbFactory()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            AppDatabase = factory.Create("dbeCommerce");
        }

    }
}
