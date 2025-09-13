﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulo()
        {

            List<Articulo> listadoArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            

            try
            {
                
                datos.SetearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, M.Descripcion Marca, IdCategoria, C.Descripcion Categoria, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where IdMarca=M.Id and IdCategoria=C.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.DescripcionArticulo = (string)datos.Lector["Descripcion"];
                    aux.MarcaArticulo = new Marca();
                    aux.MarcaArticulo.Id = (int)datos.Lector["IdMarca"];
                    aux.MarcaArticulo.Descripcion = (string)datos.Lector["Marca"];
                    aux.CategoriaArticulo = new Categoria();
                    aux.CategoriaArticulo.Id = (int)datos.Lector["IdCategoria"];
                    aux.CategoriaArticulo.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    listadoArticulos.Add(aux);
             
                }


                return listadoArticulos;
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

        public void agregarArticulo(Articulo articuloNuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.SetearParametro("@Codigo", articuloNuevo.CodigoArticulo);
                datos.SetearParametro("@Nombre", articuloNuevo.NombreArticulo);
                datos.SetearParametro("@Descripcion", articuloNuevo.DescripcionArticulo);
                datos.SetearParametro("@IdMarca", articuloNuevo.MarcaArticulo.Id);
                datos.SetearParametro("@IdCategoria", articuloNuevo.CategoriaArticulo.Id);
                datos.SetearParametro("@Precio", articuloNuevo.Precio);
                datos.EjecutarAccion();

            }   
            catch (Exception ex)
            {
                    
                throw ex;   
            }  

        }

        public void modificarArticulo(Articulo articuloModificado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, Precio=@Precio where Id=@Id");
                datos.SetearParametro("@Codigo", articuloModificado.CodigoArticulo);
                datos.SetearParametro("@Nombre", articuloModificado.NombreArticulo);
                datos.SetearParametro("@Descripcion", articuloModificado.DescripcionArticulo);
                datos.SetearParametro("@IdMarca", articuloModificado.MarcaArticulo.Id);
                datos.SetearParametro("@IdCategoria", articuloModificado.CategoriaArticulo.Id);
                datos.SetearParametro("@Precio", articuloModificado.Precio);
                datos.SetearParametro("@Id", articuloModificado.IdArticulo);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { 
                datos.cerrarConexion();
            }

        }

        public void eliminarArticulo(int idArticulo)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from ARTICULOS where Id=@Id");
                datos.SetearParametro("@Id", idArticulo);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
    }
}
