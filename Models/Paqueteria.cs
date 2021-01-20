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
    using System.ComponentModel.DataAnnotations;
    public partial class Paqueteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paqueteria()
        {
            this.Oden_cliente = new HashSet<Oden_cliente>();
        }
    
        public int id_paqueteria { get; set; }
        [Display(Name = "Nombre de la paqueteria")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string nombre_paqueteria { get; set; }
        [Display(Name = "Telfono")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int telefono { get; set; }
        [Display(Name = "Sitio web")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string sitio_web { get; set; }
        [Display(Name = "RFC")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int rfc { get; set; }
        [Display(Name = "Nombre del Contacto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string contacto { get; set; }
        [Display(Name = "Telefono del contacto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int telefono_contacto { get; set; }
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int id_direccion { get; set; }
    
        public virtual Direccion Direccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oden_cliente> Oden_cliente { get; set; }
    }
}
