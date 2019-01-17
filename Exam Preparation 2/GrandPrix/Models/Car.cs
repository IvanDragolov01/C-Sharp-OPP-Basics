using System;

public class Car
{
	private const double MaxFuel = 160;

	private double _fuelAmount;

	public Car(int hp, double fuelAmount, Tyre tyre)
	{
		Hp = hp;
		FuelAmount = fuelAmount;
		Tyre = tyre;
	}

	public int Hp
	{
		get;
	}

	public double FuelAmount
	{
		get
		{
			return FuelAmount;
		}
		private set
		{
			if (value < 0)
			{
				throw new ArgumentException(OutputMessages.OutOfFuel);
			}

			FuelAmount = Math.Min(value, MaxFuel);
		}
	}

	public Tyre Tyre
	{
		get;
		private set;
	}

	internal void Refuel(double fuelAmount)
	{
		FuelAmount += fuelAmount;
	}

	internal void ChangeTyres(Tyre tyre)
	{
		Tyre = tyre;
	}

	internal void CompleteLap(int trackLength, double fuelConsumption)
	{
		FuelAmount -= trackLength * fuelConsumption;

		Tyre.CompleteLap();
	}
}
