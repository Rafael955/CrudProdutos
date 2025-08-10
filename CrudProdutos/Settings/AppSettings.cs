using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Settings
{
    public static class AppSettings
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDCrudProdutos;Integrated Security=True;";
        }
    }
}
