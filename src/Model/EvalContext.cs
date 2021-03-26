using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// EvalContext
    /// </summary>
    [DataContract]
    public partial class EvalContext : IValidatableObject
    {
        /// <summary>
        /// determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.
        /// </summary>
        /// <value>determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.</value>
        [JsonProperty("flagTagsOperator")]
        [DataMember(Name = "flagTagsOperator", EmitDefaultValue = false)]
        public FlagTagsOperatorEnum? FlagTagsOperator { get; set; }

        /// <summary>
        /// entityID is used to deterministically at random to evaluate the flag result. If it&#39;s empty, flagr will randomly generate one.
        /// </summary>
        /// <value>entityID is used to deterministically at random to evaluate the flag result. If it&#39;s empty, flagr will randomly generate one.</value>
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
        /// Gets or Sets EnableDebug
        /// </summary>
        [JsonProperty("enableDebug")]
        [DataMember(Name = "enableDebug", EmitDefaultValue = false)]
        public bool? EnableDebug { get; set; }

        /// <summary>
        /// flagID
        /// </summary>
        /// <value>flagID</value>
        [JsonProperty("flagID")]
        [DataMember(Name = "flagID", EmitDefaultValue = false)]
        public long? FlagID { get; set; }

        /// <summary>
        /// flagKey. flagID or flagKey will resolve to the same flag. Either works.
        /// </summary>
        /// <value>flagKey. flagID or flagKey will resolve to the same flag. Either works.</value>
        [JsonProperty("flagKey")]
        [DataMember(Name = "flagKey", EmitDefaultValue = false)]
        public string FlagKey { get; set; }

        /// <summary>
        /// flagTags. flagTags looks up flags by tag. Either works.
        /// </summary>
        /// <value>flagTags. flagTags looks up flags by tag. Either works.</value>
        [JsonProperty("flagTags")]
        [DataMember(Name = "flagTags", EmitDefaultValue = false)]
        public IEnumerable<string> FlagTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvalContext {\n");
            sb.Append("  EntityID: ").Append(EntityID).Append('\n');
            sb.Append("  EntityType: ").Append(EntityType).Append('\n');
            sb.Append("  EntityContext: ").Append(EntityContext).Append('\n');
            sb.Append("  EnableDebug: ").Append(EnableDebug).Append('\n');
            sb.Append("  FlagID: ").Append(FlagID).Append('\n');
            sb.Append("  FlagKey: ").Append(FlagKey).Append('\n');
            sb.Append("  FlagTags: ").Append(FlagTags).Append('\n');
            sb.Append("  FlagTagsOperator: ").Append(FlagTagsOperator).Append('\n');
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
            // FlagID (long?) minimum
            if (FlagID < 1)
            {
                yield return new ValidationResult("Invalid value for FlagID, must be a value greater than or equal to 1.", new[] { "FlagID" });
            }

            yield break;
        }
    }
}
