using System;

namespace OOP {
	class Temperature {
		private decimal _celsius;

		public decimal Celsius {
			get => _celsius;

			set {
				if (value < (decimal)-273.15)
					throw new Exception("Celsius cannot be less than 237.15");

				_celsius = value;
			}
		}	

		public decimal Fahrenheit {
			get => (_celsius * 9/5) + 32;
		}
	}

	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello, World!");

			Temperature temp = new Temperature();
			temp.Celsius = 9.1M;

			Console.WriteLine(temp.Fahrenheit);
		}
	}
}


// See https://aka.ms/new-console-template for more information
