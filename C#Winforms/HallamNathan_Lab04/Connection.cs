using Microsoft.Extensions.Configuration;

namespace HallamNathan_Lab04
{
    public static class Connection
    {
        public static string Get()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

            IConfiguration Configuration = builder.Build();

            string con = Configuration["configuration:pubsapiurl"];

            return con;
        }
    }
}
