namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing statistical information about a programming socket
    /// </summary>
    public class SocketInfo
    {
        /// <summary>
        /// Gets or sets the adapter's clean count
        /// </summary>
        public string CleanCount { get; set; }

        /// <summary>
        /// Gets or sets the adapter's lifetime actuation count
        /// </summary>
        public uint LifetimeActuationCount { get; set; }

        /// <summary>
        /// Gets or sets the adapter's lifetime continuity fail count
        /// </summary>
        public uint LifetimeContinuityFailCount { get; set; }

        /// <summary>
        /// Gets or sets the adapter's lifetime fail count
        /// </summary>
        public uint LifetimeFailCount { get; set; }

        /// <summary>
        /// Gets or sets the adapter's lifetime pass count
        /// </summary>
        public uint LifetimePassCount { get; set; }
    }
}
