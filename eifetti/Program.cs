using System;
using System.Diagnostics.Metrics;
using System.Threading;
using System.Xml.Linq;

Console.WriteLine(aufgabe());
static string aufgabe()
{
    Console.Write($"Gebe deinen Namen ein: ");
    string name=Console.ReadLine();
    Console.Write($"Be nenne das Fach: ");
    string fach = Console.ReadLine();
    Console.Write($"Gebe die Note ein: ");
    string note = Console.ReadLine();
    Console.Write($"Gib das Alter an: ");
    string alter = Console.ReadLine();

    string text1 = "Hallo A21!!!! Guten Tag Herr ";
    string text2 = " Sie studieren ";
    string text3 = " haben die Note ";
    string text4 = " und sind ";
    string text5 = " Jahre alt ";
    return text1+name+text2+fach+text3+note+text4+alter+text5;
}

