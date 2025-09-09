using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        private int idArticulo;
        private string codigoArticulo;
        private string nombreArticulo;
        private string descripcionArticulo;
        private Marca marca;
        private Categoria categoria;
        private decimal precio;
        private List<Imagen> imagenes;
        
        public int IdArticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        }

        public string CodigoArticulo
        {
            get { return codigoArticulo; }
            set { codigoArticulo = value; }
        }

        public string NombreArticulo
        {
            get { return nombreArticulo; }
            set { nombreArticulo = value; }
        }

        public string DescripcionArticulo
        {
            get { return descripcionArticulo; }
            set { descripcionArticulo = value; }
        }

        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
        public List<Imagen> Imagenes
        {
            get { return imagenes; }
            set { imagenes = value; }
        }
    }
}
