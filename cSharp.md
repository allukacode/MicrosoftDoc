#Documentación C# en Español
========================

#Indice
========================
1. First list item
     - First nested list item
       - Second nested list item
2. Ciclos
    - 2.1 For
3. qwdqwdqwd
4. qasdasd

# 
========================

```csharp
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
```









-----------------------------wefwefwefwef-------------






# Genéricos (Generics) 
========================

Los genéricos se han agregado a la versión 2.0 del lenguaje C# y Common Language Runtime (CLR). Los genéricos introducen en .NET Framework el concepto de parámetros de tipo, lo que le permite diseñar clases y métodos que aplazan la especificación de uno o varios tipos hasta que el código de cliente declare y cree una instancia de la clase o el método. Por ejemplo, al usar un parámetro de tipo genérico T puede escribir una clase única que otro código de cliente puede usar sin incurrir en el costo o riesgo de conversiones en tiempo de ejecución u operaciones de conversión boxing

Clase Generica 
Cuando definimos una nueva clase, debemos conocer el tipo de dato con el que trabajaremos. Si queremos realizar una operación específica dentro de esta nueva clase, sea cual sea el tipo de datos que va a recibir, podemos hacer uso de los tipos genéricos. Este tipo genérico asumirá el tipo de dato que realmente le pasaremos a la clase.
```csharp
using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var intGenerico = new MiClaseGenerica<int>(10);
            var val = intGenerico.MiMetodoGenerico(200);

            var stringGenerico = new MiClaseGenerica<string>("HOLA");
            stringGenerico.MiMetodoGenerico("Como Estas");
        }
        class MiClaseGenerica<T>
        {
            private T valorGenerico;
            public MiClaseGenerica(T valor)
            {
                valorGenerico = valor;
            }

            public T MiMetodoGenerico(T parametroGenerico)
            {
                Console.WriteLine(valorGenerico);
                Console.WriteLine(parametroGenerico);

                return valorGenerico;
            }
        }
    }
}

```
















