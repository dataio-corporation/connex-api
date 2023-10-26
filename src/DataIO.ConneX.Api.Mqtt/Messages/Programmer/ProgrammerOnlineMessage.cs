using System.Collections.Generic;

namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing a Programmer Online MQTT message
    /// </summary>
    public class ProgrammerOnline
    {
        /// <summary>
        /// Gets or sets the adapters that are inserted in the programmer
        /// </summary>
        public List<AdapterInformation> Adapters { get; set; }

        /// <summary>
        /// Gets or sets the additional information for the programmer
        /// </summary>
        public Dictionary<string, string> AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets the programmer's IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the type of programmer: <b>LumenX</b> or <b>FlashCore</b>
        /// </summary>
        public string ProgrammerType { get; set; }

        /// <summary>
        /// Gets or sets the version information for the different programmer components
        /// </summary>
        public List<ProgrammerVersionInformation> VersionInformation { get; set; }
    }
}
