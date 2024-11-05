using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
string X = "-"; string Y = "|"; string _ = " "; string _2 = "=";
Console.WriteLine("Избери брой на хоризонталните символи");
int IzborX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Избери брой на вертикалните символи");
int IzborY = Convert.ToInt32(Console.ReadLine());
int sredaY = (int)Math.Ceiling(IzborY / 2.0);
for (int ix = 1; ix <= (IzborX); ix++) 
{
    if (ix == 1)
    {
        Console.Write("+");
    }
    Console.Write(X);
    if (ix == (IzborX))
    {
        Console.Write("+");
    }
}
Console.WriteLine();
for (int iy = 1; iy <= IzborY; iy++)
{
    Console.Write(Y);
    for (int jy = 1; jy <= IzborX; jy++)
    {
        if (iy == sredaY)
        {
            Console.Write(_2);
        }
        else
        {
            Console.Write(_);
        }
    }

    if (iy == sredaY)
    {
        Console.Write("O");
        Console.WriteLine();
        continue;
    }
    Console.Write(Y);
    Console.WriteLine();
}
for (int ix = 1; ix <= (IzborX); ix++)
{
    if (ix == 1)
    {
        Console.Write("+");
    }
    Console.Write(X);
    if (ix == (IzborX))
    {
        Console.Write("+");
    }
}

