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
    public partial class FrmArticuloListado : Form
    {
        public FrmArticuloListado()
        {
            InitializeComponent();
        }

        private void FrmArticuloListado_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo agregar = new FrmAgregarArticulo();
            agregar.ShowDialog();
            CargarArticulos();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmAgregarArticulo modificar = new FrmAgregarArticulo(seleccionado);
            modificar.ShowDialog(); 
            CargarArticulos();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este Articulo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {              
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.IdArticulo);
                    CargarArticulos();
                }
            }
            catch (Exception ex)    
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvArticulos.DataSource = negocio.listarArticulo();
                dgvArticulos.Columns["IdArticulo"].Visible = false;
                dgvArticulos.Columns["DescripcionArticulo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
