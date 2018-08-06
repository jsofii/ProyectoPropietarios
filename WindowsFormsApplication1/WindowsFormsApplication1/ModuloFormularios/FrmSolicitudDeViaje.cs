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
using WindowsFormsApplication1;
using WindowsFormsApplication1.ModuloFormularios;

namespace ModuloFormularios
{
    public partial class FrmSolicitudDeViaje : Form
    {
        private Conexion cnx = new Conexion();
        private SqlConnection conn;
        private ArrayList idDestino = new ArrayList();
        private String id;
        public FrmSolicitudDeViaje()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT idLugar, nombreLugar FROM dbo.Lugar", conn);
                reader = comando.ExecuteReader();
                comboBoxDestinos.DisplayMember = "Text";
                comboBoxDestinos.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxDestinos.Items.Add(new { Text = reader[1], Value = reader[0] });
                    
                }
                comboBoxDestinos.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT idMotivoViaje, descripcion FROM dbo.MotivoViaje", conn);
                reader = comando.ExecuteReader();
                comboBoxMotivos.DisplayMember = "Text";
                comboBoxMotivos.ValueMember = "Value";
                while (reader.Read())
                {
                    comboBoxMotivos.Items.Add(new { Text = reader[1], Value = reader[0] });

                }
                comboBoxMotivos.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void setID(String id)
        {
            this.id = id;
            try
            {
                Conexion cnx = new Conexion();
                SqlConnection conn = new SqlConnection(cnx.stringConexion);
                conn.Open();
                SqlCommand comando = new SqlCommand("select nombreSolicitante,email from Solicitante where idSolicitante =" + id, conn);
                SqlDataReader reader = comando.ExecuteReader();
                String nombre = "", email = "";
                while (reader.Read())
                {
                    nombre = "" + reader[0];
                    email = "" + reader[1];
                }
                txt_ciSolicitante.Text = email;
                txt_nombreSolicitante.Text = nombre;
                comboBoxMotivos.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            SolicitudDeViaje cssolicitud = new SolicitudDeViaje(txt_ciSolicitante.Text, txt_nombreSolicitante.Text, comboBoxDestinos.SelectedItem.ToString(), dtf_salida.Text, dth_salida.Text, dtf_llegada.Text, dth_llegada.Text, comboBoxDestinos.SelectedItem.ToString(), Int32.Parse(textBox1.Text));
            cssolicitud.setIDs((comboBoxMotivos.SelectedIndex + 1), (comboBoxDestinos.SelectedIndex + 1), Int32.Parse(id));
            cssolicitud.guardarEnBase();
            //MessageBox.Show(""+ txt_ciSolicitante.Text+" "+txt_nombreSolicitante.Text+" "+comboBoxDestinos.SelectedItem.ToString()+" "+dtf_salida.Text+" "+dth_salida.Text, dtf_llegada.Text+" "+dth_llegada.Text+" "+comboBoxDestinos.SelectedItem.ToString()+" "+textBox1.Text);
            //cssolicitud.setIDs((comboBoxMotivos.SelectedIndex + 1), (comboBoxDestinos.SelectedIndex + 1), Int32.Parse(id));
        }
    }
}
