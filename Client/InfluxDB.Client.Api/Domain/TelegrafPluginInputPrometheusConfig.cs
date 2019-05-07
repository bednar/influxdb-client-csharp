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
    /// TelegrafPluginInputPrometheusConfig
    /// </summary>
    [DataContract]
    public partial class TelegrafPluginInputPrometheusConfig :  IEquatable<TelegrafPluginInputPrometheusConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginInputPrometheusConfig" /> class.
        /// </summary>
        /// <param name="urls">urls.</param>
        public TelegrafPluginInputPrometheusConfig(List<string> urls = default(List<string>))
        {
            this.Urls = urls;
        }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [DataMember(Name="urls", EmitDefaultValue=false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelegrafPluginInputPrometheusConfig {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
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
            return this.Equals(input as TelegrafPluginInputPrometheusConfig);
        }

        /// <summary>
        /// Returns true if TelegrafPluginInputPrometheusConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TelegrafPluginInputPrometheusConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelegrafPluginInputPrometheusConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
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
                return hashCode;
            }
        }

    }

}
