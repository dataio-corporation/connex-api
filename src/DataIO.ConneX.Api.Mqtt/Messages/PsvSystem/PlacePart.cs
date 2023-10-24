using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;

    /// <summary>
    /// Class representing a Place Part MQTT message
    /// </summary>
    public class PlacePart
    {
        /// <summary>
        /// Gets or sets the unique device identifier
        /// </summary>
        [JsonPropertyName("DeviceID")]
        public ulong DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the location the device was placed at
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the pick head end effector used to pick the device
        /// </summary>
        public uint PickHead { get; set; }

        /// <summary>
        /// Gets or sets the position within the given location
        /// </summary>
        public uint Position { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="PsvOperationStatus"/> indicating the result of the place operation
        /// </summary>
        public PsvOperationStatus Status { get; set; }
    }
}
