# ConneX API Developer Quick-Start Guide

Get up and running with ConneX API in minutes. This guide walks you through installation, basic configuration, and common integration patterns.

---

## Prerequisites

- .NET 6.0 SDK or later
- Access to a ConneX system (for testing)
- Basic knowledge of MQTT or GraphQL concepts

---

## Installation

Add the ConneX API packages to your project:

```bash
# For MQTT messaging
dotnet add package DataIO.ConneX.Api.Mqtt

# For GraphQL queries
dotnet add package DataIO.ConneX.Api.GraphQL
```

---

## MQTT Integration

### Understanding Topics

ConneX uses a hierarchical topic structure for MQTT messaging. The API provides topic builders to simplify topic construction:

```csharp
using DataIO.ConneX.Api.Mqtt.Topics;

// Programmer topics
var connectTopic = ProgrammerTopics.ProgrammerConnect("PSV5000-001", "FC-001");
// Result: "connex/psv5000-001/programmer/fc-001/connect"

var completeTopic = ProgrammerTopics.ProgrammingComplete("PSV5000-001", "FC-001");
// Result: "connex/psv5000-001/programmer/fc-001/programming/complete"

// Handler topics (AH700)
var jobBeginTopic = Ah700Topics.JobBegin("AH700-001");
// Result: "connex/ah700-001/job/begin"

// System topics
var sessionTopic = MachineManagerTopics.JobSessionStart("PSV5000-001");
// Result: "connex/psv5000-001/session/start"
```

### Message Types

All messages are strongly-typed C# classes with JSON serialization support:

```csharp
using DataIO.ConneX.Api.Mqtt.Messages.Programmer;
using System.Text.Json;

// Deserialize incoming messages
var json = mqttMessage.Payload;
var message = JsonSerializer.Deserialize<ProgrammingCompleteMessage>(json);

// Access typed properties
Console.WriteLine($"Programmer: {message.ProgrammerId}");
Console.WriteLine($"Result: {message.Result}");
Console.WriteLine($"Duration: {message.ProgrammingDuration}");
```

### Common Message Categories

| Category | Example Messages |
|----------|------------------|
| **Programmer** | `ProgrammerConnectMessage`, `AdapterInsertMessage`, `ProgrammingCompleteMessage` |
| **PSV System** | `JobSessionStartMessage`, `DevicePickedMessage`, `DevicePlacedMessage`, `StatisticsMessage` |
| **Handler** | `JobBeginMessage`, `JobPauseMessage`, `LightTowerStatusMessage` |
| **DMS** | `DownloadBeginMessage`, `DownloadCompleteMessage` |

---

## GraphQL Integration

### Setting Up the Client

```csharp
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services
    .AddConneXGraphQLClient()
    .ConfigureHttpClient(client =>
    {
        client.BaseAddress = new Uri("https://your-connex-server/graphql");
    });

var serviceProvider = services.BuildServiceProvider();
var client = serviceProvider.GetRequiredService<IConneXGraphQLClient>();
```

### Querying Systems

```csharp
// Get all PSV systems
var systems = await client.GetSystems.ExecuteAsync();

foreach (var system in systems.Data.Systems)
{
    Console.WriteLine($"System: {system.Name}");
    Console.WriteLine($"Status: {system.Status}");
    Console.WriteLine($"Programmers: {system.Programmers.Count}");
}
```

### Querying Adapter Metrics

```csharp
// Get adapter statistics with time bucketing
var metrics = await client.GetAdapterMetrics.ExecuteAsync(
    adapterId: "adapter-001",
    startTime: DateTime.UtcNow.AddDays(-7),
    endTime: DateTime.UtcNow,
    bucketSize: TimeSpan.FromHours(1)
);

foreach (var bucket in metrics.Data.AdapterMetrics)
{
    Console.WriteLine($"Time: {bucket.Timestamp}");
    Console.WriteLine($"Pass Count: {bucket.PassCount}");
    Console.WriteLine($"Fail Count: {bucket.FailCount}");
    Console.WriteLine($"Yield: {bucket.Yield:P2}");
}
```

### Querying Message History

