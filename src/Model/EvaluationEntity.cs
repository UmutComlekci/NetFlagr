using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// EvaluationEntity
    /// </summary>
    [DataContract]
    public partial class EvaluationEntity : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EntityID
        /// </summary>
        [JsonProperty("entityID")]
        [DataMember(Name = "entityID", EmitDefaultValue = false)]
        public string EntityID { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [JsonProperty("entityType")]
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets EntityContext
        /// </summary>
        [JsonProperty("entityContext")]
        [DataMember(Name = "entityContext", EmitDefaultValue = false)]
        public object EntityContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationEntity {\n");
            sb.Append("  EntityID: ").Append(EntityID).Append('\n');
            sb.Append("  EntityType: ").Append(EntityType).Append('\n');
            sb.Append("  EntityContext: ").Append(EntityContext).Append('\n');
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
