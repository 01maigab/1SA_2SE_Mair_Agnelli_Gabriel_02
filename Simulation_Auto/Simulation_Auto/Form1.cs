﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulation_Auto
{
    public partial class Form1 : Form
    {
        string marke = "w", farbe="q";
        double ps=0,tankgrse=0,verbrauch=0,tank=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Erstellen_Click(object sender, EventArgs e)
        {
            marke=txt_BoxMarke.Text;
            farbe = cmbo_BoxFarbe.Text;
            ps=Convert.ToDouble(txtBox_Ps.Text);
            tankgrse = Convert.ToDouble(txtBoxTankgröße.Text);
            verbrauch = Convert.ToDouble(txt_BoxVerbrauch.Text);
        Auto: marke;
        }


        



        class Auto{

            public double tanken(double tankgrse) { 
            
            }





        }
    }

}
