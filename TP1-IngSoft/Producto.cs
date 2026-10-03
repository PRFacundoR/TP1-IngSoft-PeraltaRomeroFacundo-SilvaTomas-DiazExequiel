namespace TP1_IngSoft;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Categoria { get; set; }

    public Producto(string nombre, double precio, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }

    public virtual void actualizarPrecio(double nuevoPrecio )
    {
        if(nuevoPrecio < 0)
        {
            throw new ArgumentException(
                "El precio no puede ser negativo");
        }

        Precio = nuevoPrecio;
    }
}