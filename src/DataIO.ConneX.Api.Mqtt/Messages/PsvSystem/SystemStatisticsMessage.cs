using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a System Statistics MQTT message
    /// </summary>
    public class SystemStatisticsMessage
    {
        /// <summary>
        /// Gets or sets the number of devices that failed as a result of the 3D system
        /// </summary>
        [JsonPropertyName("DevicesFailedOn3DSystem")]
        public int DevicesFailedOn3dSystem { get; set; }

        /// <summary>
        /// Gets or sets the number of devices that failed as a result of the laser
        /// </summary>
        public int DevicesFailedOnLaser { get; set; }

        /// <summary>
        /// Gets or sets the number of devices that failed as a result of programming
        /// </summary>
        public int DevicesFailedOnProgrammer { get; set; }

        /// <summary>
        /// Gets or sets the number of devices that failed recurrent empty socket test (REST)
        /// </summary>
        [JsonPropertyName("DevicesFailedREST")]
        public int DevicesFailedRest { get; set; }

        /// <summary>
        /// Gets or sets the number of devices that failed vision inspection
        /// </summary>
        public int DevicesFailedVision { get; set; }

        /// <summary>
        /// Gets or sets the number of devices picked from the input media
        /// </summary>
        public int DevicesPickedInput { get; set; }

        /// <summary>
        /// Gets or sets the percentage of devices that were picked from the input media and are placed in the output and reject media
        /// </summary>
        public string HandlerYield { get; set; }

        /// <summary>
        /// Gets or sets the job assistance time
        /// </summary>
        public string JobAssistanceTime { get; set; }

        /// <summary>
        /// Gets or sets the estimated job completion time
        /// </summary>
        public string JobCompletionEstimate { get; set; }

        /// <summary>
        /// Gets or sets the job processing time
        /// </summary>
        public string JobProcessingTime { get; set; }

        /// <summary>
        /// Gets or sets the percentage of devices that passed programming
        /// </summary>
        public string ProgrammerYield { get; set; }

        /// <summary>
        /// Gets or sets the percentage of devices that were picked from the input media and are placed in the output media
        /// </summary>
        public string SystemYield { get; set; }

        /// <summary>
        /// Gets or sets the number of devices that failed in the job session
        /// </summary>
        public int TotalFail { get; set; }

        /// <summary>
        /// Gets or sets the number of devices that passed in the job session
        /// </summary>
        public int TotalPass { get; set; }

        /// <summary>
        /// Gets or sets the job throughput (including operator intervention time) of the job session
        /// </summary>
        [JsonPropertyName("UPH")]
        public int Uph { get; set; }
    }
}
