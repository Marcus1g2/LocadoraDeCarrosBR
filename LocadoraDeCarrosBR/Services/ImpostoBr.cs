using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Brasil valor do imposto= valor total<=100 { valor total * 0.20 }
// valor do imposto= valor total>100 { valor total * 0.15 }
namespace LocadoraDeCarrosBR.Services
{
    internal class ImpostoBr : Taxa
    {
        public double taxa(double Valortotal)
        {
            if (Valortotal <= 100.00)
            {
                return Valortotal * 0.20;
            }
            else
            {
                return Valortotal * 0.15;
            }
        }

    }
}
