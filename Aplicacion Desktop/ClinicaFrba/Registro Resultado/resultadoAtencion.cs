﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class ResultadoAtencion : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;

        public ResultadoAtencion(Menu menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }



       
    }
}