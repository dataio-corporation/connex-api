# ConneX API Technical Overview

## Simplifying Manufacturing Integration

The **ConneX API** is Data I/O Corporation's open-source integration library that provides standardized interfaces for connecting with the ConneX manufacturing execution system. Built on .NET Standard 2.1, it enables seamless communication through two industry-standard protocols: **MQTT** for real-time messaging and **GraphQL** for flexible data queries.

---

## Why ConneX API?

Modern manufacturing environments demand real-time visibility, seamless system integration, and flexible data access. The ConneX API addresses these challenges by providing:

| Challenge | Solution |
|-----------|----------|
| Custom integration code | Pre-built MQTT topics and GraphQL queries |
| Real-time monitoring | MQTT pub/sub for instant event streaming |
| Data over/under-fetching | GraphQL for precise data retrieval |
| Cross-platform support | .NET Standard 2.1 compatibility |
| Type safety concerns | Strongly-typed C# interfaces |

---

## Architecture at a Glance

```
┌─────────────────────────────────────────────────────────────────┐
│                     Your Application                            │
├─────────────────────────────────────────────────────────────────┤
│  DataIO.ConneX.Api.Mqtt  │  DataIO.ConneX.Api.GraphQL           │
│  ─────────────────────   │  ─────────────────────────           │
│  • 35 Message Types      │  • System Queries                    │
│  • Topic Builders        │  • Performance Metrics               │
│  • Event Subscriptions   │  • Message History                   │
├─────────────────────────────────────────────────────────────────┤
│                    ConneX Platform                              │
│  ┌──────────┐  ┌──────────┐  ┌──────────┐  ┌──────────┐        │
│  │ PSV      │  │ Handler  │  │ Program- │  │ DMS      │        │
│  │ Systems  │  │ (AH/CH)  │  │ mers     │  │ Download │        │
│  └──────────┘  └──────────┘  └──────────┘  └──────────┘        │
└─────────────────────────────────────────────────────────────────┘
```

---

## Core Components

### MQTT Message Library

Real-time event streaming with **35 predefined message types** across five categories:

- **Programmer Events**: Connectivity, adapter operations, programming status
- **PSV System Events**: Job sessions, device lifecycle, system statistics
- **Handler Events (AH700/CH700)**: Job management, light tower status, user operations
- **DMS Events**: Download lifecycle notifications
- **Common Types**: Error codes, responses, user roles

### GraphQL Query Interface

Flexible data access with comprehensive query support:

- **System Queries**: Handler and programmer status across PSV series
- **Adapter Queries**: Metrics, statistics, and lifecycle data
- **Entity Management**: Device and type lookups
- **Performance Metrics**: Time-bucketed analytics for yield and throughput
- **Message History**: Historical MQTT data with filtering and sorting

---

## Supported Equipment

| Category | Models/Types |
|----------|--------------|
| **PSV Systems** | PSV2800, PSV3000, PSV3500, PSV5000, PSV7000 |
| **Programmers** | FlashCore, LumenX |
| **Handlers** | AH700 (Automated), CH700 (Conveyor) |
| **Download Systems** | DMS (Download Management System) |

---

## Technical Specifications

| Specification | Details |
|---------------|---------|
| **Framework** | .NET Standard 2.1 |
| **Language** | C# 10+ |
| **MQTT Serialization** | System.Text.Json 8.0.4 |
| **GraphQL Client** | StrawberryShake 13.5.1 |
| **License** | Apache 2.0 (Open Source) |
| **Distribution** | NuGet Packages |

---

## Platform Compatibility

Built on .NET Standard 2.1 for maximum compatibility:

- .NET Core 3.0+
- .NET 5/6/7/8+
- .NET Framework 4.6.1+ (with compatibility shims)
- Xamarin
- Unity 2018.1+

---

## Quality Assurance

- **StyleCop Analysis**: Enforced code standards
- **Warnings as Errors**: Strict compilation checks
- **Semantic Versioning**: MinVer-based version management
- **CI/CD Pipeline**: GitHub Actions for automated builds and releases
- **Documentation**: DocFX-generated API documentation

---

## Getting Started

### Installation

```bash
# MQTT Package
dotnet add package DataIO.ConneX.Api.Mqtt

# GraphQL Package
dotnet add package DataIO.ConneX.Api.GraphQL
```

### Quick Example

```csharp
// Subscribe to programmer events
var topic = ProgrammerTopics.ProgrammingComplete("PSV5000-001", "FC-001");

// Query adapter statistics
var result = await client.GetAdapterStatistics.ExecuteAsync(adapterId);
```

---

## Learn More

- **GitHub Repository**: [dataio-corporation/connex-api](https://github.com/dataio-corporation/connex-api)
- **API Documentation**: Available in `/docs/help/`
- **Sample Applications**: See `/src/samples/`

---

*ConneX API - Connecting Manufacturing Excellence*

**Data I/O Corporation** | Open Source | Apache 2.0 License
