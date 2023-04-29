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
    public partial class Form1 : Form
    {
        clsPacientes pri = null;
        clsPacientes ult = null;
        int nro = 0;
        frmPaciente x = new frmPaciente();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsPacientes pacientes = new clsPacientes();
            pacientes.Nombre = txtNombre.Text;
            pacientes.Apellido = txtApell.Text;
            pacientes.DNI = txtDni.Text;
            pacientes.Edad = txtEdad.Text;
            
            if (pri == null)
            {
                pacientes.Anterior = null;
                pri = pacientes;
                ult = pacientes;                
            }
            else
            {
                ult.Anterior = pacientes;
                pacientes.Anterior = null;
                ult = pacientes;
            }
            nro++;
            txtDni.Text = "";
            txtApell.Text = "";
            txtEdad.Text = "";
            txtNombre.Text = "";
            lblNro.Text = nro.ToString();

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            clsPacientes aux = new clsPacientes();
            aux = pri;
            if(aux != null)
            {
                pri = aux.Anterior;
                x.LlamarPaciente(aux.Apellido + ", " + aux.Nombre);

                aux = null;
                nro--;
                lblNro.Text = nro.ToString();

            }
        }
    }
}
