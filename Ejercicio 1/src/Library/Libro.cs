using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }


        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
/* si bien un libro conoce el titulo , autor u codigo, este no tiene la responsabilidad
 de conocer donde se almacena, para ello debemos crear una nueva clase con el codigo de abajo, indicando que 
 la misma se dedique exclusivamente a almacenar dichos libros*/
       

    }
    public class Almacena 
    {
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
       
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
    } 
}