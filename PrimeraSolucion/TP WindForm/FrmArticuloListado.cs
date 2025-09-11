using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo agregar = new FrmAgregarArticulo();
            agregar.ShowDialog();
        }
    }
}
