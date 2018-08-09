using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class solicitudesPendientes : Form
    {
        string auxemail;
        public solicitudesPendientes(string email)
        {
            auxemail = email;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x = dataGridView1.CurrentCell.Value.ToString();
            MessageBox.Show(x);
            Conexion cn = new Conexion();
            cn.query("update solicitudreserva set estadosolicitud='aprobada1' where idsolicitudreserva='" + x + "'");
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();

            DataTable dtaux = cn.Buscar(auxemail, "select idusuario, departamento from usuarios where email= '" + auxemail + "'");
           DataRow row = dtaux.Rows[0];
           string x;
           int idusuario = Convert.ToInt32(row["idusuario"]);
           string facultad = Convert.ToString(row["departamento"]);
          // MessageBox.Show("  select *from SolicitudReserva where idSolicitante in (select idSolicitante from Solicitante where facultad ='" + facultad + "'");
           cn.CargarDatos("  select  nombre, fechasalida, from SolicitudReserva where estadosolicitud = 'en espera' AND idusuario in (select idusuario from usuarios where departamento ='" + facultad + "') ", dataGridView1);
         //  */
           // cn.CargarDatos("select * from usuarios", dataGridView1);
        }
    }
}
