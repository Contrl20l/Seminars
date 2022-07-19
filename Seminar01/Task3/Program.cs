// Console.WriteLine("Введите число");
// string? inputLineOne = Console.ReadLine();

// if (inputLineOne != null)
// {
//     int inputNamber = int.Parse(inputLineOne);

//     int startNamber = (inputNamber * -1);

//     string lineOutput = "";
//     while (startNamber < inputNamber)
//     {
//         lineOutput = lineOutput + startNamber + ",";
//         startNamber++;
//     }
//     lineOutput = lineOutput + inputNamber;

//     Console.WriteLine(lineOutput);
// }


Console.WriteLine("Введите число");
string? inputLineOne = Console.ReadLine();

if (inputLineOne != null)
{
    int inputNamber = int.Parse(inputLineOne);

    int startNamber = 1;

    string lineOutput = "0";
    while (startNamber <= inputNamber)
    {
        lineOutput = startNamber * (-1) + "," + lineOutput + "," + startNamber;
        startNamber++;
    }

    Console.WriteLine(lineOutput);
}