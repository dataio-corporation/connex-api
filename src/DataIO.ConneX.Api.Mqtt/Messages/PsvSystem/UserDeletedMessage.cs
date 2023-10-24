namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a User Deleted MQTT message
    /// </summary>
    public class UserDeletedMessage
    {
        /// <summary>
        /// Gets or sets the username of the deleted user
        /// </summary>
        public string Username { get; set; }
    }
}
