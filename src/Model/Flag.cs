using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NetFlagr.Model
{
    /// <summary>
    /// Flag
    /// </summary>
    [DataContract]
    public partial class Flag : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonProperty("id")]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long? Id { get; private set; }

        /// <summary>
        /// unique key representation of the flag
        /// </summary>
        /// <value>unique key representation of the flag</value>
        [JsonProperty("key")]
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonProperty("description")]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [JsonProperty("enabled")]
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [JsonProperty("tags")]
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public IEnumerable<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [JsonProperty("segments")]
        [DataMember(Name = "segments", EmitDefaultValue = false)]
        public IEnumerable<Segment> Segments { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [JsonProperty("variants")]
        [DataMember(Name = "variants", EmitDefaultValue = false)]
        public IEnumerable<Variant> Variants { get; set; }

        /// <summary>
        /// enabled data records will get data logging in the metrics pipeline, for example, kafka.
        /// </summary>
        /// <value>enabled data records will get data logging in the metrics pipeline, for example, kafka.</value>
        [JsonProperty("dataRecordsEnabled")]
        [DataMember(Name = "dataRecordsEnabled", EmitDefaultValue = false)]
        public bool? DataRecordsEnabled { get; set; }

        /// <summary>
        /// it will override the entityType in the evaluation logs if it&#39;s not empty
        /// </summary>
        /// <value>it will override the entityType in the evaluation logs if it&#39;s not empty</value>
        [JsonProperty("entityType")]
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// flag usage details in markdown format
        /// </summary>
        /// <value>flag usage details in markdown format</value>
        [JsonProperty("notes")]
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [JsonProperty("createdBy")]
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [JsonProperty("updatedBy")]
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonProperty("updatedAt")]
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flag {\n");
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  Key: ").Append(Key).Append('\n');
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  Enabled: ").Append(Enabled).Append('\n');
            sb.Append("  Tags: ").Append(Tags).Append('\n');
            sb.Append("  Segments: ").Append(Segments).Append('\n');
            sb.Append("  Variants: ").Append(Variants).Append('\n');
            sb.Append("  DataRecordsEnabled: ").Append(DataRecordsEnabled).Append('\n');
            sb.Append("  EntityType: ").Append(EntityType).Append('\n');
            sb.Append("  Notes: ").Append(Notes).Append('\n');
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append('\n');
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append('\n');
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

            // Key (string) minLength
            if (Key != null && Key.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Key, length must be greater than 1.", new[] { "Key" });
            }

            // Description (string) minLength
            if (Description != null && Description.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 1.", new[] { "Description" });
            }

            yield break;
        }
    }
}
