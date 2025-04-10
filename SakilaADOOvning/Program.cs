using Microsoft.Data.SqlClient;


namespace SakilaADOOvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sakila;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            Console.WriteLine("Fyll i skådespelarens förnamn: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Fyll i skådespelarens efternamn: ");
            var lastName = Console.ReadLine();

            //var command = connection.CreateCommand();
            var command1 = new SqlCommand($"SELECT f.title\r\n" +
                $"FROM Film f " +
                $"\r\nINNER JOIN film_actor fa ON f.film_id = fa.film_id" +
                $"\r\nINNER JOIN actor a ON fa.actor_id = a.actor_id" +
                $"\r\nWHERE a.first_name = '{firstName}' AND a.last_name = '{lastName}'" +
                $"\r\nGROUP BY a.first_name, a.last_name, f.title" +
                $"\r\nORDER BY a.first_name;"
                , connection);

            Console.Clear();

            connection.Open();
            var rec = command1.ExecuteReader();


            if (rec.HasRows)
            {
                Console.WriteLine($"{firstName.ToUpper()} {lastName.ToUpper()} is a star in the following movies: ");
                Console.WriteLine();

                while (rec.Read())
                {
                    Console.WriteLine($"{rec[0]}");
                }
            }

            else
            {
                Console.WriteLine($"{firstName.ToUpper()} {lastName.ToUpper()} is probably not an actor.");
            }
                
            connection.Close();
        }
    }
}
