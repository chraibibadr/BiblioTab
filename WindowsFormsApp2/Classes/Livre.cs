using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Livre:Ouvrage
    {
        private string auteur;
        private string titre;
        private string editeur;

        public Livre(DateTime dateEmp, string auteur, string titre, string editeur):base(dateEmp)
        {
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
        }

        public string getTitre()
        {
            return titre;
        }

        public override string ToString()
        {
            return base.ToString() + "  Auteur : " + auteur + "  Titre : " + titre + "  Editeur : " + editeur;
        }
    }
}
