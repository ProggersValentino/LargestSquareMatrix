## Prerequisites
- .Net 8.0
- Visual Studio 2022 17.14.13 or higher
- ASP.NET and web development workload 

---

## Build Using Visual Studio
1. Open the project in Visual Studio
2. Ensure the build configuration is in **Release** 
3. Navigate to 'Build >> Build Solution' or pressing **Ctrl + B** to build 

## Build via Developer Powershell
1. Open the project in Visual Studio and open the 'Developer Powershell' by navigating to 'Tools >> Command Line >> Developer Powershell'
2. If not already, 'cd' into the 'NumbersToWords' project directory. You should be in the **directory path: '\NumbersToWords-main\NumbersToWords-main\NumbersToWords'** 
3. Enter 'dotnet restore' command 
4. Enter 'dotnet build -c 'Release'' to build

## Run solution
1. Press "Ctrl + F5"

