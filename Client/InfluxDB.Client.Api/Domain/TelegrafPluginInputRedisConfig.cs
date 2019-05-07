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
    /// TelegrafPluginInputRedisConfig
    /// </summary>
    [DataContract]
    public partial class TelegrafPluginInputRedisConfig :  IEquatable<TelegrafPluginInputRedisConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginInputRedisConfig" /> class.
        /// </summary>
        /// <param name="servers">servers.</param>
        /// <param name="password">password.</param>
        public TelegrafPluginInputRedisConfig(List<string> servers = default(List<string>), string password = default(string))
        {
            this.Servers = servers;
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Servers
        /// </summary>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public List<string> Servers { get; set; }

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
            sb.Append("class TelegrafPluginInputRedisConfig {\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
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
            return this.Equals(input as TelegrafPluginInputRedisConfig);
        }

        /// <summary>
        /// Returns true if TelegrafPluginInputRedisConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TelegrafPluginInputRedisConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelegrafPluginInputRedisConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
                ) && 
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
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }

    }

}
