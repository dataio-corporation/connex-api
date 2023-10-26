namespace DataIO.ConneX.Api.Mqtt.Messages.PsvSystem
{
    /// <summary>
    /// Class representing a Light Tower Status MQTT message
    /// </summary>
    public class LightTowerStatusMessage
    {
        /// <summary>
        /// The new light tower state
        /// </summary>
        /// <remarks>
        /// <para>The following are the possible light tower statuses:</para>
        /// <list type="definition">
        ///     <item>
        ///         <term>Alternating Green-Yellow</term>
        ///         <description>Light tower is alternating between green and yellow lamps illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Alternating Yellow-Red</term>
        ///         <description>Light tower is alternating between yellow and red lamps illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Alternating Yellow-Red with alarm</term>
        ///         <description>Light tower is alternating the yellow and red lamp and emitting an audible alarm.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing Red</term>
        ///         <description>Light tower is flashing the red lamp exclusively.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing red with alarm</term>
        ///         <description>Light tower is flashing the red lamp exclusively and emitting an audible alarm.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing Yellow</term>
        ///         <description>Light tower is flashing the yellow lamp exclusively.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing Yellow with alarm</term>
        ///         <description>Light tower is flashing the yellow lamp exclusively and emitting an audible alarm.</description>
        ///     </item>
        ///     <item>
        ///         <term>Green</term>
        ///         <description>Light tower has only the green lamp illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Off</term>
        ///         <description>Light tower is off.</description>
        ///     </item>
        ///     <item>
        ///         <term>Red</term>
        ///         <description>Light tower has only the Red lamp illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Yellow</term>
        ///         <description>Light tower has only the yellow lamp illuminated.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        public string NewState { get; set; }
        
        /// <summary>
        /// The old light tower state
        /// </summary>
        /// <remarks>
        /// <para>The following are the possible light tower statuses:</para>
        /// <list type="definition">
        ///     <item>
        ///         <term>Alternating Green-Yellow</term>
        ///         <description>Light tower is alternating between green and yellow lamps illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Alternating Yellow-Red</term>
        ///         <description>Light tower is alternating between yellow and red lamps illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Alternating Yellow-Red with alarm</term>
        ///         <description>Light tower is alternating the yellow and red lamp and emitting an audible alarm.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing Red</term>
        ///         <description>Light tower is flashing the red lamp exclusively.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing red with alarm</term>
        ///         <description>Light tower is flashing the red lamp exclusively and emitting an audible alarm.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing Yellow</term>
        ///         <description>Light tower is flashing the yellow lamp exclusively.</description>
        ///     </item>
        ///     <item>
        ///         <term>Flashing Yellow with alarm</term>
        ///         <description>Light tower is flashing the yellow lamp exclusively and emitting an audible alarm.</description>
        ///     </item>
        ///     <item>
        ///         <term>Green</term>
        ///         <description>Light tower has only the green lamp illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Off</term>
        ///         <description>Light tower is off.</description>
        ///     </item>
        ///     <item>
        ///         <term>Red</term>
        ///         <description>Light tower has only the Red lamp illuminated.</description>
        ///     </item>
        ///     <item>
        ///         <term>Yellow</term>
        ///         <description>Light tower has only the yellow lamp illuminated.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        public string OldState { get; set; }
    }
}
