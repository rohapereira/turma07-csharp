namespace web_api_faculdade.Configurations
{
    public class Database
    {
        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["faculdade"].ConnectionString;
        }
    }
}