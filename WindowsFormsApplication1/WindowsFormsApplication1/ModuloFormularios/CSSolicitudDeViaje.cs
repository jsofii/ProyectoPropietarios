using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    class CSSolicitudDeViaje
    {
        private string correoInstitucional;
        private string nombreCompletoSolicitante;
        private string destino;
        private string fechaSalida;
        private string horaSalida;
        private string fechaRetorno;
        private string horaRetorno;
        private string motivo;
        private int idmotivo;
        private int idUsuario;
        private String lugar;
        private int numeroPersonas;
        private Conexion cnx = new Conexion();
        private SqlConnection conn;

        public CSSolicitudDeViaje(string correoInstitucional, string nombreCompletoSolicitante, string destino, string fechaSalida, string horaSalida, string fechaRetorno, string horaRetorno, string motivo, int numeroPersonas)
        {
            conn = new SqlConnection(cnx.stringConexion);
            this.correoInstitucional = correoInstitucional;
            this.nombreCompletoSolicitante = nombreCompletoSolicitante;
            this.destino = destino;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.fechaRetorno = fechaRetorno;
            this.horaRetorno = horaRetorno;
            this.motivo = motivo;
            this.numeroPersonas = numeroPersonas;
        }

        public CSSolicitudDeViaje() {
            conn = new SqlConnection(cnx.stringConexion);
        }

        public int getNumeroPersonas()
        {
            return this.numeroPersonas;
        }

        public void setNumeroPersonas(int numeroPersonas)
        {
            this.numeroPersonas = numeroPersonas;
        }

        public string getMotivo()
        {
            return this.motivo;
        }

        public void setMotivo(string motivo)
        {
            this.motivo = motivo;

        }

        public string getHoraRetorno()
        {
            return this.horaRetorno;
        }

        public void setHoraRetorno(string horaRetorno)
        {
            this.horaRetorno = horaRetorno;

        }

        public string getFechaRetorno()
        {
            return this.fechaRetorno;
        }

        public void setFechaRetorno(string fechaRetorno)
        {
            this.fechaRetorno = fechaRetorno;

        }

        public string getHoraSalida()
        {
            return this.horaSalida;
        }

        public void setHoraSalida(string horaSalida)
        {
            this.horaSalida = horaSalida;

        }

        public string getFechaSalida()
        {
            return this.fechaSalida;
        }

        public void setFechaSalida(string fechaSalida)
        {
            this.fechaSalida = fechaSalida;

        }

        public string getDestino()
        {
            return this.destino;
        }

        public void setDestino(string destino)
        {
            this.destino = destino;

        }

        public string getNombreCompletoSolicitante()
        {
            return this.nombreCompletoSolicitante;
        }

        public void setNombreCompletoSolicitante(string nombreCompletoSolicitante)
        {
            this.nombreCompletoSolicitante = nombreCompletoSolicitante;

        }

        public string getCorreoInstitucional()
        {
            return this.correoInstitucional;
        }

        public void setCorreoInstitucional(string correoInstitucional)
        {
            this.correoInstitucional = correoInstitucional;

        }

        public void setIDs(int idmotivo, int idUsuario) {
            this.idmotivo = idmotivo;
            this.idUsuario = idUsuario;
        }

        public void setLugar(String lugar) {
            this.lugar = lugar;
        }

        public void setAtributos(string correoInstitucional, string nombreCompletoSolicitante) {
            this.correoInstitucional = correoInstitucional;
            this.nombreCompletoSolicitante = nombreCompletoSolicitante;
            this.destino = destino;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.fechaRetorno = fechaRetorno;
            this.horaRetorno = horaRetorno;
            this.motivo = motivo;
            this.numeroPersonas = numeroPersonas;
        }

        public void actualizarLugares(ComboBox destino) {
            SqlDataReader reader = null;
            conn.Open();
        }

        public void llenarCorreo(TextBox correobox)
        {
            correobox.Text = this.correoInstitucional;
        }

        public void llenarNombre(TextBox nombrebox) {
            nombrebox.Text = this.nombreCompletoSolicitante;
        }

        public void llenarMotivos(ComboBox comboBoxMotivos) {
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT idMotivoViaje, descripcion FROM dbo.MotivoViaje", conn);
                SqlDataReader reader = comando.ExecuteReader();
                comboBoxMotivos.DisplayMember = "Text";
                comboBoxMotivos.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxMotivos.Items.Add(new { Text = reader[1], Value = reader[0] });

                }
                comboBoxMotivos.SelectedIndex = 0;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public void guardarEnBase() {
           
            try
            {
                
                cnx = new Conexion();
                conn = new SqlConnection(cnx.stringConexion);
                DateTime thisDay = DateTime.Today;
                String sql = "insert into SolicitudReservaTest(idMotivoViaje,idusuario,lugar,numeroPersonas,fechaSalida,fechaRetorno,estadoSolicitud,fechaReserva)" +
                       " values(" + idmotivo + " , " + 1 + " , '" + destino + "' , " + numeroPersonas + " , '" + fechaSalida + " " + horaSalida + "','" + fechaRetorno + " " + horaRetorno + "','en espera','" + thisDay.ToString() + "')";
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                int resultado = comando.ExecuteNonQuery();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error");
                Console.WriteLine(er.ToString());
            }


        }
    }
}
