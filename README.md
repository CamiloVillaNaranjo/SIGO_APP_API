# SIGO_APP_API - ASP.NET Core 1.0 Server

Este es de ejemplo, tiene como finalidad mostrar un mockup del API que se desarrollará para integrar con Facturizate.

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
