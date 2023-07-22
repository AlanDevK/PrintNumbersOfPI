Console.Write("How many numbers of PI you want to print? ");
int n = int.Parse(Console.ReadLine());
string process = Convert.ToString((Math.Round(Math.PI, n) * Math.Pow(10,n))/10);
string result = process.Substring(0, process.Length - 2);
Console.WriteLine($"Value of PI: {result}");