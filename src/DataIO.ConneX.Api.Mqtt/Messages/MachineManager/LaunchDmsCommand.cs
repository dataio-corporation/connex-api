namespace DataIO.ConneX.Api.Mqtt.Messages.MachineManager
{
    using Common;
    
    /// <summary>
    /// Class representing a command to launch DMS for use with LumenX programming
    /// </summary>
    /// <remarks>A <see cref="CommandResponse"/> will be published on the topic machinemanager/commandresponse/{hostname} indicating the success (or failure) of the command.</remarks>
    public class LaunchDmsCommand
    {
        /// <summary>
        /// Gets or sets the name of the job to be run
        /// </summary>
        /// <remarks>NOTE: Providing both JobName and JobPath fields is not supported and will result in an error</remarks>
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets the file path of the job to be run
        /// </summary>
        /// <remarks>NOTE: Providing both JobName and JobPath fields is not supported and will result in an error</remarks>
        public string JobPath { get; set; }

        /// <summary>
        /// Gets or sets the number of devices to process when this job runs. Must be a whole, non-zero number
        /// </summary>
        public int Quantity { get; set; }
    }
}
