using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class BiblioTab : Bibliotheque
    {
        private Ouvrage[] ouvrages = new Ouvrage[10];
        private int pos = -1;

        private Emprunt[] emprunts = new Emprunt[100];
        private int emp = -1;

        public override void ajouter(Ouvrage e)
        {
            pos++;
            if (pos < 10)
            {
                ouvrages[pos] = e;
            }
            else
            {
                Console.WriteLine("La bibliotheque est paleine !");
                pos--;
            }
                
        }

        public override void supprimer(Ouvrage e)
        {
           for(int i = 0; i <= pos; i++)
            {
                if(ouvrages[i].getCote() == e.getCote())
                {
                    for(int j = i; j < pos; j++)
                    {
                        ouvrages[j] = ouvrages[j + 1];
                    }
                    pos--;
                }
            }
        }

        public override void Emprunter(Utilisateur u)
        {
            verifierEmprunt();
            string type = "";
            string titre = "";
            Console.WriteLine("Donner le type d'ouvrage : \nL : pour livre\nP : pour Periodique\nC : pour CD");
            type = Console.ReadLine();
            Console.WriteLine("Donner le nom d'ouvrage : ");
            titre = Console.ReadLine();
            Emprunt e = new Emprunt();

            switch (type)
            {
                case "L":
                    for (int i = 0; i <= pos; i++)
                    {
                        if (ouvrages[i].GetType().Name == "Livre")
                        {
                            Livre l = (Livre)ouvrages[i];
                            if (l.getTitre() == titre && l.getEmprunt() == false)
                            {
                                Console.WriteLine("Donner le nom du client : ");
                                e.EmpruntNom = Console.ReadLine();
                                Console.WriteLine("Donner le telephone du client : ");
                                e.EmpruntTele = Console.ReadLine();
                                Console.WriteLine("Donner la date du retour : ");
                                e.EmpruntDateR = DateTime.Parse(Console.ReadLine());
                                ouvrages[i].setEmprunt(true);
                                ouvrages[i].setDateEmp(e.EmpruntDateR);
                                e.Utilisateur = u;
                                e.Ouvrage = ouvrages[i];
                                emprunts[++emp] = e;
                                Console.WriteLine(e);
                            }
                            else if(l.getTitre() == titre && l.getEmprunt() == true)
                                Console.WriteLine("Ouvrage non disponible (en emprunt) !");
                        }
                    }
                    break;
                case "P":
                    for (int i = 0; i <= pos; i++)
                    {
                        if (ouvrages[i].GetType().Name == "Periodique")
                        {
                            Periodique p = (Periodique)ouvrages[i];
                            if (p.getNom() == titre && p.getEmprunt() == false)
                            {
                                Console.WriteLine("Donner le nom du client : ");
                                e.EmpruntNom = Console.ReadLine();
                                Console.WriteLine("Donner le telephone du client : ");
                                e.EmpruntTele = Console.ReadLine();
                                Console.WriteLine("Donner la date du retour : ");
                                e.EmpruntDateR = DateTime.Parse(Console.ReadLine());
                                ouvrages[i].setEmprunt(true);
                                ouvrages[i].setDateEmp(e.EmpruntDateR);
                                e.Utilisateur = u;
                                e.Ouvrage = ouvrages[i];
                                emprunts[++emp] = e;
                                Console.WriteLine(e);
                            }
                            else if (p.getNom() == titre && p.getEmprunt() == true)
                                Console.WriteLine("Ouvrage non disponible (en emprunt) !");
                        }
                    }
                    break;
                case "C":
                    for (int i = 0; i <= pos; i++)
                    {
                        if (ouvrages[i].GetType().Name == "CD")
                        {
                            CD cd = (CD)ouvrages[i];
                            if (cd.getTitre() == titre && cd.getEmprunt() == false)
                            {
                                Console.WriteLine("Donner le nom du client : ");
                                e.EmpruntNom = Console.ReadLine();
                                Console.WriteLine("Donner le telephone du client : ");
                                e.EmpruntTele = Console.ReadLine();
                                Console.WriteLine("Donner la date du retour : ");
                                e.EmpruntDateR = DateTime.Parse(Console.ReadLine());
                                ouvrages[i].setEmprunt(true);
                                ouvrages[i].setDateEmp(e.EmpruntDateR);
                                e.Utilisateur = u;
                                e.Ouvrage = ouvrages[i];
                                emprunts[++emp] = e;
                                Console.WriteLine(e);
                            }
                            else if (cd.getTitre() == titre && cd.getEmprunt() == true)
                                Console.WriteLine("Ouvrage non disponible (en emprunt) !");
                        }
                    }
                    break;
                default:
                    break;
            }
            verifierEmprunt();
        }

        public override void verifierEmprunt()
        {
            for(int i = 0; i <= emp; i++)
            {
                if(DateTime.Compare(emprunts[i].EmpruntDateR,DateTime.Now) < 0)
                {
                    for(int j = 0; j <= pos; j++)
                    {
                        if(ouvrages[j].getCote() == emprunts[i].Ouvrage.getCote())
                        {
                            ouvrages[j].setEmprunt(false);
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            string msg= "Nombre des ouvrages: " + (pos+1);
            for (int i = 0; i <= pos; i++)
            {
                msg+="\n"+ouvrages[i].ToString();
            }
            return msg;
        }
    }
}
