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
    
    public partial class COMPANIA
    {
        public COMPANIA()
        {
            this.PRODUCTOS = new HashSet<PRODUCTOS>();
        }
    
        public int COM_CONT { get; set; }
        public string COM_NOMBRE { get; set; }
        public Nullable<int> COM_NIT { get; set; }
    
        public virtual ICollection<PRODUCTOS> PRODUCTOS { get; set; }
    }
}