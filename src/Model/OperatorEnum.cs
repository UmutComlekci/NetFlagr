using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace NetFlagr.Model
{
    /// <summary>
    /// Defines Operator
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperatorEnum
    {
        /// <summary>
        /// Enum EQ for value: EQ
        /// </summary>
        [EnumMember(Value = "EQ")]
        EQ = 1,

        /// <summary>
        /// Enum NEQ for value: NEQ
        /// </summary>
        [EnumMember(Value = "NEQ")]
        NEQ = 2,

        /// <summary>
        /// Enum LT for value: LT
        /// </summary>
        [EnumMember(Value = "LT")]
        LT = 3,

        /// <summary>
        /// Enum LTE for value: LTE
        /// </summary>
        [EnumMember(Value = "LTE")]
        LTE = 4,

        /// <summary>
        /// Enum GT for value: GT
        /// </summary>
        [EnumMember(Value = "GT")]
        GT = 5,

        /// <summary>
        /// Enum GTE for value: GTE
        /// </summary>
        [EnumMember(Value = "GTE")]
        GTE = 6,

        /// <summary>
        /// Enum EREG for value: EREG
        /// </summary>
        [EnumMember(Value = "EREG")]
        EREG = 7,

        /// <summary>
        /// Enum NEREG for value: NEREG
        /// </summary>
        [EnumMember(Value = "NEREG")]
        NEREG = 8,

        /// <summary>
        /// Enum IN for value: IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN = 9,

        /// <summary>
        /// Enum NOTIN for value: NOTIN
        /// </summary>
        [EnumMember(Value = "NOTIN")]
        NOTIN = 10,

        /// <summary>
        /// Enum CONTAINS for value: CONTAINS
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        CONTAINS = 11,

        /// <summary>
        /// Enum NOTCONTAINS for value: NOTCONTAINS
        /// </summary>
        [EnumMember(Value = "NOTCONTAINS")]
        NOTCONTAINS = 12
    }
}
