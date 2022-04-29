# Caso Práctico de Laboratorio #1 [![.NET](https://github.com/raedmiranda/SQLInjectionLab/actions/workflows/dotnet.yml/badge.svg)](https://github.com/raedmiranda/SQLInjectionLab/actions/workflows/dotnet.yml)

### Pasos iniciales
1. Clone el repositorio.
2. Restaure los paquetes de Nuget.
3. Ejecute el proyecto.

### Notas adicionales

- Existen 5 usuarios distintos. **No se pasen los screenshots**.
- El programa acepta las entradas de usuario. En este punto, recuerden el tema de Blind SQL Injection y el uso de .......................... para vulnerar la ejecución y obtener resultados.
- No forma parte de las competencias del curso, pero esta es una de las formas para restaurar paquetes de NuGet:
    - ![Visual Studio IDE Restoring NuGet packages!](https://i.imgur.com/EPE5sgV.png "Visual Studio IDE")
    - O bien [restaure usando dotnet CLI](https://docs.microsoft.com/es-es/nuget/consume-packages/package-restore#restore-using-the-dotnet-cli): ```dotnet restore ```
    - Pero de todas maneras, el proceso de compilación, por defecto, logra restaurar los paquetes.
- El IDE es indistinto. El requerimiento es que tenga [NET Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1) instalado.
- Por lo tanto, pueden usar [Visual Studio Community](https://visualstudio.microsoft.com/es/vs/community/) 2019 o superior, [Visual Studio Code](https://code.visualstudio.com/), [JetBrains Rider](https://www.jetbrains.com/es-es/rider/), entre otros:
    - ![Visual Studio Code - Run NET Core project!](https://i.imgur.com/6qP2QN6.png "Visual Studio Code")
