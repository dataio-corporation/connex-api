
# Schema

```graphql
schema {
  query: Query
}

type AdapterMetrics {
  id: Long!
  identifier: String
  timeStamp: DateTime!
  programmingDuration: Int!
  verifyDuration: Int!
  blankCheckDuration: Int!
  eraseDuration: Int!
}

"Represents an adapter for a programmer."
type AdapterModel {
  "The database key for the adapter."
  adapterKey: Int!
  "The associated entity for this adapter."
  entity: Entity
  "The last associated programmer for this adapter."
  programmer: ProgrammerModel
  "The adapter's part number identifier."
  adapterId: String
}

type AdapterStatistics {
  adapterId: String
  cleanCount: UnsignedInt!
  lifetimeActuationCount: UnsignedInt!
  lifetimeContinuityFailCount: UnsignedInt!
  lifetimeFailCount: UnsignedInt!
  lifetimePassCount: UnsignedInt!
  socketIndex: Int!
  adapterState: AdapterState!
}

"Information about the offset pagination."
type CollectionSegmentInfo {
  "Indicates whether more items exist following the set defined by the clients arguments."
  hasNextPage: Boolean!
  "Indicates whether more items exist prior the set defined by the clients arguments."
  hasPreviousPage: Boolean!
}

"Represents an abstract component that is connected to the ConneX system."
type Entity {
  "The database key for the entity."
  id: Int!
  "The unique identifier for the entity."
  entityIdentifier: String
  "The type the entity represents."
  entityType: EntityType!
  "The given name of the entity."
  entityName: String
}

"Represents a PSV system connected to ConneX."
type Handler {
  "The database key for the PSV system."
  handlerId: Int!
  "The associated entity for this PSV system."
  entity: Entity
  "The associated programmers for this PSV system."
  programmers: [ProgrammerModel]
  "The PSV system's type (e.g. PSV2800\/3000\/5000\/7000)."
  handlerType: HandlerType!
  "The PSV system's IP address."
  ipAddress: String
  "The PSV system's computer host name."
  hostName: String
  "The PSV system's associated factory."
  machineFactory: String
}

type HandlerMetrics {
  id: Long!
  identifier: String
  timeStamp: DateTime!
  jobState: String
  uptime: Int
  jobProcessingTime: Int
  unitsPerHour: Int
  yield: Float
}

type HandlerStatistics {
  currentJob: String
  availability: Float!
  uptime: String
  totalPass: Int!
  totalFail: Int!
  systemYield: String
  programmerYield: String
  handlerYield: String
  uPH: Int!
  jobCompletionEstimate: String
}

type LicenseModel {
  licenseType: String
  maxConnections: Int!
  availableConnections: Int!
  conneXAnnualMaintenanceContract: DateTime!
  timedLicenseExpiration: DateTime!
}

type MessageModel {
  topic: String
  contentType: String
  timestamp: DateTime!
  messageModelId: UUID!
  payload: [Byte!]
  payloadAsString: String
}

type MessageModelCollectionSegment {
  items: [MessageModel]
  "Information to aid in pagination."
  pageInfo: CollectionSegmentInfo!
  totalCount: Int!
}

type ProgrammerModel {
  programmerId: Int!
  entity: Entity
  handler: Handler
  adapters: [AdapterModel]
  ipAddress: String
  programmerType: ProgrammerType!
}

type Query {
  "Get the last received MQTT message."
  message: MessageModel
  "Get all MQTT messages."
  messages(skip: Int take: Int where: MessageModelFilterInput order: [MessageModelSortInput!]): MessageModelCollectionSegment
  "Get the latest statistics for the specified adapter."
  latestAdapterStatistics("The adapter's unique identifier." entityIdentifier: String): AdapterStatistics
  "Get the latest statistics for the specified PSV system."
  latestHandlerStatistics("The handler system's unique identifier." entityIdentifier: String): HandlerStatistics
  handlerMetrics("The handler's unique identifier." handlerIdentifier: String "The time bucket to aggregate metrics over." timeBucket: String "The interval of time to query." interval: String): [HandlerMetrics]
  adapterMetrics("The adapter's unique identifier." adapterIdentifier: String "The time bucket to aggregate metrics over." timeBucket: String "The interval of time to query." interval: String): [AdapterMetrics]
  "Look up all the known entities connected to this instance of ConneX."
  entities: [Entity]
  "Look up all the known entity types that can be connected to this instance of ConneX."
  entityTypes: [EntityType!]
  "Look up all the known PSV systems connected to this instance of ConneX."
  systems: [Handler]
  "Look up a singular PSV system by its database ID."
  system("The database identifier of the handler." databaseId: Int!): Handler
  "Look up all the known PSV system types that can be connected to this instance of ConneX."
  systemTypes: [HandlerType!]
  "Look up all the known programmers connected to this instance of ConneX."
  programmers: [ProgrammerModel]
  "Look up all the known programmer system types that can be connected to this instance of ConneX."
  programmerTypes: [ProgrammerType!]
  "Look up all the known adapters connected to this instance of ConneX."
  adapters: [AdapterModel]
  "Get the license information for the ConneX Service"
  license: LicenseModel
}

input ComparableByteOperationFilterInput {
  eq: Byte
  neq: Byte
  in: [Byte!]
  nin: [Byte!]
  gt: Byte
  ngt: Byte
  gte: Byte
  ngte: Byte
  lt: Byte
  nlt: Byte
  lte: Byte
  nlte: Byte
}

input ComparableDateTimeOperationFilterInput {
  eq: DateTime
  neq: DateTime
  in: [DateTime!]
  nin: [DateTime!]
  gt: DateTime
  ngt: DateTime
  gte: DateTime
  ngte: DateTime
  lt: DateTime
  nlt: DateTime
  lte: DateTime
  nlte: DateTime
}

input ComparableGuidOperationFilterInput {
  eq: UUID
  neq: UUID
  in: [UUID!]
  nin: [UUID!]
  gt: UUID
  ngt: UUID
  gte: UUID
  ngte: UUID
  lt: UUID
  nlt: UUID
  lte: UUID
  nlte: UUID
}

input ListComparableByteOperationFilterInput {
  all: ComparableByteOperationFilterInput
  none: ComparableByteOperationFilterInput
  some: ComparableByteOperationFilterInput
  any: Boolean
}

input MessageModelFilterInput {
  and: [MessageModelFilterInput!]
  or: [MessageModelFilterInput!]
  topic: StringOperationFilterInput
  contentType: StringOperationFilterInput
  payload: ListComparableByteOperationFilterInput
  timestamp: ComparableDateTimeOperationFilterInput
  messageModelId: ComparableGuidOperationFilterInput
}

input MessageModelSortInput {
  topic: SortEnumType
  contentType: SortEnumType
  timestamp: SortEnumType
  messageModelId: SortEnumType
}

input StringOperationFilterInput {
  and: [StringOperationFilterInput!]
  or: [StringOperationFilterInput!]
  eq: String
  neq: String
  contains: String
  ncontains: String
  in: [String]
  nin: [String]
  startsWith: String
  nstartsWith: String
  endsWith: String
  nendsWith: String
}

enum AdapterState {
  NOT_INSERTED
  INSERTED
  VALIDATED
  VALIDATE_FAILED
  UNKNOWN
  POWER_FAULT
}

enum EntityType {
  HANDLER
  PROGRAMMER
  ADAPTER
  JOB
}

enum HandlerType {
  DESKTOP
  PSV2800
  PSV3000
  PSV5000
  PSV7000
}

enum ProgrammerType {
  FLASH_CORE
  LUMEN_X
}

enum SortEnumType {
  ASC
  DESC
}

"The `@defer` directive may be provided for fragment spreads and inline fragments to inform the executor to delay the execution of the current fragment to indicate deprioritization of the current fragment. A query with `@defer` directive will cause the request to potentially return multiple responses, where non-deferred data is delivered in the initial response and data deferred is delivered in a subsequent response. `@include` and `@skip` take precedence over `@defer`."
directive @defer("If this argument label has a value other than null, it will be passed on to the result of this defer directive. This label is intended to give client applications a way to identify to which fragment a deferred result belongs to." label: String "Deferred when true." if: Boolean) on FRAGMENT_SPREAD | INLINE_FRAGMENT

"The `@specifiedBy` directive is used within the type system definition language to provide a URL for specifying the behavior of custom scalar definitions."
directive @specifiedBy("The specifiedBy URL points to a human-readable specification. This field will only read a result for scalar types." url: String!) on SCALAR

"The `@stream` directive may be provided for a field of `List` type so that the backend can leverage technology such as asynchronous iterators to provide a partial list in the initial response, and additional list items in subsequent responses. `@include` and `@skip` take precedence over `@stream`."
directive @stream("If this argument label has a value other than null, it will be passed on to the result of this stream directive. This label is intended to give client applications a way to identify to which fragment a streamed result belongs to." label: String "The initial elements that shall be send down to the consumer." initialCount: Int! = 0 "Streamed when true." if: Boolean) on FIELD

"The `Byte` scalar type represents non-fractional whole numeric values. Byte can represent values between 0 and 255."
scalar Byte

"The `DateTime` scalar represents an ISO-8601 compliant date time type."
scalar DateTime @specifiedBy(url: "https:\/\/www.graphql-scalars.com\/date-time")

"The `Long` scalar type represents non-fractional signed whole 64-bit numeric values. Long can represent values between -(2^63) and 2^63 - 1."
scalar Long

scalar UUID @specifiedBy(url: "https:\/\/tools.ietf.org\/html\/rfc4122")

"The UnsignedInt scalar type represents a unsigned 32-bit numeric non-fractional value greater than or equal to 0."
scalar UnsignedInt
```