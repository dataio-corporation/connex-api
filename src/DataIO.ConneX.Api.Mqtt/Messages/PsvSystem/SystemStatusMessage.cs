namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;

    /// <summary>
    /// Class representing a System Status MQTT message
    /// </summary>
    public class SystemStatusMessage
    {
        /// <summary>
        /// Gets or sets the <see cref="ErrorMessage"/>ErrorMessage of the handler
        /// </summary>
        public ErrorMessage ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="PsvRunState"/> of the handler
        /// </summary>
        public PsvRunState RunState { get; set; }
    }
}
