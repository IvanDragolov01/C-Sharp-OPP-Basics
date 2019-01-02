using System;
using System.Linq;
using _01.Structure.Factories;
using _01.Structure.Units.Harvester;
using _01.Structure.Units.Provider;
using System.Collections.Generic;
using _01.Structure.Units;

namespace _01.Structure.BusinessLogic
{
	public class DraftManager
	{
		private List<Harvester> harvesters;
		private List<Provider> providers;
		private HarvesterFactory harvesterFactory;
		private ProviderFactory providerFactory;
		private string mode;
		private double totalEnergyStored;
		private double totalMinedOre;

		public DraftManager()
		{
			harvesters = new List<Harvester>();
			providers = new List<Provider>();
			harvesterFactory = new HarvesterFactory();
			providerFactory = new ProviderFactory();
			mode = "Full";
			totalEnergyStored = 0;
			totalMinedOre = 0;
		}

		public string RegisterHarvester(List<string> arguments)
		{
			try
			{
				Harvester harvester = harvesterFactory.CreateHarvester(arguments);
				harvesters.Add(harvester);
				return $"Successfully registered {harvester.Type} Harvester - {harvester.Id}.";
			}
			catch (ArgumentException ex)
			{
				return ex.Message;
			}
		}
		public string RegisterProvider(List<string> arguments)
		{
			try
			{
				Provider provider = providerFactory.CreateProvider(arguments);
				providers.Add(provider);
				return $"Successfully registered {provider.Type} Provider - {provider.Id}.";
			}
			catch (ArgumentException ex)
			{
				return ex.Message;
			}
		}

		public string Day()
		{
			double dayEnergyProvided = providers.Sum(p => p.EnergyOutput);
			totalEnergyStored += dayEnergyProvided;
			double dayEnergyRquired, dayMinedOre;

			if (mode == "Full")
			{
				dayEnergyRquired = harvesters.Sum(h => h.EnergyRequirement);
				dayMinedOre = harvesters.Sum(h => h.OreOutput);
			}
			else if (mode == "Half")
			{
				dayEnergyRquired = harvesters.Sum(h => h.EnergyRequirement) * 0.6;
				dayMinedOre = harvesters.Sum(h => h.OreOutput) * 0.5;
			}
			else
			{
				dayEnergyRquired = 0;
				dayMinedOre = 0;
			}

			double realDayMinedOre = 0;

			if (totalEnergyStored >= dayEnergyRquired)
			{
				totalMinedOre += dayMinedOre;
				totalEnergyStored -= dayEnergyRquired;
				realDayMinedOre = dayMinedOre;
			}

			return $"A day has passed." + Environment.NewLine +
			$"Energy Provided: { dayEnergyProvided}" + Environment.NewLine +
			$"Plumbus Ore Mined: {realDayMinedOre   }";
		}

		public string Mode(List<string> arguments)
		{
			mode = arguments[0];
			return $"Successfully changed working mode to {mode} Mode";
		}

		public string Check(List<string> arguments)
		{
			string id = arguments[0];
			// operator ?? check if left side have null if have get right side.
			//But if left side do not have null get left side only and no check right side.
			Unit unit = (Unit)harvesters.FirstOrDefault(h => h.Id == id) ??
				providers.FirstOrDefault(p => p.Id == id);

			if (unit != null)
			{
				return unit.ToString();
			}
			else
			{
				return $"No element found with id - {id}";
			}
		}

		public string ShutDown()
		{
			return $"System Shutdown " + Environment.NewLine +
				$"Total Energy Stored: { totalEnergyStored}" + Environment.NewLine +
				$"Total Mined Plumbus Ore: { totalMinedOre}";
		}
	}
}
