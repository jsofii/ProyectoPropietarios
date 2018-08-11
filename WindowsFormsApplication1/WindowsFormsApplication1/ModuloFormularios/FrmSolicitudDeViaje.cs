using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    public partial class FrmSolicitudDeViaje : Form
    {
        private CSSolicitudDeViaje solicitudDeViaje = new CSSolicitudDeViaje();
        public FrmSolicitudDeViaje()
        {
            InitializeComponent();
            //Llena el Form
            solicitudDeViaje.llenarCorreo(txt_ciSolicitante);
            solicitudDeViaje.llenarCorreo(txt_nombreSolicitante);
            solicitudDeViaje.llenarMotivos(comboBoxMotivos);
        }
        
        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            solicitudDeViaje.setFechaRetorno(dtf_llegada.Text);
            solicitudDeViaje.setHoraRetorno(dth_llegada.Text);
            solicitudDeViaje.setFechaSalida(dtf_salida.Text);
            solicitudDeViaje.setHoraSalida(dth_salida.Text);
            solicitudDeViaje.setDestino(txt_Destino.Text+","+comboBoxProvincias.SelectedItem.ToString()+",Ecuador");
            solicitudDeViaje.setIDs(comboBoxMotivos.SelectedIndex+1,1);//aqui se debe pasar el idUsuario
            solicitudDeViaje.setNumeroPersonas(Convert.ToInt32(txtNumPersona.Text));
            solicitudDeViaje.guardarEnBase();
        }
    }
}
