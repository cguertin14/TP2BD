using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp.Database.Models
{
    public class Entreprise
    {
        private int numEnt;
        private string nomEnt;
        private string adresseEnt;
        private string telEnt;
        private string contactEnt;

        public Entreprise(int numEnt,string nomEnt,string adresseEnt,string telEnt,string contactEnt)
        {
            this.NumEnt = numEnt;
            this.NomEnt = nomEnt;
            this.AdresseEnt = adresseEnt;
            this.TelEnt = telEnt;
            this.ContactEnt = contactEnt;
        }

        #region get-set
        public int NumEnt
        {
            get { return numEnt; }
            set { numEnt = value; }
        }
        public string NomEnt
        {
            get { return nomEnt; }
            set { nomEnt = value; }
        }
        public string AdresseEnt
        {
            get { return adresseEnt; }
            set { adresseEnt = value; }
        }
        public string TelEnt
        {
            get { return telEnt; }
            set { telEnt = value; }
        }
        public string ContactEnt
        {
            get { return contactEnt; }
            set { contactEnt = value; }
        }
        #endregion
    }
}
