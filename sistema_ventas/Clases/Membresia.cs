namespace sistema_ventas.Clases
{
    public class Membresia
    {
        public int IdMembresia { get; private set; }
        public string Descripcion { get; set; } = string.Empty;

        public Membresia()
        {

        }

        public Membresia(int id, string name)
        {
            IdMembresia = id;
            Descripcion = name;
        }
    }
}
