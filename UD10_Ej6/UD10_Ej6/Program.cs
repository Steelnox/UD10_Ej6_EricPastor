using System;

namespace UD10_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("45879123G", "El principe maldito", "Johnson Stuart", 500);
            Libro libro2 = new Libro("87962233W", "El periplo del rey maldito", "Michael Steward", 850);

            Console.WriteLine(libro1.ToString());
            Console.WriteLine(libro2.ToString());

            if (libro1.Npaginas > libro2.Npaginas)
            {
                Console.WriteLine("El libro {0} tiene más paginas que el libro {1}", libro1.Titulo, libro2.Titulo);
            }
            else Console.WriteLine("El libro {0} tiene más paginas que el libro {1}", libro2.Titulo, libro1.Titulo);
        }
    }
}
