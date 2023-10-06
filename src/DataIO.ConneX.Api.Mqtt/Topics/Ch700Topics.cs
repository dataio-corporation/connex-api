namespace DataIO.ConneX.Api.Mqtt.Topics
{
    /// <summary>
    /// Class with CH700 MQTT topics available for subscription
    /// </summary>
    public static class Ch700Topics
    {
        private const string BASE_TOPIC = "ch700";
        
        /// <summary>
        /// Get the topic for the Abort Job Session messages
        /// </summary>
        /// <param name="hostname">The hostname to subscribe to.</param>
        /// <param name="sessionId">The session ID to subscribe to.</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetAbortJobSessionTopic(string hostname, string sessionId)
            =>  TopicBuilder.BuildExternalTopic("command", BASE_TOPIC, "abortjob", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the Begin Job Session messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetBeginJobSessionTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "beginrun", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the Device Complete messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetDeviceCompleteTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "devicecomplete", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the Device Inspection messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetDeviceInspectionTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "operations", "inspection", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the End Job Session messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetEndJobSessionTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "endrun", hostname, sessionId);     
        
        /// <summary>
        /// Get the topic for the Light Tower Status messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetLightTowerStatusTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "lighttowerchanged", hostname, sessionId);        
        
        /// <summary>
        /// Get the topic for the Marking messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetMarkingTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "operations", "marking", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the Abort Job Session messages
        /// </summary>
        /// <param name="hostname">The hostname to subscribe to.</param>
        /// <param name="sessionId">The session ID to subscribe to.</param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetPauseJobSessionTopic(string hostname, string sessionId)
            =>  TopicBuilder.BuildExternalTopic("command", BASE_TOPIC, "pausejob", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the Pick Part messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetPickPartTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "operations", "pick", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the Place Part messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetPlacePartTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "operations", "place", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the Shutdown messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetShutdownTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "shutdown", hostname, sessionId);  
        
        /// <summary>
        /// Get the topic for the Startup messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetStartupTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "startup", hostname, sessionId);  
        
        /// <summary>
        /// Get the topic for the System Statistics messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetSystemStatisticsTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "systemstatistics", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the System Status messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetSystemStatusTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "systemstatus", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the User Created messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetUserCreatedTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "users", "create", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the User Deleted messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetUserDeletedTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "users", "delete", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the User Login messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetUserLoginTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "users", "login", hostname, sessionId);
        
        /// <summary>
        /// Get the topic for the User Logout messages
        /// </summary>
        /// <param name="hostname">(optional) The hostname to subscribe to. Default = "+".</param>
        /// <param name="sessionId">(optional) The session ID to subscribe to. Default = "+". </param>
        /// <returns>A string representing an MQTT topic</returns>
        public static string GetUserLogoutTopic(string hostname = "+", string sessionId = "+")
            =>  TopicBuilder.BuildExternalTopic(BASE_TOPIC, "users", "logout", hostname, sessionId);
    }
}
