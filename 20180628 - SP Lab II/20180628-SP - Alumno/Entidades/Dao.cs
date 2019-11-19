using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Excepciones;


namespace Entidades
{
    public class Dao : IArchivo<Votacion>
    {
        public Votacion Leer(string archivo)//archivo nombre de la tabla 
        {
            throw new NotImplementedException();
        }

        public bool Guardar(string archivo, Votacion datos)
        {
            bool retorno = false;
            
            
                try
                {
                    //Votacion vot = new Votacion();
                    //vot = (Votacion)datos;
                    SqlConnection conexion = new SqlConnection(archivo);
                    conexion.Open();
                    StringBuilder cadena = new StringBuilder();
                    cadena.AppendFormat("INSERT INTO Votaciones(nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES('{0}',{1},{2},{3},'DanielaMoreno')", datos.NombreLey, datos.Afirmativo, datos.Negativo, datos.Abstencion);
                //los string van con 'aca la mascara'
                    SqlCommand comando = new SqlCommand(cadena.ToString(),conexion);
                    if(comando.ExecuteNonQuery()==1)
                    {
                        retorno = true;
                    }
                    conexion.Close();
                    
                }catch (Exception e)
                {
                    throw new ErrorArchivoException(e);
                }

            return retorno;
        }
    }
        
}
