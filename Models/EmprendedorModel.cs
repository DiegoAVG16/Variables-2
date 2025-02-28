
using System.ComponentModel.DataAnnotations;

namespace Variables_2.Models
{
    public class EmprendedorModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo es requerido")]
        //[MaxLength(10,ErrorMessage ="La cantidad máxima son 10 caracteres")]
        [Display(Name ="Cédula o RUC")]
        [Length(10,13,ErrorMessage ="El valor del campo es entre 10 y 13 caracteres")]

        public string Cedula_Ruc { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido")]
        //[MaxLength(10,ErrorMessage ="La cantidad máxima son 10 caracteres")]
        [Display(Name = "Nombre")]
        [Length(10,20,ErrorMessage = "El valor del campo es entre 10 y 20 caracteres")]
        
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es requerido")]
        //[MaxLength(10,ErrorMessage ="La cantidad máxima son 10 caracteres")]
        [Display(Name = "Apellido")]
        [Length(10,20,ErrorMessage = "El valor del campo es entre 10 y 20 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Dirección es requerida")]
        //[MaxLength(10,ErrorMessage ="La cantidad máxima son 10 caracteres")]
        [Display(Name = "Dirección")]
        [Length(10,20,ErrorMessage = "El valor del campo es entre 10 y 20 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El Número de teléfono es requerido")]
        [MaxLength(10,ErrorMessage ="La cantidad máxima son 10 caracteres")]
        [Display(Name = "Teléfono")]
        //[Length(10, 13, ErrorMessage = "El valor del campo es entre 10 y 20 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La edad es requerida")]
        //[MaxLength(10,ErrorMessage ="La cantidad máxima son 10 caracteres")]
        [Display(Name = "Edad")]
        [Length(1,3,ErrorMessage = "El valor del campo es entre 1 y 3 caracteres")]
        public string? Edad { get; set; }

        public bool Genero { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(10,ErrorMessage ="La cantidad máxima son 10 caracteres")]
        [Display(Name = "Fecha de Nacimiento")]
        //[Length(10, 13, ErrorMessage = "El valor del campo es entre 10 y 20 caracteres")]

        public DateOnly Fecha_Nacimiento { get; set; }






    }
}
