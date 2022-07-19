// Console.WriteLine("Введите число");
// string? inputLine = Console.ReadLine();

// if (inputLine != null)

// {
//     int imputNamber = int.Parse(inputLine);

//     string outDayOfWeeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(imputNamber));

//     Console.WriteLine(outDayOfWeeek);
// }


Console.WriteLine("Введите число");
string? day = Console.ReadLine();

if (day != null)
{

{    int imputNamber = int.Parse(day);
    string[] dayOfWeeek = new string[7];
    dayOfWeeek[0] ="Понедельник";
    dayOfWeeek[1] = "Вторник";
    dayOfWeeek[2] = "Среда";
    dayOfWeeek[3] = "Четверг";
    dayOfWeeek[4] = "Пятница";
    dayOfWeeek[5] = "Суббота";
    dayOfWeeek[6] = "Воскресенье";

    Console.WriteLine(dayOfWeeek[imputNamber-1]);
}
}





// Console.WriteLine("Введите число");
// string? day = Console.ReadLine();

// if (day != null)
// {
//     int imputNamber = int.Parse(day);
//     switch (imputNamber)
//     {
//         case 1:
//             Console.WriteLine("Понедельник");
//             break;
//         case 2:
//             Console.WriteLine("Вторник");
//             break;
//         case 3:
//             Console.WriteLine("Вторник");
//             break;

//         case 4:
//             Console.WriteLine("Среда");
//             break;

//         case 5:
//             Console.WriteLine("Пятница");
//             break;

//         case 6:
//             Console.WriteLine("Суббота");
//             break;

//         case 7:
//             Console.WriteLine("Воскресенье");
//             break;
//     }

// }
