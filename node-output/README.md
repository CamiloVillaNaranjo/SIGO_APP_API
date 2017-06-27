# IO.Swagger - ASP.NET Core 1.0 Server

Este es un ejemplo de como luciría la Api de Integración entre Facturizate y SIGO.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t IO.Swagger .
docker run -p 5000:5000 IO.Swagger
```
