namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing a Programmer Removed MQTT message
    /// </summary>
    public class ProgrammerRemoved
    {
        /// <summary>
        /// Gets or sets the unique ID of the system handler that the programmer disconnected from
        /// </summary>
        public string HandlerIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the programmer's IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the specific programmer that disconnected from the system
        /// </summary>
        public string ProgrammerIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the name of the programmer that disconnected from the system
        /// </summary>
        public string ProgrammerName { get; set; }

        /// <summary>
        /// Gets or sets the type of programmer that disconnected from the system: LumenX or FlashCore
        /// </summary>
        public string ProgrammerType { get; set; }
    }
}
