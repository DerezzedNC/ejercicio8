using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingresa 10 números:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }

        Console.Write("\nIngresa el número que deseas eliminar: ");
        int numeroEliminar = int.Parse(Console.ReadLine());

     
        if (numeros.Contains(numeroEliminar))
        {
            numeros.Remove(numeroEliminar);
            Console.WriteLine($"\nEl número {numeroEliminar} fue eliminado.");
        }
        else
        {
            Console.WriteLine($"\nEl número {numeroEliminar} no se encontró en la lista.");
        }

        Console.WriteLine("\nLista actualizada:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine(); 
    }
}
