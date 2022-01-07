// See https://aka.ms/new-console-template for more information

int value = 0;

Console.Write("Enter a number: ");

try
{
    value = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("Input: {0}", value);

// Get all factors
List<int> lstFactors = new List<int>();
for (int i = 1; i <= value/2; i++)
{
    if (value % i == 0)
        lstFactors.Add(i);
}
lstFactors.Add(value);

Console.Write("Factors:");
foreach (int factor in lstFactors)
    Console.Write(" " + factor);

// Get prime factors
List<int> lstPrimeFactors = new List<int>();



