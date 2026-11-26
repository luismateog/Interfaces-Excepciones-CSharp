using RetoExcepciones;

Console.WriteLine("=== Reto excepciones: validación de edad ===");
string[] casosDePrueba = ["25", "abc", "-1", "121", "0", "120"];

foreach (string entrada in casosDePrueba)
{
    Console.WriteLine($"\nEdad ingresada: {entrada}");
    try
    {
        int edad = ValidadorEdad.Validar(entrada);
        Console.WriteLine($"Edad válida: {edad}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Debes introducir un número válido");
    }
    catch (EdadInvalidaException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Proceso de validación finalizado");
    }
}
