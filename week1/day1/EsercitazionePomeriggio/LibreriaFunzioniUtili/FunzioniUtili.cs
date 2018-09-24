using System;

public static class FunzioniUtili
{
    public static double areacerchio(double raggio)
    {
        return Math.PI * raggio * raggio;

    }

    public static double areatriangolo(int basetriangolo, double altezzatriangolo)
    {
        var area = (basetriangolo * altezzatriangolo) / 2;
        Console.WriteLine(area);
        return area;
        //var generatore = new Random();
        //return generatore.NextDouble();
    }

    public static void stampaareatriangolo(int basetriangolo, double altezzatriangolo)
    {
        var area = (basetriangolo * altezzatriangolo) / 2;
        Console.WriteLine(area);
    }

    public static bool iseven(int numero)
    {
        
        return  numero % 2 == 0; //Funzione Corto

        //var resto = numero % 2;
        //if (resto == 0)
        //{
        //    return true;
        //}
        //else
        //{ return false; }

    }

    public static bool isodd (int numero)

    {
        return !iseven( numero);
    }
}