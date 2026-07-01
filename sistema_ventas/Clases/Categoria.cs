namespace sistema_ventas.Clases
{
    public class Categoria
    {
        /*
        private int idCategoria;
        private string? descripcion;

        public int IdCategoria { get { return IdCategoria; } private set { IdCategoria = value; } }
        public string Descripcion { get { return (string.IsNullOrEmpty(descripcion))? string.Empty : descripcion; } private set { descripcion = value; } }
        */

        public int IdCategoria { get; private set; }
        public string Descripcion {  get; set; } = string.Empty;

        public Categoria()
        {

        }
        
        public Categoria(string name)
        {
            // descripcion = name;
            Descripcion = name;
        }

        /*
        public void SetID(int id)
        {
            idCategoria = id;
        }

        public int GetID()
        {
            return idCategoria;
        }

        public void SetDescripcion(string name)
        {
            descripcion = name;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }
        */
    }
}
