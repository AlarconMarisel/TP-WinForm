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
    }
}
