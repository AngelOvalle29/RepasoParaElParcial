namespace RepasoParaElParcial
{
    public class Alimentos : Productos
    {
        public DateTime FechaCad { get; set; }

        public string UnidadVenta { get; set; }

        public Alimentos()
        {
            UnidadVenta = string.Empty;
        }
            

            

    }
}
