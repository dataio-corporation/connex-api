# Automated Handling software
Below, you will find the MQTT events that are published/subscribed relating to:

* [AH700](#ah700)
* [CH700](#ch700)

## AH700
AH700 software is used to control the following Data I/O handling system:

* PSV7000

## CH700
CH700 software is used to control the following Data I/O handling systems:

* PSV5000
* PSV3500
* PSV3000

## Events
References to "x" (in "xh700" and "xhsessionid") below, should be replaced with "a" or "c" when subscribing to AH700 or CH700 topics and
replaced with "A" or "C" when retrieving the version from the `xH700Version` field.

Below are the events that PSV systems publish:

Event                                     | Description
------------------------------------------|-------------------------------------------------------------------------------------
[Begin Job Session](#begin-job-session)   | Event published when the automated handler (xH700) begins running a job.
[Device Complete](#device-complete)       | Event published after the automated handler (xH700) places a device in the output media.
[Device Inspection](#device-inspection)   | Event published after the automated handler (xH700) inspects a device at the 2D and/or 3D location.
[End Job Session](#end-job-session)       | Event published when the automated handler (xH700) finishes running a job.
[Light Tower Status](#light-tower-status) | Event published when the state of the light tower changes.
[Marking](#marking)                       | Event published after the automated handler (xH700) marks a device/part (ex. laser mark or ink-dot mark).
[Pick Part](#pick-part)                   | Event published when the automated handler (xH700) picks up a device/part.
[Place Part](#place-part)                 | Event published when the automated handler (xH700) places a device/part.
[Shutdown](#shutdown)                     | Event published when the automated handler (xH700) shuts down gracefully, after xH700 is past its splash screen.
[Startup](#startup)                       | Event published after clicking the **Start** button in xH700 software.
[System Statistics](#system-statistics)   | Event published periodically providing the current system statistics.
[System Status](#system-status)           | Event published when the status changes in xH700.
[User Created](#user-created)             | Event published when a user account is created in xH700 software.
[User Deleted](#user-deleted)             | Event published when a user account is deleted in xH700 software.
[User Login](#user-login)                 | Event published when a user logs in to xH700 software.
[User Logout](#user-logout)               | Event published when a user logs out of xH700 software.

### Begin Job Session
---
**Topic:** `xh700/beginrun/{hostname}/{xhsessionid}`

Event published when the automated handler (xH700) begins running a job.

Level           | Description
----------------|-----------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                                     | Description
-----------------------------------------|-------------------------------------------------------------------
`2DInspectionProjectFile` (`string`)     | The full path of the file used for 2D inspection.
`3DInspectionProjectFile` (`string`)     | The full path of the file used for 3D inspection.
`IgnoreProgrammers` (`string`)           | `True` if programmers are ignored (ex. handler testing), otherwise `False`.
`LaserMarkingProjectFile` (`string`)     | The full path of the file used for laser marking
`MachineID` (`string`)                   | The machine identifier.
`MachineParametersFile` (`string`)       | The contents of the file used for machine parameters.
`PackageParametersFile` (`string`)       | The contents of the file used for package parameters.
`Sumcheck` (`string`)                    | The checksum for the job that is starting (the **Expected Task Checksum** in TaskLink or the **Job Checksum** in DMS).
`TaskName` (`string`)                    | The name of the job that is starting.
`VisionInspectionProjectFile` (`string`) | (CH700 only) The full path of the file used for vision inspection.
`WinAH400INIFile` (`string`)             | The contents of the `WinAH400.ini` file used.
`xH700Version` (`string`)                | The version of the installed xH700 software.

### Device Complete
---
**Topic:** `xh700/devicecomplete/{hostname}/{xhsessionid}`

Event published after the automated handler (xH700) places a programmed device in the output media.

Level           | Description
----------------|-----------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                                     | Description
-----------------------------------------|-------------------------------------------------------------------
`DeviceID` (`ulong`)                     | The unique device identification number assigned by xH700 software.
`ErrorCode` (`enum`)                     | The [`ErrorCode`](#errorcode) or status of the automated handler (xH700). 
`Status` (`string`)                      | The [`OperationStatus`](#operationstatus) indicating the state (pass or fail) of the device.

### Device Inspection
---
**Topic:** `xh700/operations/inspection/{hostname}/{xhsessionid}`

Event published after the automated handler (xH700) inspects a device at the 2D and/or 3D location.

Level           | Description
----------------|-----------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                          | Description
------------------------------|--------------------------------------------------------------------------------------------
`DeviceID` (`ulong`)          | The unique device identification number assigned by xH700 software.
`InspectionResult` (`string`) | A [`InspectionResult`](#inspectionresult) representing the result of the device inspection.
`PickHead` (`uint`)           | The unique pick head (end effector) identification number assigned by xH700 software.

### End Job Session
---
**Topic:** `xh700/endrun/{hostname}/{xhsessionid}`

Event published when the automated handler (xH700) finishes running a job.

Level           | Description
----------------|-----------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                                 | Description
-------------------------------------|----------------------------------------------------------------------
`DevicesFailedOn3DSystem` (`int`)    | The number of devices that failed as a result of the 3D system.
`DevicesFailedOnLaser` (`int`)       | The number of devices that failed as a result of the laser.
`DevicesFailedOnProgrammers` (`int`) | The number of devices that failed as a result of programming.
`DevicesFailedREST` (`uint`)         | The number of devices that failed recurrent empty socket test (REST).
`DevicesFailedVision` (`uint`)       | The number of devices that failed vision inspection.
`DevicesMissingInUse` (`uint`)       | The number of devices missing in use.
`DevicesPickedInput` (`ulong`)       | The number of devices picked from the input media.
`EndingSerialNumber` (`string`)      | The ending serial number for the job session.
`FailQuantity` (`ulong`)             | The number of devices that failed in the job session.
`IgnoreProgrammers` (`string`)       | `True` if programmers are ignored (ex. handler testing), otherwise `False`.
`InputMedia` (`string`)              | The input location media type (ex. tape, tray, tube...).
`JobAssistanceTime` (`string`)       | The job assistance time (ex. after job start, the duration of time taken by Operators to respond to dialog prompts for job continuation).
`JobProcessingTime` (`string`)       | The job processing time (ex. after xH700 starts running a job, the duration of time until xH700 stops running the job; excluding job assistance time).
`JobThroughput` (`ulong`)            | The job throughput of the job session (ex. from click of **Run** button to Job Finished/[End Job Session](#end-job-session), including all wait/pause time).
`NominalThroughput` (`double`)       | The nominal throughput of the job session (ex. from placement of the first programmed device in the output media to Job Finished/[End Job Session](#end-job-session), excluding all wait/pause time).
`OutputMedia` (`string`)             | The output location media type (ex. tape, tray, tube...).
`PassQuantity` (`ulong`)             | The number of devices that passed in the job session.
`Reject1` (`string`)                 | The Reject1 location media type (ex. tape, tray, tube...).
`Reject2` (`string`)                 | The Reject2 location media type (ex. tape, tray, tube...).
`SerialFailReport` (`string`)        | The number of devices using serialization that failed.
`SerialPassReport` (`string`)        | The number of devices using serialization that passed.
`StartingSerialNumber` (`string`)    | The starting serial number for the job session.
`TerminationReason` (`string`)       | Provides a reason as to why the job session ended.

### Light Tower Status
---
**Topic:** `xh700/lighttowerchanged/{hostname}/{xhsessionid}`

Event published when the state of the light tower changes.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                  | Description
----------------------|----------------------------------------------------------------
`NewState` (`string`) | The new light tower [`TowerState`](#towerstate) indicated below
`OldState` (`string`) | The old light tower [`TowerState`](#towerstate) indicated below

### Marking
---
**Topic:** `xh700/operations/marking/{hostname}/{xhsessionid}`

Event published after the automated handler (xH700) marks a device/part (ex. laser mark or ink-dot mark).

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                 | Description
---------------------|----------------------------------------------------------------------------------------
`Cup` (`uint`)       | The specific laser cup that the device was marked on.
`DeviceID` (`ulong`) | The unique device identification number assigned by xH700 software.
`Status` (`string`)  | The [`OperationStatus`](#operationstatus) indicating the result of a marking operation.

### Pick Part
---
**Topic:** `xh700/operations/pick/{hostname}/{xhsessionid}`

Event published when the automated handler (xH700) picks up a device/part.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                  | Description
----------------------|---------------------------------------------------------------------------------
`DeviceID` (`ulong`)  | The unique device identification number assigned by xH700 software.
`Location` (`string`) | The [`Location`](#location) from which the device was picked.
`PickHead` (`uint`)   | The pick head (end effector) used to pick the device.
`Position` (`uint`)   | The position within the given location.
`Status` (`string`)   | The [`OperationStatus`](#operationstatus) indicating the result of the pick operation.

### Place Part
---
**Topic:** `xh700/operations/place/{hostname}/{xhsessionid}`

Event published when the automated handler (xH700) places a device/part.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                  | Description
----------------------|---------------------------------------------------------
`DeviceID` (`ulong`)  | The unique device identification number assigned by xH700 software.
`Location` (`string`) | The [`Location`](#location) at which the device was placed.
`PickHead` (`uint`)   | The pick head (end effector) used to pick the device.
`Position` (`uint`)   | The position within the given location.
`Status` (`string`)   | The [`OperationStatus`](#operationstatus) indicating the result of the place operation.

### Shutdown
---
**Topic:** `xh700/shutdown/{hostname}/{xhsessionid}`

Event published when the automated handler (xH700) shuts down gracefully, after xH700 software is past its splash screen.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name              | Description
------------------|--------------
`Active` (`bool`) | Always false.

#### Special Properties
* Last Will and Testament

### Startup
---
**Topic:** `xh700/startup/{hostname}/{xhsessionid}`

Event published after clicking the **Start** button in xH700 software.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                   | Description
-----------------------|------------------------------------------------------------------------------------
`Active` (`bool`)      | Always true.
`MachineType` (`enum`) | The [`MachineType`](#machinetype) representing the type of machine that is running.

#### Special Properties
* Retained

### System Statistics
---
**Topic:** `xh700/systemstatistics/{hostname}/{xhsessionid}`

Event published periodically providing the current system statistics.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                                  | Description
--------------------------------------|--------------------------------------------------------------------------------------------------------------
`DevicesFailedOn3DSystem` (`int`)     | The number of devices that failed as a result of the 3D system.
`DevicesFailedOnLaser` (`int`)        | The number of devices that failed as a result of the laser.
`DevicesFailedOnProgrammer` (`int`)   | The number of devices that failed as a result of programming.
`DevicesFailedREST` (`int`)           | The number of devices that failed recurrent empty socket test (REST).
`DevicesFailedVision` (`int`)         | The number of devices that failed vision inspection.
`DevicesPickedInput` (`int`)          | The number of devices picked from the input media.
`HandlerYield` (`string`)             | The percentage of devices that were picked from the input media and placed in the output media (excluding rejected devices).
`JobAssistanceTime` (`string`)        | The job assistance time (ex. after job start, the duration of time taken by Operators to respond to dialog prompts for job continuation).
`JobCompletionEstimate` (`string`)    | The estimated job completion time.
`JobProcessingTime` (`string`)        | The job processing time (ex. after xH700 starts running a job, the duration of time until xH700 stops running the job; excluding job assistance time).
`ProgrammerYield` (`string`)          | The percentage of devices that passed programming.
`SystemYield` (`string`)              | The percentage of devices that were picked from the input media and placed in the output media.
`TotalFail` (`int`)                   | The number of devices that failed in the job session.
`TotalPass` (`int`)                   | The number of devices that passed in the job session.
`UPH` (`int`)                         | The job throughput (including operator intervention time) of the job session.

### System Status 
---
**Topic:** `xh700/systemstatus/{hostname}/{xhsessionid}`

Event published when the status of the automated handler (xH700) changes.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                                                           | Description
---------------------------------------------------------------|------------------------------------------------------------------
`ErrorMessage` ([`ErrorMessage`](mqtt-types.md#errormessage))  | The [`ErrorMessage`](mqtt-types.md#errormessage) of the automated handler (xH700).
`RunState` (`enum`)                                            | The [`RunState`](#runstate) of the automated handler (xH700).     

### User Created
---
**Topic:** `xh700/users/create/{hostname}/{xhsessionid}`

Event published when a user account is created in xH700 software.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                  | Description
----------------------|------------------------------------
`Role` (`enum`)       | The user's [`UserRole`](#userrole)
`Username` (`string`) | Username of the newly created user.

### User Deleted
---
**Topic:** `xh700/users/delete/{hostname}/{xhsessionid}`

Event published when a user account is deleted in xH700 software.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                  | Description
----------------------|------------------------------
`Username` (`string`) | Username of the deleted user.

### User Login
---
**Topic:** `xh700/users/login/{hostname}/{xhsessionid}`

Event published when a user logs in to xH700.

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`UserSessionID` | The session ID for the current user of xH700.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                  | Description
----------------------|---------------------------------------------------
`Success` (`bool`)    | Indicates whether or not the login was successful.
`Username` (`string`) | Username of the user who performed the login attempt.

### User Logout
---
**Topic:** `xh700/users/logout/{hostname}/{xhsessionid}`

Event published when a user logs out of xH700. 

Level           | Description
----------------|--------------------------------------------------
`hostname`      | The hostname of the PC that xH700 software is running on.
`xhsessionid`   | The session ID for the current instance of xH700 software.

#### Fields
Name                  | Description
----------------------|-------------------------------------
`Username` (`string`) | Username of the user who logged out.

## Commands
References to "x" (in "xh700" and "xhsessionid") below, should be replaced with "a" or "c" when sending commands to AH700 or CH700.

Below are the commands that can be used to control xH700:

Command                                 | Description
----------------------------------------|---------------------------------------
[Abort Job Session](#abort-job-session) | Instruct xH700 to end a job session.
[Pause Job Session](#pause-job-session) | Instruct xH700 to pause a job session.

### Abort Job Session
---
**Topic:** `command/xh700/abortjob/{hostname}/{xhsessionid}`

Instruct xH700 to end a job session. xH700 does not pick any more devices from input, finishes the current devices in the work-envelope, then stops.

Level         | Description
--------------|----------------------------------------------
`hostname`    | The hostname of the PC where xH700 should abort the job session.
`xhsessionid` | The session ID of the job to abort.

xH700 publishes a [`CommandResponse`](mqtt-types.md#commandresponse) on the topic `xh700/commandresponse/{hostname}/{xhsessionid}` indicating the success (or failure) of the command.

### Pause Job Session
---
**Topic:** `command/xh700/pausejob/{hostname}/{xhsessionid}`

Instruct xH700 to pause a job session.

Level         | Description
--------------|----------------------------------------------
`hostname`    | The hostname of the PC where xH700 should pause the job session.
`xhsessionid` | The session ID of the job to pause.

xH700 publishes a [`CommandResponse`](mqtt-types.md#commandresponse) on the topic `xh700/commandresponse/{hostname}/{xhsessionid}` indicating the success (or failure) of the command.

# Types
Types that different fields can return.

## ErrorCode
---
**Type**: `enum`

Represents the automated handler (xH700) error code value assigned to rejected devices, or the final status value reported by the automated handler (xH700) for passed devices.

Possible Error Code Values:

Value    | Description
---------|-------------------------------------------------------------------------
`3`      | Device programming error.
`7`      | Socket might be missing at this location.
`9`      | Too many consecutive errors at this socket.
`11`     | Unknown error happened.
`12`     | Recurrent Empty Socket Test (REST) error; the device is not programmed.
`15`     | Device laser marking error.
`17`     | Device continuity error.
`20`     | Failed Empty Socket Test (EST); device detected in socket.
`21`     | 3D inspection error before device programming.
`23`     | Wrong socket adapter installed.
`24`     | Bad job.
`25`     | Device is shorted.
`200`    | Device position inspection error.
`201`    | 3D inspection error after device programming.
`255`    | Hardware failure.
`901`    | 2D inspection failure, unexpected device in tape pocket.
`902`    | 2D inspection failure, device not detected.
`903`    | 2D inspection failure, device detected but failed inspection.
`904`    | 2D inspection timeout failure.
`910`    | Tape out error.
`1044`   | No socket adapter installed.

Possible Status Code Values:

Value    | Description
---------|--------------------------------------------------------------
`1`      | Location holds a device being tested.
`2`      | Location holds a good and passed device.
`5`      | Location holds a device not yet programmed.
`6`      | Location holds a device being programmed.
`10`     | Socket intentionally not loaded/needed by xH700.
`14`     | Device laser marking occurred.
`22`     | Running Empty Socket Test (EST).

## InspectionResult
---
**Type**: `string`

Represents the possible return values of a device inspection operation:

Value     | Description
----------|-------------------------------------------------------------
`201`     | 3D inspection failure.
`901`     | 2D inspection failure, unexpected device in tape pocket.
`902`     | 2D inspection failure, device not detected.
`903`     | 2D inspection failure, device detected but failed inspection.
`904`     | 2D inspection timeout failure.
`PASS 2D` | Device passed 2D inspection
`PASS 3D` | Device passed 3D inspection

## Location
---
**Type**: `string`

Represents a physical location inside a PSV system:

Location Type     | Description                              | Example
------------------|------------------------------------------|---------------------
`Laser`           | The laser marker.                        | "Shuttle"
`Programmer`      | A programmer (e.g. FlashCORE or LumenX). | "Prog1", "Prog4"
`Tape`            | An input/output tape.                    | "TapeIn", "TapeOut"
`Tray`            | An input/output/reject tray.             | "Tray1", "Tray2"
`Tube`            | An input/output tube.                    | "Tube1", "Tube2"

> [!NOTE]
> 1. The location strings are defined in the `WinAH400.ini` file.
> 2. The default name for the reject tray is "Tray4".

## MachineType
---
**Type**: `enum`

Represents the type of PSV system:

Type       | Description
---------------|-----------------------------------
`Desktop Mode` | System is running in desktop mode (with a FlashCORE desktop programmer or LumenX desktop programmer).
`PSV3000`      | System is a PSV3000 machine.
`PSV3500`      | System is a PSV3500 machine.
`PSV5000`      | System is a PSV5000 machine.
`PSV7000`      | System is a PSV7000 machine.

## OperationStatus
---
**Type**: `string`

Represents the possible return values for a pass/fail operation:

Status | Description
---------|----------------------------
`Fail`   | Operation was unsuccessful.
`Pass`   | Operation was successful.

## TowerState
---
**Type**: `string`

Represents the possible return values for tower status:

State                               | Description
------------------------------------|-----------------------------------------------------------------------------------
`Alternating Green-Yellow`          | Light tower is alternating between green and yellow lamps illuminated.
`Alternating Yellow-Red`            | Light tower is alternating between yellow and red lamps illuminated.
`Alternating Yellow-Red with alarm` | Light tower is alternating the yellow and red lamp and emitting an audible alarm.
`Flashing Red`                      | Light tower is flashing the red lamp exclusively.
`Flashing red with alarm`           | Light tower is flashing the red lamp exclusively and emitting an audible alarm.
`Flashing Yellow`                   | Light tower is flashing the yellow lamp exclusively.
`Flashing Yellow with alarm`        | Light tower is flashing the yellow lamp exclusively and emitting an audible alarm.
`Green`                             | Light tower has only the green lamp illuminated.
`Off`                               | Light tower is off.
`Red`                               | Light tower has only the Red lamp illuminated.
`Yellow`                            | Light tower has only the yellow lamp illuminated.

## UserRole
---
**Type**: `enum`

Represents the possible return values for a user role:

Role     | Description
-------------|---------------------------------------
`Operator`   | User has operator-level permissions (ex. only allow Job Runs).
`Service`    | User has service-level permissions (ex. no restrictions/allow All permissions).
`Supervisor` | User has supervisor-level permissions (ex. allow Job Creation and Editing).

## RunState
---
**Type**: `enum`

Represents the possible return values for the state of a job run:

State         | Description
--------------|--------------------------------------------------------------
`JobIdle`     | xH700 has not started the job.
`JobPaused`   | xH700 has paused the job.
`JobRunning`  | xH700 is running the job.
`JobStopped`  | xH700 encountered an error and cannot continue the job.
