﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIT_SENAI_V2.Dados
{
    public partial class frm4_1Nota : Form
    {
        public frm4_1Nota()
        {
            InitializeComponent();
            cmbTipoDeMovimento.SelectedIndex = 
                cmbFormaDePagamento.SelectedIndex = 0;
        }
    }
}