using ModuloFormularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    public partial class FrmPrincipalFormularioProfesor : Form
    {
        Usuario usuario;
        public FrmPrincipalFormularioProfesor()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            FrmSolicitudDeViaje solicitudReserva = new FrmSolicitudDeViaje();
            solicitudReserva.PonerUsuario(usuario);
            solicitudReserva.llenarFormulario();
            
           solicitudReserva.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCalificacionServicio calificacionServicio = new FrmCalificacionServicio();
            calificacionServicio.Show();
        }
        public void PonerUsuario(object usuario)
        {
            this.usuario = (Usuario) usuario;
        }
    }
}
