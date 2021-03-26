using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// PutDistributionsRequest
    /// </summary>
    [DataContract]
    public partial class PutDistributionsRequest : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Distributions
        /// </summary>
        [JsonProperty("distributions")]
        [DataMember(Name = "distributions", EmitDefaultValue = false)]
        public IEnumerable<Distribution> Distributions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutDistributionsRequest {\n");
            sb.Append("  Distributions: ").Append(Distributions).Append('\n');
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
