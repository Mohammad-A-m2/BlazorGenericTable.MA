<div align="center">
  <img src="https://github.com/Mohammad-A-m2/BlazorGenericTable.MA/blob/main/wwwroot/BlazorGenericTable.MA.jpg" alt="Project Logo" width="300">
</div>

# Client Project Guide: Using BlazorGenericTable.MA

**BlazorGenericTable.MA** is a dynamic, feature-rich generic table component designed for C# and Blazor applications. Built on .NET 6 and enhanced by modern C# features like nullable enablement and implicit usings, it enables you to present and interact with data seamlessly. In addition to supporting selection, deletion, and pagination out-of-the-box, it also allows you to easily customize table styles by adding your own CSS classes.

This document will guide you through the steps to incorporate and use **BlazorGenericTable.MA** in your client project.

---
### Features

- Making the table responsive to only one parameter.  
  ![[Responsive Table](IMAGE_LINK_HERE)](https://github.com/Mohammad-A-m2/BlazorGenericTable.MA/blob/main/wwwroot/tableImages/TableOne.jpg)
- Add a loading bar when data is loaded in the first render.  
  ![[Loading Bar](IMAGE_LINK_HERE)](https://github.com/Mohammad-A-m2/BlazorGenericTable.MA/blob/main/wwwroot/tableImages/First%20loading%20bar.jpg)
- Add spinner loading for deleting and changing the page.  
  ![[Spinner Loading](IMAGE_LINK_HERE)](https://github.com/Mohammad-A-m2/BlazorGenericTable.MA/blob/main/wwwroot/tableImages/Circle%20Loading.jpg)
- Add dialog box for delete button to get its confirmation.  
  ![[Delete Confirmation](IMAGE_LINK_HERE)](https://github.com/Mohammad-A-m2/BlazorGenericTable.MA/blob/main/wwwroot/tableImages/Delete%20confirmation.jpg)
## Prerequisites

- **Visual Studio 2022** or later with .NET 6 SDK.
- A Blazor project (Client/Server/WebAssembly) where you plan to integrate the table component.
- Basic understanding of Blazor components and C#.

---

## Installation

You can add **BlazorGenericTable.MA** to your project using either the NuGet Package Manager Console or the .NET CLI.

### Using Package Manager Console

```Powershell
Install-Package BlazorGenericTable.MA -Version 1.0.5
```

### Using .NET CLI
 ```bash
dotnet add package BlazorGenericTable.MA --version 1.0.5
 ```

### Usage
After installing the package, import the namespace in your Blazor component:
```Razor
@using BlazorGenericTable.MA
