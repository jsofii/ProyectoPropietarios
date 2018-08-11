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
    public partial class MainFormulariosProfesor : Form
    {
        string nombresConductor;
        string idConductor;
        private Form2 frmReporteConductor;
        public MainFormulariosProfesor(string nombresConductor, string idConductor,string idCargo)
        {
            InitializeComponent();
            validar(idCargo);
        
            this.nombresConductor = nombresConductor;
            this.idConductor = idConductor;
           
        }
        private void validar(string idCargo) {
            if (idCargo.Equals("5")) {
                btn_reporteConductor.Enabled = true;
            }
        }

        private void ingresarReporte(object sender, EventArgs e)
        {
            frmReporteConductor = new Form2(nombresConductor, idConductor);
            frmReporteConductor.Show();
        }
    }
}
