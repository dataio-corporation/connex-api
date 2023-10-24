namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing an Adapter Removed MQTT message
    /// </summary>
    /// <remarks>(LumenX only)</remarks>
    public class AdapterRemovedMessage
    {
        /// <summary>
        /// Gets or sets the adapter's identifier (e.g. 110008)
        /// </summary>
        public string AdapterId { get; set; }

        /// <summary>
        /// Gets or sets the adapter's index position
        /// </summary>
        public int AdapterIndex { get; set; }
    }
}
