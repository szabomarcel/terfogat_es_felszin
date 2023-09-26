using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terfogat_es_felszin
{
    internal class Teglatest : Testek
    {
        readonly double aoldal;
        readonly double boldal;
        readonly double coldal;

        public Teglatest(double aoldal, double boldal, double coldal) : base ("Téglatest")
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
            this.coldal = coldal;
        }

        public double Aoldal { get => aoldal; }
        public double Boldal { get => boldal; }
        public double Coldal { get => coldal; }

        public override double Felszin()
        {
            return 2 * (aoldal * boldal + aoldal * coldal + boldal * coldal);
        }
        public override double Terfogat()
        {
            return aoldal * boldal * coldal;
        }
    }
}
