# Xperience Community: .NET Item Templates

[![CI: Build and Test](https://github.com/seangwright/xperience-community-dotnet-item-templates/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/seangwright/xperience-community-dotnet-item-templates/actions/workflows/ci.yml)

[![Release: Publish to NuGet](https://github.com/seangwright/xperience-community-dotnet-item-templates/actions/workflows/publish.yml/badge.svg?branch=main)](https://github.com/seangwright/xperience-community-dotnet-item-templates/actions/workflows/publish.yml)

.NET CLI Item Templates for Xperience by Kentico projects, usable at the command line or in Visual Studio

## Setup

### Install

[![NuGet Package](https://img.shields.io/nuget/v/XperienceCommunity.DotnetItemTemplates.svg)](https://www.nuget.org/packages/XperienceCommunity.DotnetItemTemplates)

Install the `XperienceCommunity.DotnetItemTemplates` NuGet Template package globally:

```bash
dotnet new install XperienceCommunity.DotnetItemTemplates
```

### Use

Use the templates in Visual Studio or at the command line:

```bash
dotnet new xpc-page-builder-widget -n HeroWidget -o .\MySite.Web\Components\Widgets
```

This will generate a new folder automatically: `.\MySite.Web\Components\Widgets\Hero` containing the following files:

- `HeroWidget.cs`
- `Hero.cshtml`

To view the list of all the templates that are installed with this package run `dotnet new list` at the command line.

## Screenshots

![Visual Studio new item dialog](https://raw.githubusercontent.com/seangwright/xperience-community-dotnet-item-templates/main/images/vs-new-item-dialog.jpg)

![Using the Widget Item Template in Visual Studio](https://raw.githubusercontent.com/seangwright/xperience-community-dotnet-item-templates/main/images/xperience-widget-vs-template.webp)

## Templates

This package includes the following item templates.

### Required Suffix

**Note**: Each template has a required suffix for the name of the item you are scaffolding. You can use any name you want as long as you include the suffix at the end of the name.

### Admin

- [Admin Module](https://docs.xperience.io/xp/developers-and-admins/customization/extend-the-administration-interface/prepare-your-environment-for-admin-development#Prepareyourenvironmentforadmindevelopment-Renametheboilerplateproject)

  - Required suffix `AdminModule`

    `dotnet new xpc-admin-module -n AppleAdminModule -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\AppleAdminModule.cs`

- [Admin Application Page](https://docs.xperience.io/x/2gSiCQ)
  - Required suffix `ApplicationPage`
  
    `dotnet new xpc-admin-application-page -n AppleApplicationPage -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\AppleApplicationPage.cs`

- [Admin Edit Page](https://docs.xperience.io/x/1IouCw)

  - Required suffix `EditPage`

    `dotnet new xpc-admin-edit-page -n AppleEditPage -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\AppleEditPage.cs`

- [Admin Edit Section Page](https://docs.xperience.io/x/1IouCw)

  - Required suffix `EditSectionPage`

    `dotnet new xpc-admin-edit-section-page -n AppleEditSectionPage -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\AppleEditSectionPage.cs`  

- [Admin List Page](https://docs.xperience.io/x/1oouCw)

  - Required suffix `ListPage`

    `dotnet new xpc-admin-list-page -n AppleListPage -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\AppleListPage.cs`

- [Admin Create Page](https://docs.xperience.io/xp/developers-and-admins/customization/extend-the-administration-interface/ui-pages/reference-ui-page-templates/edit-ui-page-template#EditUIpagetemplate-Useeditpagestocreatenewobjects)

  - Required suffix `CreatePage`

    `dotnet new xpc-admin-create-page -n AppleCreatePage -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\AppleCreatePage.cs`

- [Admin Page Extender](https://docs.xperience.io/x/4gSiCQ)

  - Required suffix `PageExtender`

    `dotnet new xpc-admin-page-extender -n ApplePageExtender -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\ApplePageExtender.cs`

- [Admin UI Form Component](https://docs.xperience.io/x/5ASiCQ)

  - Required suffix `FormComponent`

    `dotnet new xpc-admin-ui-form-component -n AppleFormComponent -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\AppleFormcomponent.cs`

- [Admin UI Form Component (TSX))](https://docs.xperience.io/xp/developers-and-admins/customization/extend-the-administration-interface/ui-form-components#UIformcomponents-Formcomponentfrontend)

  - Required suffix `FormComponent`

    `dotnet new xpc-admin-ui-form-component-client -n AppleFormComponent -o .\App.Admin\Client\src\apples`

  - Generates

    `.\App.Admin\Client\src\apples\AppleFormComponent.tsx`

- [Validation Rule](https://docs.xperience.io/x/6QSiCQ)

  - Required suffix `ValidationRule`

    `dotnet new xpc-admin-validation-rule -n FreshAppleValidationRule -o .\App.Admin\Apples`

  - Generates

    `.\App.Admin\Apples\FreshAppleValidationRule.cs`

- [Validation Rule (TypeScript)](https://docs.xperience.io/xp/developers-and-admins/customization/extend-the-administration-interface/ui-form-components/ui-form-component-validation-rules#UIformcomponentvalidationrules-Validationrulefrontend)

  - Required suffix `ValidationRule`

    `dotnet new xpc-admin-validation-rule-client -n AppleValidationRule -o .\App.Admin\Client\src\apples`

  - Generates

    `.\App.Admin\Client\src\apples\AppleValidationRule.tsx`

### Form Builder

- [Form Component](https://docs.xperience.io/x/YIbWCQ)

  - Required suffix `FormComponent`

    `dotnet new xpc-form-builder-form-component -n AppleFormComponent -o .\App.Web\Components\FormComponents`

  - Generates

    `.\App.Web\Components\FormComponents\Apple\AppleFormComponent.cs`

    `.\App.Web\Components\FormComponents\Apple\Apple.cshtml`

- [Form Section](https://docs.xperience.io/x/ZYbWCQ)

  - Required suffix `FormSection`

    `dotnet new xpc-form-builder-form-section -n AppleFormSection -o .\App.Web\Components\FormSections`

  - Generates

    `.\App.Web\Components\FormSections\Apple\AppleFormSection.cs`

    `.\App.Web\Components\FormSections\Apple\Apple.cshtml`

### Page Builder

- [Widget](https://docs.xperience.io/xp/developers-and-admins/development/builders/page-builder/widgets-for-page-builder#WidgetsforPageBuilder-Widgetsbasedonaviewcomponent)

  - Required suffix `Widget`

    `dotnet new xpc-page-builder-widget -n AppleWidget -o .\App.Web\Components\Widgets`

  - Generates

    `.\App.Web\Components\Widgets\Apple\AppleWidget.cs`

    `.\App.Web\Components\Widgets\Apple\Apple.cshtml`

- [Section](https://docs.xperience.io/xp/developers-and-admins/development/builders/page-builder/sections-for-page-builder#SectionsforPageBuilder-Sectionsbasedonaviewcomponent)

  - Required suffix `Section`

    `dotnet new xpc-page-builder-section -n AppleSection -o .\App.Web\Components\Sections`

  - Generates

    `.\App.Web\Components\Sections\Apple\AppleSection.cs`

    `.\App.Web\Components\Sections\Apple\Apple.cshtml`

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
