To Run Benchmarks:

1) Set Benchmark Mappings to startup project
2) Set Configuration to release
3) Build (ctrl + shift + B) and start without debugging (ctrl + F5)



To add tooling for autogenerating 'manual' mappings:
Can see existing required tools in dotnet-tools.json (inside the root/.config folder)

1) Open developer console - should be pointing to the solution's directory
2) Run: dotnet new tool-manifest
3) Run: dotnet tool install Mapster.Tool
4) Modify Project with https://github.com/MapsterMapper/Mapster/wiki/Mapster.Tool