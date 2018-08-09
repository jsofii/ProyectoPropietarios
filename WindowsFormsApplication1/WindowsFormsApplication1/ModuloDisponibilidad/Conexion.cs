﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.ModuloDisponibilidad

{
    class Conexion
    {
        //public readonly String stringConexion = "Data Source=localhost,2000;Initial Catalog=sistemaAAP;User ID=sistemaAAP;Password=sistemaAAP";
        //public readonly String stringConexion = "Data Source=172.31.101.33,1433;Initial Catalog=SistemaAAP;Persist Security Info=True;User ID=grupoAli;Password=grupoAli";
        public readonly String stringConexion = "Data Source=MICHAEL;Initial Catalog=sistemAAP;Integrated Security=True";
        // public SqlConnection conectarbd = new SqlConnection();

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;




        public Conexion()
        {
            try
            {
                cn = new SqlConnection(stringConexion);
                cn.Open();
              //MessageBox.Show("CONECTADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto a la base");

            }



        }
        public void query(String consulta)
        {
            try
            {
                cmd = new SqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto no hice la consulta");
            }
        }
        public void CargarDatos(String consulta, DataGridView tabla)
        {
            try
            {
                DataTable dt2 = new DataTable();
                cn = new SqlConnection(stringConexion);
                cmd = new SqlCommand(consulta, cn);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt2);
                tabla.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar la tabla");
                MessageBox.Show(Convert.ToString(ex));
            }


        }
        //me retorna una tabla con los valores de solicitados en la consulta

        public DataTable Buscar(string idsolicitante, string consulta)
        {
            DataTable dt2 = new DataTable();

            cn = new SqlConnection(stringConexion);
            cmd = new SqlCommand(consulta, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
            return dt2;
        }
        public DataTable tablaConsulta( string consulta)
        {
            DataTable dt2 = new DataTable();

            cn = new SqlConnection(stringConexion);
            cmd = new SqlCommand(consulta, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
            return dt2;
        }


    }
}
