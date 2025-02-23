﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreysGym.Forms
{
    public partial class FrmFrequencia: Form
    {
        private FrmFrequencia()
        {
            InitializeComponent();
        }

        private static FrmFrequencia instancia;

        public static FrmFrequencia GetInstance()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmFrequencia();
            }
            return instancia;
        }
    }
}
