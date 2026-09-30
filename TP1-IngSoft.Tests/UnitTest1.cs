namespace TP1_IngSoft;

using System.Reflection;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void TestAgregarYBuscarProducto()
    {
        Tienda tienda = new Tienda();

        Producto producto =
            new Producto("Producto1", 10.0, "Categoria1");

        tienda.AgregarProducto(producto);

        Producto encontrado =
            tienda.BuscarProducto("Producto1");

        Assert.Equal(producto, encontrado);
    }

    [Fact]
    public void TestEliminarProducto()
    {
        Tienda tienda = new Tienda();
        Producto producto =
            new Producto("Teclado", 2500, "Electronica");

        tienda.AgregarProducto(producto);

        // Act: eliminamos el producto
        bool resultado =
            tienda.EliminarProducto("Teclado");

        //assert: Verificamos resultado.
        Assert.True(resultado);
    }


}

/*
    Preguntas conceptuales:
- ¿Puedes identificar pruebas de unidad y de integración en la práctica que se realizó?
    Si, las pruebas de unidad se enfoncan en probar modulos individaules, mientras que las pruebas de integración se enfocan en probar la interacción entre modulos
    
    */
