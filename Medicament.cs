using System;
using System.Collections.Generic;

namespace Farmacie
{
    public class Medicament
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private static int IdCurrent = 0;
        public string Nume { get; set; }
        public int Cantitate{ get; set; }
        public string CategorieVarsta { get; set; }
        public bool InStoc { get; set; }
        public int IdMedicament { get; set; } //identificator unic medicament

        //Constructor cu parametrii
        public Medicament(string nume, int cantitate, string categorievarsta, bool inStoc)
        {
            Nume = nume;
            Cantitate = cantitate;
            CategorieVarsta = categorievarsta;
            InStoc = inStoc;
            IdMedicament = IdCurrent++;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Medicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            IdMedicament = IdCurrent++;
            Nume = dateFisier[0];
            Cantitate = int.Parse(dateFisier[1]);
            CategorieVarsta = dateFisier[2];
            InStoc = bool.Parse(dateFisier[3]);
        }

        public List<string> GetAtributes()
        {
            return new List<string>()
            {
                IdMedicament.ToString(),
                Nume,
                Cantitate.ToString(),
            };
        }
        public string ConversieLaSir_PentruFisier()
        {
            return $"{Nume}{SEPARATOR_PRINCIPAL_FISIER}" +
                $"{Cantitate}{SEPARATOR_PRINCIPAL_FISIER}" +
                $"{CategorieVarsta}{SEPARATOR_PRINCIPAL_FISIER}" +
                $"{InStoc}{SEPARATOR_PRINCIPAL_FISIER}\n";
        }


    
    }
}
