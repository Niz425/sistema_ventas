namespace sistema_ventas.Clases
{
    public class Cliente : Entidad
    {
        /*
        private int membresia;

        public int Membresia { get { return membresia; } set { membresia = value; } }
        */

        public int IdMembresia {  get; set; }
        public Membresia Membresia { get; set; } = null!;

        public Cliente()
        {

        }

        public Cliente(int id, string name, string dir, string tel, Membresia mem) : base(id, name, dir, tel)
        {
            // membresia = mem;
            IdMembresia = mem.IdMembresia;
            Membresia = mem;
        }

        /*
        public void SetMembresia(int mem)
        {
            membresia = mem;
        }

        public int GetMembresia()
        {
            return membresia;
        }
        */

        public override string GetDatos()
        {
            // string datos = base.GetDatos() + "\nMembresia: " + this.GetMembresia().ToString();
            string datos = base.GetDatos() + "\nMembresia: " + IdMembresia.ToString();
            return datos;
        }
    }
}
