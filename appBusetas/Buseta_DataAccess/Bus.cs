//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buseta_DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bus
    {
        public Bus()
        {
            this.Route = new HashSet<Route>();
        }
    
        public int id { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public Nullable<int> capacity { get; set; }
    
        public virtual ICollection<Route> Route { get; set; }
    }
}