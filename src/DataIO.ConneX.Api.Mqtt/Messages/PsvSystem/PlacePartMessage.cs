using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;

    /// <summary>
    /// Class representing a Place Part MQTT message
    /// </summary>
    public class PlacePartMessage
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
        /// Gets or sets the operation status indicating the result of the place operation
        /// </summary>
        /// <remarks>
        /// <para>The following are the possible Status values:</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>Fail</term>
        ///         <description>Operation was unsuccessful</description>
        ///     </item>
        ///     <item>
        ///         <term>Pass</term>
        ///         <description>Operation was successful</description>
        ///     </item>
        /// </list>
        /// </remarks>
        public string Status { get; set; }
    }
}
