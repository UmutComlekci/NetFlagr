using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// EvaluationBatchResponse
    /// </summary>
    [DataContract]
    public partial class EvaluationBatchResponse : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EvaluationResults
        /// </summary>
        [JsonProperty("evaluationResults")]
        [DataMember(Name = "evaluationResults", EmitDefaultValue = false)]
        public IEnumerable<EvalResult> EvaluationResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationBatchResponse {\n");
            sb.Append("  EvaluationResults: ").Append(EvaluationResults).Append('\n');
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
