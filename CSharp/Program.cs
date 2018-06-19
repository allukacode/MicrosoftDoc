using System;
class Program
{
    static void Main()
    {
        // los argumentos se encuentran ubicados en la definición de un procedimientos.
        int Argumento1 = 5, Argumento2 = 5;
        Console.WriteLine(OperacionSumar(Argumento1,Argumento2));

        // los parámetros se encuentran ubicados en la definición del procedimiento, 
        int OperacionSumar(int Parametro1, int Parametro2)
        {
            int a = Parametro1;
            int b = Parametro2;
            return a + b;
        }
    }
}
