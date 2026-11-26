# 220501097-04-AA1 – EV09

Retos de programación orientada a objetos en C#: interfaces y manejo de excepciones.

## Proyectos

- `RetoInterfaces/`: interfaz `IMediaPlayer` y clase `MusicPlayer`.
- `RetoExcepciones/`: excepción personalizada `EdadInvalidaException` y validación de edad.

Se requiere el SDK de .NET 10.

## Ejecución

```sh
dotnet run --project RetoInterfaces
dotnet run --project RetoExcepciones
```

El reto de interfaces muestra la pista inicial `Sin pista`, la carga, reproducción, pausa y detención (que restablece la pista a `Sin pista`). El reto de excepciones recorre entradas de prueba válidas (`25`, `0`, `120`), no numérica (`abc`) y fuera del rango (`-1`, `121`), mostrando los mensajes solicitados y ejecutando `finally` para cada caso.

Repositorio GitHub: https://github.com/luismateog/Interfaces-Excepciones-CSharp
