//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaMotores.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int Id_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public System.DateTime fecha_nac { get; set; }
        public string estatus { get; set; }
        public decimal salario { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public int id_direccion { get; set; }
        public int id_departamento { get; set; }
        public int id_puesto { get; set; }
        public string rfc { get; set; }
        public string rol { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasenia { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}
