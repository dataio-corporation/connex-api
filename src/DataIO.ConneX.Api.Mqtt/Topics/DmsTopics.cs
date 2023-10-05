namespace DataIO.ConneX.Api.Mqtt.Topics
{
    /// <summary>
    /// Class with DMS topics available for subscription and publishing
    /// </summary>
    public static class DmsTopics
    {
        private const string BASE_TOPIC = "dms";
        
        /// <summary>
        /// Get the topic for the Begin Download messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="jobName">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetBeginDownloadTopic(string hostname = "+", string jobName = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "jobs", "begindownload", hostname, jobName);
        
        /// <summary>
        /// Get the topic for the End Download messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="jobName">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetEndDownloadTopic(string hostname = "+", string jobName = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "jobs", "enddownload", hostname, jobName);
    }
}
