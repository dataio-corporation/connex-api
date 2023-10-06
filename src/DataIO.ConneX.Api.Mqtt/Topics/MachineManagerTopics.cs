namespace DataIO.ConneX.Api.Mqtt.Topics
{
    /// <summary>
    /// Class with Machine Manager topics available for subscription and publishing
    /// </summary>
    public static class MachineManagerTopics
    {
        /// <summary>
        /// Get the topic for the command to launch DMS
        /// </summary>
        /// <param name="hostname">(optional) The hostname to send the command to</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetLaunchDmsTopic(string hostname)
            =>  TopicBuilder.BuildExternalTopic("command", "dms", "launchdms", hostname);
        
        /// <summary>
        /// Get the topic for the command to launch TaskLink
        /// </summary>
        /// <param name="hostname">(optional) The hostname to send the command to</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetLaunchTaskLinkTopic(string hostname)
            =>  TopicBuilder.BuildExternalTopic("command", "dms", "launchtasklink", hostname);
    }
}
