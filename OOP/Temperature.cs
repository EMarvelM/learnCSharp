namespace OOP.Temperatures {
    class Temperature {
		private decimal _celsius;

		public decimal Celsius {
			get => _celsius;

			set {
				if (value < -273.15M)
					throw new Exception("Celsius cannot be less than 237.15");

				_celsius = value;
			}
		}	

		public decimal Fahrenheit {
			get => (_celsius * 9/5) + 32;
		}
	}
}