using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HalconDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        static HalconDAO()
        {
            connectionString = @"Server=DESKTOP-URF8KVO\SQLEXPRESS;Database=ZoologicoDB;Trusted_Connection=True;TrustServerCertificate=true";
        }

        public HalconDAO()
        {
            connection = new SqlConnection(HalconDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        public void Guardar(Halcon halcon)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Aves (nombre,habitat,edad,envergadura,rangoCaza) VALUES (@nombre, @habitat, @edad, @envergadura, @rangoCaza)";
                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", halcon.Nombre);
                command.Parameters.AddWithValue("habitat", halcon.Habitat);
                command.Parameters.AddWithValue("edad", halcon.Edad);
                command.Parameters.AddWithValue("envergadura", halcon.Envergadura);
                command.Parameters.AddWithValue("rangoCaza", halcon.RangoDeCaza);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
