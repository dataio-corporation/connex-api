namespace DataIO.ConneX.Api.Mqtt.Messages.Dms
{
    /// <summary>
    /// Class representing a Begin Download MQTT message
    /// </summary>
    public class BeginDownloadMessage
    {
        /// <summary>
        /// Gets or sets the download size of the job in bytes
        /// </summary>
        public ulong DownloadSize { get; set; }
    }
}
