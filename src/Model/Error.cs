using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// Error
    /// </summary>
    [DataContract]
    public partial class Error : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonProperty("message")]
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Message: ").Append(Message).Append('\n');
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
            // Message (string) minLength
            if (Message != null && Message.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Message, length must be greater than 1.", new[] { "Message" });
            }

            yield break;
        }
    }
}
