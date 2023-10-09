# Common Types
The following types are shared across the different software components:

## Types
Type                                   | Description
---------------------------------------|------------------------------------------
[`CommandResponse`](#commandresponse)  | Represents a result of a command message.
[`ErrorMessage`](#errormessage)        | Represents an error message.

### CommandResponse
---
Represents a result of a command message

#### Fields
Name                                           | Description
-----------------------------------------------|---------------------------------------------------
CommandTopic (`string`)                        | The command topic that was sent.
ErrorMessage ([`ErrorMessage`](#errormessage)) | If not successful, the accompanying error message.
Success (`bool`)                               | Indicates if the command was successful or not.

### ErrorMessage
---
Represents an error message.

#### Fields
Name                                     | Description
-----------------------------------------|------------------------------
ErrorCode (`string`)                     | The error code (if provided).
ErrorLevel ([`ErrorLevel`](#errorlevel)) | The error level.
Message (`string`)                       | The error message.


## Enumerations
Enumeration                 | Description
----------------------------|-----------------------------
[`ErrorLevel`](#errorlevel) | The severity level of error.

### ErrorLevel
---
The severity level of error.

Value       | Description
------------|------------------------------------------------------------------------------------------------
0 - Warning | The error is a warning, but operation can continue.
1 - Error   | The error is an error, operation cannot continue.
2 - Fatal   | The error is a fatal error, operation cannot continue and software may be in an unstable state.
