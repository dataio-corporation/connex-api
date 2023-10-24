using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a Device Complete MQTT message
    /// </summary>
    public class DeviceInspectionMessage
    {
        /// <summary>
        /// Gets or sets the identification number assigned by the handling system
        /// </summary>
        [JsonPropertyName("DeviceID")]
        public ulong DeviceId { get; set; }
        
        /// <summary>
        /// A string representing the result of the device inspection
        /// </summary>
        /// <remarks>
        /// <list type="definition">
        ///     <item>
        ///         <term>201</term>
        ///         <description>3D inspection failure.</description>
        ///     </item>
        ///     <item>
        ///         <term>901</term>
        ///         <description>2D inspection failure, unexpected device in pocket</description>
        ///     </item>
        ///     <item>
        ///         <term>902</term>
        ///         <description>2D inspection failure, device not detected</description>
        ///     </item>
        ///     <item>
        ///         <term>903</term>
        ///         <description>2D inspection failure, device detected but failed inspection</description>
        ///     </item>
        ///     <item>
        ///         <term>904</term>
        ///         <description>2D inspection timeout failure</description>
        ///     </item>
        ///     <item>
        ///         <term>PASS 2D</term>
        ///         <description>Device passed 2D inspection</description>
        ///     </item>
        ///     <item>
        ///         <term>PASS 3D</term>
        ///         <description>Device passed 3D inspection</description>
        ///     </item>
        /// </list>
        /// </remarks>
        public string InspectionResult { get; set; }
        
        /// <summary>
        /// The pick head end effector
        /// </summary>
        public uint PickHead { get; set; }
    }
}
