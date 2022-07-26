//Печатает номер четверти
void printQuater(int[,] arreyPoint)
{

    if (arreyPoint[0, 0] >  0 && arreyPoint[0, 1] > 0)
        Console.WriteLine("1 четверть");

    if (arreyPoint[0, 0] < 0 && arreyPoint[0, 1] > 0)
        Console.WriteLine("2 четверть");

    if (arreyPoint[0, 0] < 0 && arreyPoint[0, 1] < 0)
        Console.WriteLine("3 четверть");

    if (arreyPoint[0, 0] > 0 && arreyPoint[0, 1] < 0)
        Console.WriteLine("4 четверть");
}
int[,] arreyPoint = readPoint();
printQuater(arreyPoint);