//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuidadClientes
    {
        public int id_cuidad { get; set; }
        public int id_provincia { get; set; }
        public string nombre_cuidad { get; set; }
        public Nullable<int> aux1_cuidad { get; set; }
        public string aux2_cuidad { get; set; }
    
        public virtual ProvinciaClientes ProvinciaClientes { get; set; }
    }
}
