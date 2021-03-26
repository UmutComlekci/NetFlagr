using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// PutFlagRequest
    /// </summary>
    [DataContract]
    public partial class PutFlagRequest : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonProperty("description")]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// enabled data records will get data logging in the metrics pipeline, for example, kafka.
        /// </summary>
        /// <value>enabled data records will get data logging in the metrics pipeline, for example, kafka.</value>
        [JsonProperty("dataRecordsEnabled")]
        [DataMember(Name = "dataRecordsEnabled", EmitDefaultValue = false)]
        public bool? DataRecordsEnabled { get; set; }

        /// <summary>
        /// it will overwrite entityType into evaluation logs if it&#39;s not empty
        /// </summary>
        /// <value>it will overwrite entityType into evaluation logs if it&#39;s not empty</value>
        [JsonProperty("entityType")]
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [JsonProperty("enabled")]
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [JsonProperty("key")]
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [JsonProperty("notes")]
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutFlagRequest {\n");
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  DataRecordsEnabled: ").Append(DataRecordsEnabled).Append('\n');
            sb.Append("  EntityType: ").Append(EntityType).Append('\n');
            sb.Append("  Enabled: ").Append(Enabled).Append('\n');
            sb.Append("  Key: ").Append(Key).Append('\n');
            sb.Append("  Notes: ").Append(Notes).Append('\n');
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
