namespace TP1_IngSoft;



public class Tienda
{
    // El inventario es una lista privada de objetos tipo Producto
    private List<Producto> inventario;

    // Constructor que inicializa la lista vacía
    public Tienda()
    {
        inventario = new List<Producto>();
    }

    // Método para agregar un producto
    public void AgregarProducto(Producto producto)
    {
        inventario.Add(producto);
    }

    // Método para buscar un producto por su nombre
    public Producto BuscarProducto(string nombre)
    {
        
        foreach (var producto in inventario)
        {
            if (producto.Nombre == nombre)
            {
                return producto; // Retorna el objeto encontrado
            }
        }
        throw new Exception("Producto no encontrado"); // Lanza una excepción si no se encuentra
    }

    // Método para eliminar un producto por su nombre
    public bool EliminarProducto(string nombre)
    {

        foreach (var producto in inventario)
        {
            if (producto.Nombre == nombre)
            {
                inventario.Remove(producto);
                return true; // Eliminación exitosa
            }
        }
        throw new ArgumentException("Producto inexistente"); // Lanza una excepción si no se encuentra
    }

    public  void aplicarDescuento(string nombre, double porcentaje)
    {
        Producto producto = BuscarProducto(nombre);
        
        producto.actualizarPrecio(producto.Precio * (1 - porcentaje / 100));
    }
}