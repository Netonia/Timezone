# Timezone Comparator

A Blazor WebAssembly application built with .NET 10 that allows you to compare timezones around the world.

## Features

- 🌍 **Automatic timezone detection** - Detects your browser's timezone automatically
- ⏰ **Real-time updates** - Time updates every second
- 🔍 **Multi-timezone comparison** - Compare your local time with multiple timezones
- 🌓 **Dark/Light mode** - Toggle between dark and light themes
- 📱 **Responsive design** - Works on desktop and mobile devices
- 🚀 **100% client-side** - No server required, hosted on GitHub Pages

## Technology Stack

- **Frontend**: Blazor WebAssembly (.NET 10)
- **Timezone Management**: NodaTime 3.3.0
- **UI Framework**: Bootstrap 5
- **Hosting**: GitHub Pages

## Development

### Prerequisites

- .NET 10 SDK

### Building

```bash
dotnet build TimezoneComparator/TimezoneComparator.csproj
```

### Running locally

```bash
dotnet run --project TimezoneComparator/TimezoneComparator.csproj
```

## Deployment

The application is automatically deployed to GitHub Pages via GitHub Actions when changes are pushed to the main branch.

## License

This project is open source and available under the MIT License.