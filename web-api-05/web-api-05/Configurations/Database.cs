namespace web_api_05.Configurations
{
    public class Database
    {
        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["papelaria"].ConnectionString;
        }
    }
}