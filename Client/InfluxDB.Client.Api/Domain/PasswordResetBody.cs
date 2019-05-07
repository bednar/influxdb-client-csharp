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

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// PasswordResetBody
    /// </summary>
    [DataContract]
    public partial class PasswordResetBody :  IEquatable<PasswordResetBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetBody" /> class.
        /// </summary>
        [JsonConstructor]
        protected PasswordResetBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetBody" /> class.
        /// </summary>
        /// <param name="password">password (required).</param>
        public PasswordResetBody(string password = default(string))
        {
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for PasswordResetBody and cannot be null");
            }
            else
            {
                this.Password = password;
            }
        }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordResetBody {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as PasswordResetBody);
        }

        /// <summary>
        /// Returns true if PasswordResetBody instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordResetBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordResetBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }

    }

}
