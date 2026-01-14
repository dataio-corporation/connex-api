# ConneX API Feature Highlights

Discover the powerful capabilities that make ConneX API the go-to solution for manufacturing system integration.

---

## Real-Time Event Streaming

### MQTT-Powered Communication

Stream manufacturing events in real-time with industry-standard MQTT protocol.

**35 Pre-Built Message Types** organized into logical categories:

```
Programmer Events (6)          PSV System Events (16)
├── ProgrammerConnect          ├── JobSessionStart/End
├── ProgrammerDisconnect       ├── DevicePicked
├── AdapterInsert              ├── DevicePlaced
├── AdapterRemove              ├── DeviceInspected
├── ProgrammingComplete        ├── DeviceMarked
└── ProgrammingAbort           ├── StatisticsUpdate
                               └── SystemStatusChange

Handler Events (AH700/CH700)   DMS Events (2)
├── JobBegin/End               ├── DownloadBegin
├── JobPause/Resume            └── DownloadComplete
├── JobAbort
├── LightTowerStatus
└── UserLogin/Logout
```

### Intelligent Topic Builders

Never manually construct topic strings again:

```csharp
// Before: Error-prone manual strings
var topic = $"connex/{systemId}/programmer/{programmerId}/programming/complete";

// After: Type-safe topic builders
var topic = ProgrammerTopics.ProgrammingComplete(systemId, programmerId);
```

**Benefits:**
- Compile-time validation
- IntelliSense support
- Consistent topic structure
- Wildcard support for subscriptions

---

## Flexible Data Access

### GraphQL Query Interface

Request exactly the data you need - no more, no less.

**Available Query Types:**

| Query Category | Capabilities |
|----------------|--------------|
| **Systems** | Status, configuration, connected equipment |
| **Programmers** | FlashCore and LumenX programmer data |
| **Adapters** | Statistics, metrics, lifecycle information |
| **Entities** | Device and type management |
| **Metrics** | Time-bucketed performance analytics |
| **Messages** | Historical MQTT message queries |

### Performance Metrics

Track manufacturing KPIs with built-in analytics:

```graphql
query GetHandlerMetrics($handlerId: ID!, $start: DateTime!, $end: DateTime!) {
  handlerMetrics(handlerId: $handlerId, startTime: $start, endTime: $end) {
    timestamp
    yield
    availability
    unitsPerHour
    passCount
    failCount
  }
}
```

**Supported Metrics:**
- **Yield**: Pass/fail ratios over time
- **Throughput**: Units per hour (UPH)
- **Availability**: Equipment uptime percentage
- **Socket Statistics**: Per-socket performance tracking
- **Adapter Lifecycle**: Actuation counts, lifetime tracking

---

## Comprehensive Equipment Support

### PSV System Series

Full support for Data I/O's programming system lineup:

| Model | Description | Use Case |
|-------|-------------|----------|
| **PSV2800** | Entry-level system | Low-volume production |
| **PSV3000** | Mid-range system | Medium-volume production |
| **PSV3500** | Advanced system | High-mix production |
| **PSV5000** | High-performance | High-volume production |
| **PSV7000** | Enterprise system | Maximum throughput |

### Programmer Types

- **FlashCore**: High-speed flash programming
- **LumenX**: Universal device programming

### Automated Handlers

- **AH700**: Automated handler for production environments
- **CH700**: Conveyor handler for inline integration

---

## Device Lifecycle Tracking

Follow devices through every manufacturing stage:

```
┌─────────┐    ┌─────────┐    ┌─────────┐    ┌─────────┐    ┌─────────┐
│  PICK   │───▶│  PLACE  │───▶│ PROGRAM │───▶│ INSPECT │───▶│  MARK   │
└─────────┘    └─────────┘    └─────────┘    └─────────┘    └─────────┘
     │              │              │              │              │
     ▼              ▼              ▼              ▼              ▼
DevicePicked  DevicePlaced  Programming   DeviceInspected  DeviceMarked
  Message       Message      Complete         Message        Message
                             Message
```

**Track Every Event:**
- Pick location and timestamp
- Placement coordinates
- Programming result and duration
- Inspection outcome
- Marking verification

