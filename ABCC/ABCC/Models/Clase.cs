//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABCC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clase
    {
        public decimal IdClase { get; set; }
        public string NombreClase { get; set; }
        public decimal IdDepartamento { get; set; }
    
        public virtual Departamento Departamento { get; set; }
    }
}