using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Utilisateur
    {
        private string CIN;
        private string nom;
        private string tele;
        private string motDePasse = "emsi";

        public Utilisateur(string CIN, string nom, string tele)
        {
            this.CIN = CIN;
            this.nom = nom;
            this.tele = tele;
        }

        public string MotDePasse { get => motDePasse; set => motDePasse = value; }

        public override string ToString()
        {
            return "CIN : " + CIN + "  NOM : " + nom + "  Telephone : " + tele;
        }
    }
}
