# TP1-IngSoft-PeraltaRomeroFacundo-SilvaTomas

# COMANDOS

- PARA SABER LAS PRUEBAS DISPONIBLES.

*** dotnet test --list-tests ***


# PARA EJECUTAR LOS TEST




# PASO 1

PARA EJECUTAR PRUEBA:
ir a al directorio
\TP1-IngSoft-PeraltaRomeroFacundo-SilvaTomas-DiazExequiel\TP1-IngSoft.Tests>

**UnistTest1 - Punto 1**
dotnet test --filter "FullyQualifiedName~TP1_IngSoft.UnitTest1"

**PruebaDobles - Punto 2**
dotnet test --filter "FullyQualifiedName~TP1_IngSoft.PruebaDobles"

**PruebasExcepciones - Punto 3**
dotnet test --filter "FullyQualifiedName~TP1_IngSoft.pruebasExcepciones"

**PruebasFixture - Punto 4**
dotnet test --filter "FullyQualifiedName~TP1_IngSoft.PruebasFixture"

**PruebasIntegracion - Punto 5**
dotnet test --filter "FullyQualifiedName~TP1_IngSoft.PruebasIntegracion"




# HERRAMIENTA VISUAL DE PORCENTAJES

**PARA EJECUTAR LA HERRAMIENTA VISUAL**

Ir a la ruta, todos los comandos se ejecutan desde la carpeta raiz
\TP1-IngSoft-PeraltaRomeroFacundo-SilvaTomas-DiazExequiel

INSTALAR HERRAMIENTA VISUAL
dotnet tool install --global dotnet-reportgenerator-globaltool

EJECUTAR PARA RECOLECTAR DATOS
dotnet test ".\TP1-IngSoft.Tests\TP1-IngSoft.Tests.csproj" --collect:"XPlat Code Coverage" --results-directory ".\TestResults"

EJECUTAR PARA ARMAR EL REPORTE
reportgenerator "-reports:TestResults/**/coverage.cobertura.xml" "-targetdir:CoverageReport" "-reporttypes:Html;TextSummary"


EJECUTAR PARA ABRIR EL HTML
start CoverageReport\index.html



# RESPUESTAS A PREGUNTAS CONCEPTUALES

Las respuestas a las preguntas conceptuales estan comentandas al final de cada archivo