using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// SegmentDebugLog
    /// </summary>
    [DataContract]
    public partial class SegmentDebugLog : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SegmentID
        /// </summary>
        [JsonProperty("segmentID")]
        [DataMember(Name = "segmentID", EmitDefaultValue = false)]
        public long SegmentID { get; set; }

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
            sb.Append("class SegmentDebugLog {\n");
            sb.Append("  SegmentID: ").Append(SegmentID).Append('\n');
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
            // SegmentID (long) minimum
            if (SegmentID < 1)
            {
                yield return new ValidationResult("Invalid value for SegmentID, must be a value greater than or equal to 1.", new[] { "SegmentID" });
            }

            yield break;
        }
    }
}
