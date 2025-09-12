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
    public partial class FrmAgregarCategoria : Form
    {
        private Categoria categoria = null;
        public FrmAgregarCategoria()
        {
            InitializeComponent();
        }
        public FrmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            txtNombreCategoria.Text = categoria.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null) // Alta
                {
                    Categoria nuevo = new Categoria();
                    nuevo.Descripcion = txtNombreCategoria.Text;
                    negocio.agregar(nuevo);
                    MessageBox.Show("Agregado exitosamente");
                }
                else // Edición
                {
                    categoria.Descripcion = txtNombreCategoria.Text;
                    negocio.modificar(categoria);                
                    MessageBox.Show("Modificado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
