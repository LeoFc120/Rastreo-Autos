// See https://aka.ms/new-console-template for more information

using Rastreo_Autos;

Console.WriteLine("-------Auto-------");
int cant,cantgas, cantgasoli = 0;
Console.WriteLine("Ingresa datos de vehiculos");
Console.WriteLine("Ingresa la cantidad de autos que ingresan al dia: ");
cant= int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la cantidad de vehiculos de Gas: ");
cantgas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la cantidad de vehiculos de Gasolina: ");
cantgasoli = int.Parse(Console.ReadLine());

Vehiculo auto = new Vehiculo("Tipo de vehiculo",5,cant,cantgas,cantgasoli);
auto.mostrarvehiculo();
Console.WriteLine();



Console.WriteLine("-------Moto-------");
int cantm,cc250=0;
Console.WriteLine("Ingresa datos de la Moto");
Console.WriteLine("Ingresa la cantidad de Motos que ingresan al dia: ");
cantm = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la cantidad de motos con un cilindraje mayor a 250: ");
cantgas = int.Parse(Console.ReadLine());

Moto moto = new Moto("Tipo de moto",2,cantm,cc250);
moto.mostrarmoto();