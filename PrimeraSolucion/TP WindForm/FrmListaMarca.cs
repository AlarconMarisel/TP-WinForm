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
    public partial class FrmListaMarca : Form
    {
        public FrmListaMarca()
        {
            InitializeComponent();
        }
        private void FrmListaMarca_Load_1(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            MarcaNegocio datos = new MarcaNegocio();
            try
            {
                DgvListaDeMarcas.DataSource = datos.ListaMarca();
                DgvListaDeMarcas.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca alta = new FrmAgregarMarca();
            alta.ShowDialog();
            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
