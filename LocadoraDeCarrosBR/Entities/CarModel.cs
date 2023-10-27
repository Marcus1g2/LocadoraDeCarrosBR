using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarrosBR.Entities
{
    internal class CarModel
    {
        public string Modelo { get; set; }

        public CarModel(string modelo)
        {
            Modelo = modelo;
        }
    }
}
