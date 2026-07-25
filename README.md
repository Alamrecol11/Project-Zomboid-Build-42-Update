# PZ Build 42 Updater

> An open-source updater and manager for Project Zomboid Build 42.

![Platform](https://img.shields.io/badge/Platform-Windows-blue)
![.NET](https://img.shields.io/badge/.NET-9.0-purple)
![License](https://img.shields.io/badge/License-MIT-green)

## Overview

PZ Build 42 Updater is a desktop application designed to simplify managing **Project Zomboid Build 42**.

The application provides a simple interface for updating the game, backing up saves, managing Steam Workshop mods, and launching the game—all from one place.

## Screenshots

![photo]()

## Features

- Automatic Project Zomboid Build 42 updates
- SteamCMD integration
- Save backup and restore
- Steam Workshop mod management
- Game file verification
- Game launcher
- Update log
- Automatic application updates *(planned)*
- Modern and user-friendly interface

## Planned Features

- Mod profiles
- Save manager
- Server management
- Performance diagnostics
- Multiple game installations
- Cloud backup support
- Dark & Light themes
- Multi-language support

## Requirements

- Windows 10/11
- .NET 9 Runtime
- Steam
- Project Zomboid Build 42

## Installation

[Download Release](https://github.com/Alamrecol11/Project-Zomboid-Build-42-Update/releases/tag/Release)

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run
```

## Project Structure

```
src/
 ├── PZUpdater.UI
 ├── PZUpdater.Core
 ├── SteamCMD
 ├── Backup
 ├── Workshop
 └── Settings
```

## Roadmap

- [x] Initial UI
- [x] Steam detection
- [x] SteamCMD updater
- [x] Save backup
- [x] Workshop manager
- [x] Game launcher
- [x] Auto updater
- [ ] Stable v1.0 release

## Contributing

Contributions, bug reports, and feature requests are welcome.

Please open an Issue or submit a Pull Request.

## License

This project is licensed under the MIT License.

## Disclaimer

This project is an independent open-source utility

Project Zomboid™ is a trademark of The Indie Stone.
