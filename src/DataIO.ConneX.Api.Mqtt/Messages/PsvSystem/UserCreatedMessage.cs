namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    using Common;

    /// <summary>
    /// Class representing a User Created MQTT message
    /// </summary>
    public class UserCreatedMessage
    {
        /// <summary>
        /// Gets or sets the user's <see cref="PsvUserRole"/>
        /// </summary>
        public PsvUserRole Role { get; set; }

        /// <summary>
        /// Gets or sets the username of the newly created user
        /// </summary>
        public string Username { get; set; }
    }
}
