using System;

public class Car
{
	private const double maxFuel = 160;

	private double fuelAmount;

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
			return fuelAmount;
		}
		private set
		{
			if (value < 0)
			{
				throw new ArgumentException(OutputMessages.OutOfFuel);
			}

			fuelAmount = Math.Min(value, maxFuel);
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
