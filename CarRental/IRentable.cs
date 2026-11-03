namespace CarRental
{
	internal interface IRentable
	{
		double CalculateCost(int days);
		void Rent(int days);
	}
}