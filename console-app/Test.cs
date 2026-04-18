

// string name = "Sumaila";
// int age = 30;
// float height = 1.75f;
// decimal salary = 50000.00m;

// Console.WriteLine($"Hello, {name}! You are {age} years old.");
// Console.WriteLine($"Your height is {height} meters and your salary is {salary:C}.");

// using System.Text;

// string petFish = "Goldfish";

// //contcatenation
// petFish  = "porcupine " + petFish;

// // template literal
// //petFish = $"porcupine {petFish}";
// //update
// petFish = petFish.Replace("porcupine", "turtle");
// Console.WriteLine(petFish);

// // Delete
// //stringbuilder 
// StringBuilder sb = new StringBuilder(petFish);
// sb.Remove(0, 7);
// petFish = sb.ToString();
// Console.WriteLine(petFish);

// string[] name = new string[3];
// string[] rats = {"Ratatouille", "Remy", "Emile"};

// // LINQ
// var filteredRats = rats.Where(r => r.StartsWith("R"));
// foreach (string rat in filteredRats){
//     Console.WriteLine(rat);
// }

// foreach (string rat in rats)
// {
//     Console.WriteLine(rat);
// }

// update
//rats[1] = "Remy the Chef";
//Console.WriteLine(rats[1]);

// new switch expression
// var preHistroricFish = "Coelacanth";

// var result = preHistroricFish switch 
// {
//     "Coelacanth" => "A rare and ancient fish species.",
//     "Dunkleosteus" => "A prehistoric armored fish.",
//     _ => "Unknown prehistoric fish."
// };

// Console.WriteLine(result);

//Pinger

// using System.Net.NetworkInformation;

// Ping pingSender = new Ping();
// PingReply reply = pingSender.Send("8.8.8.8");

// while (reply.Status.ToString() == "Success")
// {
//     Console.WriteLine(reply.Status.ToString() + "!");
//     Thread.Sleep(10000);
//     reply = pingSender.Send("8.8.8.8");
// }

using System.Runtime.CompilerServices;
using console_app;

// Rat wolfRat = new Rat();
// Rat fancyRat = new Rat();

// wolfRat.Name = "Wolf Rat";
// wolfRat.Number = 1;
// wolfRat.IsRadioactive = true;

// fancyRat.Name = "Fancy Rat";
// fancyRat.Number = 2;
// fancyRat.IsRadioactive = false;

// Console.WriteLine($"Name: {wolfRat.Name}, Number: {wolfRat.Number}, Is Radioactive: {wolfRat.IsRadioactive}");
// Console.WriteLine($"Name: {fancyRat.Name}, Number: {fancyRat.Number}, Is Radioactive: {fancyRat.IsRadioactive}");

// RealState house = new()
// {
//     Address = "123 Main St",
//     Price = 250000,
//     SquareFootage = 2000
// };

// int pricePerSquareFoot = house.CalculatePricePerSquareFoot();   
// Console.WriteLine($"The price per square foot for the house at {house.Address} is ${pricePerSquareFoot}.");

// (int a, string b, bool c) tupleExample()
// {
//     return (42, "Hello", true);
// };
// // Console.WriteLine($"Tuple values: {tupleExample.a}, {tupleExample.b}, {tupleExample.c}");

// (int a, string b, bool c) = tupleExample();
// Console.WriteLine($"Tuple values: {a}, {b}, {c}");

// string? value = null;

// if (value is not null)
// {
//     Console.WriteLine(value);
// }

// Console.WriteLine(value ?? "Value is null");
// Console.WriteLine(value is not null ? value : "Value is null");

// Student student1 = new Student("Alice");
// Console.WriteLine($"Student Name: {student1.Name}");
// student1.Name = "Bob";
// Console.WriteLine($"Updated Student Name: {student1.Name}");

//TimeUtility.PrintCurrentTime();

// List CRUD operations
// List<string> names = new List<string>();
// // Create
// names.Add("Alice");
// names.Add("Bob");
// names.Add("Charlie");

// // Read
// Console.WriteLine("Names in the list:");

// // Update
// names[1] = "Bobby";
// Console.WriteLine("\nUpdated Names in the list:");

// // Delete
// names.Remove("Charlie");
// Console.WriteLine("\nNames in the list after deletion:");
// foreach (string name in names){
//     Console.WriteLine(name);
// }

// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// numbers.Add(6);
// numbers.Insert(0, 0);

// Delete
// numbers.Remove(3);
// numbers.RemoveAt(0);
// //var newNumbers = numbers.Where(n => n != 3);

// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }

// Record type example
// Person person1 = new Person("Alice", 30, new string[1] { "123-456-7890" });
// Person person2 = new Person("Alice", 30, new string[1] { "123-456-7890" });

// // Imutable properties
// // person1.Name = "Bob";
// // person1.phoneNumbers[0] = "987-654-3210";

// // Equality check
// Console.WriteLine($"Are person1 and person2 equal? {person1 == person2}");

// // copy object with non-destructive mutation
// Person person3 = person1 with { Name = "Bob" };
// Console.WriteLine(person3.Name);
// Console.WriteLine(person3.Age);
//Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}, Phone Numbers: {string.Join(", ", person1.phoneNumbers)}");


// Action loggerAction = () =>
// {
//     Console.WriteLine("This is a log message.");
// };

// Func<int, int> loggerfunc =  (int x) =>
// {
//     return x + 2;
// }; 

// SuperCustom superCustomFunc = (int x) =>
// {
//     return x * 2;
// };

// var  list = Enumerable.Range(1, 10).Select(i => i * 3).ToList();


// var callcall = (Action func) =>
// {
//     func();
// };

// callcall(loggerAction);

// public delegate int SuperCustom(int x);

// Solution soln = new();

// int[] nums = [2,7,11,15];
// int target = 9;
// var tests1 = soln.Twosum1(nums, target);
// var tests2 = soln.Twosum2(nums, target);
// foreach(var tt in tests2)
// {
//     Console.WriteLine(tt);
// }

int[] nums  = [1,2,3,1];
Soultion2 soln2 = new();
Console.WriteLine(soln2.ContainsDuplicate2(nums));