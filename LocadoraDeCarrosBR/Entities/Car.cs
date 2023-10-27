using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarrosBR.Entities
{
    internal class Car
    {
        public DateTime Inicial { get; set; }
        public DateTime Final { get; set; }
        public CarModel Modelo { get; set; }
        public ValorTaxa valorTaxa { get; set; }

        public Car(DateTime inicial, DateTime final, CarModel modelo)
        {
            Inicial = inicial;
            Final = final;
            Modelo = modelo;
        }

    }
}
