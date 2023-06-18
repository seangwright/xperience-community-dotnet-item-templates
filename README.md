# Xperience Community: .NET Item Templates

.NET CLI Item Templates for Xperience by Kentico projects, usable at the command line or in Visual Studio

<video src="https://raw.githubusercontent.com/seangwright/xperience-community-dotnet-item-templates/main/images/xperience-widget-vs-template.mp4">

## Building and Testing

1. Make template changes
1. Run the `dotnet: build` VS Code task to ensure the template changes compile
1. Run the `dotnet: pack` VS Code task to package the templates
1. Close all instances of VS
1. Run the `dotnet: uninstall template` VS Code task to uninstall the template, if already installed
1. Run the `templates: clear cache` VS Code task to clear the template cache
1. Run the `dotnet: install template` VS Code task to install the locally packaged template (use the correct version number when prompted)
1. Open VS and test the templates on an ASP.NET Core or class library project

## Contributing

- [Exposing Item Tempaltes in VS](https://github.com/dotnet/templating/issues/4686#issuecomment-1591202127)
  - [Example VS compatible item template](https://github.com/dotnet/maui/blob/main/src/Templates/src/templates/maui-contentpage-csharp/.template.config/ide.host.json)
- [Interactive dotnet new experiences](https://github.com/dotnet/templating/issues/6024)
- [Guidance on authoring .NET CLI templates](https://github.com/sayedihashimi/template-sample)
- [Templating repo and wiki](https://github.com/dotnet/templating/)
- [Example templates for ASP.NET Core](https://github.com/dotnet/aspnetcore/blob/main/src/ProjectTemplates/Web.ItemTemplates/content/ViewStart/.template.config/template.json)
