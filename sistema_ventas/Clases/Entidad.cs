namespace sistema_ventas.Clases
{
    public abstract class Entidad
    {
        /*
        private int idEntidad;
        private string? nombre;
        private string? direccion;
        private string? telefono;

        public int ID { get { return idEntidad; } private set { idEntidad = value; } }
        public string Nombre { get { return (string.IsNullOrEmpty(nombre))? string.Empty : nombre; } set { nombre = value; } }
        public string Direccion { get { return (string.IsNullOrEmpty(direccion))? string.Empty : direccion; } set { direccion = value; } }
        public string Telefono { get { return (string.IsNullOrEmpty(telefono))? string.Empty : telefono; } set { telefono = value; } }
        */

        public int ID { get; private set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Direccion {  get; set; }
        public string? Telefono { get; set; }

        public Entidad()
        {

        }

        public Entidad(int id, string name, string dir, string tel)
        {
            /*
            idEntidad = id;
            nombre = name;
            direccion = dir;
            telefono = tel;
            */
            ID = id;
            Nombre = name;
            Direccion = dir;
            Telefono = tel;
        }

        /*
        public void SetID(int id)
        {
            idEntidad = id;
        }

        public int GetID()
        {
            return idEntidad;
        }

        public void SetNombre(string name)
        {
            nombre = name;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetDireccion(string dir)
        {
            direccion = dir;
        }

        public string GetDireccion()
        {
            return direccion;
        }

        public void SetTelefono(string tel)
        {
            telefono = tel;
        }

        public string GetTelefono()
        {
            return telefono;
        }
        */

        public virtual string GetDatos()
        {
            // string datos = "ID: " + this.GetID().ToString() + "\nNombre: " + this.GetNombre() + "\nDireccion: " + this.GetDireccion() + "\nTelefono: " + this.GetTelefono();
            string datos = "ID: " + ID.ToString() + "\nNombre: " + Nombre + "\nDireccion: " + Direccion + "\nTelefono: " + Telefono;
            return datos;
        }

    }
}
