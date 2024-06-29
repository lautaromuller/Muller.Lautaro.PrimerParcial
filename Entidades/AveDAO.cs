using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AveDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        public delegate Task<int> EjecutarCommandAsync(SqlCommand command);

        static AveDAO()
        {
            connectionString = @"Server=DESKTOP-URF8KVO\SQLEXPRESS;Database=ZoologicoDB;Trusted_Connection=True;TrustServerCertificate=true";
        }

        public AveDAO()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public async Task GuardarAsync(Ave ave, EjecutarCommandAsync ejecutarCommandAsync)
        {
            try
            {
                await connection.OpenAsync();

                string query = "INSERT INTO Aves (nombre, habitat, edad, peso, especie, envergadura, rangoCaza, velocidadVuelo, colorPlumas) VALUES (@nombre, @habitat, @edad, @peso, @especie, @envergadura, @rangoCaza, @velocidadVuelo, @colorPlumas); SELECT SCOPE_IDENTITY();";
                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", ave.Nombre);
                command.Parameters.AddWithValue("habitat", ave.Habitat);
                command.Parameters.AddWithValue("edad", ave.Edad);

                if (ave is Pinguino pinguino)
                {
                    command.Parameters.AddWithValue("peso", pinguino.Peso);
                    command.Parameters.AddWithValue("especie", pinguino.Especie);
                    command.Parameters.AddWithValue("envergadura", DBNull.Value);
                    command.Parameters.AddWithValue("rangoCaza", DBNull.Value);
                    command.Parameters.AddWithValue("colorPlumas", DBNull.Value);
                    command.Parameters.AddWithValue("velocidadVuelo", DBNull.Value);
                }
                else if (ave is Halcon halcon)
                {
                    command.Parameters.AddWithValue("peso", DBNull.Value);
                    command.Parameters.AddWithValue("especie", DBNull.Value);
                    command.Parameters.AddWithValue("envergadura", halcon.Envergadura);
                    command.Parameters.AddWithValue("rangoCaza", halcon.RangoDeCaza);
                    command.Parameters.AddWithValue("colorPlumas", DBNull.Value);
                    command.Parameters.AddWithValue("velocidadVuelo", DBNull.Value);
                }
                else if (ave is Colibri colibri)
                {
                    command.Parameters.AddWithValue("peso", DBNull.Value);
                    command.Parameters.AddWithValue("especie", DBNull.Value);
                    command.Parameters.AddWithValue("envergadura", DBNull.Value);
                    command.Parameters.AddWithValue("rangoCaza", DBNull.Value);
                    command.Parameters.AddWithValue("colorPlumas", colibri.ColorPlumas);
                    command.Parameters.AddWithValue("velocidadVuelo", colibri.VelocidadVuelo);
                }

                ave.Id = await ejecutarCommandAsync(command);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public async Task ModificarAsync(Ave aveSeleccionada, Ave nuevaAve, EjecutarCommandAsync ejecutarCommandAsync)
        {
            try
            {
                await connection.OpenAsync();

                string query = "UPDATE Aves SET nombre = @nombre, habitat = @habitat, edad = @edad, peso = @peso, especie = @especie, envergadura = @envergadura, rangoCaza = @rangoCaza, velocidadVuelo = @velocidadVuelo, colorPlumas = @colorPlumas WHERE Id = @id";
                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", nuevaAve.Nombre);
                command.Parameters.AddWithValue("habitat", nuevaAve.Habitat);
                command.Parameters.AddWithValue("edad", nuevaAve.Edad);
                command.Parameters.AddWithValue("id", aveSeleccionada.Id);

                if (nuevaAve is Pinguino pinguino)
                {
                    command.Parameters.AddWithValue("peso", pinguino.Peso);
                    command.Parameters.AddWithValue("especie", pinguino.Especie);
                    command.Parameters.AddWithValue("envergadura", DBNull.Value);
                    command.Parameters.AddWithValue("rangoCaza", DBNull.Value);
                    command.Parameters.AddWithValue("velocidadVuelo", DBNull.Value);
                    command.Parameters.AddWithValue("colorPlumas", DBNull.Value);
                }
                else if (nuevaAve is Halcon halcon)
                {
                    command.Parameters.AddWithValue("peso", DBNull.Value);
                    command.Parameters.AddWithValue("especie", DBNull.Value);
                    command.Parameters.AddWithValue("envergadura", halcon.Envergadura);
                    command.Parameters.AddWithValue("rangoCaza", halcon.RangoDeCaza);
                    command.Parameters.AddWithValue("velocidadVuelo", DBNull.Value);
                    command.Parameters.AddWithValue("colorPlumas", DBNull.Value);
                }
                else if (nuevaAve is Colibri colibri)
                {
                    command.Parameters.AddWithValue("peso", DBNull.Value);
                    command.Parameters.AddWithValue("especie", DBNull.Value);
                    command.Parameters.AddWithValue("envergadura", DBNull.Value);
                    command.Parameters.AddWithValue("rangoCaza", DBNull.Value);
                    command.Parameters.AddWithValue("velocidadVuelo", colibri.VelocidadVuelo);
                    command.Parameters.AddWithValue("colorPlumas", colibri.ColorPlumas);
                }

                await ejecutarCommandAsync(command);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public async Task EliminarAsync(Ave ave, EjecutarCommandAsync ejecutarCommandAsync)
        {
            try
            {
                await connection.OpenAsync();

                string query = "DELETE FROM Aves WHERE id = @id";
                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", ave.Id);

                await ejecutarCommandAsync(command);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el ave: {ex.Message}", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Ave> Leer()
        {
            List<Ave> lista = new List<Ave>();
            try
            {
                string query = "SELECT * FROM Aves";

                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string nombre = dataReader.GetString(1);
                    int habitatIndice = int.Parse(dataReader.GetString(2));
                    Habitat habitat = (Habitat)habitatIndice;
                    int edad = int.Parse(dataReader.GetString(3));
                    double peso = dataReader.IsDBNull(4) ? 0 : double.Parse(dataReader.GetString(4));
                    string especie = dataReader.IsDBNull(5) ? string.Empty : dataReader.GetString(5);
                    double velocidadVuelo = dataReader.IsDBNull(6) ? 0 : double.Parse(dataReader.GetString(6));
                    string colorPlumas = dataReader.IsDBNull(7) ? string.Empty : dataReader.GetString(7);
                    double envergadura = dataReader.IsDBNull(8) ? 0 : double.Parse(dataReader.GetString(8));
                    string rangoCaza = dataReader.IsDBNull(9) ? string.Empty : dataReader.GetString(9);

                    Ave ave = null;

                    if (peso > 0 && !string.IsNullOrEmpty(especie))
                    {
                        ave = new Pinguino(nombre, habitat, edad, peso, especie);
                    }
                    else if (velocidadVuelo > 0 && !string.IsNullOrEmpty(colorPlumas))
                    {
                        ave = new Colibri(nombre, habitat, edad, colorPlumas, velocidadVuelo);
                    }
                    else if (envergadura > 0 && !string.IsNullOrEmpty(rangoCaza))
                    {
                        ave = new Halcon(nombre, habitat, edad, envergadura, rangoCaza);
                    }

                    if (ave != null)
                    {
                        lista.Add(ave);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer datos de la base de datos: {ex.Message} ---- {ex.StackTrace}", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
