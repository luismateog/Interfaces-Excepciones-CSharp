# 220501097-04-AA1 – EV09

Retos de programación orientada a objetos en C#: interfaces y manejo de excepciones.

## Estructura

- `RetoInterfaces/`: contrato `IMediaPlayer` e implementación `MusicPlayer`.
- `RetoExcepciones/`: excepción personalizada `EdadInvalidaException` y validación de edad.

## Requisitos

.NET 10 SDK (los proyectos usan `net10.0`).

## Ejecutar

Desde esta carpeta, ejecute:

```sh
dotnet run --project RetoInterfaces
dotnet run --project RetoExcepciones
```

Cada reto es una aplicación de consola independiente. La demostración de interfaces carga pistas, reproduce, pausa y detiene. La de excepciones prueba edades válidas (25, 0, 120), texto no numérico (`abc`) y edades fuera del rango (`-1`, `121`). También muestra el cierre en `finally` para cada caso.

## Crear el repositorio remoto

El repositorio local puede publicarse en GitHub con el nombre `220501097-04-AA1-EV09-Interfaces-Excepciones-CSharp`.
