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
    /// DashboardLinks
    /// </summary>
    [DataContract]
    public partial class DashboardLinks :  IEquatable<DashboardLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="cells">cells.</param>
        /// <param name="members">members.</param>
        /// <param name="owners">owners.</param>
        /// <param name="logs">logs.</param>
        /// <param name="labels">labels.</param>
        /// <param name="org">org.</param>
        public DashboardLinks(string self = default(string), string cells = default(string), string members = default(string), string owners = default(string), string logs = default(string), string labels = default(string), string org = default(string))
        {
            this.Self = self;
            this.Cells = cells;
            this.Members = members;
            this.Owners = owners;
            this.Logs = logs;
            this.Labels = labels;
            this.Org = org;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }

        /// <summary>
        /// Gets or Sets Cells
        /// </summary>
        [DataMember(Name="cells", EmitDefaultValue=false)]
        public string Cells { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public string Members { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public string Owners { get; set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [DataMember(Name="logs", EmitDefaultValue=false)]
        public string Logs { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public string Labels { get; set; }

        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [DataMember(Name="org", EmitDefaultValue=false)]
        public string Org { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
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
            return this.Equals(input as DashboardLinks);
        }

        /// <summary>
        /// Returns true if DashboardLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Cells == input.Cells ||
                    (this.Cells != null &&
                    this.Cells.Equals(input.Cells))
                ) && 
                (
                    this.Members == input.Members ||
                    (this.Members != null &&
                    this.Members.Equals(input.Members))
                ) && 
                (
                    this.Owners == input.Owners ||
                    (this.Owners != null &&
                    this.Owners.Equals(input.Owners))
                ) && 
                (
                    this.Logs == input.Logs ||
                    (this.Logs != null &&
                    this.Logs.Equals(input.Logs))
                ) && 
                (
                    this.Labels == input.Labels ||
                    (this.Labels != null &&
                    this.Labels.Equals(input.Labels))
                ) && 
                (
                    this.Org == input.Org ||
                    (this.Org != null &&
                    this.Org.Equals(input.Org))
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Cells != null)
                    hashCode = hashCode * 59 + this.Cells.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Org != null)
                    hashCode = hashCode * 59 + this.Org.GetHashCode();
                return hashCode;
            }
        }

    }

}
