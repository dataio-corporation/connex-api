namespace DataIO.ConneX.Api.Mqtt.Messages.Common
{
    /// <summary>
    /// Represents a result of a command message
    /// </summary>
    public class CommandResponse
    {
        /// <summary>
        /// Gets or sets the command topic that was sent
        /// </summary>
        public string CommandTopic { get; set; }

        /// <summary>
        /// If not successful, gets or sets the accompanying error message
        /// </summary>
        public ErrorMessage ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the command was successful or not
        /// </summary>
        public bool Success { get; set; }
    }
}
