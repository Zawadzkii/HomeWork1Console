using System;

class Program
{
	static void Main()
	{
		// Declaration of variables related to employee data
		string firstName = "Harry";
		string lastName = "Keayn";
		int age = 25;
		char gender = 'm'; 
		string pesel = "12345678901";
		long employeeNumber = 2509324094;

		// Displaying employee data
		Console.WriteLine("Employee Data:");
		Console.WriteLine("First Name: " + firstName);
		Console.WriteLine("Last Name: " + lastName);
		Console.WriteLine("Age: " + age);
		Console.WriteLine("Gender: " + gender);
		Console.WriteLine("PESEL: " + pesel);
		Console.WriteLine("Employee Number: " + employeeNumber);

		Console.ReadKey();
	}
}