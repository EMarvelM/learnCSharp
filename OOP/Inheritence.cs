namespace OOP.VehicleModule {
	class Vehicle {
		private decimal _speed;

		public decimal Speed {
			get => _speed;

			set {
				if (value <= 0M)
					throw new Exception("Speed cannot be less than zero");
				_speed = value;
			}
		}

		public virtual void Start() {
			Console.WriteLine("started Engine");
		}

		public void Stop() {
			Console.WriteLine("Engine stopped");
		}
	}

	class Car : Vehicle {
		
	}

	class Boat : Vehicle {
		public override void Start() {
			Console.WriteLine("Starting Boat engine");
		}
	}

	class Plane : Vehicle {
		public override void Start() {
			Console.WriteLine("Starting engines");
		}

		public void Fly() {
			Console.WriteLine("Fying");
		}
	}
}
