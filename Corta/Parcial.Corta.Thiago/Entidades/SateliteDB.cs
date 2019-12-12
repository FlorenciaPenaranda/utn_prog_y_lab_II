using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Entidades;

namespace Entidades
{
    public class SateliteDB
    {
        private SqlCommand comando;
        private SqlConnection connection;


        public void Guardar(Satelite satelite)
        {
            if (!(satelite is null))
            {
                try
                {
                    connection.Open();
                    
                    comando.CommandText = String.Format($"INSERT INTO dbo.Satelites(nombre,duracion_orbita,duracion_rotacion) VALUES('{satelite.Nombre}', {satelite.DuraOrbita}, {satelite.DuraRotacion})");
                   comando.ExecuteNonQuery();

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


        public void Leer(List<Satelite> datos)
        {
            try
            {
                connection.Open();
                comando.CommandText = $"SELECT * FROM dbo.Satelites";
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    string nombre = oDr["nombre"].ToString();
                    int orbita = int.Parse(oDr["duracion_orbita"].ToString());
                    int rotacion = int.Parse(oDr["duracion_rotacion"].ToString());
                    if(nombre != null && orbita >= 1 && rotacion >= 1)
                    {
                        Satelite s = new Satelite(orbita, rotacion, nombre);
                        datos.Add(s);
                    }
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
        }

        
        public SateliteDB()
        {
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = ".\\SQLEXPRESS";
            connectionString.InitialCatalog = "planetario";
            connectionString.IntegratedSecurity = true;
            connection = new SqlConnection(connectionString.ToString());
            comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandType = System.Data.CommandType.Text;
        }
    }
}

