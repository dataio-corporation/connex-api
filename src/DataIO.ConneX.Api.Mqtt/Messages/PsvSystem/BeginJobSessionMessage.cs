using System.Text.Json.Serialization;

namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a Begin Job Session MQTT message
    /// </summary>
    public class BeginJobSessionMessage
    {
        /// <summary>
        /// Gets or sets the version of the installed AH700 software
        /// </summary>
        /// <remarks>Will not be populated if the <see cref="Ch700Version"/> property is set</remarks>
        [JsonPropertyName("AH700Version")]
        public string Ah700Version { get; set; }
        
        /// <summary>
        /// Gets or sets the version of the installed CH700 software
        /// </summary>
        /// <remarks>Will not be populated if the <see cref="Ah700Version"/> property is set</remarks>
        [JsonPropertyName("CH700Version")]
        public string Ch700Version { get; set; }
        
        /// <summary>
        /// Gets or sets the full path of the file used for 2D inspection
        /// </summary>
        [JsonPropertyName("2DInspectionProjectFile")]
        public string TwoDInspectionProjectFile { get; set; }
        
        /// <summary>
        /// Gets or sets the full path of the file used for 3D inspection
        /// </summary>
        [JsonPropertyName("3DInspectionProjectFile")]
        public string ThreeDInspectionProjectFile { get; set; }
        
        /// <summary>
        /// Gets or sets whether the programmers are ignored
        /// </summary>
        public bool IgnoreProgrammers  { get; set; }
        
        /// <summary>
        /// Gets or sets the full path of the file used for laser marking
        /// </summary>
        public string LaserMarkingProjectFile { get; set; }
        
        /// <summary>
        /// Gets or sets the machine identifier
        /// </summary>
        [JsonPropertyName("MachineID")]
        public string MachineId { get; set; }
        
        /// <summary>
        /// Gets or sets the contents of the file used for machine parameters
        /// </summary>
        public string MachineParametersFile { get; set; }
        
        /// <summary>
        /// Gets or sets the contents of the file used for package parameters
        /// </summary>
        public string PackageParametersFile  { get; set; }
        
        /// <summary>
        /// Gets or sets the checksum for the job that is starting
        /// </summary>
        public string Sumcheck { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the job that is starting
        /// </summary>
        public string TaskName { get; set; }
        
        /// <summary>
        /// Gets or sets the full path of the file used for vision inspection (CH700 only)
        /// </summary>
        public string VisionInspectionProjectFile { get; set; }
        
        /// <summary>
        /// Gets or sets the contents of the WinAH400.ini file used
        /// </summary>
        [JsonPropertyName("WinAH400INIFile")]
        public string WinAh400IniFile { get; set; }
    }
}
