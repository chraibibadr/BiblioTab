using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Emprunt
    {
        private Ouvrage ouvrage;
        private Utilisateur utilisateur;
        private string empruntNom;
        private string empruntTele;
        private DateTime empruntDateR;

        public Emprunt(){}

        public Emprunt(Ouvrage ouvrage, Utilisateur utilisateur, string empruntNom, string empruntTele, DateTime empruntDateR)
        {
            this.ouvrage = ouvrage;
            this.utilisateur = utilisateur;
            this.empruntNom = empruntNom;
            this.empruntTele = empruntTele;
            this.empruntDateR = empruntDateR;
        }

        public string EmpruntNom { get => empruntNom; set => empruntNom = value; }

        public string EmpruntTele { get => empruntTele; set => empruntTele = value; }

        public DateTime EmpruntDateR { get => empruntDateR; set => empruntDateR = value; }

        internal Ouvrage Ouvrage { get => ouvrage; set => ouvrage = value; }

        internal Utilisateur Utilisateur { get => utilisateur; set => utilisateur = value; }

        public override string ToString()
        {
            return "Ouvrage : " + ouvrage.ToString() + "\nUtilisateur : " + utilisateur.ToString() + "\n Nom d'emprunteur : " + empruntNom + "  Telephone d'emprunteur : " + empruntTele + "  Date de retour : " + empruntDateR.ToShortDateString();
        }
    }
}
