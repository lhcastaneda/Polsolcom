﻿using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmRepProdTer : Form
    {
        public frmRepProdTer()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRepProdTer_Load(object sender, EventArgs e)
        {
            especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbEspecialidad.SelectedIndex = -1;


        }
    }
}
