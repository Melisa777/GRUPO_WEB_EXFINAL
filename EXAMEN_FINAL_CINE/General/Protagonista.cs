//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace General
{
    using System;
    using System.Collections.Generic;
    
    public partial class Protagonista
    {
        public int CodInterprete { get; set; }
        public int CodPelicula { get; set; }
        public string NombreProtagonista { get; set; }
        public Nullable<bool> EsPrincipal { get; set; }
    
        public virtual Interprete Interprete { get; set; }
        public virtual Pelicula Pelicula { get; set; }
    }
}
