namespace sistema_ventas.Clases
{
    public class Producto
    {
        /*
        private int idProducto;
        private string? descripcion;
        private decimal precio;
        private Categoria? categoria;
        private Proveedor? proveedor;
        private int stock;

        public int IdProducto { get { return idProducto; } private set { idProducto = value; } }
        public string Descripcion { get { return (string.IsNullOrEmpty(descripcion))? string.Empty : descripcion; } set { descripcion = value; } }

        public decimal Precio { get { return precio; } set { precio = value; } }

        public int IdCategoria { get; private set; }

        public Categoria? Categoria { get { return categoria; } set { categoria = value; } }

        public int IdProveedor { get; private set; }

        public Proveedor? Proveedor { get { return proveedor; } set { proveedor = value; } }

        public int Stock { get { return stock; } set { stock = value; } }
        */

        public int IdProducto { get; private set; }
        public string Descripcion { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int IdCategoria { get; private set; }

        public Categoria Categoria { get; set; } = null!;

        public int IdProveedor { get; private set; }

        public Proveedor Proveedor { get; set; } = null!;

        public int Stock { get; set; }


        public Producto() 
        { 

        }

        public Producto(int id, string name, decimal valor, Categoria cat, Proveedor prov, int cant)
        {
            /*
            idProducto = id;
            descripcion = name;
            precio = valor;
            categoria = cat;
            proveedor = prov;
            stock = cant;
            */

            IdProducto = id;
            Descripcion = name;
            Precio = valor;
            IdCategoria = cat.IdCategoria;
            Categoria = cat;
            IdProveedor = prov.ID;
            Proveedor = prov;
            Stock = cant;
        }

        /*
        public void SetID(int id)
        {
            idProducto = id;
        }

        public int GetID()
        {
            return idProducto;
        }

        public void SetDescripcion(string name)
        {
            descripcion = name;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public void SetPrecio(decimal valor)
        {
            precio = valor;
        }

        public decimal GetPrecio()
        {
            return precio;
        }

        public void SetCategoria(Categoria cat)
        {
            categoria = cat;
        }

        public Categoria GetCategoria()
        {
            return categoria;
        }

        public void SetProveedor(Proveedor prov)
        {
            proveedor = prov;
        }

        public Proveedor GetProveedor()
        {
            return proveedor;
        }

        public void SetStock(int cant)
        {
            stock = cant;
        }

        public int GetStock()
        {
            return stock;
        }
        */

//-------------------------------------------------------------------------------------------------------

        public void AumentarPrecio(int porcentaje)
        {
            // aumenta un % del precio
            // precio = precio + (precio * porcentaje / 100);
            Precio = Precio + (Precio * porcentaje / 100);
        }

        public void DisminuirPrecio(int porcentaje)
        {
            // disminuye un % del precio
            // precio = precio - (precio * porcentaje / 100);
            Precio = Precio - (Precio * porcentaje / 100);
        }

        public void AumentarStock(int cant)
        {
            // agrega items al stock
            // stock = stock + cant;
            Stock = Stock + cant;
        }

        public void DisminuirStock(int cant)
        {
            // retira items del stock
            // stock = stock - cant;
            Stock = Stock - cant;
        }

    }
}
