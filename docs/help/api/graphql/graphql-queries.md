# Queries
ConneX exposes the following GraphQL queries:

Query                                                 | Description
------------------------------------------------------|------------------------------------------------------------------------------------------------
[`adapterMetrics`](#adaptermetrics)                   | Get metrics for the specified adapter.
[`adapters`](#adapters)                               | Look up all the known adapters connected to this instance of ConneX.
[`entities`](#entities)                               | Look up all the known entities connected to this instance of ConneX.
[`entityTypes`](#entitytypes)                         | Look up all the known entity types that can be connected to this instance of ConneX.
[`handlerMetrics`](#handlermetrics)                   | Get metrics for the specified PSV system.
[`latestAdapterStatistics`](#latestadapterstatistics) | Get the latest metric entries for the specified adapter.
[`latestHandlerStatistics`](#latesthandlerstatistics) | Get the latest metric entries for the specified PSV system.
[`license`](#license)                                 | Get the installed license information.
[`message`](#message)                                 | Get the last received MQTT message.
[`messages`](#messages)                               | Get all MQTT messages.
[`programmers`](#programmers)                         | Look up all the known programmers connected to this instance of ConneX.
[`programmerTypes`](#programmertypes)                 | Look up all the known programmer system types that can be connected to this instance of ConneX.
[`system`](#system)                                   | Look up a singular PSV system by its database ID.
[`systems`](#systems)                                 | Look up all the known PSV systems connected to this instance of ConneX.
[`systemTypes`](#systemtypes)                         | Look up all the known PSV system types that can be connected to this instance of ConneX.

## adapterMetrics
---
**Type:** [`[AdapterMetrics]`](graphql-objects.md#adaptermetrics)

Get metrics for the specified adapter.

### Arguments
Name                                                     | Description
---------------------------------------------------------|----------------------------------------------------------------------------------------
`adapterIdentifier` ([`String`](graphql-scalars.md))     | The adapter's unique identifier.
`interval` ([`Interval`](graphql-objects.md#interval))   | An [`Interval`](graphql-objects.md#interval) defining how far back to query.
`timeBucket` ([`Interval`](graphql-objects.md#interval)) | An [`Interval`](graphql-objects.md#interval) over which the metrics will be aggregated.

### Example

# [Request](#tab/tabid-adapters-metrics-request)

```graphql
query{
  adapterMetrics(adapterIdentifier: "222-032-205-139-137-224-207-100-238"
    interval: "1 hour"
    timeBucket: "15 minutes")
    {
      timeStamp
      blankCheckDuration
      eraseDuration
      programmingDuration
      verifyDuration
    }
}
```

# [Response](#tab/tabid-adapters-metrics-response)

```json
{
  "data": {
    "adapterMetrics": [
      {
        "timeStamp": "2022-10-06T11:30:00.000-07:00",
        "blankCheckDuration": 901358,
        "eraseDuration": 896337,
        "programmingDuration": 904021,
        "verifyDuration": 895560
      },
      {
        "timeStamp": "2022-10-06T11:15:00.000-07:00",
        "blankCheckDuration": 895828,
        "eraseDuration": 904213,
        "programmingDuration": 898582,
        "verifyDuration": 898548
      },
      {
        "timeStamp": "2022-10-06T11:00:00.000-07:00",
        "blankCheckDuration": 895486,
        "eraseDuration": 895593,
        "programmingDuration": 902716,
        "verifyDuration": 896741
      },
      {
        "timeStamp": "2022-10-06T10:45:00.000-07:00",
        "blankCheckDuration": 900471,
        "eraseDuration": 897392,
        "programmingDuration": 898490,
        "verifyDuration": 899448
      }
    ]
  }
}
```

***

## adapters
---
**Type:** [`AdapterModel`](graphql-objects.md#adaptermodel)

Look up all the known adapters connected to this instance of ConneX.

### Example

# [Request](#tab/tabid-adapters-request)

```graphql
query { 
  adapters {
    adapterId
  }
}
```

# [Response](#tab/tabid-adapters-response)

```json
{
  "data": {
    "adapters": [
      {
        "adapterId": "110008"
      },
      {
        "adapterId": "110008"
      },
      {
        "adapterId": "110008"
      },
      {
        "adapterId": "110008"
      },
      {
        "adapterId": "310008"
      },
      {
        "adapterId": "310008"
      }
    ]
  }
}
```

***

## entities
---
**Type:** [`[Entity]`](graphql-objects.md#entity)

Look up all the known entities connected to this instance of ConneX.

### Example

# [Request](#tab/tabid-entities-request)

```graphql
query {
    entities {
        entityIdentifier
        entityType
        entityName
    }
}
```

# [Response](#tab/tabid-entities-response)

```json
{
  "data": {
    "entities": [
      {
        "entityIdentifier": "42707786-1a5b-4b2f-9c0d-9512bb30cbb0",
        "entityType": "HANDLER",
        "entityName": "PSV2800 #1"
      },
      {
        "entityIdentifier": "ee232edf-05ef-4407-a4e4-1d0431099e97",
        "entityType": "HANDLER",
        "entityName": "PSV3000 #1"
      },
      {
        "entityIdentifier": "853be1da-0847-4a85-b499-208c37ce40fb",
        "entityType": "HANDLER",
        "entityName": "PSV5000 #1"
      },
      {
        "entityIdentifier": "777425b0-300e-43d6-b40a-0f94c57559fa",
        "entityType": "HANDLER",
        "entityName": "PSV5000 #2"
      },
      {
        "entityIdentifier": "5573f981-10c4-4466-adf2-c68039cb9983",
        "entityType": "HANDLER",
        "entityName": "PSV7000 #1"
      },
      {
        "entityIdentifier": "ee496e4a-2b14-4cd2-af6a-bb92ad9fa015",
        "entityType": "HANDLER",
        "entityName": "PSV7000 #2"
      },
      {
        "entityIdentifier": "D1:AD:0D:28:26:9E",
        "entityType": "PROGRAMMER",
        "entityName": "FC - 1"
      },
      {
        "entityIdentifier": "D1:AD:0D:28:26:9E_Socket0",
        "entityType": "ADAPTER",
        "entityName": null
      }
    ]
  }
}
```

***

## entityTypes
---
**Type:** [`[EntityType!]`](graphql-enums.md#entitytype)

Look up all the known entity types that can be connected to this instance of ConneX.

### Example

# [Request](#tab/tabid-entityTypes-request)

```graphql
query { 
  entityTypes
}
```

# [Response](#tab/tabid-entityTypes-response)

```json
{
  "data": {
    "entityTypes": [
      "HANDLER",
      "PROGRAMMER",
      "ADAPTER",
      "JOB"
    ]
  }
}
```

***

## handlerMetrics
---
**Type:** [`[HandlerMetrics]`](graphql-objects.md#handlermetrics)

Get metrics for the specified PSV system.

### Arguments
Name                                                     | Description
---------------------------------------------------------|----------------------------------------------------------------------------------------
`handlerIdentifier` ([`String`](graphql-scalars.md))     | The PSV system's unique identifier.
`interval` ([`Interval`](graphql-objects.md#interval))   | An [`Interval`](graphql-objects.md#interval) defining how far back to query.
`timeBucket` ([`Interval`](graphql-objects.md#interval)) | An [`Interval`](graphql-objects.md#interval) over which the metrics will be aggregated.

### Example

# [Request](#tab/tabid-handlerMetrics-request)

```graphql
query{
  handlerMetrics(handlerIdentifier: "42707786-1a5b-4b2f-9c0d-9512bb30cbb0"
    interval: "1 hour"
    timeBucket: "15 minutes")
    {
      timeStamp
      jobState
      uptime
      jobProcessingTime
      unitsPerHour
      yield
    }
}
```

# [Response](#tab/tabid-handlerMetrics-response)

```json
{
  "data": {
    "handlerMetrics": [
      {
        "timeStamp": "2022-10-06T12:01:57.173-07:00",
        "jobState": null,
        "uptime": 892,
        "jobProcessingTime": null,
        "unitsPerHour": 500,
        "yield": 0.9923533439853912
      },
      {
        "timeStamp": "2022-10-06T11:46:57.173-07:00",
        "jobState": null,
        "uptime": 597,
        "jobProcessingTime": null,
        "unitsPerHour": 503,
        "yield": 0.9923533439853912
      },
      {
        "timeStamp": "2022-10-06T11:31:57.173-07:00",
        "jobState": null,
        "uptime": 1187,
        "jobProcessingTime": 873,
        "unitsPerHour": 498,
        "yield": 0.9923533439853912
      },
      {
        "timeStamp": "2022-10-06T11:16:57.173-07:00",
        "jobState": null,
        "uptime": 890,
        "jobProcessingTime": 884,
        "unitsPerHour": 487,
        "yield": 0.9923533439853912
      }
    ]
  }
}
```

***

## latestAdapterStatistics
---
**Type:** [`[AdapterStatistics]`](graphql-objects.md#adapterstatistics)

Get the latest statistics for the specified adapter.

### Arguments
Name                                                | Description
----------------------------------------------------|---------------------------------
`entityIdentifier` ([`String`](graphql-scalars.md)) | The adapter's unique identifier.

### Example

# [Request](#tab/tabid-latestAdapterStatistics-request)

```graphql
query {
  latestAdapterStatistics(
    entityIdentifier: "136-043-225-168-137-224-207-100-238"
  )
  {
    adapterId
    cleanCount
    lifetimeActuationCount
    lifetimeContinuityFailCount
    lifetimeFailCount
    lifetimePassCount
    socketIndex
    adapterState
  }
}
```

# [Response](#tab/tabid-latestAdapterStatistics-response)

```json
{
  "data": {
    "latestAdapterStatistics": {
      "adapterId": "110008",
      "cleanCount": 2,
      "lifetimeActuationCount": 4955,
      "lifetimeContinuityFailCount": 25,
      "lifetimeFailCount": 70,
      "lifetimePassCount": 9713,
      "socketIndex": 4,
      "adapterState": "VALIDATED"
    }
  }
}
```

***

## latestHandlerStatistics
---
**Type:** [`[HandlerStatistics]`](graphql-objects.md#handlerstatistics)

Get the latest statistics for the specified PSV system.

### Arguments
Name                                                | Description
----------------------------------------------------|------------------------------------
`entityIdentifier` ([`String`](graphql-scalars.md)) | The PSV system's unique identifier.

### Example

# [Request](#tab/tabid-latestHandlerStatistics-request)

```graphql
query { 
  latestHandlerStatistics(entityIdentifier:"4826196c-0866-44f4-afa0-d331bcfd04eb")
  { 
    currentJob
    availability
    uptime
    totalPass
    totalFail
    systemYield
    programmerYield
    handlerYield
    uPH
    jobCompletionEstimate
  }
}
```
# [Response](#tab/tabid-latestHandlerStatistics-response)

```json
{
  "data": {
    "latestHandlerStatistics": {
      "currentJob": "MX 29LV160DBTI",
      "availability": "100.00",
      "uptime": "100.00",
      "totalPass": 189,
      "totalFail": 3,
      "systemYield": "98.44",
      "programmerYield": "98.44",
      "handlerYield": "100.00",
      "uPH": 1859,
      "jobCompletionEstimate": "6/8/2022 11:35:18 AM"
    }
  }
}
```

***

## license
---
**Type:** [`[LicenseModel]`](graphql-objects.md#licensemodel)

Get the installed license information.

### Example

# [Request](#tab/tabid-license-request)

```graphql
query {
  license {
    licenseType
    maxConnections
    availableConnections
    conneXAnnualMaintenanceContract
    timedLicenseExpiration
  }
}
```
# [Response](#tab/tabid-license-response)

```json
{
  "data": {
    "license": {
      "licenseType": "Perpetual",
      "maxConnections": 10,
      "availableConnections": 9,
      "conneXAnnualMaintenanceContract": "2023-06-01T00:00:00.000-07:00",
      "timedLicenseExpiration": "0001-01-01T00:00:00.000-08:00"
    }
  }
}
```

***

## message
---
**Type:** [`MessageModel`](graphql-objects.md#messagemodel)

Get the last received MQTT message.

### Example

# [Request](#tab/tabid-message-request)

```graphql
query {
  message
  {
    topic
    timestamp
  }
}
```

# [Response](#tab/tabid-message-response)

```json
{
  "data": {
    "message": {
      "topic": "connex/programmer/currentprogrammerstatuses",
      "timestamp": "2021-12-21T21:48:28.514-08:00"
    }
  }
}
```

***

## messages
---
**Type:** [`MessageModelCollectionSegment`](graphql-objects.md#messagemodelcollectionsegment)

Get all MQTT messages using paging (maximum of 50 items per page).

### Arguments
Name                                                                                   | Description
---------------------------------------------------------------------------------------|-----------------------------------------
`skip` ([`Int`](graphql-scalars.md))                                                   | The number of messages to skip.
`take` ([`Int`](graphql-scalars.md))                                                   | The number of messages to return.
`where` ([MessageModelFilterInput](graphql-input-objects.md#messagemodelfilterinput))  | The Filter to apply to the messages.
`order` ([`[MessageModelSortInput!]`](graphql-input-objects.md#messagemodelsortinput)) | The sort order to apply to the messages.

### Example

# [Request](#tab/tabid-messages-request)

```graphql
query { 
  messages (take:1) {
    totalCount
    items {
      topic 
      contentType
      timestamp 
      messageModelId 
      payloadAsString 
    } 
  }
}
```

# [Response](#tab/tabid-messages-response)

```json
{
  "data": {
    "messages": {
      "totalCount": 138,
      "items": [
        {
          "topic": "connex/programmer/lumenx/legacy/connected",
          "contentType": null,
          "timestamp": "2022-01-05T21:38:26.835-08:00",
          "messageModelId": "f89a9ea5-cb22-4c32-811e-9fe08f3e6cab",
          "payloadAsString": "{\"ProgrammerIdentifier\":\"\",\"HandlerIdentifer\":\"323bcb6c-3e40-4678-98a8-d373e38144af\",\"IpAddress\":\"127.0.0.1\",\"ProgrammerType\":1,\"ProgrammerName\":\"LX-1\",\"Adapters\":[]}"
        }
      ]
    }
  }
}
```

***
## programmers
---
**Type:** [`[ProgrammerModel]`](graphql-objects.md#programmermodel)

Look up all the known programmers connected to this instance of ConneX.

### Example

# [Request](#tab/tabid-programmers-request)

```graphql
query { 
  programmers {
    programmerId
    ipAddress
    programmerType
  }
}
```

# [Response](#tab/tabid-programmers-response)

```json
{
  "data": {
    "programmers": [
      {
        "programmerId": 2,
        "ipAddress": "192.168.1.1",
        "programmerType": "FLASH_CORE"
      },
      {
        "programmerId": 3,
        "ipAddress": "192.168.1.2",
        "programmerType": "FLASH_CORE"
      },
      {
        "programmerId": 4,
        "ipAddress": "192.168.1.3",
        "programmerType": "FLASH_CORE"
      },
      {
        "programmerId": 5,
        "ipAddress": "192.168.1.4",
        "programmerType": "FLASH_CORE"
      },
      {
        "programmerId": 6,
        "ipAddress": "192.168.1.5",
        "programmerType": "FLASH_CORE"
      },
      {
        "programmerId": 7,
        "ipAddress": "10.0.0.0",
        "programmerType": "LUMEN_X"
      }
    ]
  }
}
```

***

## programmerTypes
---
**Type:** [`[ProgrammerType!]`](graphql-enums.md#programmertype)

Look up all the known programmer system types that can be connected to this instance of ConneX.

### Example

# [Request](#tab/tabid-programmerTypes-request)

```graphql
query { 
  programmerTypes
}
```

# [Response](#tab/tabid-programmerTypes-response)

```json
{
  "data": {
    "programmerTypes": [
      "FLASH_CORE",
      "LUMEN_X"
    ]
  }
}
```

***

## system
---
**Type:** [`Handler`](graphql-objects.md#handler)

Look up a singular PSV system by its database ID.

### Arguments
Name                                        | Description
--------------------------------------------|----------------------------------------
`databaseId` ([`Int!`](graphql-scalars.md)) | The database identifier of the handler.

### Example

# [Request](#tab/tabid-system-request)

```graphql
query { 
    system (databaseId: 1) {
      handlerId
    }
}
```

# [Response](#tab/tabid-system-response)

```json
{
  "data": {
    "system": {
      "handlerId": 1,
      "handlerType": "PSV2800",
      "ipAddress": "172.16.0.1",
      "hostName": "PSV-1",
      "machineFactory": null
    }
  }
}
```

***

## systems
---
**Type:** [`[Handler]`](graphql-objects.md#handler)

Look up all the known PSV systems connected to this instance of ConneX.

### Example

# [Request](#tab/tabid-systems-request)

```graphql
query { 
    systems {
        handlerId
        handlerType
        ipAddress
        hostName
        machineFactory
    }
}
```

# [Response](#tab/tabid-systems-response)

```json
{
  "data": {
    "systems": [
      {
        "handlerId": 1,
        "handlerType": "PSV2800",
        "ipAddress": "172.16.0.1",
        "hostName": "PSV-1",
        "machineFactory": null
      },
      {
        "handlerId": 2,
        "handlerType": "PSV3000",
        "ipAddress": "172.16.0.2",
        "hostName": "PSV-2",
        "machineFactory": null
      },
      {
        "handlerId": 3,
        "handlerType": "PSV5000",
        "ipAddress": "172.16.0.3",
        "hostName": "PSV-3",
        "machineFactory": null
      },
      {
        "handlerId": 4,
        "handlerType": "PSV5000",
        "ipAddress": "172.16.0.11",
        "hostName": "PSV-6",
        "machineFactory": null
      },
      {
        "handlerId": 5,
        "handlerType": "PSV7000",
        "ipAddress": "172.16.0.9",
        "hostName": "PSV-4",
        "machineFactory": null
      },
      {
        "handlerId": 6,
        "handlerType": "PSV7000",
        "ipAddress": "172.16.0.10",
        "hostName": "PSV-5",
        "machineFactory": null
      }
    ]
  }
}
```

***

## systemTypes
---
**Type:** [`[HandlerType!]`](graphql-enums.md#handlertype)

Look up all the known PSV system types that can be connected to this instance of ConneX.

### Example

# [Request](#tab/tabid-systemTypes-request)

```graphql
query { 
  systemTypes
}
```

# [Response](#tab/tabid-systemTypes-response)

```json
{
  "data": {
    "systemTypes": [
      "DESKTOP",
      "PSV2800",
      "PSV3000",
      "PSV5000",
      "PSV7000"
    ]
  }
}
```

***
