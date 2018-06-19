using System;

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
