# Xperience Community: .NET Item Templates

[![CI: Build and Test](https://github.com/seangwright/xperience-community-dotnet-item-templates/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/seangwright/xperience-community-dotnet-item-templates/actions/workflows/ci.yml)

.NET CLI Item Templates for Xperience by Kentico projects, usable at the command line or in Visual Studio

![Visual Studio new item dialog](https://raw.githubusercontent.com/seangwright/xperience-community-dotnet-item-templates/main/images/vs-new-item-dialog.jpg)

![Using the Widget Item Template in Visual Studio](https://raw.githubusercontent.com/seangwright/xperience-community-dotnet-item-templates/main/images/xperience-widget-vs-template.webp)

## Templates

This package includes the following item templates

### Admin

- [Admin Application Page](https://docs.xperience.io/x/2gSiCQ)
- [Admin Module](https://docs.xperience.io/xp/developers-and-admins/customization/extend-the-administration-interface/prepare-your-environment-for-admin-development#Prepareyourenvironmentforadmindevelopment-Renametheboilerplateproject)
- [Admin Edit Page](https://docs.xperience.io/x/1IouCw)
- [Admin Edit Section Page](https://docs.xperience.io/x/1IouCw)
- [Admin List Page](https://docs.xperience.io/x/1oouCw)
- [Admin Create Page](https://docs.xperience.io/xp/developers-and-admins/customization/extend-the-administration-interface/ui-pages/reference-ui-page-templates/edit-ui-page-template#EditUIpagetemplate-Useeditpagestocreatenewobjects)
- [Admin Page Extender](https://docs.xperience.io/x/4gSiCQ)
- [UI Form Component](https://docs.xperience.io/x/5ASiCQ)
- [Validation Rule](https://docs.xperience.io/x/6QSiCQ)
- [Validation Rule (TypeScript)](https://docs.xperience.io/xp/developers-and-admins/customization/extend-the-administration-interface/ui-form-components/ui-form-component-validation-rules#UIformcomponentvalidationrules-Validationrulefrontend)

### Form Builder

- [Form Component](https://docs.xperience.io/x/YIbWCQ)
- [Form Section](https://docs.xperience.io/x/ZYbWCQ)

### Page Builder

- [Widget](https://docs.xperience.io/xp/developers-and-admins/development/builders/page-builder/widgets-for-page-builder#WidgetsforPageBuilder-Widgetsbasedonaviewcomponent)
- [Section](https://docs.xperience.io/xp/developers-and-admins/development/builders/page-builder/sections-for-page-builder#SectionsforPageBuilder-Sectionsbasedonaviewcomponent)

## Building and Testing

### Automated

Run the `templates: reinstall` VS Code task, which will perform all the manual steps below

### Manual

1. Make template changes
1. Run the `dotnet: build` VS Code task to ensure the template changes compile
1. Run the `dotnet: pack` VS Code task to package the templates
1. Close all instances of VS
1. Run the `dotnet: uninstall template` VS Code task to uninstall the template, if already installed
1. Run the `templates: clear cache` VS Code task to clear the template cache
1. Run the `dotnet: install template` VS Code task to install the locally packaged template (use the correct version number when prompted)
1. Open VS and test the templates on an ASP.NET Core or class library project

## Notes

- [Exposing Item Tempaltes in VS](https://github.com/dotnet/templating/issues/4686#issuecomment-1591202127)
  - [Example VS compatible item template](https://github.com/dotnet/maui/blob/main/src/Templates/src/templates/maui-contentpage-csharp/.template.config/ide.host.json)
- [Interactive dotnet new experiences](https://github.com/dotnet/templating/issues/6024)
- [Guidance on authoring .NET CLI templates](https://github.com/sayedihashimi/template-sample)
- [Templating repo and wiki](https://github.com/dotnet/templating/)
- [Example templates for ASP.NET Core](https://github.com/dotnet/aspnetcore/blob/main/src/ProjectTemplates/Web.ItemTemplates/content/ViewStart/.template.config/template.json)

## Contributions

If you discover a problem, please [open an issue](https://github.com/seangwright/xperience-community-dotnet-item-templates/issues/new).

If you would like contribute to the code or documentation, please [open a pull request](https://github.com/seangwright/xperience-community-dotnet-item-templates/compare).

Please refer to the [Code of Conduct](./CODE_OF_CONDUCT.md) when contributing to or opening issues for this repository.
