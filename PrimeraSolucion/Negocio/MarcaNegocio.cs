using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {

        public List<Marca> ListaMarca()
        {
            List<Marca> lista = new List<Marca>();

            SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=CATALOGO_P3_DB; Integrated Security=true");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "SELECT * FROM MARCAS";
            SqlDataReader lector;
            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Marca marca = new Marca();
                marca.Id = (int)lector["Id"];
                marca.Descripcion = (string)lector["Descripcion"];
                lista.Add(marca);
            }
            conexion.Close();

            return lista;


        }

    }
}
