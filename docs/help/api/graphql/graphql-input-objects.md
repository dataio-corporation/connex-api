# Objects
ConneX exposes the following GraphQL input objects:

## ComparableByteOperationFilterInput
--- 
Represents filters for a [`Byte`](graphql-scalars.md) type.

### Input Fields
Name                                    | Description
----------------------------------------|-------------------------------------------------------------------------------------------
`eq` ([`Byte`](graphql-scalars.md))     | Filter results to when the `Byte` value equals the given value.
`gt` ([`Byte`](graphql-scalars.md))     | Filter results to when the `Byte` value is greater than the given value.
`gte` ([`Byte`](graphql-scalars.md))    | Filter results to when the `Byte` value is greater than or equal to the given value.
`in` ([`[Byte!]`](graphql-scalars.md))  | Filter results to when the `Byte` value is in the collection of the given values.
`lt` ([`Byte`](graphql-scalars.md))     | Filter results to when the `Byte` value is less than the given value.
`lte` ([`Byte`](graphql-scalars.md))    | Filter results to when the `Byte` value is less than or equal to the given value.
`neq` ([`Byte`](graphql-scalars.md))    | Filter results to when the `Byte` value does *not* equals the given value.
`ngt` ([`Byte`](graphql-scalars.md))    | Filter results to when the `Byte` value is *not* greater than the given value.
`ngte` ([`Byte`](graphql-scalars.md))   | Filter results to when the `Byte` value is *not* greater than or equal to the given value.
`nin` ([`[Byte!]`](graphql-scalars.md)) | Filter results to when the `Byte` value is *not* in the collection of the given values.
`nlt` ([`Byte`](graphql-scalars.md))    | Filter results to when the `Byte` value is *not* less than the given value.
`nlte` ([`Byte`](graphql-scalars.md))   | Filter results to when the `Byte` value is *not* less than or equal to the given value.

## ComparableDateTimeOperationFilterInput
--- 
Represents filters for a [`DateTime`](graphql-scalars.md) type.

### Input Fields
Name                                        | Description
--------------------------------------------|-----------------------------------------------------------------------------------------------
`eq` ([`DateTime`](graphql-scalars.md))     | Filter results to when the `DateTime` value equals the given value.
`gt` ([`DateTime`](graphql-scalars.md))     | Filter results to when the `DateTime` value is greater than the given value.
`gte` ([`DateTime`](graphql-scalars.md))    | Filter results to when the `DateTime` value is greater than or equal to the given value.
`in` ([`[DateTime!]`](graphql-scalars.md))  | Filter results to when the `DateTime` value is in the collection of the given values.
`lt` ([`DateTime`](graphql-scalars.md))     | Filter results to when the `DateTime` value is less than the given value.
`lte` ([`DateTime`](graphql-scalars.md))    | Filter results to when the `DateTime` value is less than or equal to the given value.
`neq` ([`DateTime`](graphql-scalars.md))    | Filter results to when the `DateTime` value does *not* equals the given value.
`ngt` ([`DateTime`](graphql-scalars.md))    | Filter results to when the `DateTime` value is *not* greater than the given value.
`ngte` ([`DateTime`](graphql-scalars.md))   | Filter results to when the `DateTime` value is *not* greater than or equal to the given value.
`nin` ([`[DateTime!]`](graphql-scalars.md)) | Filter results to when the `DateTime` value is *not* in the collection of the given values.
`nlt` ([`DateTime`](graphql-scalars.md))    | Filter results to when the `DateTime` value is *not* less than the given value.
`nlte` ([`DateTime`](graphql-scalars.md))   | Filter results to when the `DateTime` value is *not* less than or equal to the given value.

## ComparableGuidOperationFilterInput
--- 
Represents filters for a [`UUID`](graphql-scalars.md) type.

### Input Fields
Name                                    | Description
----------------------------------------|-------------------------------------------------------------------------------------------
`eq` ([`UUID`](graphql-scalars.md))     | Filter results to when the `UUID` value equals the given value.
`gt` ([`UUID`](graphql-scalars.md))     | Filter results to when the `UUID` value is greater than the given value.
`gte` ([`UUID`](graphql-scalars.md))    | Filter results to when the `UUID` value is greater than or equal to the given value.
`in` ([`[UUID!]`](graphql-scalars.md))  | Filter results to when the `UUID` value is in the collection of the given values.
`lt` ([`UUID`](graphql-scalars.md))     | Filter results to when the `UUID` value is less than the given value.
`lte` ([`UUID`](graphql-scalars.md))    | Filter results to when the `UUID` value is less than or equal to the given value.
`neq` ([`UUID`](graphql-scalars.md))    | Filter results to when the `UUID` value does *not* equals the given value.
`ngt` ([`UUID`](graphql-scalars.md))    | Filter results to when the `UUID` value is *not* greater than the given value.
`ngte` ([`UUID`](graphql-scalars.md))   | Filter results to when the `UUID` value is *not* greater than or equal to the given value.
`nin` ([`[UUID!]`](graphql-scalars.md)) | Filter results to when the `UUID` value is *not* in the collection of the given values.
`nlt` ([`UUID`](graphql-scalars.md))    | Filter results to when the `UUID` value is *not* less than the given value.
`nlte` ([`UUID`](graphql-scalars.md))   | Filter results to when the `UUID` value is *not* less than or equal to the given value.

