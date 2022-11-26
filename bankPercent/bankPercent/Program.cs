
string userInput = Console.ReadLine();
Console.WriteLine(Calculate(userInput));
static double Calculate(string userInput)
{
    string[] v = userInput.Split(' ');
    double amount = double.Parse(v[0], System.Globalization.CultureInfo.InvariantCulture);
    double percent = double.Parse(v[1], System.Globalization.CultureInfo.InvariantCulture);
    double months = double.Parse(v[2], System.Globalization.CultureInfo.InvariantCulture);
    return amount*(Math.Pow(1 + percent / 100 / 12, months));
}