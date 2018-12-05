# Dotnet Core API com Docker
Repositório exemplo API in dotnet core com docker

# Build and run the Docker image
1. Open a command prompt and navigate to your project folder.
2. Use the following commands to build and run your Docker image:

```
$ docker build -t aspnetapp .
$ docker run -d -p 8080:80 --name myapp aspnetapp
```
