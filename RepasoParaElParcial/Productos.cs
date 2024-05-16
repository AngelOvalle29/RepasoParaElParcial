using System.ComponentModel.DataAnnotations;

namespace RepasoParaElParcial
{
    public class Productos
    {
        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Codigo es Requerido")]
        public int Code { get; set; }
        [Required(ErrorMessage = "La Descripción es Requerida")]
        public string Descrip { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido")]
        public decimal PrecioCompra { get; set; }

        [Required(ErrorMessage = "El Codigo es Requerido")]
        public decimal PrecioVenta { get; set; }
        

        public Productos()
        {
            Nombre = string.Empty;
            Descrip = string.Empty;
           
        }

    }
}
