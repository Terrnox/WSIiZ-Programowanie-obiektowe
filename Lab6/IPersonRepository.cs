using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Lab6;
public interface IPersonRepository
{
	void AddPerson(Person person);
	List<Person> GetAllPeople();
}

public record Person(string FirstName, string LastName, int Age);

public class FilePersonRepository : IPersonRepository
{
	private readonly string filePath;

	public FilePersonRepository(string filePath)
	{
		this.filePath = filePath;

		if (!File.Exists(filePath))
		{
			using (StreamWriter sw = File.CreateText(filePath))
			{
				sw.WriteLine();
			}
		}
	}

	public void AddPerson(Person person)
	{
		List<Person> people = GetAllPeople();

		people.Add(person);

		File.WriteAllText(filePath, string.Empty);
		using (StreamWriter sw = File.AppendText(filePath))
		{
			foreach (var p in people)
			{
				string personJson = JsonConvert.SerializeObject(p);
				sw.WriteLine(personJson);
			}
		}
	}

	public List<Person> GetAllPeople()
	{
		List<Person> people = new List<Person>();

		string[] lines = File.ReadAllLines(filePath);
		foreach (string line in lines)
		{
			if (!string.IsNullOrWhiteSpace(line))
			{
				Person person = JsonConvert.DeserializeObject<Person>(line);
				people.Add(person);
			}
		}

		return people;
	}
}
