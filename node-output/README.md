# Sigo_App_Api - ASP.NET Core 1.0 Server

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
cd src/Sigo_App_Api
docker build -t Sigo_App_Api .
docker run -p 5000:5000 Sigo_App_Api
```
