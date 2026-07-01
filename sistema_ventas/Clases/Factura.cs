using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sistema_ventas.Interfaz;

namespace sistema_ventas.Clases
{
    public class Factura : ICalcular
    {
        /*
        private int idFactura;
        private DateTime fecha;
        private Cliente cliente;
        private List<Venta> ventas;
        */

        public int IdFactura { get; private set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; private set; }
        public Cliente Cliente { get; set; } = null!;
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();

        public Factura()
        {

        }
        
        public Factura (int id, DateTime date, Cliente cli)
        {
            /*
            idFactura = id;
            fecha = date;
            cliente = cli;
            ventas = new List<Venta>();
            */
            IdFactura = id;
            Fecha = date;
            IdCliente = cli.ID;
            Cliente = cli;
        }

        /*
        public void SetID(int id)
        {
            idFactura = id;
        }
        
        public int GetID()
        {
            return idFactura;
        }

        public void SetFecha(DateTime date)
        {
            fecha = date;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }

        public void SetCliente(Cliente cli)
        {
            cliente = cli;
        }

        public Cliente GetCliente()
        {
            return cliente;
        }
        */

//---------------------------------------------------------------------

        public void AgregarVenta(Venta vent)
        {
            // agregar la venta a la lista
            // ventas.Add(vent);
            Ventas.Add(vent);
        }

        public void QuitarVenta(int vent)
        {
            /* No se puede usar un foreach, porque necesitaria varios constructores vacios, ya que ninguna clase acepta nulls
            int quitar;
            // recorrer la lista
            for (int i = 0; i < ventas.Count; i++)
            {
                if (ventas[i].GetID() == vent.GetID())
                {
                    quitar = i;
                    break;
                }
            }

            // quitar la venta de la lista
            ventas.RemoveAt(quitar);
            */

            // remover todas las ventas que cumplan la condicion
            // ventas.RemoveAll(quitar => quitar.GetID() == vent);

            Venta quitar = new Venta();
            foreach(Venta v in Ventas)
            {
                if (v.IdVenta == vent)
                {
                    quitar = v;
                    break;
                }
            }
            Ventas.Remove(quitar);

        }

        public decimal CalcularTotal()
        {
            // calcular el total de la factura
            decimal total = 0;
            /*
            for (int i = 0; i < ventas.Count; i++)
            {
                total = total + ventas[i].CalcularTotal();
            }
            */
            foreach (Venta v in Ventas)
            {
                total += v.CalcularTotal();
            }

            return total;
        }


    }
}
