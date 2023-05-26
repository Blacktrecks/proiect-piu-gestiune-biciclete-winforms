using System;
using System.Windows.Forms;

namespace Magazin_Biciclete
{
   internal static class Program
   {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var magazinBiciclete = new MagazinBicicleta();

            //test
            //program
            magazinBiciclete.AdaugaBicicleta(new Bicicleta("tadashi", "ser", 123, true, Culoare.Alb, Tip.Pliabila));
            magazinBiciclete.AdaugaBicicleta(new Bicicleta("komo", "axiom", 345, true, Culoare.Alb, Tip.Pliabila));
            magazinBiciclete.AdaugaBicicleta(new Bicicleta("shi", "qwa", 221, true, Culoare.Alb, Tip.Electrica));
            magazinBiciclete.AdaugaBicicleta(new Bicicleta("ashi", "ssser", 972, true, Culoare.Verde, Tip.Pliabila));
         

            Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Form1(magazinBiciclete));
      }
   }
}
