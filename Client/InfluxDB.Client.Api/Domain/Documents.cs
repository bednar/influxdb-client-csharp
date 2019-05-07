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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// Documents
    /// </summary>
    [DataContract]
    public partial class Documents :  IEquatable<Documents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Documents" /> class.
        /// </summary>
        /// <param name="documents">documents.</param>
        public Documents(List<DocumentListEntry> documents = default(List<DocumentListEntry>))
        {
            this._Documents = documents;
        }

        /// <summary>
        /// Gets or Sets _Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<DocumentListEntry> _Documents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Documents {\n");
            sb.Append("  _Documents: ").Append(_Documents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Documents);
        }

        /// <summary>
        /// Returns true if Documents instances are equal
        /// </summary>
        /// <param name="input">Instance of Documents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Documents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Documents == input._Documents ||
                    this._Documents != null &&
                    this._Documents.SequenceEqual(input._Documents)
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
                int hashCode = 41;
                if (this._Documents != null)
                    hashCode = hashCode * 59 + this._Documents.GetHashCode();
                return hashCode;
            }
        }

    }

}
