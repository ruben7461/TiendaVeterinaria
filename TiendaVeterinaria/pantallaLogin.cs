﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVeterinaria
{
    public partial class pantallaLogin : Form
    {
        public pantallaLogin()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBBDD.conectar().Open();


        }

        private void ComprobarUsuario(string usuario,string contraseña)
        {

        }
    }
}
