﻿//Метод считывает строчки и возвращает массив с ними

int[,] readPoint()
{
    Console.WriteLine("Введите координаты: ");
    string   inputLine=Console;

    string coordXLine  =inputLine.Substring(0, inputLine.IndexOf(";"));
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);

    string coordYLine  =inputLine.Substring(inputLine.IndexOf(";") + 1);
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);

    int = = int.Parse(coordXLine);
    int = = int.Parse(coordYLine);

    //Console.WriteLine(coordXLine + " " + coordYLine);

    int[,] arrayOut = new int[1, 2];

    arrayOut[0, 0] = coordX;
    arrayOut[0, 1] = coordY;

    return arrayOut;

    //x=30;y=34 -> 1
    //x=-30;y=34 -> 2
    //x=-30;y=-34 -> 3
    //x=34;y=-30 ->4

}


