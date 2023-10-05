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
        /// <para>Possible values:</para>
        /// <para>201:     3D inspection failure.</para>
        /// <para>901:     2D inspection failure, unexpected device in pocket</para>
        /// <para>902:     2D inspection failure, device not detected</para>
        /// <para>903:     2D inspection failure, device detected but failed inspection</para>
        /// <para>904:     2D inspection timeout failure</para>
        /// <para>PASS 2D: Device passed 2D inspection</para>
        /// <para>PASS 3D: Device passed 3D inspection</para>
        /// </remarks>
        public string InspectionResult { get; set; }
        
        /// <summary>
        /// The pick head end effector
        /// </summary>
        public uint PickHead { get; set; }
    }
}
