using System;
using System.Collections.Generic;
using System.IO;

namespace Farmacie
{
    public class Farmacie
    {
        public string numeFarmacie;
        public List<Medicament> medicamente = new List<Medicament>();

        public void AdaugMed(Medicament medicament)
        {
            medicamente.Add(medicament);
        }

        public void AfisareListaMed()
        {
            for (int i = 0; i < medicamente.Count; i++)
            {
                Console.WriteLine($"NUME: {medicamente[i].Nume},CANTITATE: {medicamente[i].Cantitate}");

            }
        }

        public void Afisare_Lista_Medicamente()
        {
            foreach (Medicament medicam in this.medicamente)
            {
                Console.WriteLine($"{medicam.IdMedicament},{medicam.Nume},{medicam.Cantitate}");
            }
        }
        public List<Medicament> CautaMedicamente(string CuvantCheie)
        {
            var MedicamenteGasite = new List<Medicament>();
            foreach(var medicament in medicamente)
            {
                if (medicament.Nume.Contains(CuvantCheie))
                {
                    MedicamenteGasite.Add(medicament);
                }
                else if(medicament.Cantitate.ToString().Contains(CuvantCheie))
                {
                    MedicamenteGasite.Add(medicament);
                }
                else if((medicament.CategorieVarsta.Contains(CuvantCheie)))
                {
                    MedicamenteGasite.Add(medicament);
                }
                else if(medicament.InStoc.ToString().Contains(CuvantCheie))
                {
                    MedicamenteGasite.Add(medicament);
                }
            }
            return MedicamenteGasite;
        }
        
        public void SalvareMedicamenteInFisier(string NumeFisier)
        {
            using (StreamWriter StreamWriterFisier = new StreamWriter(NumeFisier, false))
            {
                foreach (Medicament medicament in this.medicamente)
                {
                    StreamWriterFisier.Write(medicament.ConversieLaSir_PentruFisier());
                }
            }
        }
        public int IncarcareMedicamenteInFisier(string NumeFisier)
        {
            int nr_medicamente_adaugate = 0;

            using (StreamReader streamReader = new StreamReader(NumeFisier))
            {
                string linieFisier;

                /* citeste cate o linie si creaza un obiect de tip Person
                pe baza datelor din linia citita */

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    if (linieFisier.Length == 0) continue;

                    this.medicamente.Add(new Medicament(linieFisier));
                    nr_medicamente_adaugate++;
                }
            }
            return nr_medicamente_adaugate;
        }
    }
}
