using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    class CSListaCalificacionServicio
    {
        private Conexion cnx;
        private SqlConnection conn;
        private HashSet<CSCalificacionDeServicio> listaCalificacionServicio;
        private CSCalificacionDeServicio calificacionServicio;
        public CSListaCalificacionServicio()
        {
            listaCalificacionServicio = new HashSet<CSCalificacionDeServicio>();
            cargarLista();
        }
        public CSCalificacionDeServicio getListaReporteConductor(int i)
        {
            return listaCalificacionServicio.ElementAt(i);

        }
        public void cargarLista()
        {
            string idCalificacionServicio;
            string idReserva;
            string puntualSalida;
            string limpiezaVehiculo;
            string puntualAlDestino;
            string puntualAlRetorno;
            string comentariosAdicionales;
            try
            {
                cnx = new Conexion();
                conn = new SqlConnection(cnx.stringConexion);
                SqlDataReader reader = null;
                String sql = "select * from Calificación_Servicio";
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    idCalificacionServicio = "" + reader[0];
                    puntualSalida = "" + reader[1];
                    limpiezaVehiculo = "" + reader[2];
                    puntualAlDestino = "" + reader[3];
                    puntualAlRetorno = "" + reader[4];
                    comentariosAdicionales = "" + reader[5];
                    idReserva = "" + reader[6];
                    listaCalificacionServicio.Add(new CSCalificacionDeServicio(idCalificacionServicio, idReserva, puntualSalida, limpiezaVehiculo, puntualAlDestino, puntualAlRetorno, comentariosAdicionales));
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error");
                Console.WriteLine(er.ToString());
            }
        }
    }
}
