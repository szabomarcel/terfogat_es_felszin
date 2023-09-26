using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terfogat_es_felszin
{
    internal class Henger : Testek
    {
        readonly double mMagassag;
        readonly double sugar;

        public Henger(double mMagassag, double sugar) : base("Henger")
        {
            this.mMagassag = mMagassag;
            this.sugar = sugar;
        }

        public double MMagassag { get => mMagassag; }
        public double Sugar { get => sugar; }
        public override double Felszin()
        {
            return 2 * sugar * sugar * Math.PI + sugar * Math.PI * mMagassag;
        }
        public override double Terfogat()
        {
            return sugar * sugar * Math.PI * mMagassag;
        }
    }
}
