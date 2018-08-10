using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    class FachadaFormularios
    {
        
        //Formulario Caro
        public FachadaFormularios(FormMenu frmMenu, Usuario usuario) {
        //mostrarModulo(frmMenu, formularioCaro(usuario));

        }

        public void mostrarModulo(FormMenu frmMenu, object formHijo)
        {
            
            if (frmMenu.panelContenedor.Controls.Count > 0)
                frmMenu.panelContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            frmMenu.panelContenedor.Controls.Add(fh);
            frmMenu.panelContenedor.Tag = fh;
            fh.Show();
        }

    }
 }

