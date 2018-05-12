



Documentacion basica c#
========================

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










