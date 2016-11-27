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
    public partial class TopBonosComprados : Form
    {
        ListadoEstadistico_DAO especialidades = new ListadoEstadistico_DAO();

        public TopBonosComprados()
        {
            InitializeComponent();
        }

        public void cargarListBonosUtilizados(SqlDataReader lectorTop5)
        {
            SqlDataReader lector;
            lector = lectorTop5;
            cargar_grid_afiliadosConMasBonosComp(lectorTop5);
        }

        private void cargar_grid_afiliadosConMasBonosComp(SqlDataReader lector) //Deberán ir en otro form
        {
            labeTop.Text = "Top Bonos comprados por afiliado";
            SqlDataReader lectorT5;
            int i = 0;

            lectorT5 = lector;

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5]; 

            while (lectorT5.Read())
            {
                i++;
                columnas[0] = i.ToString();
                columnas[1] = lectorT5["desc_apellido"].ToString(); //apellido afiliado
                columnas[2] = lectorT5["desc_nombre"].ToString();//nombre afiliado
                columnas[3] = lectorT5["Cantidad"].ToString(); //cantidad de bonos comprados
                columnas[4] = lectorT5["GrupoFam"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewBonosComprados, columnas);
            }

            lectorT5.Close();
            dataGridViewBonosComprados.Rows.AddRange(filas.ToArray());
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
