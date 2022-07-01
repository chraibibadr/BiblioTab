using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Ouvrage
    {
        protected DateTime dateEmp;
        protected int cote;
        protected Boolean isEmprunt = false;
        private static int cmp = 0;

        public Ouvrage()
        {
            this.dateEmp = new DateTime();
            this.cote = ++cmp;
        }

        public Ouvrage(DateTime dateEmp)
        {
            this.dateEmp = dateEmp;
            this.cote = ++cmp;
        }

        public int getCote()
        {
            return cote;
        }

        public Boolean getEmprunt()
        {
            return isEmprunt;
        }

        public void setEmprunt(Boolean etat)
        {
            isEmprunt = etat;
        }

        public void setDateEmp(DateTime d)
        {
            dateEmp = d;
        }

        public override string ToString()
        {
            if(isEmprunt == false)
                return "Cote : " + cote + " " + "Disponible ! ";
            else
                return "Cote : " + cote + " " + "Date d'emprunt : " + dateEmp.ToShortDateString()+"    ";
        }
    }
}
