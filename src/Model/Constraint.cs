using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// Constraint
    /// </summary>
    [DataContract]
    public partial class Constraint : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [JsonProperty("operator")]
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public OperatorEnum Operator { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonProperty("id")]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [JsonProperty("property")]
        [DataMember(Name = "property", EmitDefaultValue = false)]
        public string Property { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonProperty("value")]
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Constraint {\n");
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  Property: ").Append(Property).Append('\n');
            sb.Append("  Operator: ").Append(Operator).Append('\n');
            sb.Append("  Value: ").Append(Value).Append('\n');
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
            // Id (long) minimum
            if (Id < 1)
            {
                yield return new ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new[] { "Id" });
            }

            // Property (string) minLength
            if (Property != null && Property.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Property, length must be greater than 1.", new[] { "Property" });
            }

            // Value (string) minLength
            if (Value != null && Value.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Value, length must be greater than 1.", new[] { "Value" });
            }

            yield break;
        }
    }
}
