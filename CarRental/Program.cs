namespace CarRental
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car[] cars =
			{
				new Car("Toyota", "Corolla", "LK21 BNF", 45.00),
				new Car("Honda", "Civic", "YH19 TRD", 50.00),
				new Car("Volkswagen", "Golf", "BD68 KWA", 55.00)
			};

			Console.WriteLine("=== CAR RENTAL SYSTEM ===");
			Console.WriteLine("Available cars:\n");
			for (int i = 0; i < cars.Length; i++)
			{
				Console.Write($"{i + 1}. ");
				cars[i].ShowFullInfo();
			}

			// Choose a car
			int carChoice;
			Console.Write("\nEnter the number of the car you want to rent: ");
			while (!int.TryParse(Console.ReadLine(), out carChoice) || carChoice < 1 || carChoice > cars.Length)
			{
				Console.Write($"Invalid choice. Enter a number from 1 to {cars.Length}: ");
			}
			Car selectedCar = cars[carChoice - 1];

			// Rental days
			int days;
			Console.Write("How many days do you want to rent it? ");
			while (!int.TryParse(Console.ReadLine(), out days) || days <= 0)
			{
				Console.Write("Invalid input. Enter a whole number of days (1 or more): ");
			}

			double total = selectedCar.CalculateCost(days);
			selectedCar.Rent(days);
			Console.WriteLine($"Total cost: ${total:F2}");

			// Payment method
			int payChoice;
			Console.Write("\nPayment method: 1 = Card, 2 = Cash. Enter your choice: ");
			while (!int.TryParse(Console.ReadLine(), out payChoice) || (payChoice != 1 && payChoice != 2))
			{
				Console.Write("Invalid choice. Enter 1 for Card or 2 for Cash: ");
			}

			IPaymentProcessor processor;
			if (payChoice == 1)
			{
				processor = new CardPaymentProcessor();
			}
			else
			{
				processor = new CashPaymentProcessor();
			}

			string reference = $"RENT-{selectedCar.RegistrationNumber.Replace(" ", "")}-{days}D";
			processor.ProcessPayment(total, reference);

			// Receipt
			Console.WriteLine("\n===== RECEIPT =====");
			Console.WriteLine($"Car: {selectedCar.Make} {selectedCar.Model}");
			Console.WriteLine($"Registration: {selectedCar.RegistrationNumber}");
			Console.WriteLine($"Days: {days}");
			Console.WriteLine($"Daily rate: ${selectedCar.DailyRate:F2}");
			Console.WriteLine($"Total paid: ${total:F2}");
			Console.WriteLine($"Payment: {(payChoice == 1 ? "Card" : "Cash")}");
			Console.WriteLine($"Reference: {reference}");
			Console.WriteLine("===================");
		}
	}
}