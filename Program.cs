using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var farmacie = new Farmacie();
            //farmacie.AdaugMed(new Medicament("Paracetamol", 500, "Adulti", true));
            //farmacie.AdaugMed(new Medicament("Vidan", 20, "Adulti", true));
            //farmacie.AdaugMed(new Medicament("Ampicilina", 500, "Adulti", false));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(farmacie));
        }
    }
}
