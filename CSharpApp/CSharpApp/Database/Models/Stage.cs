using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp.Database.Models
{
    public class Stage
    {
        private int numStage;
        private string description;
        private string typeStg;
        private string langages;
        private string plateformes;
        private int numEnt;
        private int numTr;
        private int numAd;

        // Normal Stage.
        public Stage(int numStage,string description,string langages,string plateformes,int numEnt,int numTr,int numAd)
        {
            this.NumStage = numStage;
            this.Description = description;
            this.Langages = langages;
            this.Plateformes = plateformes;
            this.NumEnt = numEnt;
            this.NumTr = numTr;
            this.NumAd = numAd;
        }

        // Stage to show.
        public Stage(string description, string langages, string plateformes, int numEnt, int numTr, int numAd)
        {
            this.NumStage = 0;
            this.Description = description;
            this.Langages = langages;
            this.Plateformes = plateformes;
            this.NumEnt = numEnt;
            this.NumTr = numTr;
            this.NumAd = numAd;
        }

        #region get-set
        public int NumStage
        {
            get { return numStage; }
            set { numStage = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string TypeStg
        {
            get { return typeStg; }
            set { typeStg = value; }
        }
        public string Langages
        {
            get { return langages; }
            set { langages = value; }
        }
        public string Plateformes
        {
            get { return plateformes; }
            set { plateformes = value; }
        }
        public int NumEnt
        {
            get { return numEnt; }
            set { numEnt = value; }
        }
        public int NumTr
        {
            get { return numTr; }
            set { numTr = value; }
        }
        public int NumAd
        {
            get { return numAd; }
            set { numAd = value; }
        }
        #endregion
    }
}
