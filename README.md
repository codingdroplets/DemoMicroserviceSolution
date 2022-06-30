# .NET Core Demo Microservice Solution

Watch Tutorial Videos Now:
1. .NET Core Web API Microservice with SQL Server Entity Framework Core - https://www.youtube.com/watch?v=2p01iafOxUw
2. .Net Core MySQL Microservice - Entity Framework Core MySQL - https://www.youtube.com/watch?v=b1BSu0Wb2Rw
3. .Net Core MongoDB Microservice - .Net Core MongoDB CRUD - https://www.youtube.com/watch?v=fWwbY91eDlY
4. ASP.Net Core API Gateway - Ocelot API Microservice - https://www.youtube.com/watch?v=k4l3Ptd4yjw

This solution is a collection of three microservices with different database (SQL Server, MySQL & MongoDB).
We'll be developing a API Gateway which communicates with all the three microservices for doing the CRUD operations. Finally we'll also develop a Web Application which only communicates with the API Gateway.

Follow the Youtube Playlist: https://www.youtube.com/playlist?list=PLzewa6pjbr3JQKhB_U_FiuYwQC70i-TyU

Visual Studio provides a consistent way to develop Docker containers and validate your application locally. You can run and debug your apps in Linux or Windows containers running on your local Windows desktop with Docker installed, and you don't have to restart the container each time you make a code change.

You can view what's going on inside the containers that host your app by using the Containers window. If you're used to using the command prompt to run Docker commands to view and diagnose what's going on with your containers, this window provides a more convenient way to monitor your containers without leaving the Visual Studio IDE.

What is Docker Compose?
Docker Compose is a tool for defining and running multi-container Docker applications. With Compose, you use a YAML file to configure your application’s services. Then, with a single command, you create and start all the services from your configuration.

Docker for .Net Core:
.NET Core can easily run in a Docker container. Containers provide a lightweight way to isolate your application from the rest of the host system, sharing just the kernel, and using resources given to your application. Learn how to use docker for .Net Core and deploy .Net Core to Docker.

.NET Core images
Official .NET Core Docker images are published to the Microsoft Container Registry (MCR) and are discoverable at the Microsoft .NET Core Docker Hub repository. Each repository contains images for different combinations of the .NET (SDK or Runtime) and OS that you can use.
Microsoft provides images that are tailored for specific scenarios. For example, the ASP.NET Core repository provides images that are built for running ASP.NET Core apps in production.

The tools included in Visual Studio for developing with Docker containers [.Net Core Docker Container] are easy to use, and greatly simplify building, debugging, and deployment for containerized applications. You can work with a container for a single project, or use container orchestration with Docker Compose or Service Fabric to work with multiple services in containers.
