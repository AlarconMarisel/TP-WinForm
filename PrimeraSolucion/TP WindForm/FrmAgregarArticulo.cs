using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP_WindForm
{
    public partial class FrmAgregarArticulo : Form
    {
        private Articulo articulo = null;
        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }

        public FrmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Operación cancelada");
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                articulo = new Articulo();
                    

                articulo.CodigoArticulo = txtCodigoArticulo.Text;
                articulo.NombreArticulo = txtNombreArticulo.Text;
                articulo.DescripcionArticulo = txtDescripcionArticulo.Text;
                articulo.MarcaArticulo = (Marca)cboMarcaArticulo.SelectedItem;
                articulo.CategoriaArticulo = (Categoria)cboCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                
                if (articulo.IdArticulo != 0)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Artículo modificado con éxito");
                }
                else
                {
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Artículo agregado con éxito");
                }
                
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarcaArticulo.DataSource = marcaNegocio.ListaMarca();
                cboMarcaArticulo.ValueMember = "Id";
                cboMarcaArticulo.DisplayMember = "Descripcion";
                cboCategoriaArticulo.DataSource = categoriaNegocio.listarCategoria();
                cboCategoriaArticulo.ValueMember = "Id";
                cboCategoriaArticulo.DisplayMember = "Descripcion";

                if (articulo != null)  
                {
                    Text = "Modificar Artículo";
                    txtCodigoArticulo.Text = articulo.CodigoArticulo;
                    txtNombreArticulo.Text = articulo.NombreArticulo;
                    txtDescripcionArticulo.Text = articulo.DescripcionArticulo;
                    cboMarcaArticulo.SelectedValue = articulo.MarcaArticulo.Id;
                    cboCategoriaArticulo.SelectedValue = articulo.CategoriaArticulo.Id;
                    txtPrecioArticulo.Text = articulo.Precio.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   
        }
    }
}
