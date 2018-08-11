
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ModuloFormularios;
using WindowsFormsApplication1.ModuloReportesEstadisticos;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Correo cor = new Correo();



            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            ////PRUEBAS UNITARIAS
            //Application.Run(new FrmReporteHistorialKilometraje());

            //simuladorLogin log = new simuladorLogin();
            //log.ShowDialog();

            //String[] caro = { "jajaja", "jujuju" };
          //  Application.Run(new ModuloFormularios.FrmReporteConductor("099900","juan Perez",caro));

            //Application.Run(new ModuloFormularios.FrmCalificacionServicio());
            Application.Run(new FormLogin());
            
                //Application.Run(new FrmCalificacionServicio());
            //SIMULACION LOGIN

            /*
            Conexion conect = new Conexion();
            simuladorLogin log = new simuladorLogin();
            log.ShowDialog();
            */

            // conect.query("insert into NotificacionRuta values ('rut2','2-jun-2019');");
            //conect.abrir();
            // conect.query("insert into NotificacionRuta values ('rut5','3-jun-2019')");

            // Reporte Conductor
            //string [] idreserva = {"hola","mundo"};
            //Application.Run(new Form2("481","AIMACAÑA CHUQUILLA WALTER OSWALDO", idreserva));

        }
    }
}
