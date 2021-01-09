using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej6
{
    public class Libro
    {

        private string isbn;
        private string titulo;
        private string autor;
        private int npaginas;

        public Libro(string isbn, string titulo, string autor, int npaginas)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.npaginas = npaginas;
        }

        public Libro()
        {
            isbn = "";
            titulo = "";
            autor = "";
            npaginas = 0;
        }

        public string Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Npaginas { get => npaginas; set => npaginas = value; }

        public override string ToString()
        {
            return "El libro " + titulo.ToString() + " con ISBN " + isbn.ToString() + " creado por el autor " + autor.ToString() + " tiene " + npaginas.ToString() + " paginas";
        }
    }
}
