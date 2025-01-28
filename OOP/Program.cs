using System;
using OOP.Temperatures;
using OOP.VehicleModule;

namespace OOP {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello, World!");

			Temperature temp = new Temperature();
			temp.Celsius = 9.1M;

			Console.WriteLine(temp.Fahrenheit);

			Vehicle vehicle = new Plane();

			vehicle.Start();
			vehicle.Speed = 300.9M;
			vehicle.Stop();
		}
	}
}


// See https://aka.ms/new-console-template for more information
