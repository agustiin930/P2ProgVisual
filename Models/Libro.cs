//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NET.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Edicion { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string CantidadPaginas { get; set; }
        public string Editorial { get; set; }
        public string CiudadPais { get; set; }
        public string FechaEdicion { get; set; }
    }
}
