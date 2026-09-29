namespace TP1_IngSoft;

using System.Reflection;
using System.Reflection.Metadata;
using Xunit;

public class PruebasExcepciones
{
    [Fact]
    public void TestPrecioExcepcion()
    {
       
        Producto producto = new Producto("Producto1", 10.0, "Categoria1");
        
        Assert.Throws<ArgumentException>(() => producto.actualizarPrecio(-100.0));


    }

    [Fact]
    public void TestEliminarExcepcion()
    {
        Tienda tienda = new Tienda();

        Assert.Throws<ArgumentException>(() => tienda.EliminarProducto("productoInexistente"));
    }

    [Fact]
    public void TestBuscarProductoException()
    {
        Tienda tienda = new Tienda();
        
        Assert.Throws<Exception>(() => tienda.BuscarProducto("productoInexistente"));
    }
}


/*

Podría haber escrito las pruebas primero antes de modificar el código de la aplicación?
¿Cómo sería el proceso de escribir primero los tests? Describe el proceso con tus palabras.
Sí, es posible escribir las pruebas antes de modificar el código
El proceso se haria escribiendo primero las pruebas que queremos utilizar con la definicion de los metodos que vamos a utilizar( puede o no estar definidos) y luego se implementaria el codigo para probar las pruebas. 
Esto nos permite tener una guia de lo que queremos lograr y asegurarnos de que nuestro codigo cumpla con los requisitos establecidos en las pruebas.
*/