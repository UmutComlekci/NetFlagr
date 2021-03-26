using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// PutSegmentReorderRequest
    /// </summary>
    [DataContract]
    public partial class PutSegmentReorderRequest : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SegmentIDs
        /// </summary>
        [JsonProperty("segmentIDs")]
        [DataMember(Name = "segmentIDs", EmitDefaultValue = false)]
        public IEnumerable<long> SegmentIDs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutSegmentReorderRequest {\n");
            sb.Append("  SegmentIDs: ").Append(SegmentIDs).Append('\n');
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
