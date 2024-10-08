﻿using Microsoft.Data.SqlClient;
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
        #region Atributos

        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        #endregion

        public delegate void OperacionCompletaHandler(object sender, EventArgs e);
        public event OperacionCompletaHandler OperacionCompleta;



        #region Constructores

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

        #endregion



        #region Métodos



        /// <summary>
        /// Escucha del evento que avisa cuando la operación termina
        /// </summary>
        private void OnOperacionCompleta()
        {
            OperacionCompleta?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Método para guardar elemento en base de datos
        /// </summary>
        /// <param name="ave">Ave a guardar</param>
        public void Guardar(Ave ave)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Aves (nombre, habitat, edad, ";
                
                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", ave.Nombre);
                command.Parameters.AddWithValue("habitat", ave.Habitat);
                command.Parameters.AddWithValue("edad", ave.Edad);

                if (ave is Pinguino pinguino)
                {
                    query += " peso, especie) VALUES (@nombre, @habitat, @edad, @peso, @especie);";

                    command.Parameters.AddWithValue("peso", pinguino.Peso);
                    command.Parameters.AddWithValue("especie", pinguino.Especie);
                }
                else if (ave is Halcon halcon)
                {
                    query += " envergadura, rangoCaza) VALUES (@nombre, @habitat, @edad, @envergadura, @rangoCaza);";
                    command.Parameters.AddWithValue("envergadura", halcon.Envergadura);
                    command.Parameters.AddWithValue("rangoCaza", halcon.RangoDeCaza);
                }
                else if (ave is Colibri colibri)
                {
                    query += " velocidadVuelo, colorPlumas) VALUES (@nombre, @habitat, @edad, @velocidadVuelo, @colorPlumas);";
                    command.Parameters.AddWithValue("colorPlumas", colibri.ColorPlumas);
                    command.Parameters.AddWithValue("velocidadVuelo", colibri.VelocidadVuelo);
                }
                command.CommandText = query;

                command.ExecuteNonQuery();
                OnOperacionCompleta();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar ave: {ex.Message}", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método que modifica un elemento de la base de datos
        /// </summary>
        /// <param name="aveSeleccionada">Ave a modificar</param>
        /// <param name="nuevaAve">Ave de reemplazo</param>
        public void Modificar(Ave aveSeleccionada, Ave nuevaAve)
        {
            try
            {
                connection.Open();

                string query = "UPDATE Aves SET nombre = @nombre, habitat = @habitat, edad = @edad, ";
                
                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", nuevaAve.Nombre);
                command.Parameters.AddWithValue("habitat", nuevaAve.Habitat);
                command.Parameters.AddWithValue("edad", nuevaAve.Edad);
                command.Parameters.AddWithValue("id", aveSeleccionada.Id);

                if (nuevaAve is Pinguino pinguino)
                {
                    query += "peso = @peso, especie = @especie WHERE Id = @id";
                    command.Parameters.AddWithValue("peso", pinguino.Peso);
                    command.Parameters.AddWithValue("especie", pinguino.Especie);
                }
                else if (nuevaAve is Halcon halcon)
                {
                    query += "envergadura = @envergadura, rangoCaza = @rangoCaza WHERE Id = @id";
                    command.Parameters.AddWithValue("envergadura", halcon.Envergadura);
                    command.Parameters.AddWithValue("rangoCaza", halcon.RangoDeCaza);
                }
                else if (nuevaAve is Colibri colibri)
                {
                    query += "velocidadVuelo = @velocidadVuelo, colorPlumas = @colorPlumas WHERE Id = @id";
                    command.Parameters.AddWithValue("velocidadVuelo", colibri.VelocidadVuelo);
                    command.Parameters.AddWithValue("colorPlumas", colibri.ColorPlumas);
                }
                command.CommandText = query;

                command.ExecuteNonQuery();
                OnOperacionCompleta();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar ave: {ex.Message}", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método para eliminar un elemento de la base de datos
        /// </summary>
        /// <param name="id">ID del elemento a eliminar</param>
        public void Eliminar(int id)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM Aves WHERE id = @id";
                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
                OnOperacionCompleta();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar ave: {ex.Message}", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método para leer información de una base de datos.
        /// </summary>
        /// <returns>Retorna una lista con los valores obtenidos</returns>
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
                    int id = dataReader.GetInt32(0);
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
                        ave.Id = id;
                        lista.Add(ave);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer datos de la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        #endregion


    }
}
