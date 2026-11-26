using RetoExcepciones;

Console.WriteLine("=== Reto excepciones: validación de edad ===");
string[] casos = ["25", "abc", "-1", "121", "0", "120"];
foreach (string entrada in casos)
{
    Console.WriteLine($"\nEntrada de prueba: {entrada}");
    try
    {
        int edad = ValidadorEdad.Validar(entrada);
        Console.WriteLine($"Edad válida: {edad} años.");
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: debe ingresar un número entero.");
    }
    catch (EdadInvalidaException ex) when (entrada.TrimStart().StartsWith('-'))
    {
        Console.WriteLine($"Edad fuera del rango permitido: {ex.Message}");
    }
    catch (EdadInvalidaException ex)
    {
        Console.WriteLine($"Edad fuera del rango permitido: {ex.Message}");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Error: el número ingresado es demasiado grande.");
    }
    finally
    {
        Console.WriteLine("Cierre del proceso de validación.");
    }
}
