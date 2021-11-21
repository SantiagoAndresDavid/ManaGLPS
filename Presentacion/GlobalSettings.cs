using Microsoft.Extensions.Configuration;

namespace Presentacion
{
    public static class GlobalSettings 
    {
        public static IConfiguration Configuration => new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .Build();
        
    }
}