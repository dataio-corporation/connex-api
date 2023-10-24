namespace DataIO.ConneX.Api.Mqtt.Messages.Common
{
    /// <summary>
    /// Enum representing the run state of a PSV job
    /// </summary>
    public enum PsvRunState
    {
        /// <summary>
        /// The job has not been started
        /// </summary>
        JobIdle,

        /// <summary>
        /// The job is paused
        /// </summary>
        JobPaused,

        /// <summary>
        /// The job is running
        /// </summary>
        JobRunning,

        /// <summary>
        /// The handler encountered an error and cannot continue the job
        /// </summary>
        JobStopped
    }
}
