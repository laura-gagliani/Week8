using EsMaster.Core.Entities;
using EsMaster.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.RepositoryADO
{
    public class RepositoryCorsiADO : IRepositoryCorsi
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EsMaster;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Corso Add(Corso item)
        {
            SqlConnection connection = null;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Corso values (@code, @name, @descr)";
                command.Parameters.AddWithValue("@code", item.CorsoCodice);
                command.Parameters.AddWithValue("@name", item.Nome);
                command.Parameters.AddWithValue("@descr", item.Descrizione);

                command.ExecuteNonQuery();

                connection.Close();
                return item;
            }
        }

        public bool Delete(Corso item)
        {
            SqlConnection connection = null;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from Corso where CorsoCodice= @code";
                command.Parameters.AddWithValue("@code", item.CorsoCodice);

                int rows = command.ExecuteNonQuery();

                connection.Close();
                if (rows == 1) 
                    return true;
                else 
                    return false;
            }
        }

        public List<Corso> GetAll()
        {
            SqlConnection connection = null;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Corso";

                SqlDataReader reader = command.ExecuteReader();
                List<Corso> corsi = new List<Corso>();

                while (reader.Read())
                {
                    Corso corso = new Corso();
                    corso.CorsoCodice = (string)reader["CorsoCodice"];
                    corso.Nome = (string)reader["Nome"];
                    corso.Descrizione = (string)reader["Descrizione"];

                    corsi.Add(corso);
                }

                connection.Close();
                return corsi;
            }


        }

        public Corso GetByCode(string codice)
        {
            SqlConnection connection = null;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Corso where CorsoCodice =@codice";
                command.Parameters.AddWithValue("@codice", codice);

                SqlDataReader reader = command.ExecuteReader();
                Corso corso = null;

                while (reader.Read())
                {
                    corso = new Corso();
                    corso.CorsoCodice = (string)reader["CorsoCodice"];
                    corso.Nome = (string)reader["Nome"];
                    corso.Descrizione = (string)reader["Descrizione"];

                }

                connection.Close();
                return corso;
            }
        }

        public Corso Update(Corso item)
        {
            SqlConnection connection = null;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "update Corso set Nome = @n, Descrizione = @d where CorsoCodice=@code";
                command.Parameters.AddWithValue("@n", item.Nome);
                command.Parameters.AddWithValue("@d", item.Descrizione);
                command.Parameters.AddWithValue("@code", item.CorsoCodice);

                int rows = command.ExecuteNonQuery();

                connection.Close();
                if (rows == 1)
                    return item;
                else
                    return null;
                
                
            }
        }
    }
}
