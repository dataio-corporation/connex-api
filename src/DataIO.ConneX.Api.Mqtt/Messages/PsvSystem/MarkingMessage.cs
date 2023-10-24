using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;
    
    /// <summary>
    /// Class representing a System Status MQTT message
    /// </summary>
    public class MarkingMessage
    {
        /// <summary>
        /// Gets or sets the cup the device was marked on
        /// </summary>
        public uint Cup { get; set; }

        /// <summary>
        /// Gets or sets the unique device identifier
        /// </summary>
        [JsonPropertyName("DeviceID")]
        public ulong DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="PsvOperationStatus"/> indicating the result of a marking operation
        /// </summary>
        public PsvOperationStatus Status { get; set; }
    }
}
