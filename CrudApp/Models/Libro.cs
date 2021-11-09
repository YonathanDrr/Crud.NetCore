using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Models
{
    public class Libro 
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage ="Campo obligatorio", MinimumLength = 3)]
        [Display (Name = "Titulo")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "Campo obligatorio", MinimumLength = 3)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }


        [Required(ErrorMessage = "Campo Obligatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "Campo obligatorio", MinimumLength = 3)]
        [Display(Name ="Autor")]
        public string Autor { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Precio")]
        public int Precio { get; set; }
    }
}
