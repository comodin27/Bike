//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BodyRents
    {
        public int id { get; set; }
        public int rents_id { get; set; }
        public double price { get; set; }
        public int typerents_id { get; set; }
        public System.DateTime date { get; set; }
    }
}