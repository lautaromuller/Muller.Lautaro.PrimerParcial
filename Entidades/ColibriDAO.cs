using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ColibriDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        static ColibriDAO()
        {
            connectionString = @"Server=DESKTOP-URF8KVO\SQLEXPRESS;Database=ZoologicoDB;Trusted_Connection=True;TrustServerCertificate=true";
        }

        public ColibriDAO()
        {
            connection = new SqlConnection(ColibriDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        public void Guardar(Colibri colibri)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Aves (nombre,habitat,edad,velocidadVuelo,colorPlumas) VALUES (@nombre, @habitat, @edad, @velocidadVuelo, @colorPlumas)";
                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", colibri.Nombre);
                command.Parameters.AddWithValue("habitat", colibri.Habitat);
                command.Parameters.AddWithValue("edad", colibri.Edad);
                command.Parameters.AddWithValue("velocidadVuelo", colibri.VelocidadVuelo);
                command.Parameters.AddWithValue("colorPlumas", colibri.ColorPlumas);

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
