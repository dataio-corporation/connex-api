namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a User Login MQTT message
    /// </summary>
    public class UserLoginMessage
    {
        /// <summary>
        /// Gets or sets whether or not the login was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who logged in
        /// </summary>
        public string Username { get; set; }
    }
}
