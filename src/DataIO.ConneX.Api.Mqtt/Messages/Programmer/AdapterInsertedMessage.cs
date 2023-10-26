using System.Collections.Generic;

namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing an Adapter Inserted MQTT message
    /// </summary>
    /// <remarks>(LumenX only)</remarks>
    public class AdapterInsertedMessage
    {
        /// <summary>
        /// Gets or sets the adapter's identifier (e.g. 110008)
        /// </summary>
        public string AdapterId { get; set; }

        /// <summary>
        /// Gets or sets the adapter's index position
        /// </summary>
        public int AdapterIndex { get; set; }

        /// <summary>
        /// Gets or sets the socket information for the adapter
        /// </summary>
        public List<SocketInfo> SocketInformation { get; set; }
    }
}
