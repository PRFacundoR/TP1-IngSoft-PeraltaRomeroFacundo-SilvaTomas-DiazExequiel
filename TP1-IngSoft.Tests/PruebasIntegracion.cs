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
            "Teclado",
        };

        var carritoInvalido = new List<string>
        {
            "placa de video",
            "Teclado",
        };

        var carritoVacio = new List<string>();

        var carritorepetido = new List<string>
        {
            "Mouse",
            "Mouse",
            "Teclado",
        };


        // Act
        tienda.aplicarDescuento("Mouse", 10);
        


        double total =
            tienda.calcularTotalCarrito(carrito);

        // Assert
        Assert.Equal(2900, total);
        Assert.Throws<Exception>(() => tienda.aplicarDescuento("placa de video", 10));
        Assert.Throws<Exception>(() => tienda.calcularTotalCarrito(carritoInvalido));
        Assert.Throws<Exception>(() => tienda.aplicarDescuento("Teclado", -20));
        Assert.Throws<Exception>(() => tienda.aplicarDescuento("Teclado", 0));
        Assert.Throws<Exception>(() => tienda.aplicarDescuento("Teclado", 200));
        Assert.Throws<Exception>(() => tienda.calcularTotalCarrito(carritoVacio));
       
       
        double totalRepetido = tienda.calcularTotalCarrito(carritorepetido);
        Assert.Equal(3800, totalRepetido);
        
        
        tienda.aplicarDescuento("Teclado", 100);
        Assert.Equal(0, tienda.BuscarProducto("Teclado").Precio);


    }
}

/*

#¿Realizó una prueba de cobertura completa? ¿Qué tipo de cobertura utilizó?

Se puede considerar que la cobertura sea completamente exhaustiva solamente con estas pruebas.

Se realizaron pruebas de cobertura de sentencias, ramas y valores límite. Se probaron el flujo normal de cálculo, la aplicación de descuentos, los productos inexistentes, un carrito vacío, productos repetidos y porcentajes de descuento en los límites y fuera del rango permitido.

La cobertura de sentencias permite comprobar que las instrucciones de los métodos fueron ejecutadas, mientras que la cobertura de ramas permite recorrer tanto los caminos exitosos como los caminos que generan excepciones. También se aplicaron pruebas de valores límite utilizando descuentos del 0 % y 100 %, además de porcentajes menores que 0 y mayores que 100.


#¿Puede describir una situación de desarrollo para este caso en donde se plantee pruebas de integración ascendente? Describa la situación.

Una integración ascendente comenzaría probando los componentes de nivel más bajo y luego incorporaría progresivamente los componentes que dependen de ellos.

En este caso, primero se probaría individualmente la clase Producto, por ejemplo verificando la actualización de su precio. Después se integraría Producto con Tienda para probar las operaciones de agregar y buscar productos. Luego se incorporaría aplicarDescuento, que utiliza tanto la búsqueda de la tienda como la actualización del precio del producto. Finalmente se probaría calcularTotalCarrito y el flujo completo que aplica un descuento y calcula el total.

Es una integración ascendente porque se comienza con Producto, que es el componente más básico, y se avanza hacia operaciones de mayor nivel que combinan varios métodos y objetos.

*/