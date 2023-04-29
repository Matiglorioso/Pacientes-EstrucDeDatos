using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes_EstrucDeDatos
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }
        public void LlamarPaciente(string nombre)
        {
            lblNombreApell.Text = nombre;
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
