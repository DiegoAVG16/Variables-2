namespace Variables_2.Models
{
    public class EmprendedorModel
    {
        public int Id { get; set; }

        public string Cedula_Ruc { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        //propiedad opcional
        public string? Edad { get; set; }

        public bool Genero { get; set; }

        public DateOnly Fecha_Nacimiento { get; set; }





    }
}
