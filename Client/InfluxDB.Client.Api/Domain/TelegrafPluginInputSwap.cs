/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// TelegrafPluginInputSwap
    /// </summary>
    [DataContract]
    public partial class TelegrafPluginInputSwap : TelegrafRequestPlugin,  IEquatable<TelegrafPluginInputSwap>
    {
        /// <summary>
        /// Defines Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum Swap for value: swap
            /// </summary>
            [EnumMember(Value = "swap")]
            Swap = 1
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginInputSwap" /> class.
        /// </summary>
        [JsonConstructor]
        protected TelegrafPluginInputSwap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginInputSwap" /> class.
        /// </summary>
        /// <param name="name">name (required) (default to NameEnum.Swap).</param>
        /// <param name="comment">comment.</param>
        public TelegrafPluginInputSwap(NameEnum name = NameEnum.Swap, TypeEnum type = TypeEnum.Input, string comment = default(string)) : base(type)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TelegrafPluginInputSwap and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Comment = comment;
        }


        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelegrafPluginInputSwap {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TelegrafPluginInputSwap);
        }

        /// <summary>
        /// Returns true if TelegrafPluginInputSwap instances are equal
        /// </summary>
        /// <param name="input">Instance of TelegrafPluginInputSwap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelegrafPluginInputSwap input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }

    }

}
