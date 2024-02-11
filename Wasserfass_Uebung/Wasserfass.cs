using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass_Uebung
{
    /*
     Autor: Aron Herbel
     Version: 1.0
     */

    public class Wasserfass
    {
        private int minimalPegel;
        private int maximalPegel;
        private int fuellstand;
        private int kapiziteat;


        public Wasserfass(int kapazitaet, int minimalPegel, int maximalPegel)
        {
            this.kapiziteat = kapazitaet;
            this.minimalPegel = minimalPegel;
            this.maximalPegel = maximalPegel;
        }

        private int MinimalPegel
        {
            get
            {
                return minimalPegel;
            }
        }

        private int MaximalPegel
        {
            get
            {
                return maximalPegel;
            }
        }

        public int Fuellstand
        {
            get
            {
                return fuellstand;
            }
            set
            {
               fuellstand = value;
            }
        }

        public int Kapiziteat
        {
            get
            {
                return kapiziteat;
            }
        }

        public void Befuellen(int menge)
        {
            if (fuellstand + menge <= kapiziteat)
            {
                fuellstand += menge;
            }
            if (menge < 0)
            {
                fuellstand = kapiziteat;
            }
            else
            {
                fuellstand = kapiziteat;
            }
        }

        public void Entnehmen(int menge)
        {
            if (fuellstand - menge >= minimalPegel)
            {
                fuellstand -= menge;
            }
            if (menge < 0)
            {
                fuellstand = kapiziteat;
            }
            else
            {
                fuellstand = minimalPegel;
            }
        }

        public void Entleeren()
        {
            fuellstand = minimalPegel;
        }
    }

}
