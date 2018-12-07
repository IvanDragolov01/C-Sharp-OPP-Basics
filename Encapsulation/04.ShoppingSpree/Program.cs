using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ShoppingSpree
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				List<Person> people = ParsePeople();

				List<Product> products = ParseProduct();

				BuyProducts(people, products);

				foreach (Person person in people)
				{
					Console.WriteLine(person);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		private static void BuyProducts(List<Person> people, List<Product> products)
		{
			string command;

			while ((command = Console.ReadLine()) != "END")
			{
				string[] tokens = command.Split();
				string personName = tokens[0];
				string productName = tokens[1];

				Person person = people.First(p => p.Name == personName);
				Product product = products.First(p => p.Name == productName);

				string output = person.TryBuyProduct(product);
				Console.WriteLine(output);
			}
		}

		private static List<Product> ParseProduct()
		{
			{
				string[] productsInput = Console.ReadLine().
					Split(';', StringSplitOptions.RemoveEmptyEntries);
				List<Product> products = new List<Product>();

				foreach (string productInput in productsInput)
				{
					string prodinput = productInput;
					string[] prodinput2 = prodinput.Split("=");
					string[] tokens = prodinput2;
					string productName = tokens[0];
					decimal productPrice = decimal.Parse(tokens[1]);

					Product product = new Product(productName, productPrice);
					products.Add(product);
				}

				return products;
			}
		}

		private static List<Person> ParsePeople()
		{
			string peopleInp = Console.ReadLine();
			string[] peopleInput = peopleInp.Split(';');
			List<Person> people = new List<Person>();

			foreach (string personInput in peopleInput)
			{
				string personinput = personInput;
				string[] tokens = personinput.Split("=");
				string personName = tokens[0];
				decimal personMoney = decimal.Parse(tokens[1]);

				Person person = new Person(personName, personMoney);
				people.Add(person);
			}

			return people;
		}
	}
}
