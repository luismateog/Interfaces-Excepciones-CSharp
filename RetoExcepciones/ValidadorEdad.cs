namespace RetoExcepciones;

public static class ValidadorEdad
{
    public static int Validar(string entrada)
    {
        int edad = int.Parse(entrada);
        if (edad < 0 || edad > 120)
        {
            throw new EdadInvalidaException("La edad debe estar entre 0 y 120 años");
        }
        return edad;
    }
}
