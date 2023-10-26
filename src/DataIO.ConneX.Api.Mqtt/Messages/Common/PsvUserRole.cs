namespace DataIO.ConneX.Api.Mqtt.Messages.Common
{
    /// <summary>
    /// Represents the possible return values for a user's role
    /// </summary>
    public enum PsvUserRole
    {
        /// <summary>
        /// User has operator level permissions
        /// </summary>
        Operator,

        /// <summary>
        /// User has service level permissions
        /// </summary>
        Service,

        /// <summary>
        /// User has supervisor level permissions
        /// </summary>
        Supervisor
    }
}
