#Documentacion basica c#
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

# Generics (Genéricos)
========================

Los genéricos se han agregado a la versión 2.0 del lenguaje C# y Common Language Runtime (CLR). Los genéricos introducen en .NET Framework el concepto de parámetros de tipo, lo que le permite diseñar clases y métodos que aplazan la especificación de uno o varios tipos hasta que el código de cliente declare y cree una instancia de la clase o el método. Por ejemplo, al usar un parámetro de tipo genérico T puede escribir una clase única que otro código de cliente puede usar sin incurrir en el costo o riesgo de conversiones en tiempo de ejecución u operaciones de conversión boxing






















GitHub.com utiliza su propia versión de sintaxis Markdown que provee un
conjunto de características adicionales, muchas de ellas para hacer más fácil
trabajar con el contenido en GitHub.com
```csharp
int x = 10;
```


## Lista  ##

El estándar Markdown convierte el texto que comienza con cuatros espacios en
cada línea en un bloque de código; GFM también soporta bloques de código. Sólo
encierra tu código en ```` ``` ```` (como se muestra enseguida) y no necesitarás
```csharp
var NombreString = new List<string>();
NombreString.Add("AllukaCode");
NombreString.Add("KennyS");
NombreString.Add("Faker");
NombreString.Add("Hisoka");
NombreString.Add("Kakashi");

foreach (var xLocalVariable in NombreString)
{
    Console.Write(xLocalVariable + " ");
}
```
Atributos:
Remove
```csharp
salmons.Remove("coho");
```


Interfaces
Herencia de una clase para implementar sus metodos

[public] {tipo de retorno} {nombre del método}([parámetros]);
```csharp
public int CalcularPromedio(int nota1, int nota2, int nota3);
```





```csharp
namespace _Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            IManejoDeDatos operacion = new  Cliente();
            operacion.ActualisarRegistro(2548);
            operacion.BuscarRegistro(0144);
            Console.ReadLine();
        }
    }
}

namespace _Debug
{
    public class Cliente : IManejoDeDatos
    {
        public void ActualisarRegistro(int idcliente)
        {
            // Logica Para actualizar el registro 
            // enviado por paramaetro
        }

        public void BuscarRegistro(int idcliente)
        {
            // Logica Para Buscar los datos del registro 
            // enviado por paramaetro
        }

        public void EliminarRegistro(int idcliente)
        {
            // Logica Para eliminar el registro 
            // enviado por paramaetro
        }
    }
}

namespace _Debug
{
    public interface IManejoDeDatos
    {
        void ActualisarRegistro(int idcliente);
        void EliminarRegistro(int idcliente);
        void BuscarRegistro(int idcliente);
    }
}

```





 los parámetros aparecen en la definición del procedimiento, 
 los argumentos aparecen en los llamados a procedimientos.




