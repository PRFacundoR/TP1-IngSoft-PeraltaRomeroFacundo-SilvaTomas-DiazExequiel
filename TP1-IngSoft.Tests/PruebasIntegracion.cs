using Xunit;

namespace TP1_IngSoft;

public class PruebasIntegracion
{
    private readonly Tienda tienda;

    public PruebasIntegracion()
    {
        tienda = new Tienda();

        tienda.AgregarProducto(
            new Producto("Mouse", 1000, "Perifericos")
        );

        tienda.AgregarProducto(
            new Producto("Teclado", 2000, "Perifericos")
        );

        tienda.AgregarProducto(
            new Producto("Monitor", 5000, "Monitores")
        );
    }

    [Fact]
    public void CalcularTotalCarrito_DebeSumarPrecios()
    {
        // Arrange
        var carrito = new List<string>
        {
            "Mouse",
            "Teclado"
        };

        // Act
        double total =
            tienda.calcularTotalCarrito(carrito);

        // Assert
        Assert.Equal(3000, total);
    }

    [Fact]
    public void FlujoCompleto_DebeCalcularTotalLuegoDeAplicarDescuento()
    {
        // Arrange
        var carrito = new List<string>
        {
            "Mouse",
            "Teclado"
        };

        // Act
        tienda.aplicarDescuento("Mouse", 10);

        double total =
            tienda.calcularTotalCarrito(carrito);

        // Assert
        Assert.Equal(2900, total);
    }
}