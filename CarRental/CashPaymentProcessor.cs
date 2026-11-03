namespace CarRental
{
	internal class CashPaymentProcessor : IPaymentProcessor
	{
		public void ProcessPayment(double amount, string reference)
		{
			Console.WriteLine($"Cash payment of ${amount:F2} received. Reference: {reference}");
		}
	}
}