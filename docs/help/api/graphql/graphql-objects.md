# Objects
ConneX exposes the following GraphQL objects:

## AdapterMetrics
---
Represents metrics related to an adapter.

### Fields
Name                                                 | Description
-----------------------------------------------------|------------------------------------------------------------
`blankCheckDuration` ([`Int!`](graphql-scalars.md))  | The duration for a blank check operation (in milliseconds).
`eraseDuration` ([`Int!`](graphql-scalars.md))       | The duration for an erase operation (in milliseconds).
`id` ([`Long!`](graphql-scalars.md))                 | The metric's index.
`identifier` ([`String!`](graphql-scalars.md))       | The entity identifier for the metric.
`programmingDuration` ([`Int!`](graphql-scalars.md)) | The duration for a programming operation (in milliseconds).
`timeStamp` ([`DateTime!`](graphql-scalars.md))      | The time stamp for the metric.
`verifyDuration` ([`Int!`](graphql-scalars.md))      | The duration for a verify operation (in milliseconds).

## AdapterModel
--- 
Represents an adapter for a programmer.

### Fields
Name                                                 | Description
-----------------------------------------------------|-------------------------------------------------
`adapterKey` ([`Int!`](graphql-scalars.md))          | The database key for the adapter.
`entity` ([`Entity`](#entity))                       | The associated entity for this adapter.
`programmer` ([`ProgrammerModel`](#programmermodel)) | The last associated programmer for this adapter.
`adapterId` ([`String`](graphql-scalars.md))         | The adapter's part number identifier.
## AdapterStatistics
---
Represents an adapter's statistics.

### Fields
Name                                                                  | Description
----------------------------------------------------------------------|---------------------------------------------------------------
`adapterId` ([`String`](graphql-scalars.md))                          | The adapter's ID.
`cleanCount` ([`UnsignedInt!`](graphql-scalars.md))                   | The adapter's clean count.
`lifetimeActuationCount` ([`UnsignedInt!`](graphql-scalars.md))       | The adapter's lifetime actuation count.
`lifetimeContinuityFailCount`: ([`UnsignedInt!`](graphql-scalars.md)) | The adapter's lifetime continuity fail count.
`lifetimeFailCount` ([`UnsignedInt!`](graphql-scalars.md))            | The adapter's lifetime fail count.
`lifetimePassCount` ([`UnsignedInt!`](graphql-scalars.md))            | The adapter's lifetime pass count.
`socketIndex` ([`Int!`](graphql-scalars.md))                          | The adapter's socket index.
`adapterState` ([`AdapterState!`](graphql-enums.md#adapterstate))     | The adapter's [`AdapterState`](graphql-enums.md#adapterstate).


## CollectionSegmentInfo
--- 
Information about the offset pagination.

### Fields
Name                                                 | Description
-----------------------------------------------------|---------------------------------------------------------------------------------------
`hasNextPage` ([`Boolean!`](graphql-scalars.md))     | Indicates whether more items exist following the set defined by the clients arguments.
`hasPreviousPage` ([`Boolean!`](graphql-scalars.md)) | Indicates whether more items exist prior the set defined by the clients arguments.

## Entity
--- 
Represents an abstract component that is connected to the ConneX system.

### Fields
Name                                                        | Description
------------------------------------------------------------|--------------------------------------
`id` ([`Int!`](graphql-scalars.md))                         | The database key for the entity.
`entityIdentifier` ([`String`](graphql-scalars.md))         | The unique identifier for the entity.
`entityType` ([`EntityType!`](graphql-enums.md#entitytype)) | The type the entity represents.
`entityName` ([`String`](graphql-scalars.md))               | The given name of the entity.

## Handler
--- 
Represents a PSV system connected to ConneX.

### Fields
Name                                                           | Description
---------------------------------------------------------------|-----------------------------------------------------
`handlerId` ([`Int!`](graphql-scalars.md))                     | The database key for the PSV system.
`entity` ([`Entity`](#entity))                                 | The associated entity for this PSV system.
`programmers` ([`[ProgrammerModel]`](#programmermodel))        | The associated programmers for this PSV system.
`handlerType` ([`HandlerType!`](graphql-enums.md#handlertype)) | The PSV system's type (e.g. PSV2800/3000/3500/5000/7000).
`ipAddress` ([`String`](graphql-scalars.md))                   | The PSV system's IP address.
`hostName` ([`String`](graphql-scalars.md))                    | The PSV system's computer host name.
`machineFactory` ([`String`](graphql-scalars.md))              | The PSV system's associated factory.

## HandlerMetrics
---
Represents metrics related to a handler system.

### Fields
Name                                                 | Description
-----------------------------------------------------|----------------------------------------------------
`id` ([`Long!`](graphql-scalars.md))                 | The metric's index.
`identifier` ([`String`](graphql-scalars.md))        | The entity identifier for the metric.
`jobProcessingTime` ([`String`](graphql-scalars.md)) | The job processing time since the last measurement.
`jobState` ([`String`](graphql-scalars.md))          | The job's current state.
`timeStamp` ([`DateTime!`](graphql-scalars.md))      | The time stamp for the metric.
`unitsPerHour` ([`Int`](graphql-scalars.md))         | The system's UPH (units per hour).
`uptime` ([`Int`](graphql-scalars.md))               | The uptime of the system since the last measurement.
`yield` ([`Float`](graphql-scalars.md))              | The system's programmer yield.

## HandlerStatistics
---
Represents a handler system's statistics.

### Fields
Name                                                     | Description
---------------------------------------------------------|------------
`currentJob` ([`String`](graphql-scalars.md))            | The current job the system is running.
`availability` ([`Float!`](graphql-scalars.md))          | The system's availability.
`uptime` ([`String`](graphql-scalars.md))                | The system's uptime.
`totalPass` ([`Int!`](graphql-scalars.md))               | The total number of passed devices.
`totalFail` ([`Int!`](graphql-scalars.md))               | The total number of failed devices.
`systemYield` ([`String`](graphql-scalars.md))           | The system's yield.
`programmerYield` ([`String`](graphql-scalars.md))       | The system's programmer yield.
`handlerYield` ([`String`](graphql-scalars.md))          | The system's handler yield.
`uPH` ([`Int!`](graphql-scalars.md))                     | The system's UPH (units per hour).
`jobCompletionEstimate` ([`String`](graphql-scalars.md)) | The system's job completion estimate.

## Interval
---
Represents a time interval as a [`String`](graphql-scalars.md). Interval values can be written using the following syntax:

_**`quantity unit`**_

where `quantity` is an [`Int!`](graphql-scalars.md) and `unit` is one of the following:

Unit          | ISO 8601 Abbreviation  | Example
--------------|------------------------|-----------------
`microsecond` |                        | `1 microsecond(s)`
`millisecond` |                        | `1 millisecond(s)`
`second`      | `S`                    | `1 second(s)`
`minute`      | `M` (in the time part) | `1 minute(s)`
`hour`        | `H`                    | `1 hour(s)`
`day`         | `D`                    | `1 day(s)`
`week`        | `W`                    | `1 week(s)`
`month`       | `M` (in the date part) | `1 month(s)`
`year`        | `Y`                    | `1 year(s)`
`decade`      |                        | `1 decade(s)`
`century`     |                        | `1 century(ies)`
`millenium`   |                        | `1 millenium(s)`

## LicenseModel
---
Represents the license information for the ConneX Service.

### Fields
Name                                                                  | Description
----------------------------------------------------------------------|------------
`availableConnections` ([`Int!`](graphql-scalars.md))                 | The number of connections still available for use.
`conneXAnnualMaintenanceContract` ([`DateTime!`](graphql-scalars.md)) | The expiration date for the ConneX Annual Maintenence Contract.
`licenseType` ([`String`](graphql-scalars.md))                        | The type of license installed.
`maxConnections` ([`Int!`](graphql-scalars.md))                       | The maximum number of connections available with the installed license.
`timedLicenseExpiration` ([`DateTime!`](graphql-scalars.md))          | The expiration date of the license (if applicable).

The field `licenseType` has the following values:

Value       | Description
------------|---------------------------------------------------
`NoLicense` | No ConneX license has been installed.
`Perpetual` | License is perpetual for the purchased version.
`Timed`     | License is time bound based on purchase agreement.

## MessageModel
--- 
Represents a message received over MQTT.

### Fields
Name                                               | Description
---------------------------------------------------|-------------------------------------------------
`topic` ([`String`](graphql-scalars.md))           | The MQTT topic.
`contentType` ([`String`](graphql-scalars.md))     | The MQTT message type.
`timestamp` ([`DateTime!`](graphql-scalars.md))    | The message timestamp.
`messageModelId` ([`UUID!`](graphql-scalars.md))   | The unique UUID message identifier.
`payload` ([`[Byte!]`](graphql-scalars.md))        | The message payload in raw bytes.
`payloadAsString` ([`String`](graphql-scalars.md)) | The message payload converted to a `UTF8` string.

## MessageModelCollectionSegment
--- 
Represents a collection of [MessageModel](#messagemodel) (used in pagination).

### Fields
Name                                                            | Description
----------------------------------------------------------------|--------------------------------------
`items` ([`[MessageModel]`](#messagemodel))                     | The items in the current page.
`pageInfo` ([`CollectionSegmentInfo!`](#collectionsegmentinfo)) | Information to aid in pagination.
`totalCount` ([`Int!`](graphql-scalars.md))                     | The total message count for the query.

## ProgrammerModel
--- 
Represents a programmer connected to ConneX.

### Fields
Name                                                                    | Description
------------------------------------------------------------------------|----------------------------------------------------------
`programmerId` ([`Int!`](graphql-scalars.md))                           | The database key for the programmer.
`entity` ([`Entity`](#entity))                                          | The associated entity for this programmer.
`handler` ([`Handler`](#handler))                                       | The associated handler for this programmer.
`adapters` ([`[AdapterModel]`](#adaptermodel))                          | A collection of adapters associated with this programmer.
`ipAddress` ([`String`](graphql-scalars.md))                            | The IP address of the programmer.
`programmerType` ([`ProgrammerType!`](graphql-enums.md#programmertype)) | The type of programmer.
