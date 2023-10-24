namespace DataIO.ConneX.Api.Mqtt.Messages.Common
{
    /// <summary>
    /// Enum representing the type of PSV system
    /// </summary>
    public enum PsvMachineType
    {
        /// <summary>
        /// System is running in desktop mode
        /// </summary>
        DesktopMode,

        /// <summary>
        /// System is a PSV3000 machine
        /// </summary>
        PSV3000,

        /// <summary>
        /// System is a PSV3500 machine
        /// </summary>
        PSV3500,

        /// <summary>
        /// System is a PSV5000 machine
        /// </summary>
        PSV5000,

        /// <summary>
        /// System is a PSV7000 machine
        /// </summary>
        PSV7000
    }
}
