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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// IsOnboarding
    /// </summary>
    [DataContract]
    public partial class IsOnboarding :  IEquatable<IsOnboarding>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsOnboarding" /> class.
        /// </summary>
        /// <param name="allowed">true means that the influxdb instance has NOT had initial setup; false means that the database has been setup..</param>
        public IsOnboarding(bool? allowed = default(bool?))
        {
            this.Allowed = allowed;
        }

        /// <summary>
        /// true means that the influxdb instance has NOT had initial setup; false means that the database has been setup.
        /// </summary>
        /// <value>true means that the influxdb instance has NOT had initial setup; false means that the database has been setup.</value>
        [DataMember(Name="allowed", EmitDefaultValue=false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsOnboarding {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
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
            return this.Equals(input as IsOnboarding);
        }

        /// <summary>
        /// Returns true if IsOnboarding instances are equal
        /// </summary>
        /// <param name="input">Instance of IsOnboarding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsOnboarding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Allowed == input.Allowed ||
                    (this.Allowed != null &&
                    this.Allowed.Equals(input.Allowed))
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
                if (this.Allowed != null)
                    hashCode = hashCode * 59 + this.Allowed.GetHashCode();
                return hashCode;
            }
        }

    }

}
