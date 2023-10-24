using System.Collections.Generic;

namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing information about a programming adapter
    /// </summary>
    public class AdapterInformation
    {
        /// <summary>
        /// Gets or sets the adapter's unique serial number
        /// </summary>
        public string SerialNumber { get; set; }

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
