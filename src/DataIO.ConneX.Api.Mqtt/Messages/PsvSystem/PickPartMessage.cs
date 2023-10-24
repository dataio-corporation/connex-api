using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;
    
    /// <summary>
    /// Class representing a Pick Part MQTT message
    /// </summary>
    public class PickPartMessage
    {
        /// <summary>
        /// Gets or sets the unique device identifier.
        /// </summary>
        [JsonPropertyName("DeviceID")]
        public ulong DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the location the device was picked from.
        /// <remarks>
        /// <para>The following are the possible device types and their associated names:</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Device Type</term>
        ///         <description>Description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>Laser</term>
        ///         <description>The laser marking device. Examples: "Shuttle"</description>
        ///     </item>
        ///     <item>
        ///         <term>Programmer</term>
        ///         <description>A programmer (e.g. FlashCORE or LumenX). Examples: "Prog1", "Prog4"</description>
        ///     </item>
        ///     <item>
        ///         <term>Tape</term>
        ///         <description>An input/output tape. Examples: "TapeIn", "TapeOut"</description>
        ///     </item>
        ///     <item>
        ///         <term>Tray</term>
        ///         <description>An input/output/reject tray. Examples: "Tray1", "Tray2"</description>
        ///     </item>
        ///     <item>
        ///         <term>Tube</term>
        ///         <description>An input/output tube. Examples: "Tube1", "Tube2"</description>
        ///     </item>
        /// </list>
        /// </remarks>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the pick head end effector used to pick the device.
        /// </summary>
        public uint PickHead { get; set; }

        /// <summary>
        /// Gets or sets the position within the given location.
        /// </summary>
        public uint Position { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="PsvOperationStatus"/> indicating the result of the pick operation.
        /// </summary>
        public PsvOperationStatus Status { get; set; }
    }
}
