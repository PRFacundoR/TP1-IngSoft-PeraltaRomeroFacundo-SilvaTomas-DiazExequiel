using Xunit;

namespace TP1_IngSoft;

public class PruebasFixture
{
    private readonly Tienda tienda;
    public PruebasFixture()
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
    public void BuscarProductoExistente_UsandoFixture()
    {
        Producto producto =
            tienda.BuscarProducto("Mouse");

        Assert.Equal("Mouse", producto.Nombre);
        Assert.Equal(1000, producto.Precio);
    }

    [Fact]
    public void AgregarProducto_UsandoFixture()
    {
        Producto notebook =
            new Producto(
                "Notebook",
                10000,
                "Computadoras"
            );

        tienda.AgregarProducto(notebook);

        Producto encontrado =
            tienda.BuscarProducto("Notebook");

        Assert.Equal(notebook, encontrado);
    }
}

/*
    El fixture sirve para evitar tener que repetir lineas
    de codigo, eso genera menos duplicacion y una preparacion
    mas consistente. Pero se debería tener cuidado de no abusar
    porque puede pasar que cada test necesite un escenario 
    diferente. O sea, si cada test necesita un escenario
    diferente, al meter todo en un fixture gigante puede hacer
    que los test no se entiendan.

    Un Setup es la preparación que se hace antes de ejecutar
    el test. Como lo siguiente:
    public PruebasFixture()
    {
        tienda = new Tienda();
        tienda.AgregarProducto(...);
    }

    El TearDown es la limpieza que se hace despies del test

    La caja negra diseña los casos a partir de entradas, salidas
    y como se comporta el test pero es independiente de la
    estructura interna del codigo. Por ejemplo cuando se hace
    tienda.BuscarProducto("ALGO") y se comprueba con 
    Assert.Equal("ALGO",producto.Nombre); aca no se analiza el
    if o el foreach o cosas asi.

    La caja blanca es una prueba donde se tiene en cuenta la 
    estructura interna del programa. Acá si importa como está
    hecho el if o el foreach
*/
