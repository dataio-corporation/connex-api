namespace DataIO.ConneX.Api.Mqtt.Messages.Programmer
{
    /// <summary>
    /// Class representing versioning information about a programmer component
    /// </summary>
    public class ProgrammerVersionInformation
    {
        /// <summary>
        /// Gets or sets the name of the component
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Gets or sets the programmer's version
        /// </summary>
        public string Version { get; set; }
    }
}
