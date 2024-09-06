using System.Text;

while (true)
{
    Console.WriteLine("Select an option");
    Console.WriteLine("[1] Generate random number\n[2] Generate random string");
    var selectedOption = Console.ReadLine();
    if (selectedOption == "1")
    {
        GenerateRandomNumber();
    }
    else if (selectedOption == "2")
    {
        GenerateRandomString();
    }
    Console.WriteLine("===============================");
}


void GenerateRandomNumber()
{
    var rnd = new Random();
    var value = rnd.Next(10_000, 100_000);
    Console.WriteLine("Random number = " + value);
}

void GenerateRandomString()
{
    const string buffer = "AaBbCcDdEeFfGgHhIiJjKkLlMmOoPpQqRrSsTtUuWwSsYyNnVvXxZz!@#$%^&*()_-.1234567890";
    var sp = new StringBuilder();
    var rnd = new Random();
    while (sp.Length < 16)
    {
        var randomIndex = rnd.Next(0, buffer.Length - 1);
        sp.Append(buffer[randomIndex]);
    }
    Console.WriteLine("Random string = " + sp);
}