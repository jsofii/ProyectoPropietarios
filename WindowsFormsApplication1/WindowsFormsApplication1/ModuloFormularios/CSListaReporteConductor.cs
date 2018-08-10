using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    class CSListaReporteConductor
    {
        private Conexion cnx;
        private SqlConnection conn;
        private HashSet<CSReporteConductor> listaReporteConductor;
        private CSReporteConductor reporteConductor;

        public CSListaReporteConductor()
        {

            listaReporteConductor = new HashSet<CSReporteConductor>();
            cargarLista();
        }
        public CSReporteConductor getListaReporteConductor(int i)
        {
            return listaReporteConductor.ElementAt(i);

        }
        public void cargarLista()
        {
            string idReservaAprobada;
            string nombreCompletoConductor;
            string inconvenientesViaje;
            string descripcionInconveniente;
            string dineroGastadoEnGasolina;
            string comportamientoPasajeros;
            try
            {
                cnx = new Conexion();
                conn = new SqlConnection(cnx.stringConexion);
                SqlDataReader reader = null;
                String sql = "select * from ReporteConductor ";
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    idReservaAprobada = "" + reader[0];
                    nombreCompletoConductor = "" + reader[1];
                    inconvenientesViaje = "" + reader[2];
                    descripcionInconveniente = "" + reader[3];
                    dineroGastadoEnGasolina = "" + reader[4];
                    comportamientoPasajeros = "" + reader[5];
                    listaReporteConductor.Add(new CSReporteConductor(idReservaAprobada, nombreCompletoConductor, inconvenientesViaje, descripcionInconveniente, System.Convert.ToSingle(dineroGastadoEnGasolina), comportamientoPasajeros));
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
