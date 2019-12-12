
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {

        private SqlCommand comando;
        private SqlConnection connection;

        public void Guardar(string archivo, Queue<Patente> datos)
        {
            if (!(datos is null))
            {
                try
                {
                    connection.Open();
                    foreach (Patente item in datos)
                    {
                        comando.CommandText = String.Format($"INSERT INTO dbo.Patentes(patente,tipo) VALUES('{item.CodigoPatente}', '{item.TipoCodigo}')");
                        comando.ExecuteNonQuery();
                    }

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void Leer(string archivom, out Queue<Patente> datos)
        {
            Queue<Patente> r = new Queue<Patente>();
            try
            {
                connection.Open();
                comando.CommandText = $"SELECT * FROM {archivom}";
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Patente p = oDr["patente"].ToString().ValidarPatente();
                    if(!(p.CodigoPatente is null)) r.Enqueue(p);

                }
            }
            catch (Exception e)
            {
                datos = default;
                throw new Exception(e.Message, e);
            }
            finally
            {
                connection.Close();
            }

            datos = r;
        }

        public Sql()
        {
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = ".\\SQLEXPRESS";
            connectionString.InitialCatalog = "patentes-sp-2018";
            connectionString.IntegratedSecurity = true;
            connection = new SqlConnection(connectionString.ToString());
            comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandType = System.Data.CommandType.Text;
        }
    }
}