```csharp
// Query historical MQTT messages
var messages = await client.GetMqttMessages.ExecuteAsync(
    filter: new MqttMessageFilter
    {
        TopicPattern = "connex/*/programmer/*/programming/complete",
        StartTime = DateTime.UtcNow.AddHours(-24)
    },
    sort: MqttMessageSort.TimestampDesc,
    limit: 100
);
```

---

## Common Integration Patterns

### Pattern 1: Real-Time Dashboard

Subscribe to MQTT topics for live updates, use GraphQL for historical context:

```csharp
// MQTT: Subscribe to live events
mqttClient.Subscribe(ProgrammerTopics.AllProgrammingComplete("PSV5000-001"));

// GraphQL: Load initial state
var currentStats = await graphqlClient.GetSystemStatistics.ExecuteAsync("PSV5000-001");

// Update dashboard on each MQTT message
mqttClient.MessageReceived += (sender, e) =>
{
    var message = JsonSerializer.Deserialize<ProgrammingCompleteMessage>(e.Payload);
    dashboard.UpdateProgrammerStatus(message);
};
```

### Pattern 2: Yield Monitoring

Track manufacturing yield across shifts:

```csharp
// Query yield metrics for the current shift
var shiftStart = GetShiftStartTime();
var metrics = await client.GetHandlerMetrics.ExecuteAsync(
    handlerId: "PSV5000-001",
    startTime: shiftStart,
    endTime: DateTime.UtcNow
);

var totalYield = metrics.Data.HandlerMetrics
    .Where(m => m.TotalDevices > 0)
    .Average(m => m.Yield);

Console.WriteLine($"Current Shift Yield: {totalYield:P2}");
```

### Pattern 3: Equipment Status Monitoring

Monitor all equipment on the factory floor:

```csharp
// Subscribe to connection status for all programmers
var topics = new[]
{
    ProgrammerTopics.ProgrammerConnect("+", "+"),
    ProgrammerTopics.ProgrammerDisconnect("+", "+")
};

foreach (var topic in topics)
{
    mqttClient.Subscribe(topic);
}

// Track equipment status changes
mqttClient.MessageReceived += (sender, e) =>
{
    if (e.Topic.Contains("/connect"))
    {
        var msg = JsonSerializer.Deserialize<ProgrammerConnectMessage>(e.Payload);
        equipmentTracker.MarkOnline(msg.ProgrammerId);
    }
    else if (e.Topic.Contains("/disconnect"))
    {
        var msg = JsonSerializer.Deserialize<ProgrammerDisconnectMessage>(e.Payload);
        equipmentTracker.MarkOffline(msg.ProgrammerId);
    }
};
```

---

## User Roles and Authentication

ConneX supports role-based access with predefined user roles:

```csharp
using DataIO.ConneX.Api.Mqtt.Messages.Common;

// Available roles
var roles = new[]
{
    PsvUserRole.Operator,    // Basic operations
    PsvUserRole.Technician,  // Technical access
    PsvUserRole.Supervisor,  // Supervisory functions
    PsvUserRole.Service      // Service/maintenance
};

// Handle user login events
var loginMessage = JsonSerializer.Deserialize<UserLoginMessage>(payload);
Console.WriteLine($"User {loginMessage.Username} logged in as {loginMessage.Role}");
```

---

## Error Handling

All operations include comprehensive error information:

```csharp
using DataIO.ConneX.Api.Mqtt.Messages.Common;

// Check command responses
var response = JsonSerializer.Deserialize<CommandResponse>(payload);

if (response.Success)
{
    Console.WriteLine("Command executed successfully");
}
else
{
    Console.WriteLine($"Error Code: {response.ErrorCode}");
    Console.WriteLine($"Error Message: {response.ErrorMessage}");
}
```

---

## Next Steps

1. **Explore the Sample Application**: Check `/src/samples/ConneXSampleGraphQl/` for a complete working example
2. **Review API Documentation**: Browse the DocFX-generated docs in `/docs/help/`
3. **Join the Community**: Report issues and contribute at [GitHub](https://github.com/dataio-corporation/connex-api)

---

## Support

- **GitHub Issues**: [Report bugs and request features](https://github.com/dataio-corporation/connex-api/issues)
- **Documentation**: Available in the repository `/docs/` folder
- **License**: Apache 2.0 - Free for commercial and personal use

---

*Build smarter manufacturing integrations with ConneX API*
