namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a User Logout MQTT message
    /// </summary>
    public class UserLogoutMessage
    {
        /// <summary>
        /// Gets or sets the username of the user who logged out
        /// </summary>
        public string Username { get; set; }
    }
}
