# Enums
ConneX exposes the following GraphQL enums:

## AdapterState
--- 
Represents the different state an adapter can be in.

Values          | Description
----------------|-----------------------------------
NOT_INSERTED    | Adapter is not inserted.
INSERTED        | Adapter is inserted.
VALIDATED       | Adapter is inserted and validated.
VALIDATE_FAILED | Adapter validation failed.
UNKNOWN         | Adapter state is unknown.
POWER_FAULT     | Adapter experienced a power fault.

## EntityType
--- 
Represents the different types an entity can represent.

Values     | Description
-----------|---------------------------------------------------
HANDLER    | Represents a PSV system.
PROGRAMMER | Represents a programmer (e.g. LumenX or FlashCORE).
ADAPTER    | Represents a programmer adapter.
JOB        | Represents a programming job.

## HandlerType
--- 
Represents the different types a PSV system object can be.

Values  | Description
--------|----------------------------------------
DESKTOP | Represents a desktop programming system.
PSV2800 | Represents a PSV2800 programming system.
PSV3000 | Represents a PSV3000 programming system.
PSV3500 | Represents a PSV3500 programming system.
PSV5000 | Represents a PSV5000 programming system.
PSV7000 | Represents a PSV7000 programming system.

## ProgrammerType
--- 
Represents the different types a programmer object can be.

Values     | Description
-----------|---------------------------------------
FLASH_CORE | Represents a FlashCORE III programmer.
LUMEN_X    | Represents a LumenX programmer.

## SortEnumType
--- 
Represents the different types of sorting that can be applied when filtering.

Values | Description
-------|------------------------------------
ASC    | Sort the values in ascending order.
DESC   | Sort the values in descending order.
