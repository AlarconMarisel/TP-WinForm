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
    public partial class FrmAgregarMarca : Form
    {
        public FrmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca nuevo = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                nuevo.Descripcion = texNombreMarca.Text;
                negocio.agregar(nuevo);
                MessageBox.Show("Agregado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
        }
    }
}
