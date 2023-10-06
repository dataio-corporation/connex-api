using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;
    
    /// <summary>
    /// Class representing a Device Complete MQTT message
    /// </summary>
    public class DeviceCompleteMessage
    {
        /// <summary>
        /// Gets or sets the identification number assigned by the handling system
        /// </summary>
        [JsonPropertyName("DeviceID")]
        public ulong DeviceId { get; set; }
        
        /// <summary>
        /// Gets or sets the <see cref="PsvErrorCode"/> or status of the handler
        /// </summary>
        public PsvErrorCode ErrorCode  { get; set; }
        
        /// <summary>
        /// Gets or sets the <see cref="PsvOperationStatus"/> indicating the state of the device.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PsvOperationStatus Status  { get; set; }
    }
}
