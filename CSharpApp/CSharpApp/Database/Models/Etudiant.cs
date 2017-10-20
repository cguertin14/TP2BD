using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp.Database.Models
{
    public class Etudiant
    {
        private string nomStg;
        private string prenomStg;
        private string description;
        private string nomEnt;
        private string nomTr;
        private string nomSvr;

        public Etudiant(string nomStg,string prenomStg,string description,string nomEnt,string nomTr,string nomSvr)
        {
            this.NomStg = nomStg;
            this.PrenomStg = prenomStg;
            this.Description = description;
            this.NomEnt = nomEnt;
            this.NomTr = nomTr;
            this.NomSvr = nomSvr; 
        }

        #region get-set
        public string NomStg
        {
            get { return nomStg; }
            set { nomStg = value; }
        }
        public string PrenomStg
        {
            get { return prenomStg; }
            set { prenomStg = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string NomEnt
        {
            get { return nomEnt; }
            set { nomEnt = value; }
        }
        public string NomTr
        {
            get { return nomTr; }
            set { nomTr = value; }
        }
        public string NomSvr
        {
            get { return nomSvr; }
            set { nomSvr = value; }
        }
        #endregion
    }
}
