namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a Shutdown MQTT message
    /// </summary>
    public class ShutdownMessage
    {
        /// <summary>
        /// Gets a value indicating whether the object is active. This property is always false
        /// </summary>
        public bool Active => true;
    }
}
