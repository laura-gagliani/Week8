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
    public class RepositoryStudentiADO : IRepositoryStudenti
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EsMaster;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Studente Add(Studente item)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into Studente values (@nome, @cognome, @email, @titolo, @nascita, @corsocodice)";
                    command.Parameters.AddWithValue("@nome", item.Nome);
                    command.Parameters.AddWithValue("@cognome", item.Cognome);
                    command.Parameters.AddWithValue("@email", item.Email);
                    command.Parameters.AddWithValue("@titolo", item.TitoloStudio);
                    command.Parameters.AddWithValue("@nascita", item.DataDiNascita);
                    command.Parameters.AddWithValue("@corsocodice", item.CorsoCodice);

                    int rows = command.ExecuteNonQuery();
                    connection.Close();

                    if (rows == 1)
                        return item;
                    else
                        return null;

                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }

        public bool CheckUnivocita(Studente s)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from Studente where Nome=@nome and Cognome=@cognome and DataDiNascita=@data";
                    command.Parameters.AddWithValue("@nome", s.Nome);
                    command.Parameters.AddWithValue("@cognome", s.Cognome);
                    command.Parameters.AddWithValue("@data", s.DataDiNascita);

                    SqlDataReader reader = command.ExecuteReader();
                    int rows = 0;

                    while (reader.Read())
                    {
                        rows++;
                    }

                    connection.Close();

                    if (rows == 0)
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }

        public bool Delete(Studente item)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "delete from Studente where ID=@id";
                    command.Parameters.AddWithValue("@id", item.ID);

                    int rows = command.ExecuteNonQuery();
                    connection.Close();

                    if (rows == 1)
                        return true;
                    else 
                        return false;
                                      
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }

        public List<Studente> GetAll()
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from Studente";

                    SqlDataReader reader = command.ExecuteReader();
                    List<Studente> studenti = new List<Studente>();
                    while (reader.Read())
                    {
                        Studente s = new Studente();
                        s.ID = (int)reader["ID"];
                        s.Nome = (string)reader["Nome"];
                        s.Cognome = (string)reader["Cognome"];
                        s.Email = (string)reader["Email"];
                        s.TitoloStudio = (string)reader["TitoloStudio"];
                        s.DataDiNascita = (DateTime)reader["DataDiNascita"];
                        s.CorsoCodice = (string)reader["CorsoCodice"];

                        studenti.Add(s);
                    }

                    connection.Close();
                    return studenti;

                }
            }
            catch(SqlException sqlex) 
            {
                Console.WriteLine(sqlex.Message);
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    
                }
            }
        }

        public List<Studente> GetByCodiceCorso(string codice)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from Studente where CorsoCodice = @codice";
                    command.Parameters.AddWithValue("@codice", codice);

                    SqlDataReader reader = command.ExecuteReader();
                    List<Studente> studenti = new List<Studente>();
                    while (reader.Read())
                    {
                        Studente s = new Studente();
                        s.ID = (int)reader["ID"];
                        s.Nome = (string)reader["Nome"];
                        s.Cognome = (string)reader["Cognome"];
                        s.Email = (string)reader["Email"];
                        s.TitoloStudio = (string)reader["TitoloStudio"];
                        s.DataDiNascita = (DateTime)reader["DataDiNascita"];
                        s.CorsoCodice = (string)reader["CorsoCodice"];

                        studenti.Add(s);
                    }

                    connection.Close();
                    return studenti;

                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }

        public Studente GetByID(int id)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from Studente where ID=@id";
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    Studente s = null;

                    while (reader.Read())
                    {
                        s = new Studente();
                        s.ID = (int)reader["ID"];
                        s.Nome = (string)reader["Nome"];
                        s.Cognome = (string)reader["Cognome"];
                        s.Email = (string)reader["Email"];
                        s.TitoloStudio = (string)reader["TitoloStudio"];
                        s.DataDiNascita = (DateTime)reader["DataDiNascita"];
                        s.CorsoCodice = (string)reader["CorsoCodice"];

                    }

                    connection.Close();
                    return s;

                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }

        public Studente Update(Studente item)
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "update Studente set Email=@email where ID=@id";
                    command.Parameters.AddWithValue("@email", item.Email);
                    command.Parameters.AddWithValue("@id", item.ID);

                    int rows = command.ExecuteNonQuery();
                    connection.Close();

                    if (rows == 1)
                        return item;
                    else
                        return null;

                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }
    }
}