---

## User Management & Security

### Role-Based Access Control

Built-in support for manufacturing user roles:

```csharp
public enum PsvUserRole
{
    Operator,    // Day-to-day operations
    Technician,  // Technical troubleshooting
    Supervisor,  // Team oversight
    Service      // Maintenance access
}
```

### User Activity Tracking

Monitor user sessions across your factory:

- **Login/Logout Events**: Track user sessions
- **Role Verification**: Ensure proper access levels
- **Activity Logging**: Audit trail for compliance

---

## Cross-Platform Compatibility

### .NET Standard 2.1

Deploy anywhere .NET runs:

```
Windows Desktop    │  Linux Server     │  Cloud Services
───────────────────┼───────────────────┼─────────────────
.NET Framework     │  .NET Core        │  Azure Functions
WPF Applications   │  Docker Containers│  AWS Lambda
Windows Services   │  Kubernetes       │  Google Cloud
```

**Supported Runtimes:**
- .NET Core 3.0+
- .NET 5/6/7/8+
- .NET Framework 4.6.1+
- Xamarin (iOS/Android)
- Unity 2018.1+

---

## Developer Experience

### Type-Safe Integration

Eliminate runtime errors with strongly-typed C# interfaces:

```csharp
// Compile-time type checking
var message = new ProgrammingCompleteMessage
{
    ProgrammerId = "FC-001",
    Result = ProgrammingResult.Success,  // Enum - can't misspell
    Duration = TimeSpan.FromSeconds(2.5)
};

// IDE autocomplete for all properties
message.  // IntelliSense shows all available properties
```

### Comprehensive Documentation

- **XML Documentation**: IntelliSense tooltips in your IDE
- **DocFX Site**: Searchable API reference
- **Sample Applications**: Working code examples
- **This Guide**: Step-by-step tutorials

### Modern C# Features

Built with the latest language features:

```csharp
// Record types for immutable messages
public record ProgrammingCompleteMessage(
    string ProgrammerId,
    ProgrammingResult Result,
    TimeSpan Duration
);

// Nullable reference types for null safety
public string? ErrorMessage { get; init; }

// Pattern matching for message handling
var result = message switch
{
    { Result: ProgrammingResult.Success } => "Passed",
    { Result: ProgrammingResult.Failure } => "Failed",
    _ => "Unknown"
};
```

---

## Quality & Reliability

### Production-Ready

- **Battle-Tested**: Used internally at Data I/O Corporation
- **Semantic Versioning**: Predictable version management
- **CI/CD Pipeline**: Automated testing and releases
- **Code Analysis**: StyleCop-enforced standards

### Open Source Benefits

- **Apache 2.0 License**: Use commercially without restrictions
- **Community Contributions**: Accept improvements from users
- **Transparent Development**: Full source code visibility
- **No Vendor Lock-in**: Fork and customize as needed

---

## Quick Comparison

### Why ConneX API vs. Custom Integration?

| Aspect | Custom Integration | ConneX API |
|--------|-------------------|------------|
| **Development Time** | Weeks to months | Hours to days |
| **Topic Management** | Manual strings | Type-safe builders |
| **Message Parsing** | Custom serialization | Pre-built types |
| **Query Flexibility** | Fixed endpoints | GraphQL queries |
| **Maintenance** | Your responsibility | Community + Data I/O |
| **Documentation** | Build from scratch | Comprehensive docs |
| **Type Safety** | Varies | Full C# type checking |
| **Cost** | Development hours | Free (Apache 2.0) |

---

## Get Started Today

```bash
dotnet add package DataIO.ConneX.Api.Mqtt
dotnet add package DataIO.ConneX.Api.GraphQL
```

**Resources:**
- [GitHub Repository](https://github.com/dataio-corporation/connex-api)
- [Developer Quick-Start Guide](./DEVELOPER_QUICKSTART.md)
- [Technical Overview](./TECHNICAL_OVERVIEW.md)

---

*ConneX API - Manufacturing Integration Made Simple*

**Data I/O Corporation** | Open Source | Apache 2.0 License
