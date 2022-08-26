using Microsoft.Data.SqlClient;

namespace JokesWebApp.Data
{
    internal class JokeDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-JokesWebApp-184CF329-980D-4746-9E51-1AAC46782E50;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public JokeDAO()
        {
        }

        public void LikeJoke(int id)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"UPDATE Joke SET Score += 1 WHERE Id = {id}";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
            }
        }
    }
}