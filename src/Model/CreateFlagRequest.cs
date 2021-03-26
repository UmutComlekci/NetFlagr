using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// CreateFlagRequest
    /// </summary>
    [DataContract]
    public partial class CreateFlagRequest : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonProperty("description")]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// unique key representation of the flag
        /// </summary>
        /// <value>unique key representation of the flag</value>
        [JsonProperty("key")]
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// template for flag creation
        /// </summary>
        /// <value>template for flag creation</value>
        [JsonProperty("template")]
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFlagRequest {\n");
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  Key: ").Append(Key).Append('\n');
            sb.Append("  Template: ").Append(Template).Append('\n');
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

            yield break;
        }
    }
}
