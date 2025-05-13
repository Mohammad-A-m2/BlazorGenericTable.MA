<div align="center">
  <img src="https://github.com/Mohammad-A-m2/MA.BlazorGenericTable/blob/main/wwwroot/BlazorGenericTable.MA.jpg" alt="Project Logo" width="300">
</div>

# Client Project Guide: Using MA.BlazorGenericTable

**MA.BlazorGenericTable** is a dynamic, feature-rich generic table component designed for C# and Blazor applications. Built on .NET 6 and enhanced by modern C# features like nullable enablement and implicit usings, it enables you to present and interact with data seamlessly. In addition to supporting selection, deletion, and pagination out-of-the-box, it also allows you to easily customize table styles by adding your own CSS classes.

This document will guide you through the steps to incorporate and use **MA.BlazorGenericTable** in your client project.

---

## Prerequisites

- **Visual Studio 2022** or later with .NET 6 SDK.
- A Blazor project (Client/Server/WebAssembly) where you plan to integrate the table component.
- Basic understanding of Blazor components and C#.

---

## Installation

You can add **MA.BlazorGenericTable** to your project using either the NuGet Package Manager Console or the .NET CLI.

### Using Package Manager Console

```Powershell
Install-Package MA.BlazorGenericTable -Version 1.0.0
```

### Using .NET CLI
 ```bash
dotnet add package MA.BlazorGenericTable --version 1.0.0
 ```

###Usage
After installing the package, import the namespace in your Blazor component:
```Razor
@using Common.CRUD.Table.Components.Components```
