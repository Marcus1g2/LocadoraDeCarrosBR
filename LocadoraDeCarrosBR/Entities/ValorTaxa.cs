using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarrosBR.Entities
{
    internal class ValorTaxa
    {
        public double Valortotal { get; set; }
        public double Imposto { get; set; }

        public ValorTaxa(double valortotal, double imposto)
        {
            Valortotal = valortotal;
            Imposto = imposto;
        }

        public double ValorcomTaxa
        {
            get { return Valortotal + Imposto; }
        }

        public override string ToString()
        {
            return
                " Valor da locação =" + Valortotal.ToString("F2", CultureInfo.InvariantCulture)
                + " valor do imposto" + Imposto.ToString("F2", CultureInfo.InvariantCulture)
                + " valor total do pagamento" + ValorcomTaxa.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
