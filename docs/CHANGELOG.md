# Changelog

All notable changes to QuickServer will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0] - 2025-11-23

### Added
- Initial release of QuickServer
- Support for Nginx web server
- Support for PHP (FastCGI)
- Support for MariaDB database server
- Support for PostgreSQL database server
- Support for Redis in-memory data store
- Control panel with start/stop/restart functionality for all services
- Automatic PATH environment variable configuration for all service binaries (Nginx, PHP, MariaDB, PostgreSQL, Redis)
- Automatic database initialization for PostgreSQL
- Automatic configuration file generation for Redis
- Tray icon with context menu for quick access
- Configuration and log file management through context menus
- Options dialog for configuring service startup behavior
- Auto-start services on application launch option
- Start with Windows option
- PostgreSQL and Redis UI controls in main control panel
- PostgreSQL shell access functionality
- Redis shell access functionality

### Changed
- Based on Wnmp project
- Simplified directory structure (removed -bins suffix and symbolic links for PostgreSQL and Redis)
- Removed automatic MariaDB setup window on application startup (now accessible via menu)
- Updated UI to display all five services (Nginx, MariaDB, PHP, PostgreSQL, Redis)

### Technical Details
- PostgreSQL: Automatic database initialization on first start
- Redis: Automatic default configuration file creation
- All services: Automatic PATH environment variable setup for command-line access
- Service management: PostgreSQL uses Windows service or pg_ctl, Redis runs as process
- UI: All services now have consistent Start/Stop/Restart/Configuration/Logs buttons

