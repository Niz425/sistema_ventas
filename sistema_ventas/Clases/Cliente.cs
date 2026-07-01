namespace sistema_ventas.Clases
{
    public class Cliente : Entidad
    {
        /*
        private int membresia;

        public int Membresia { get { return membresia; } set { membresia = value; } }
        */

        public int Membresia {  get; set; }

        public Cliente()
        {

        }

        public Cliente(int id, string name, string dir, string tel, int mem) : base(id, name, dir, tel)
        {
            // membresia = mem;
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
            string datos = base.GetDatos() + "\nMembresia: " + Membresia.ToString();
            return datos;
        }
    }
}
