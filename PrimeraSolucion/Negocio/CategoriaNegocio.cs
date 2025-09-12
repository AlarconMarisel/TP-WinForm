using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listarCategoria()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select * from CATEGORIAS");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    listaCategoria.Add(aux);
                }
                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { 
                datos.cerrarConexion();
            }
        }

        public void agregar(Categoria nuevo)
        {
            
            if (existeCategoria(nuevo.Descripcion))
            {
                throw new Exception($"Ya existe una categoría con el nombre '{nuevo.Descripcion}'. No se permiten duplicados.");
            }

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into CATEGORIAS values (@descripcion)");
                datos.Comando.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Categoria categoria)
        {
            
            Categoria categoriaOriginal = obtenerCategoriaPorId(categoria.Id);
            
           
            if (categoriaOriginal != null && categoriaOriginal.Descripcion == categoria.Descripcion)
            {
                throw new Exception("No se realizaron cambios en la categoría.");
            }

            
            if (existeCategoriaExacta(categoria.Descripcion, categoria.Id))
            {
                throw new Exception($"La categoría no se puede modificar porque ya existe una categoría con el nombre '{categoria.Descripcion}'.");
            }

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update CATEGORIAS set Descripcion = @descripcion where Id = @id");
                datos.Comando.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                datos.Comando.Parameters.AddWithValue("@id", categoria.Id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from CATEGORIAS where Id = @id");
                datos.Comando.Parameters.AddWithValue("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        
        private bool existeCategoria(string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select count(*) from CATEGORIAS where UPPER(Descripcion) = UPPER(@descripcion)");
                datos.Comando.Parameters.AddWithValue("@descripcion", descripcion);
                datos.EjecutarLectura();
                
                if (datos.Lector.Read())
                {
                    return (int)datos.Lector[0] > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        
        private bool existeCategoriaExacta(string descripcion, int idExcluir)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select count(*) from CATEGORIAS where Descripcion = @descripcion and Id != @id");
                datos.Comando.Parameters.AddWithValue("@descripcion", descripcion);
                datos.Comando.Parameters.AddWithValue("@id", idExcluir);
                datos.EjecutarLectura();
                
                if (datos.Lector.Read())
                {
                    return (int)datos.Lector[0] > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        
        private Categoria obtenerCategoriaPorId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select * from CATEGORIAS where Id = @id");
                datos.Comando.Parameters.AddWithValue("@id", id);
                datos.EjecutarLectura();
                
                if (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Lector["Id"];
                    categoria.Descripcion = (string)datos.Lector["Descripcion"];
                    return categoria;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
