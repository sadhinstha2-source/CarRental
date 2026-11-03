namespace CarRental
{
	internal class CardPaymentProcessor : IPaymentProcessor
	{
		public void ProcessPayment(double amount, string reference)
		{
			Console.WriteLine($"Card payment of ${amount:F2} processed. Reference: {reference}");
		}
	}
}