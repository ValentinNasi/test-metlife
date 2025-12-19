# TestMetLife

Este proyecto consiste en el desarrollo de una API REST en .NET que consume datos de una API pública externa, expuestos mediante endpoints utilizando autenticación JWT, aplicando Clean Architecture, principios SOLID, tests unitarios y contenedorización con Docker.

## Tecnologías utilizadas

- .NET 7
- ASP.NET Core Web API
- C#
- Clean Architecture
- JWT Authentication
- Docker
- xUnit
- Postman
- Swagger

## Requisitos previos

- .NET SDK 7.0
- Docker
- Postman
- Git

## Instrucciones de instalación y ejecución

1. Clonar el repositorio.

git clone https://github.com/ValentinNasi/test-metlife.git

cd test-metlife/src

2. Restaurar dependencias.

dotnet restore

3. Compilar la solución.

dotnet build

4. Ejecutar la API.

dotnet run --project TestMetLife.Api

## Instrucciones para ejecutar con Docker

Posterior a la instalación del proyecto.

1. Acceder a la carpeta src dentro del proyecto.

2. Abrir una ventana de powershell en la ubicación de la carpeta.

3. Ejecutar el siguiente comando.

docker compose up --build -d

## Instrucciones para ejecutar tests

1. Acceder a la carpeta src dentro del proyecto.

2. Abrir una ventana de powershell en la ubicación de la carpeta.

3. Ejecutar el siguiente comando.

dotnet test

## Credenciales de prueba para JWT

{
"username": "admin",
"password": "password"
}

## Ejemplos de uso de la API

Endpoints

POST http://localhost:5027/api/auth/login (Devuelve token)
Body:
{
"username": "admin",
"password": "password"
}

GET http://localhost:5027/api/posts (Devuelve 100 posts)
Agregar en headers:
{
"Authorization": "{token_generado}"
}

GET http://localhost:5027/api/posts/{id} (Devuelve la información del post especificado en el campo id)
Agregar en headers:
{
"Authorization": "{token_generado}"
}

Para probar los endpoints, se puede utilizar tanto Swagger como Postman.

## Swagger

1. Acceder a http://localhost:5027/swagger/index.html.

2. Seleccionar el unico endpoint de Auth y presionar el botón "Try it out".

3. Completar las credenciales del usuario y ejecutar.

4. Copiar el valor del token de la respuesta y pegarlo en el campo de texto que aparece al presionar el botón "Authorize" en la parte derecha de la página.

5. Ejecutar el resto de endpoints.

## Postman

1. Abrir Postman y seleccionar la opción de "Importar".

2. Seleccionar el archivo que se encuentra en la carpeta raiz del repositorio llamado "TestMetLife.postman_collection".

3. Esperar a que se importe la colección.

4. Ejecutar el endpoint llamado "Login".

5. Ejecutar el resto de endpoints.
