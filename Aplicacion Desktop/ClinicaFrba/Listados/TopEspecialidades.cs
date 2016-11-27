using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using System.Data.SqlClient;
using ClinicaFrba.Listados;

namespace ClinicaFrba.Listados
{
    public partial class TopEspecialidades : Form
    {
        ListadoEstadistico_DAO especialidades = new ListadoEstadistico_DAO();

        public TopEspecialidades()
        {
            InitializeComponent();
        }

        public void cargarListaEsp(SqlDataReader lectorTop5)
        {
            SqlDataReader lector;
            lector = lectorTop5;
            cargar_grid_profConMasBonosConsultUtil(lector);
        }

        private void cargar_grid_profConMasBonosConsultUtil(SqlDataReader lector) //Deberán ir en otro form
        {
            labelTop.Text = "Top Especialidades con más bonos utilizados";
            SqlDataReader lectorT5;
            int i = 0;

            lectorT5 = lector;

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[3];
    
            while (lectorT5.Read())
            {
                i++;
                columnas[0] = i.ToString();
                columnas[1] = lectorT5["Especialidad"].ToString();
                columnas[2] = lectorT5["Cantidad"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewEspecialidades, columnas);
            }

            lectorT5.Close();
            dataGridViewEspecialidades.Rows.AddRange(filas.ToArray());
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
