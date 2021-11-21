using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Presentacion
{
    public static class ConfigConnectionString
    {
        public static string ConnectionString = GlobalSettings.Configuration.GetConnectionString("DefaultConnection");
    }
}
