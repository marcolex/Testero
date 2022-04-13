using Ingenya.Entities;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ingenya.API.Models
{
    public class ClienteModel
    {
        public string ConnectionString { get; set; }

        public ClienteModel(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Cliente> TodosLosClientes()
        {
            List<Cliente> list = new List<Cliente>();

            using (MySqlConnection conn = GetConnection())
            using (var command = new MySqlCommand("RET_ALL_CLIENTE", conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                //foreach (var param in sqlOperation.Parameters)
                //{
                //    command.Parameters.Add(param);
                //}
                try
                {
                    conn.Open();
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Cliente()
                        {
                            IdCliente = Convert.ToInt32(reader["idCliente"]),
                            Nombre = reader["Nombre"].ToString(),
                            Site = reader["Site"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            CorreoContacto = reader["CorreoContacto"].ToString()
                        });
                    }
                }
                catch (Exception msg)
                {

                    throw msg;
                }
                finally
                {
                    conn.Close();
                }

            }
            return list;
        }
    }
}
