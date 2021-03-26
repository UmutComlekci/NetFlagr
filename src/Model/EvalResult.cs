using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// EvalResult
    /// </summary>
    [DataContract]
    public partial class EvalResult : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FlagID
        /// </summary>
        [JsonProperty("flagID")]
        [DataMember(Name = "flagID", EmitDefaultValue = false)]
        public long? FlagID { get; set; }

        /// <summary>
        /// Gets or Sets FlagKey
        /// </summary>
        [JsonProperty("flagKey")]
        [DataMember(Name = "flagKey", EmitDefaultValue = false)]
        public string FlagKey { get; set; }

        /// <summary>
        /// Gets or Sets FlagSnapshotID
        /// </summary>
        [JsonProperty("flagSnapshotID")]
        [DataMember(Name = "flagSnapshotID", EmitDefaultValue = false)]
        public long? FlagSnapshotID { get; set; }

        /// <summary>
        /// Gets or Sets SegmentID
        /// </summary>
        [JsonProperty("segmentID")]
        [DataMember(Name = "segmentID", EmitDefaultValue = false)]
        public long? SegmentID { get; set; }

        /// <summary>
        /// Gets or Sets VariantID
        /// </summary>
        [JsonProperty("variantID")]
        [DataMember(Name = "variantID", EmitDefaultValue = false)]
        public long? VariantID { get; set; }

        /// <summary>
        /// Gets or Sets VariantKey
        /// </summary>
        [JsonProperty("variantKey")]
        [DataMember(Name = "variantKey", EmitDefaultValue = false)]
        public string VariantKey { get; set; }

        /// <summary>
        /// Gets or Sets VariantAttachment
        /// </summary>
        [JsonProperty("variantAttachment")]
        [DataMember(Name = "variantAttachment", EmitDefaultValue = false)]
        public object VariantAttachment { get; set; }

        /// <summary>
        /// Gets or Sets EvalContext
        /// </summary>
        [JsonProperty("evalContext")]
        [DataMember(Name = "evalContext", EmitDefaultValue = false)]
        public EvalContext EvalContext { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets EvalDebugLog
        /// </summary>
        [JsonProperty("evalDebugLog")]
        [DataMember(Name = "evalDebugLog", EmitDefaultValue = false)]
        public EvalDebugLog EvalDebugLog { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvalResult {\n");
            sb.Append("  FlagID: ").Append(FlagID).Append('\n');
            sb.Append("  FlagKey: ").Append(FlagKey).Append('\n');
            sb.Append("  FlagSnapshotID: ").Append(FlagSnapshotID).Append('\n');
            sb.Append("  SegmentID: ").Append(SegmentID).Append('\n');
            sb.Append("  VariantID: ").Append(VariantID).Append('\n');
            sb.Append("  VariantKey: ").Append(VariantKey).Append('\n');
            sb.Append("  VariantAttachment: ").Append(VariantAttachment).Append('\n');
            sb.Append("  EvalContext: ").Append(EvalContext).Append('\n');
            sb.Append("  Timestamp: ").Append(Timestamp).Append('\n');
            sb.Append("  EvalDebugLog: ").Append(EvalDebugLog).Append('\n');
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
