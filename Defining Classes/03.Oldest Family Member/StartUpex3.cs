using System;
using System.Collections.Generic;

public class NameAndAge
{
	int age;
	string name;

	private NameAndAge(string name, int age)
	{
		Name = name;
		Age = age;
	}

	public string Name { get => name; set => name = value; }

	public int Age { get => age; set => age = value; }

	string fullNameAndAge;

	public NameAndAge()
	{
		fullNameAndAge = age + name;
	}

	public void AddNewMemberinFamily(string[] name, int[] age)
	{
		string[] names = name;
		int[] ages = age;
	}

	public string GetOldestMemberOfFamily(string name, int age)
	{

		return $"{this.name} {this.age}";
	}
}


