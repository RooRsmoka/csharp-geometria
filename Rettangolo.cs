using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class Rettangolo
    {
        private double dBaseRettangolo;
        private double dAltezzaRettangolo;
        private string sNomeRettangolo;

        public Rettangolo(int baseRet, int altezzaRet, string sNomeRet)
        {
            dBaseRettangolo = baseRet;
            dAltezzaRettangolo = altezzaRet;
            sNomeRettangolo = sNomeRet;

        }

        public double CalcolaPerimetro()
        {
            return (dBaseRettangolo + dAltezzaRettangolo) * 2;
        }

        public double CalcolaArea()
        {
            return dBaseRettangolo * dAltezzaRettangolo;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("-- {0} --", sNomeRettangolo);
            Console.WriteLine("Base: {0} cm", dBaseRettangolo);
            Console.WriteLine("Altezza: {0} cm", dAltezzaRettangolo);
            Console.WriteLine("Perimetro: {0} cm", CalcolaPerimetro());
            Console.WriteLine("Area: {0} cm²", CalcolaArea());
            Console.WriteLine();
        }
    }
}