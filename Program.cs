using System.Text.Json;
using items;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Contact>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var myClass = new Contact();

	Console.WriteLine("Enter the value for First Name");
	myClass.FirstName = Console.ReadLine();

    Console.WriteLine("Enter the value for Last Name");
	myClass.LastName = Console.ReadLine();

    Console.WriteLine("Enter the value for Age");
	myClass.Age = int.Parse(Console.ReadLine());

	recordList.Add(myClass);
}


foreach (Contact record in recordList) {
    Console.WriteLine(record.ToString());
}