using System;
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
        double ps=0,tankgrse=0,verbrauch=0,tank=0,fahren=0,reichweite=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Erstellen_Click(object sender, EventArgs e)
        {
            auto();
        }

      /*  private void marke()
        {
            throw new NotImplementedException();
        }

        */
        



        class Auto{

      //    public static double tanke(double tankgrse) { 


            
         //   }





        }

        private void rTB_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_Tanken_Click(object sender, EventArgs e)
        {
            auto();


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void cmd_Fahren_Click(object sender, EventArgs e)
        {
            tank = tank - (fahren * verbrauch);
            auto();
        }

        private void txt_BoxFahren_TextChanged(object sender, EventArgs e)
        {

        }
        public void auto()
        {
             tank =tank+ Convert.ToDouble(textBox1.Text);
            
            progressBar1.Value =Convert.ToInt32( tank);

             fahren = Convert.ToDouble(txt_BoxFahren.Text);

             reichweite = tankgrse / verbrauch;

             marke=txt_BoxMarke.Text;

            farbe = cmbo_BoxFarbe.Text;

            ps=Convert.ToDouble(txtBox_Ps.Text);

            tankgrse = Convert.ToDouble(txtBoxTankgröße.Text);

            verbrauch = Convert.ToDouble(txt_BoxVerbrauch.Text);


       rTB_Info.Text="Marke: "+marke+"\nFarbe "+farbe+"\nPs: "+ps+"\nTankgröse: "+tankgrse+"\nVerbrauch: "+verbrauch+"\n"+tank+"\nReichweite:"+reichweite;

       progressBar1.Maximum =Convert.ToInt32( tankgrse);
        }
    }

}