## ListComparableByteOperationFilterInput
--- 
Represents filters for a [`[Byte]`](graphql-scalars.md) type.

### Input Fields
Name                                                                                 | Description
-------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------
`all` ([`ComparableGuidOperationFilterInput`](#comparableguidoperationfilterinput))  | Filter results to when all match the given. [`ComparableGuidOperationFilterInput`](#comparableguidoperationfilterinput)
`any`  ([`Boolean`](graphql-scalars.md))                                             | TODO: Figure out what this does.
`none` ([`ComparableGuidOperationFilterInput`](#comparableguidoperationfilterinput)) | Filter results to when none match the given [`ComparableGuidOperationFilterInput`](#comparableguidoperationfilterinput).
`some` ([`ComparableGuidOperationFilterInput`](#comparableguidoperationfilterinput)) | Filter results to when some match the given [`ComparableGuidOperationFilterInput`](#comparableguidoperationfilterinput).

## MessageModelFilterInput
--- 
Represents filters for a [`[MessageModel]`](graphql-objects.md#messagemodel) type.

### Input Fields
Name                                                                                              | Description
--------------------------------------------------------------------------------------------------|-------------------------------------------------------
`and` ([`[MessageModelFilterInput]`](#messagemodelfilterinput))                                   | Add additional filtering criteria to restrict results.
`contentType` ([`StringOperationFilterInput`](#stringoperationfilterinput))                       | Filter results based on the `contentType` field.
`messageModelId` ([`ComparableGuidOperationFilterInput`](#comparableguidoperationfilterinput))    | Filter results based on the `messageModelId`
`or` [`[MessageModelFilterInput]`](#messagemodelfilterinput)                                      | Add additional filtering criteria to expand results.
`payload` ([`ListComparableByteOperationFilterInput`](#listcomparablebyteoperationfilterinput))   | Filter results based on the `payload` field.
`timestamp` ([`ComparableDateTimeOperationFilterInput`](#comparabledatetimeoperationfilterinput)) | Filter results based on the `timestamp` field.
`topic` ([`StringOperationFilterInput`](#stringoperationfilterinput))                             | Filter results based on the `topic` field.

## MessageModelSortInput
--- 
Represents sort orders for a [`[MessageModel]`](graphql-objects.md#messagemodel) type.

### Input Fields
Name                                                               | Description
-------------------------------------------------------------------|-------------------------------------------------
`contentType` ([`SortEnumType`](graphql-enums.md#sortenumtype))    | Sort results based on the `contentType` field.
`messageModelId` ([`SortEnumType`](graphql-enums.md#sortenumtype)) | Sort results based on the `messageModelId`
`timestamp` ([`SortEnumType`](graphql-enums.md#sortenumtype))      | Sort results based on the `timestamp` field.
`topic` ([`SortEnumType`](graphql-enums.md#sortenumtype))          | Sort results based on the `topic` field.

## StringOperationFilterInput
--- 
Represents filters for a [`String`](graphql-scalars.md) type.

### Input Fields
Name                                                                   | Description
-----------------------------------------------------------------------|------------------------------------------------------------------------------------------
`and` ([`[StringOperationFilterInput!]`](#stringoperationfilterinput)) | Add additional filtering criteria to restrict results.
`contains` ([`String`](graphql-scalars.md))                            | Filter results to when the `String` value contains the given value.
`endsWith` ([`String`](graphql-scalars.md))                            | Filter results to when the `String` value ends with the given value.
`eq` ([`String`](graphql-scalars.md))                                  | Filter results to when the `String` value equals the given value.
`in` ([`[String]`](graphql-scalars.md))                                | Filter results to when the `Byte` value is in the collection of the given values.
`ncontains` ([`String`](graphql-scalars.md))                           | Filter results to when the `String` value does *not* contain the given value.
`nendsWith` ([`String`](graphql-scalars.md))                           | Filter results to when the `String` value does *not* end with the given value.
`neq` ([`String`](graphql-scalars.md))                                 | Filter results to when the `String` value does *not* equals the given value.
`nin` ([`[String]`](graphql-scalars.md))                               | Filter results to when the `String` value is *not* in the collection of the given values.
`nstartswith` ([`[String]`](graphql-scalars.md))                       | Filter results to when the `String` value does *not* start with the given value.
`or` ([`[StringOperationFilterInput!]`](#stringoperationfilterinput))  | Add additional filtering criteria to expand results.
`startswith` ([`[String]`](graphql-scalars.md))                        | Filter results to when the `String` value starts with the given value.