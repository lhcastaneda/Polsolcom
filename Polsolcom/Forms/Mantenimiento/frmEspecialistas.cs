﻿using Polsolcom.Dominio.Helpers;
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
    public partial class frmEspecialistas : Form
    {
        public frmEspecialistas()
        {
            InitializeComponent();
            lstBusMed.DataSource = General.TraerEspecialistas();
        }
    }
}