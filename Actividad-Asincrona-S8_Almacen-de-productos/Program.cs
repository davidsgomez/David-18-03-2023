using Actividad-Asincrona-S8_Almacen-de-productos.Models;

Console.WriteLine();
Console.WriteLine("             BIENVENIDO A SU ALMACEN DE CONFIANZA.      ");
Console.WriteLine();

AlmacenContext db = new AlmacenContext();
Producto producto = new Producto();

Console.WriteLine();

Console.Write("- Nombre de el producto ---> ");
producto.Nombre = Console.ReadLine();
Console.Write("- Descripción del producto ---> ");
producto.Descripcion = Console.ReadLine();
Console.Write("- Precio de el producto ---> ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());
Console.Write("- Cantidad de productos en stock ---> ");
producto.Stock = Convert.ToInt32(Console.ReadLine());

db.Producto.Add(producto);
db.SaveChanges();

Console.WriteLine("     Ha sido un exito el registro del producto     ");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("     Id Cantidad. Productos Descripcion Precio     ");
Console.WriteLine("---------------------------------------------------");

Console.WriteLine();

var ListaProductos = db.Producto.ToList();
foreach (var product in ListaProductos){

    Console.WriteLine($"  {product.Id}  {product.Stock}    {product.Nombre} / {product.Descripcion} / ${product.Precio}");
}

Console.WriteLine();
Console.WriteLine("         GRACIAS POR PREFERIRNOS.           ");
Console.WriteLine();
