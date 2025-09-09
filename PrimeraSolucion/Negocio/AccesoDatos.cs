using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
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
        public void cerrarConexion() 
        { 
            if (lector != null) 
                lector.Close();
                conexion.Close();
        }
        
    }
}
