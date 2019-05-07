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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// TelegrafPluginOutputInfluxDBV2Config
    /// </summary>
    [DataContract]
    public partial class TelegrafPluginOutputInfluxDBV2Config :  IEquatable<TelegrafPluginOutputInfluxDBV2Config>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginOutputInfluxDBV2Config" /> class.
        /// </summary>
        [JsonConstructor]
        protected TelegrafPluginOutputInfluxDBV2Config() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginOutputInfluxDBV2Config" /> class.
        /// </summary>
        /// <param name="urls">urls (required).</param>
        /// <param name="token">token (required).</param>
        /// <param name="organization">organization (required).</param>
        /// <param name="bucket">bucket (required).</param>
        public TelegrafPluginOutputInfluxDBV2Config(List<string> urls = default(List<string>), string token = default(string), string organization = default(string), string bucket = default(string))
        {
            // to ensure "urls" is required (not null)
            if (urls == null)
            {
                throw new InvalidDataException("urls is a required property for TelegrafPluginOutputInfluxDBV2Config and cannot be null");
            }
            else
            {
                this.Urls = urls;
            }
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new InvalidDataException("token is a required property for TelegrafPluginOutputInfluxDBV2Config and cannot be null");
            }
            else
            {
                this.Token = token;
            }
            // to ensure "organization" is required (not null)
            if (organization == null)
            {
                throw new InvalidDataException("organization is a required property for TelegrafPluginOutputInfluxDBV2Config and cannot be null");
            }
            else
            {
                this.Organization = organization;
            }
            // to ensure "bucket" is required (not null)
            if (bucket == null)
            {
                throw new InvalidDataException("bucket is a required property for TelegrafPluginOutputInfluxDBV2Config and cannot be null");
            }
            else
            {
                this.Bucket = bucket;
            }
        }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [DataMember(Name="urls", EmitDefaultValue=false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name="bucket", EmitDefaultValue=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelegrafPluginOutputInfluxDBV2Config {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
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
            return this.Equals(input as TelegrafPluginOutputInfluxDBV2Config);
        }

        /// <summary>
        /// Returns true if TelegrafPluginOutputInfluxDBV2Config instances are equal
        /// </summary>
        /// <param name="input">Instance of TelegrafPluginOutputInfluxDBV2Config to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelegrafPluginOutputInfluxDBV2Config input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
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
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                return hashCode;
            }
        }

    }

}
