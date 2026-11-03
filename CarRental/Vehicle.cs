namespace CarRental
{
	internal class Vehicle
	{
		public string Make { get; set; }
		public string Model { get; set; }

		public Vehicle(string make, string model)
		{
			Make = make;
			Model = model;
		}

		public void ShowBasicInfo()
		{
			Console.WriteLine($"{Make} {Model}");
		}
	}
}