using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// EvaluationBatchRequest
    /// </summary>
    [DataContract]
    public partial class EvaluationBatchRequest : IValidatableObject
    {
        /// <summary>
        /// determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.
        /// </summary>
        /// <value>determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.</value>
        [JsonProperty("flagTagsOperator")]
        [DataMember(Name = "flagTagsOperator", EmitDefaultValue = false)]
        public FlagTagsOperatorEnum? FlagTagsOperator { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [JsonProperty("entities")]
        [DataMember(Name = "entities", EmitDefaultValue = false)]
        public IEnumerable<EvaluationEntity> Entities { get; set; }

        /// <summary>
        /// Gets or Sets EnableDebug
        /// </summary>
        [JsonProperty("enableDebug")]
        [DataMember(Name = "enableDebug", EmitDefaultValue = false)]
        public bool? EnableDebug { get; set; }

        /// <summary>
        /// flagIDs
        /// </summary>
        /// <value>flagIDs</value>
        [JsonProperty("flagIDs")]
        [DataMember(Name = "flagIDs", EmitDefaultValue = false)]
        public IEnumerable<long> FlagIDs { get; set; }

        /// <summary>
        /// flagKeys. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.
        /// </summary>
        /// <value>flagKeys. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.</value>
        [JsonProperty("flagKeys")]
        [DataMember(Name = "flagKeys", EmitDefaultValue = false)]
        public IEnumerable<string> FlagKeys { get; set; }

        /// <summary>
        /// flagTags. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.
        /// </summary>
        /// <value>flagTags. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.</value>
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
            sb.Append("class EvaluationBatchRequest {\n");
            sb.Append("  Entities: ").Append(Entities).Append('\n');
            sb.Append("  EnableDebug: ").Append(EnableDebug).Append('\n');
            sb.Append("  FlagIDs: ").Append(FlagIDs).Append('\n');
            sb.Append("  FlagKeys: ").Append(FlagKeys).Append('\n');
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
            yield break;
        }
    }
}
