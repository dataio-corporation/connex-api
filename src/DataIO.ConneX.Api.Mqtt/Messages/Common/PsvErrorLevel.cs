namespace DataIO.ConneX.Api.Mqtt.Messages.Common
{
    /// <summary>
    /// Enum representing the severity level of an error
    /// </summary>
    public enum ErrorLevel
    {
        /// <summary>
        /// The error is a warning, but operation can continue
        /// </summary>
        Warning = 0,

        /// <summary>
        /// The error is an error, operation cannot continue
        /// </summary>
        Error = 1,

        /// <summary>
        /// The error is a fatal error, operation cannot continue and software may be in an unstable state
        /// </summary>
        Fatal = 2
    }
}
