namespace DataIO.ConneX.Api.Mqtt.Topics
{
    /// <summary>
    /// Class with DMS topics available for subscription and publishing
    /// </summary>
    public static class ProgrammerTopics
    {
        private const string BASE_TOPIC = "programmers";
        
        /// <summary>
        /// Get the topic for the Adapter Inserted messages (LumenX only)
        /// </summary>
        /// <param name="programmerSerialNumber">(optional) The programmer serial number to subscribe to. Default = "+".</param>
        /// <param name="adapterSerialNumber">(optional) The adapter serial number to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetAdapterInsertedTopic(string programmerSerialNumber = "+", string adapterSerialNumber = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "adapter", "inserted", programmerSerialNumber, adapterSerialNumber);
        
        /// <summary>
        /// Get the topic for the Adapter Removed messages (LumenX only)
        /// </summary>
        /// <param name="programmerSerialNumber">(optional) The programmer serial number to subscribe to. Default = "+".</param>
        /// <param name="adapterSerialNumber">(optional) The adapter serial number to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetAdapterRemovedTopic(string programmerSerialNumber = "+", string adapterSerialNumber = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "adapter", "removed", programmerSerialNumber, adapterSerialNumber);

        /// <summary>
        /// Get the topic for the Programmer Connected messages
        /// </summary>
        /// <param name="programmerType">(optional) The programmer type subscribe to ("lumenx" or "flashcore"). Default = "+".</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetProgrammerConnectedTopic(string programmerType = "+")
            =>  TopicBuilder.BuildTopic("programmer", programmerType, "legacy", "connected");
        
        /// <summary>
        /// Get the topic for the Programmer Offline messages
        /// </summary>
        /// <param name="programmerSerialNumber">(optional) The programmer serial number to subscribe to. Default = "+".</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetProgrammerOfflineTopic(string programmerSerialNumber = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "poweron", programmerSerialNumber);
        
        /// <summary>
        /// Get the topic for the Programmer Removed messages
        /// </summary>
        /// <param name="programmerType">(optional) The programmer type subscribe to ("lumenx" or "flashcore"). Default = "+".</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetProgrammerRemovedTopic(string programmerType = "+")
            =>  TopicBuilder.BuildTopic("programmer", programmerType, "legacy", "removed");
        
        /// <summary>
        /// Get the topic for the Programming Complete messages
        /// </summary>
        /// <param name="programmerType">(optional) The programmer type subscribe to ("lumenx" or "flashcore"). Default = "+".</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetProgrammingCompleteTopic(string programmerType = "+")
            =>  TopicBuilder.BuildTopic("programmer", programmerType, "legacy", "programmingcomplete");
    }
}
