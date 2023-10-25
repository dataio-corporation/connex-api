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
        /// Gets or sets the operation status indicating the state of the device.
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
        public string Status  { get; set; }
    }
}
