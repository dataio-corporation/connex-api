namespace DataIO.ConneX.Api.Mqtt.Messages.Common
{
    /// <summary>
    /// Class representing an error message
    /// </summary>
    public class ErrorMessage
    {
        /// <summary>
        /// Gets or sets the error code (if provided)
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error level
        /// </summary>
        public ErrorLevel ErrorLevel { get; set; }

        /// <summary>
        /// Gets or sets the error message
        /// </summary>
        public string Message { get; set; }
    }
}
