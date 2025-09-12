using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_WindForm
{
    public partial class FrmListaCategoria : Form
    {
        public FrmListaCategoria()
        {
            InitializeComponent();
        }

        private void FrmListaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                DgvCategorias.DataSource = negocio.listarCategoria();
                DgvCategorias.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria agregar = new FrmAgregarCategoria();
            agregar.ShowDialog();
            FrmListaCategoria_Load(sender, e);
        }

        private void BtnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (DgvCategorias.CurrentRow != null)
            {
                Categoria seleccionada = (Categoria)DgvCategorias.CurrentRow.DataBoundItem;
                FrmAgregarCategoria modificar = new FrmAgregarCategoria(seleccionada);
                modificar.ShowDialog();
                FrmListaCategoria_Load(sender, e);
            }
        }

        private void BtnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (DgvCategorias.CurrentRow != null)
            {
                Categoria seleccionada = (Categoria)DgvCategorias.CurrentRow.DataBoundItem;
                CategoriaNegocio negocio = new CategoriaNegocio();
                try
                {
                    negocio.eliminar(seleccionada.Id);
                    MessageBox.Show("Eliminado exitosamente");
                    FrmListaCategoria_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
