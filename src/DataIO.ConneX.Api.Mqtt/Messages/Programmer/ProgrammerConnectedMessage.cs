using System.Collections.Generic;

namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing a Programmer Connected MQTT message
    /// </summary>
    public class ProgrammerConnected
    {
        /// <summary>
        /// Gets or sets the adapters that are inserted in the programmer
        /// </summary>
        public List<AdapterInformation> Adapters { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the system handler that the programmer connected to
        /// </summary>
        public string HandlerIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the programmer's IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the specific programmer that connected to the system
        /// </summary>
        public string ProgrammerIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the name of the programmer that connected to the system
        /// </summary>
        public string ProgrammerName { get; set; }

        /// <summary>
        /// Gets or sets the type of programmer that connected to the system: LumenX or FlashCore
        /// </summary>
        public string ProgrammerType { get; set; }
    }
}
