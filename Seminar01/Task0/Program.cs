string? inputLine = Console.ReadLine();

if (inputLine != null)
{
int inputNumber = int.Parse(inputLine);

//int outNamber = inputNumber*inputNumber;
int outNamber = (int)Math.Pow(inputNumber, 2);

Console.WriteLine(outNamber);

}