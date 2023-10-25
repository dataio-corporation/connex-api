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
        /// Gets or sets the operation status indicating the result of a marking operation
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
