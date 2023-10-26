namespace DataIO.ConneX.Api.Mqtt.Messages.MachineManager
{
    using Common;

    /// <summary>
    /// Class representing a command to launch TaskLink for use with FlashCORE programming
    /// </summary>
    /// <remarks>
    /// <para>A <see cref="CommandResponse"/> will be published on the topic machinemanager/commandresponse/{hostname} indicating the success (or failure) of the command.</para>
    /// <para>The <b>TaskName</b> field can also be used to launch with a specific database such as <b>task_database::task_name</b>. See the TaskLink documentation for more information.</para>
    /// </remarks>
    public class LaunchTaskLinkCommand
    {
        /// <summary>
        /// Gets or sets the name of the Task to be run. The Task must be present in the current Task file
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether TaskLink should be run in Administrator Mode
        /// </summary>
        public bool AdministratorMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether TaskLink should be run in Batch Mode
        /// </summary>
        public bool BatchMode { get; set; }

        /// <summary>
        /// Gets or sets the number of devices to process when this Job runs
        /// Must be a whole, non-zero number. This option disables the prompt for pass quantity at run-time and is useful for Batch Mode operation
        /// </summary>
        public int Quantity { get; set; }
    }
}
