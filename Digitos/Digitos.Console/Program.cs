namespace Digitos.Console
{
    using System;
    using Domain;

    class Program
    {
        static void Main(string[] args)
        {
            var generador = new Generador();
            var buscador = new Buscador(generador);

            var numero = "";
            while (numero != "X")
            {
                Console.WriteLine("Ingrese el número a buscar (X para salir): ");
                numero = Console.ReadLine();

                if (numero == "X")
                    return;

                var result = buscador.Buscar(int.Parse(numero));

                Console.WriteLine($"El número está en la posición {result}");
            }
        }
    }
}
