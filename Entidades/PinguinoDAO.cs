using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PinguinoDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        static PinguinoDAO()
        {
            connectionString = @"Server=DESKTOP-URF8KVO\SQLEXPRESS;Database=ZoologicoDB;Trusted_Connection=True;TrustServerCertificate=true";
        }

        public PinguinoDAO()
        {
            connection = new SqlConnection(PinguinoDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public void Guardar(Pinguino pinguino)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Aves (nombre,habitat,edad,peso,especie) VALUES (@nombre, @habitat, @edad, @peso, @especie)";
                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", pinguino.Nombre);
                command.Parameters.AddWithValue("habitat", pinguino.Habitat);
                command.Parameters.AddWithValue("edad", pinguino.Edad);
                command.Parameters.AddWithValue("peso", pinguino.Peso);
                command.Parameters.AddWithValue("especie", pinguino.Especie);

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


        //public List<Cliente> Leer()
        //{
        //    List<Cliente> lista = new List<Cliente>();
        //    try
        //    {
        //        string query = "SELECT * FROM Clientes";

        //        connection.Open();
        //        command.CommandText = query;

        //        SqlDataReader dataReader = command.ExecuteReader(); //Leemos base de datos

        //        while (dataReader.Read()) //Read() retorna true si hay datos
        //        {
        //            int id = dataReader.GetInt32(0);
        //            string nombre = dataReader.GetString(1);
        //            string direccion = dataReader.GetString(2);

        //            Cliente cliente = new Cliente(id, nombre, direccion);

        //            lista.Add(cliente);
        //        }
        //        return lista;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        //Si se abrio la conexion, la cerramos
        //        if (connection is not null && connection.State == System.Data.ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}


        //public void Modificar(int id, Cliente cliente)
        //{
        //    try
        //    {
        //        string query = "UPDATE Clientes SET nombre = @nombre, direccion = @direccion WHERE id = @id";

        //        connection.Open();
        //        command.CommandText = query;

        //        command.Parameters.Clear();
        //        command.Parameters.AddWithValue("id", id);
        //        command.Parameters.AddWithValue("nombre", cliente.Nombre);
        //        command.Parameters.AddWithValue("direccion", cliente.Direccion);

        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (connection is not null && connection.State == System.Data.ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //public void Eliminar(int id)
        //{
        //    try
        //    {
        //        string query = "DELETE FROM Clientes WHERE id = @id";

        //        connection.Open();
        //        command.CommandText = query;

        //        command.Parameters.Clear();
        //        command.Parameters.AddWithValue("id", id);

        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (connection is not null && connection.State == System.Data.ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}
    }
}
