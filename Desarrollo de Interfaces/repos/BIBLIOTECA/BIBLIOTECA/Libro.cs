using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;
        private Boolean nuevo;
        private string foto;

        public Libro() { }

        Libro(String t, String a, String e, Boolean n, String f)
        {
            titulo = t;
            autor = a;
            editorial = e;
            nuevo = n;
            foto = f;
        }

        public String getTitulo()
        {
            return titulo;
        }

        public void setTitulo(String t)
        {
            titulo = t;
        }


    }
}
