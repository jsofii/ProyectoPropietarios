using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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

        }
        public void rechazar (String reserva)
        {

        }








    }
}
