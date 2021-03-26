using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// FlagSnapshot
    /// </summary>
    [DataContract]
    public partial class FlagSnapshot : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonProperty("id")]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [JsonProperty("updatedBy")]
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Flag
        /// </summary>
        [JsonProperty("flag")]
        [DataMember(Name = "flag", EmitDefaultValue = false)]
        public Flag Flag { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonProperty("updatedAt")]
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlagSnapshot {\n");
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append('\n');
            sb.Append("  Flag: ").Append(Flag).Append('\n');
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append('\n');
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

            // UpdatedAt (string) minLength
            if (UpdatedAt != null && UpdatedAt.Length < 1)
            {
                yield return new ValidationResult("Invalid value for UpdatedAt, length must be greater than 1.", new[] { "UpdatedAt" });
            }

            yield break;
        }
    }
}
