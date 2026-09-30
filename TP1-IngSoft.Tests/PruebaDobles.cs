namespace TP1_IngSoft;
using NSubstitute;
using System.Reflection;
using System.Reflection.Metadata;
using Xunit;

public class PruebaDobles
{
    [Fact]
    public void TestDouble()
    {
        var tienda = new Tienda();

        var productoFalso =
            Substitute.For<Producto>(
                "Auto",
                1000.0,
                "Juguetes");

        tienda.AgregarProducto(productoFalso);

        tienda.aplicarDescuento("Auto", 10.0);

        productoFalso.Received(1).actualizarPrecio(900.0);

    }

    [Fact]
    public void AplicarDescuento_ActualizaPrecioCorrectamente()
    {
        Tienda tienda = new Tienda();
        Producto producto =
            new Producto("Auto", 1000.0, "Juguetes");

        tienda.AgregarProducto(producto);

        tienda.aplicarDescuento("Auto", 10.0);

        Assert.Equal(900.0, producto.Precio);
    }


}

/*

- En lo que va del trabajo práctico, ¿puedes identificar 'Controladores' y 'Resguardos'?
si, el controlador es la clase Tienda y el resguardo es la clase Producto.
- ¿Qué es un “test double”? ¿Hay otros nombres para los objetos/funciones simulados?
Es un objeto que simula el comportamiento de un objeto real en pruebas unitarias. Otros nombres incluyen "mock", "stub", "fake" y "spy".


*/