using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ModuloFormularios;

namespace WindowsFormsApplication1.ModuloFormularios
{
    public partial class FrmCalificacionServicio : Form
    {
        private CSCalificacionDeServicio calificacionServicio;

        public FrmCalificacionServicio()
        {
            InitializeComponent();
            calificacionServicio = new CSCalificacionDeServicio();
        }

        private void obtenerDatos(object sender, EventArgs e)
        {
            if (rb_puntSalidaT.Checked)
            {
                calificacionServicio.setPuntualSalida("SI");
            }
            else {
                calificacionServicio.setPuntualSalida("NO");
            }

            if (rb_limpiezaT.Checked)
            {
                calificacionServicio.setLimpiezaVehiculo("SI");
            }
            else
            {
                calificacionServicio.setLimpiezaVehiculo("NO");
            }
            if (rb_puntLlegadaT.Checked) {
                calificacionServicio.setPuntualAlDestino("SI");
            } else {
                calificacionServicio.setPuntualAlDestino("NO");
            }

            if (rb_puntRetornoT.Checked)
{
                calificacionServicio.setPuntualAlRetorno("SI");
            }
            else {
                calificacionServicio.setPuntualAlRetorno("NO");
            }
            if (!txt_comenAdicionales.Text.Equals(""))
            {
                calificacionServicio.setComentariosAdicionales(txt_comenAdicionales.Text);
            }
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
