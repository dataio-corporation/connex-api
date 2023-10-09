# Programmer
Below, you will find the MQTT events that are published/subscribed relating to a programmer:

Message                                       | Description
----------------------------------------------|-------------------------------------------------------------
[Adapter Inserted](#adapter-inserted-lumenx-only) | Event published when a socket adapter is inserted into a programmer.
[Adapter Removed](#adapter-removed-lumenx-only)   | Event published when a socket adapter is removed from a programmer.
[Programmer Connected](#programmer-connected) | Event published when a programmer connection is added to ConneX.
[Programmer Offline](#programmer-offline)     | Event published when a programmer goes offline.
[Programmer Online](#programmer-online)       | Event published when a programmer comes online.
[Programmer Removed](#programmer-removed)     | Event published when a programmer disconnects from ConneX.
[Programming Complete](#programming-complete) | Event published when a programmer completes a programming cycle.

## Adapter Inserted (LumenX only)
---
**Topic:** `programmers/adapter/inserted/{programmerserialnumber}/{adapterserialnumber}`

Event published when a socket adapter is inserted into a LumenX programmer (event not supported for FlashCore).

Level                  | Description
-----------------------|---------------------------------------
programmerserialnumber | The unique serial number of the programmer.
adapterserialnumber    | The unique serial number of the socket adapter.

### Fields
Name                                               | Description
---------------------------------------------------|----------------------------------------
AdapterId (`string`)                               | The unique identifier (e.g. 110008) of the socket adapter.
AdapterIndex (`int`)                               | The index position of the socket adapter.
SocketInformation ([`[SocketInfo]`](#socketinfo))  | The socket information for the adapter.

## Adapter Removed (LumenX only)
---
**Topic:** `programmers/adapter/removed/{programmerserialnumber}/{adapterserialnumber}`

Event published when a socket adapter is removed from a LumenX programmer (event not supported for FlashCore).

Level                  | Description
-----------------------|---------------------------------------
programmerserialnumber | The unique serial number of the programmer.
adapterserialnumber    | The unique serial number of the socket adapter.

### Fields
Name                 | Description
---------------------|----------------------------------------
AdapterId (`string`) | The unique identifier (e.g. 110008) of the socket adapter.
AdapterIndex (`int`) | The index position of the socket adapter.

## Programmer Connected
---
**Topic:** `connex/programmer/{programmertype}/legacy/connected`

Event published when a programmer connection is added to ConneX.

Level          | Description
---------------|----------------------------------------------------------------------------------
programmertype | The type of programmer that connected to the system: **LumenX** or **FlashCore**.

### Fields
Name                                                      | Description
----------------------------------------------------------|----------------------------------------------------------------------------------
Adapters ([`[AdapterInformation]`](#adapterinformation))  | The socket adapters that are inserted in the programmer.
HandlerIdentifier (`string`)                              | The Unique ID of the host Machine Manager that the programmer connected to.
IpAddress (`string`)                                      | The IP address of the programmer.
ProgrammerIdentifier (`string`)                           | The Unique ID of the specific programmer that connected to ConneX.
ProgrammerName (`string`)                                 | The name of the programmer that connected to ConneX.
ProgrammerType (`string`)                                 | The type of programmer that connected to ConneX: **LumenX** or **FlashCore**.

## Programmer Offline
---
**Topic:** `programmers/poweroff/{programmerserialnumber}`

Event published when a programmer is powered off.

Level                  | Description
-----------------------|---------------------------------------
programmerserialnumber | The unique serial number of the programmer.

### Fields
Name                                                                                    | Description
----------------------------------------------------------------------------------------|-----------------------------------------------------------------
IpAddress (`string`)                                                                    | The IP address of the programmer.
ProgrammerType (`string`)                                                               | The type of programmer: **LumenX** or **FlashCore**.

## Programmer Online
---
**Topic:** `programmers/poweron/{programmerserialnumber}`

Event published when a programmer is powered on.

Level                  | Description
-----------------------|---------------------------------------
programmerserialnumber | The unique serial number of the programmer.

### Fields
Name                                                                                    | Description
----------------------------------------------------------------------------------------|-----------------------------------------------------------------
Adapters ([`[AdapterInformation]`](#adapterinformation))                                | The socket adapters that are inserted in the programmer.
AdditionalInformation (`Dictionary<string, string>`)                                    | The additional information for the programmer.
IpAddress (`string`)                                                                    | The IP address of the programmer.
ProgrammerType (`string`)                                                               | The type of programmer: **LumenX** or **FlashCore**.
VersionInformation ([`[ProgrammerVersionInformation]`](#programmerversioninformation))  | The version information for the different programmer components.

## Programmer Removed
---
**Topic:** `connex/programmer/{programmertype}/legacy/removed`

Event published when a programmer disconnects from ConneX.

Level                  | Description
-----------------------|---------------------------------------
programmertype | The type of programmer that disconnected from ConneX: **LumenX** or **FlashCore**.

### Fields
Name                 | Description
---------------------|----------------------------------------
HandlerIdentifier (`string`)      | The Unique ID of the host Machine Manager that the programmer disconnected from.
IpAddress (`string`)              | The IP address of the programmer.
ProgrammerIdentifier (`string`)   | The Unique ID of the specific programmer that disconnected from ConneX.
ProgrammerName (`string`)         | The name of the programmer that disconnected from ConneX.
ProgrammerType (`string`)         | The type of programmer that disconnected from ConneX: **LumenX** or **FlashCore**.

## Programming Complete
---
**Topic:** `connex/programmer/{programmertype}/legacy/programmingcomplete`

Event published when a programmer completes a data and/or security provisioning cycle of the device/part, thereby producing a device record.

Level          | Description
---------------|------------------------------------------------------------------------------------------------------
programmertype | The type of programmer performing the data and/or security provisioning: **LumenX** or **FlashCore**.

### Fields (at minimum)
Name                               | Description
-----------------------------------|------------------------------------------------------------------------------------------------------
TimeStamp                          | Date and Time (in UTC) of the programming event.
ProgrammerClass                    | Type of programmer: **LumenX** or **FlashCore**.
ProgrammerFirmwareVersion          | Firmware version of the programmer.
ProgrammerSerialNumber             | Serial number of the programmer.
ProgrammerSystemVersion            | System version of the programmer.
ProgrammerIP                       | IP address of the programmer.
AdapterId                          | Unique ID of the socket adapter on the programmer.
AdapterSerialNumber                | Serial Number of the socket adapter on the programmer. For example, a LumenX adapter serial number may appear as "123-456-789-123-456-789-123-456-789" while a FlashCore adapter serial number may appear as "AAA12345_Socket1" (notice that for FlashCore, the socket number is appended to the adapter serial number).
AdapterCleanCount                  | Number of times the "clean adapter module" reminder message was displayed to Operators.
AdapterLifetimeActuationCount      | Total number of times the socket adapter is mechanically actuated over the life of the adapter.
AdapterLifetimeContinuityCount     | Total number of devices that ran continuity check over the life of the adapter.
AdapterLifetimeContinuityFailCount | Total number of devices that failed continuity check over the life of the adapter.
AdapterLifetimeFailCount           | Total number of devices that failed to complete all operations of a job over the life of the adapter.
AdapterPassCount                   | Total number of devices that passed all operations of a job over the life of the adapter.
AdapterSocketIndex                 | Index number of a particular socket adapter.
AdapterState                       | The state of the socket adapter.
AlgorithmID                        | Unique ID that specifies the particular algorithm used in the job.
JobID                              | Unique ID that specifies the particular job.
JobName                            | Name of the job.
JobDescription                     | Description of the job.
DeviceName                         | Name of the device.
DeviceManufacturer                 | Name of the device manufacturer.
ChipID                             | Unique Chip ID on the device.
RawChipID                          | Raw Chip ID on the device.
SocketIndex                        | Index number of the socket adapter in which the device was placed and programmed.
Code                               | Unique status code that represents Pass, Fail, or Other.
CodeName                           | Name of the result code/status.
ProgramDuration                    | Amount of time elapsed to complete programming.
VerifyDuration                     | Amount of time elapsed to verify programming.
TimesTime                          | Total time minus the time for Blank Check, Erase, Program, and Verify operations.
AlgoDeviceDetailsCID               | Unique Chip ID correlating the algorithm with the device.
BlankCheckDuration                 | Amount of time elapsed to perform the Blank Check operation.
EraseDuration                      | Amount of time elapsed to perform the Erase operation.
ErrorMessage                       | Specific message describing the error.
SerialData                         | Serialization pattern to be programmed into devices.


# Types
Types that different fields can return.

## AdapterInformation
---
Represents information about a socket adapter.

### Fields
Name                                               | Description
---------------------------------------------------|----------------------------------------
SerialNumber (`string`)                            | The unique serial number of the socket adapter.
AdapterId (`string`)                               | The unique identifier (e.g. 110008) of the socket adapter.
AdapterIndex (`int`)                               | The index position of the socket adapter.
SocketInformation ([`[SocketInfo]`](#socketinfo))  | The socket information for the adapter.

## ProgrammerVersionInformation
---
Represents versioning information about a programmer component.

### Fields
Name                   | Description
-----------------------|--------------------------------
VersionName (`string`) | The name of the programmer component.
Version (`string`)     | The version number of the programmer component.

## SocketInfo
---
Represents statistical information about a programming socket.

### Fields
Name                                 | Description
-------------------------------------|----------------------------------------------
CleanCount (`string`)                | The clean count for the socket adapter.
LifetimeActuationCount (`uint`)      | The lifetime actuation count for the socket adapter.
LifetimeContinuityFailCount (`uint`) | The lifetime continuity fail count for the socket adapter.
LifetimeFailCount (`uint`)           | The lifetime fail count for the socket adapter.
LifetimePassCount (`uint`)           | The lifetime pass count for the socket adapter.
