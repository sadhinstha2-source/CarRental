namespace CarRental
{
	internal interface IPaymentProcessor
	{
		void ProcessPayment(double amount, string reference);
	}
}