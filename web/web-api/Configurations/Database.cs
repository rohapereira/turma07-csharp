namespace web_api.Configurations
{
    public class Database
    {
        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["consultorio"].ConnectionString;
        }
    }
}