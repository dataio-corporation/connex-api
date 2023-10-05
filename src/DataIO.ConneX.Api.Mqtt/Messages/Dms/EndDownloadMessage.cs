namespace DataIO.ConneX.Api.Mqtt.Messages.Dms
{
    /// <summary>
    /// Class representing a Begin Download MQTT message
    /// </summary>
    public class EndDownloadMessage
    {
        /// <summary>
        /// Gets or sets whether or not the download was successful
        /// </summary>
        public bool Success  { get; set; }
    }
}
