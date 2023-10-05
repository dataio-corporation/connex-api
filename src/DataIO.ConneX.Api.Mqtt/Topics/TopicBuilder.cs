using System.Text;

namespace DataIO.ConneX.Api.Mqtt.Topics
{
    /// <summary>
    /// Topic helper class
    /// </summary>
    public static class TopicBuilder
    {
        /// <summary>
        /// Build a ConneX topic by passing in the different levels
        /// </summary>
        /// <param name="levels">An ordered array of the topic levels</param>
        /// <returns>An MQTT topic</returns>
        internal static string BuildTopic(params string[] levels)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("conneX");

            foreach (var part in levels)
            {
                stringBuilder.Append($"/{part}");
            }

            return stringBuilder.ToString().ToLower();
        }
        
        /// <summary>
        /// Build an external topic (not from ConneX) by passing in the different levels
        /// </summary>
        /// <param name="levels">An ordered array of the topic levels</param>
        /// <returns>An MQTT topic</returns>
        internal static string BuildExternalTopic(params string[] levels)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(levels[0]);
            
            foreach (var part in levels[1..])
            {
                stringBuilder.Append($"/{part}");
            }

            return stringBuilder.ToString();
        }
    }
}
