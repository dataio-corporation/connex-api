using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing an End Job Session MQTT message
    /// </summary>
    public class EndJobSessionMessage
    {
        /// <summary>
        /// Gets or sets the number of devices that failed as a result of the 3D system
        /// </summary>
        [JsonPropertyName("DevicesFailedOn3DSystem")]
        public int DevicesFailedOn3dSystem { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices that failed as a result of the laser
        /// </summary>
        public int DevicesFailedOnLaser { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices that failed as a result of programming
        /// </summary>
        public int DevicesFailedOnProgrammers { get; set; }
        
        /// <summary>
        /// Gets or sets number of devices that failed recurrent empty socket test (REST)
        /// </summary>
        [JsonPropertyName("DevicesFailedREST")]
        public uint DevicesFailedRest { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices that failed vision inspection
        /// </summary>
        public uint DevicesFailedVision { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices missing in use
        /// </summary>
        public uint DevicesMissingInUse { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices picked from the input media
        /// </summary>
        public ulong DevicesPickedInput { get; set; }
        
        /// <summary>
        /// Gets or sets the ending serial number for the job session
        /// </summary>
        public string EndingSerialNumber { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices that failed in the job session
        /// </summary>
        public ulong FailQuantity { get; set; }
        
        /// <summary>
        /// Gets or sets whether the programmers are ignored. True if programmers are ignored, otherwise False
        /// </summary>
        public string IgnoreProgrammers { get; set; }
        
        /// <summary>
        /// Gets or sets the input location media type
        /// </summary>
        public string InputMedia { get; set; }
        
        /// <summary>
        /// Gets or sets the job assistance time
        /// </summary>
        public string JobAssistanceTime { get; set; }
        
        /// <summary>
        /// Gets or sets the job processing time
        /// </summary>
        public string JobProcessingTime { get; set; }
        
        /// <summary>
        /// Gets or sets the job throughput of the job session
        /// </summary>
        public ulong JobThroughput { get; set; }
        
        /// <summary>
        /// Gets or sets the nominal throughput of the job session
        /// </summary>
        public double NominalThroughput { get; set; }
        
        /// <summary>
        /// Gets or sets the output location media type
        /// </summary>
        public string OutputMedia { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices that passed in the job session
        /// </summary>
        public ulong PassQuantity { get; set; }
        
        /// <summary>
        /// Gets or sets the Reject1 location media type
        /// </summary>
        public string Reject1 { get; set; }
        
        /// <summary>
        /// Gets or sets the Reject2 location media type
        /// </summary>
        public string Reject2 { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices using serialization that failed
        /// </summary>
        public string SerialFailReport { get; set; }
        
        /// <summary>
        /// Gets or sets the number of devices using serialization that passed
        /// </summary>
        public string SerialPassReport { get; set; }
        
        /// <summary>
        /// Gets or sets the starting serial number for the job session
        /// </summary>
        public string StartingSerialNumber { get; set; }
        
        /// <summary>
        /// Gets or sets the reason as to why the job session ended
        /// </summary>
        public string TerminationReason { get; set; }
    }
}
