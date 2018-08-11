using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1

{
    class Autorizacion
    {
        public Boolean estado = false;
        public String fecha_autorizacion;

        LinkedList<string[]> list = new LinkedList<string[]>();
        string[] motivosValidos = { "Excursion", "Salida de campo", "Gira" };
        DateTime thisDay = DateTime.Today;


        //este analiza solo la que se envio para analizar, es decir, la que que se selecciono de la tabla de solicitudes de la ventana













        //este analiza todas las solicitudes de golpe, no se la llama en ningun lado por el momento, solo se la usó para hacer pruebas al inicio

        public void autorizar(String reserva)
        {


  
            Conexion conect = new Conexion();
            conect.query(" update solicitudreserva set estadosolicitud='aprobada1' where idsolicitudreserva=" + reserva + ";");
            Conexion cn = new Conexion();
           
            DataTable dtaux = cn.Buscar("", "select idusuario from solicitudreserva where idsolicitudreserva= '" + reserva + "'");
            DataRow row = dtaux.Rows[0];
            String idusuario = Convert.ToString(row["idusuario"]);

            DataTable dtaux2 = cn.Buscar("", "select email, nombre from usuarios where idusuario= '" + idusuario + "'");
            DataRow row2 = dtaux2.Rows[0];
            String email = Convert.ToString(row2["email"]);
            String nombre = Convert.ToString(row2["nombre"]);
            //MessageBox.Show("mi email del solicitante es" + email);
            NotificacionUsuario notificacion = new NotificacionUsuario();
            notificacion.NotificacionSolicitudAprobada(email, "SOLICITANTE:" + nombre + "SU SOLICITUD HA SIDO APROBADA");

        }
        public void rechazar (String reserva)
        {
            Conexion conect = new Conexion();
            conect.query(" update solicitudreserva set estadosolicitud='rechazada' where idsolicitudreserva=" + reserva + ";");
            Conexion cn = new Conexion();

            DataTable dtaux = cn.Buscar("", "select idusuario from solicitudreserva where idsolicitudreserva= '" + reserva + "'");
            DataRow row = dtaux.Rows[0];
            String idusuario = Convert.ToString(row["idusuario"]);

            DataTable dtaux2 = cn.Buscar("", "select email, nombre from usuarios where idusuario= '" + idusuario + "'");
            DataRow row2 = dtaux2.Rows[0];
            String email = Convert.ToString(row2["email"]);
            String nombre = Convert.ToString(row2["nombre"]);
            //MessageBox.Show("mi email del solicitante es" + email);
            NotificacionUsuario notificacion = new NotificacionUsuario();
            notificacion.NotificacionSolicitudRechazada(email, "SOLICITANTE:" + nombre + "SU SOLICITUD HA SIDO RECHAZADA");
        }








    }
}
