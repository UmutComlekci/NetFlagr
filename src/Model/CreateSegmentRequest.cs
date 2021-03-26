using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// CreateSegmentRequest
    /// </summary>
    [DataContract]
    public partial class CreateSegmentRequest : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonProperty("description")]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RolloutPercent
        /// </summary>
        [JsonProperty("rolloutPercent")]
        [DataMember(Name = "rolloutPercent", EmitDefaultValue = false)]
        public long? RolloutPercent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSegmentRequest {\n");
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  RolloutPercent: ").Append(RolloutPercent).Append('\n');
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
            // Description (string) minLength
            if (Description != null && Description.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 1.", new[] { "Description" });
            }

            // RolloutPercent (long?) maximum
            if (RolloutPercent > 100)
            {
                yield return new ValidationResult("Invalid value for RolloutPercent, must be a value less than or equal to 100.", new[] { "RolloutPercent" });
            }

            // RolloutPercent (long?) minimum
            if (RolloutPercent < 0)
            {
                yield return new ValidationResult("Invalid value for RolloutPercent, must be a value greater than or equal to 0.", new[] { "RolloutPercent" });
            }

            yield break;
        }
    }
}
