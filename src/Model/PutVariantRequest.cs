using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// PutVariantRequest
    /// </summary>
    [DataContract]
    public partial class PutVariantRequest : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [JsonProperty("key")]
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Attachment
        /// </summary>
        [JsonProperty("attachment")]
        [DataMember(Name = "attachment", EmitDefaultValue = false)]
        public object Attachment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutVariantRequest {\n");
            sb.Append("  Key: ").Append(Key).Append('\n');
            sb.Append("  Attachment: ").Append(Attachment).Append('\n');
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
            // Key (string) minLength
            if (Key != null && Key.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Key, length must be greater than 1.", new[] { "Key" });
            }

            yield break;
        }
    }
}
