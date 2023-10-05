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
    }
}
