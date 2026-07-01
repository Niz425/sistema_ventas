/*
using sistema_ventas.Clases.Deprecated;

Cliente cliente;
cliente = new Cliente("Jose", "Calle Falsa 123", "12345678");
cliente.SetID(1);
Console.WriteLine(cliente.GetDatos());
int membresia;
do {
    Console.Write("Por favor ingrese una membresia: ");
} while (!Int32.TryParse(Console.ReadLine(), out membresia));
ClienteVIP clienteVIP;
clienteVIP = new ClienteVIP(cliente, membresia);
Console.WriteLine("El cliente " + clienteVIP.GetNombre() + " tiene la membresia " + clienteVIP.GetMembresia());


DeprecatedMenu menuPrincipal = new DeprecatedMenu();
menuPrincipal.MostrarMenu();
*/

using sistema_ventas.Clases;
using sistema_ventas.EF;

using (var contexto = new AppDBContext())
{
    Cliente cliente = new Cliente(0, "Josefa", "Calle X 654", "43218765", 1);
    contexto.Clientes.Add(cliente);
    await contexto.SaveChangesAsync();
}





