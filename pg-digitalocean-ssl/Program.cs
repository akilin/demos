using Npgsql;

namespace pg_digitalocean_ssl
{
    static class Program
    {
        static void Main(string[] args)
        {
            var conStr = new NpgsqlConnectionStringBuilder
            {
                Host = "db-postgresql-fra1-85405-do-user-9543433-0.b.db.ondigitalocean.com",
                Database = "postgres",
                Username = "doadmin",
                Password = "zyk19s2agqce2czf",
                Port = 25060,
                SslMode = SslMode.Require,
                RootCertificate = "ca-certificate.crt"
            }.ConnectionString;
            new NpgsqlConnection(conStr).Open();
        }
    }
}