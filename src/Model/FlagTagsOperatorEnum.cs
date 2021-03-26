using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace NetFlagr.Model
{
    /// <summary>
    /// determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.
    /// </summary>
    /// <value>determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlagTagsOperatorEnum
    {
        /// <summary>
        /// Enum ANY for value: ANY
        /// </summary>
        [EnumMember(Value = "ANY")]
        ANY = 1,

        /// <summary>
        /// Enum ALL for value: ALL
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL = 2
    }
}
