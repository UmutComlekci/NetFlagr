using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// EvalDebugLog
    /// </summary>
    [DataContract]
    public partial class EvalDebugLog : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SegmentDebugLogs
        /// </summary>
        [JsonProperty("segmentDebugLogs")]
        [DataMember(Name = "segmentDebugLogs", EmitDefaultValue = false)]
        public IEnumerable<SegmentDebugLog> SegmentDebugLogs { get; set; }

        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [JsonProperty("msg")]
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvalDebugLog {\n");
            sb.Append("  SegmentDebugLogs: ").Append(SegmentDebugLogs).Append('\n');
            sb.Append("  Msg: ").Append(Msg).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
