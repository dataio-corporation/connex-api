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
        /// Gets or sets the <see cref="PsvMachineType"/> representing the type of machine that is running
        /// </summary>
        public PsvMachineType MachineType { get; set; }
    }
}
