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
            MarcaNegocio datos = new MarcaNegocio();
            DgvListaDeMarcas.DataSource = datos.ListaMarca();
        }
    }
}
