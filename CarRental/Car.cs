namespace CarRental
{
	internal class Car : Vehicle, IRentable
	{
		public string RegistrationNumber { get; set; }
		public double DailyRate { get; set; }

		public Car(string make, string model, string registrationNumber, double dailyRate)
			: base(make, model)
		{
			RegistrationNumber = registrationNumber;
			DailyRate = dailyRate;
		}

		public void ShowFullInfo()
		{
			ShowBasicInfo();
			Console.WriteLine($"Registration: {RegistrationNumber}, Daily rate: ${DailyRate:F2}");
		}

		public double CalculateCost(int days)
		{
			return DailyRate * days;
		}

		public void Rent(int days)
		{
			Console.WriteLine($"{Make} {Model} rented for {days} day(s).");
		}
	}
}