using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Periodique:Ouvrage
    {
        private string nom;
        private int numero;
        private int periodicite;

        public Periodique(DateTime dateEmp, string nom, int numero, int periodicite):base(dateEmp)
        {
            this.nom = nom;
            this.numero = numero;
            this.periodicite = periodicite;
        }

        public string getNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return base.ToString() + "  Nom : " + nom + "  Numero : " + numero + "  Periodicite : " + periodicite;
        }
    }
}
