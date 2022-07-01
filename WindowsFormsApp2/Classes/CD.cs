using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class CD:Ouvrage
    {
        private string titre;
        private string auteur;

        public CD(DateTime dateEmp,string titre, string auteur):base(dateEmp)
        {
            this.titre = titre;
            this.auteur = auteur;
        }

        public string getTitre()
        {
            return titre;
        }

        public override string ToString()
        {
            return base.ToString() + "  Auteur : " + auteur + "  Titre : " + titre;
        }
    }
}
