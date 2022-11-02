Demo app for running benchmarks using Benchmark Dot Net

To enable graphical plots of benchmark results using R:
- Install R from https://www.r-project.org/
- Add 'R_HOME' with value 'C:\Program Files\R\R-4.2.2' to environment variables (where 4.2.2 is the installed version)
- Navigate to the 'C:\Program Files\R\R-4.2.2\bin' directory and run 'R.exe' and run 'install.packages("ggplot2")' in the prompt
- Add '[RPlotExporter]' annotation to class containing benchmarks
- Results outputted to '..src\Project\bin\Release\net6.0\BenchmarkDotNet.Artifacts\results' upon successful completion of a benchmark.