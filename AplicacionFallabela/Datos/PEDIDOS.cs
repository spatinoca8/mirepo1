//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEDIDOS
    {
        public int PED_CONT { get; set; }
        public Nullable<int> VEND_CONT { get; set; }
        public Nullable<int> CLIE_CONT { get; set; }
        public Nullable<int> PRO_CONT { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual PRODUCTOS PRODUCTOS { get; set; }
        public virtual VENDEDOR VENDEDOR { get; set; }
    }
}
