using sistema_ventas.Interfaz;

namespace sistema_ventas.Clases
{
    public class Venta : ICalcular
    {
        /*
        private int idVenta;
        private Producto producto;
        private int cantidad;
        */

        public int IdVenta { get; private set; }
        public int IdProducto { get; private set; }
        public Producto Producto { get; set; } = null!;
        public int IdFactura { get; private set; }
        public Factura Factura { get; set; } = null!;
        public int Cantidad { get; set; }

        public Venta()
        {

        }

        public Venta(int id, Producto prod, Factura fac, int cant)
        {
            /*
            idVenta = id;
            producto = prod;
            cantidad = cant;
            */
            IdVenta = id;
            IdProducto = prod.IdProducto;
            Producto = prod;
            IdFactura = fac.IdFactura;
            Factura = fac;
            Cantidad = cant;
        }

        /*
        public void SetID(int id)
        {
            idVenta = id;
        }

        public int GetID()
        {
            return idVenta;
        }

        public void SetProducto(Producto prod)
        {
            producto = prod;
        }

        public Producto GetProducto()
        {
            return producto;
        }

        public void SetCantidad(int cant)
        {
            cantidad = cant;
        }

        public int GetCantidad()
        {
            return cantidad;
        }
        */

//----------------------------------------------------------------------

        public void AumentarCantidad(int cant)
        {
            // aumenta la cantidad del producto
            // cantidad = cantidad + cant;
            Cantidad += cant;
        }

        public void DisminuirCantidad(int cant)
        {
            // disminuye la cantidad del producto
            // cantidad = cantidad - cant;
            Cantidad -= cant;
        }

        public decimal CalcularTotal()
        {
            // calcula el total de la venta
            // decimal subtotal = producto.GetPrecio() * this.GetCantidad();
            decimal subtotal = Producto.Precio * Cantidad;
            return subtotal;
        }


    }
}
