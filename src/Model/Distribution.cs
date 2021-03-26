using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// Distribution
    /// </summary>
    [DataContract]
    public partial class Distribution : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonProperty("id")]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [JsonProperty("percent")]
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public long? Percent { get; set; }

        /// <summary>
        /// Gets or Sets VariantKey
        /// </summary>
        [JsonProperty("variantKey")]
        [DataMember(Name = "variantKey", EmitDefaultValue = false)]
        public string VariantKey { get; set; }

        /// <summary>
        /// Gets or Sets VariantID
        /// </summary>
        [JsonProperty("variantID")]
        [DataMember(Name = "variantID", EmitDefaultValue = false)]
        public long? VariantID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Distribution {\n");
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  Percent: ").Append(Percent).Append('\n');
            sb.Append("  VariantKey: ").Append(VariantKey).Append('\n');
            sb.Append("  VariantID: ").Append(VariantID).Append('\n');
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
            // Id (long?) minimum
            if (Id < 1)
            {
                yield return new ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new[] { "Id" });
            }

            // Percent (long?) maximum
            if (Percent > 100)
            {
                yield return new ValidationResult("Invalid value for Percent, must be a value less than or equal to 100.", new[] { "Percent" });
            }

            // Percent (long?) minimum
            if (Percent < 0)
            {
                yield return new ValidationResult("Invalid value for Percent, must be a value greater than or equal to 0.", new[] { "Percent" });
            }

            // VariantKey (string) minLength
            if (VariantKey != null && VariantKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for VariantKey, length must be greater than 1.", new[] { "VariantKey" });
            }

            // VariantID (long?) minimum
            if (VariantID < 1)
            {
                yield return new ValidationResult("Invalid value for VariantID, must be a value greater than or equal to 1.", new[] { "VariantID" });
            }

            yield break;
        }
    }
}
