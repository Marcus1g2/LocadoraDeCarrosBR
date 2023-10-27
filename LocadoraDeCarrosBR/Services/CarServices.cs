using LocadoraDeCarrosBR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarrosBR.Services
{
    internal class CarServices
    {////ler valor por hora e o valor diário
        public double Hora { get; set; }
        public double Diario { get; set; }
        public ImpostoBr Imposto { get; set; }

        public CarServices(double hora, double diario, ImpostoBr imposto)
        {
            Hora = hora;
            Diario = diario;
            Imposto = imposto;
        }


        public void Locacoes(Car car)
        {
            double Locacao = 0.00;
            TimeSpan Data = car.Final.Subtract(car.Inicial);
            if (Data.TotalHours <= 12.00)
            {
                Locacao = Math.Ceiling(Data.TotalHours) * Hora;
            }
            else
            {
                Locacao = Math.Ceiling(Data.TotalHours) * Diario;
            }
            double taxa = Imposto.taxa(Locacao);

            car.valorTaxa = new ValorTaxa(Locacao, taxa);
        }

    }
}
