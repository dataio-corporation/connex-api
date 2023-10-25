namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;
    
    /// <summary>
    /// Class representing a Startup MQTT message
    /// </summary>
    public class StartupMessage
    {
        /// <summary>
        /// Gets a value indicating whether the object is active. This property is always true
        /// </summary>
        public bool Active => true;

        /// <summary>
        /// Gets or sets the machine type representing the type of machine that is running
        /// </summary>
        /// <remarks>
        /// <para>The following are the possible Machine Type values:</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>Desktop Mode</term>
        ///         <description>System is running in desktop mode</description>
        ///     </item>
        ///     <item>
        ///         <term>PSV3000</term>
        ///         <description>System is a PSV3000 machine</description>
        ///     </item>
        ///     <item>
        ///         <term>PSV3500</term>
        ///         <description>System is a PSV3500 machine</description>
        ///     </item>
        ///     <item>
        ///         <term>PSV5000</term>
        ///         <description>System is a PSV5000 machine</description>
        ///     </item>
        ///     <item>
        ///         <term>PSV7000</term>
        ///         <description>System is a PSV7000 machine</description>
        ///     </item>
        /// </list>
        /// </remarks>
        public string MachineType { get; set; }
    }
}
