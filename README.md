# Usage of SimpleSOAPClient in .NET Core

## WSDL file convertation to c# classes via **dotnet-svcutils** needs some preparation:
1. Install .NET Core 2.1 (**dotnet-svcutils 2.0.2**) or .NET 5 (**dotnet-svcutils 2.0.3**)
2. Install **dotnet-svcutils** using command **dotnet tool install --global dotnet-svcutil --version 2.0.2**
2. Run command **dotnet-svcutils {wsdl_file_path}**