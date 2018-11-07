using System;

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

	public string PrintNameAndAge()
	{
		return $"{this.name} {this.age}";
	}
}


