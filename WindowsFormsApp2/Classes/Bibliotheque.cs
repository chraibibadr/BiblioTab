using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract class Bibliotheque
    {
        public abstract void ajouter(Ouvrage e);
        public abstract void supprimer(Ouvrage e);
        public abstract void Emprunter(Utilisateur u);
        public abstract void verifierEmprunt();
    }
}
