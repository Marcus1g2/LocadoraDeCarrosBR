// See https://aka.ms/new-console-template for more information


using LocadoraDeCarrosBR.Entities;
using LocadoraDeCarrosBR.Services;
using System.Globalization;

Console.WriteLine("modelo do carro ");
string Modelo = Console.ReadLine();
Console.WriteLine("instante inicial ");
DateTime Inicial = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("final da locação ");
DateTime Final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("valor por hora ");
double Hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("valor diário ");
double Diario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Car car = new Car(Inicial, Final, new(Modelo));

CarServices carServices = new CarServices(Hora, Diario, new());

carServices.Locacoes(car);

Console.WriteLine("gerarando nota ");
Console.WriteLine(car.valorTaxa);




