namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing a Programmer Offline MQTT message
    /// </summary>
    public class ProgrammerOffline
    {
        /// <summary>
        /// Gets or sets the programmer's IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the programmer's type
        /// </summary>
        public string ProgrammerType { get; set; }
    }
}
