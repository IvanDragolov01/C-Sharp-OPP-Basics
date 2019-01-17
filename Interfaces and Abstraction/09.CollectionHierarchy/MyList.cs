using System;
using System.Collections.Generic;

namespace _09.CollectionHierarchy
{
	public class MyList : IMylist
	{
		private List<string> _data;
		private List<int> _indexes;
		private List<string> _removedElements;

		public MyList()
		{
			_data = new List<string>();
			_indexes = new List<int>();
			_removedElements = new List<string>();
		}

		public int NumberOfElements
		{
			get => _data.Count;
		}

		public void Add(string element)
		{
			_indexes.Add(0);
			_data.Insert(0, element);
		}

		public void Remove()
		{
			string firstElement = _data[0];
			_removedElements.Add(firstElement);
			_data.RemoveAt(0);
		}

		public void GetRemovedElements()
		{
			Console.WriteLine($"{string.Join(" ", _removedElements)}");
		}

		public override string ToString()
		{
			return $"{string.Join(" ", _indexes)}";
		}
	}
}
