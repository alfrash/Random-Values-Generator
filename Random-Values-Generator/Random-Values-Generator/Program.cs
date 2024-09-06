// See https://aka.ms/new-console-template for more information
Console.WriteLine("Select an option");
Console.WriteLine("[1] Generate random number\n[2] Generate random string");
var selectedOption = Console.ReadLine();
if (selectedOption == "1") {
    GenerateRandomNumber();
}

void GenerateRandomNumber() {
    var rnd = new Random();
    var value = rnd.Next(10_000, 100_000);
    Console.WriteLine("Random number = " + value);
}