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
        private int indiceImagenActual = 0;
        private bool articuloGuardadoTemporalmente = false;
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
            // Validar campos antes de proceder

            try
            {
                if (!ValidarCampos())
                {
                    MessageBox.Show("Es obligatorio completar todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                ArticuloNegocio negocio = new ArticuloNegocio();
                if (articulo == null)
                articulo = new Articulo();
                    

                articulo.CodigoArticulo = txtCodigoArticulo.Text;
                articulo.NombreArticulo = txtNombreArticulo.Text;
                articulo.DescripcionArticulo = txtDescripcionArticulo.Text;
                articulo.MarcaArticulo = (Marca)cboMarcaArticulo.SelectedItem;
                articulo.CategoriaArticulo = (Categoria)cboCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                
                if (articulo.IdArticulo != 0 && !articuloGuardadoTemporalmente)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Artículo modificado con éxito");
                }
                else
                {
                    if (articulo.IdArticulo == 0)
                    {
                        int idGenerado = negocio.agregarArticulo(articulo);
                        articulo.IdArticulo = idGenerado;
                    }
                    MessageBox.Show("Artículo agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                Close();
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Error al abrir el gestor de imágenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            FrmAgregarImagen agregarImagen = new FrmAgregarImagen();
            agregarImagen.ShowDialog();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoArticulo.Text) ||
                string.IsNullOrWhiteSpace(txtNombreArticulo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionArticulo.Text) ||
                cboMarcaArticulo.SelectedItem == null ||
                cboCategoriaArticulo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPrecioArticulo.Text))
            {
                return false;
            }

            // Validar que el precio sea un número válido
            decimal precio;
            if (!decimal.TryParse(txtPrecioArticulo.Text, out precio))
            {
                return false;
            }

            return true;
        }

        private bool GuardarArticuloTemporal()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();

                if (articulo == null)
                    articulo = new Articulo();

                // Asignar los valores de los controles al artículo
                articulo.CodigoArticulo = txtCodigoArticulo.Text;
                articulo.NombreArticulo = txtNombreArticulo.Text;
                articulo.DescripcionArticulo = txtDescripcionArticulo.Text;
                articulo.MarcaArticulo = (Marca)cboMarcaArticulo.SelectedItem;
                articulo.CategoriaArticulo = (Categoria)cboCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                // Guardar el artículo y obtener el ID
                int idGenerado = negocio.agregarArticulo(articulo);
                articulo.IdArticulo = idGenerado;
                articuloGuardadoTemporalmente = true; // Marcar que fue guardado temporalmente

                MessageBox.Show("Artículo guardado temporalmente. Ahora puede agregar imágenes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
