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
    /// CreateCell
    /// </summary>
    [DataContract]
    public partial class CreateCell :  IEquatable<CreateCell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCell" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <param name="w">w.</param>
        /// <param name="h">h.</param>
        /// <param name="viewID">uses the view provided in the request.</param>
        /// <param name="usingView">makes a copy of the provided view.</param>
        public CreateCell(string name = default(string), int? x = default(int?), int? y = default(int?), int? w = default(int?), int? h = default(int?), string viewID = default(string), string usingView = default(string))
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            this.ViewID = viewID;
            this.UsingView = usingView;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Gets or Sets W
        /// </summary>
        [DataMember(Name="w", EmitDefaultValue=false)]
        public int? W { get; set; }

        /// <summary>
        /// Gets or Sets H
        /// </summary>
        [DataMember(Name="h", EmitDefaultValue=false)]
        public int? H { get; set; }

        /// <summary>
        /// uses the view provided in the request
        /// </summary>
        /// <value>uses the view provided in the request</value>
        [DataMember(Name="viewID", EmitDefaultValue=false)]
        public string ViewID { get; set; }

        /// <summary>
        /// makes a copy of the provided view
        /// </summary>
        /// <value>makes a copy of the provided view</value>
        [DataMember(Name="usingView", EmitDefaultValue=false)]
        public string UsingView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCell {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  W: ").Append(W).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  ViewID: ").Append(ViewID).Append("\n");
            sb.Append("  UsingView: ").Append(UsingView).Append("\n");
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
            return this.Equals(input as CreateCell);
        }

        /// <summary>
        /// Returns true if CreateCell instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCell to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCell input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.W == input.W ||
                    (this.W != null &&
                    this.W.Equals(input.W))
                ) && 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
                ) && 
                (
                    this.ViewID == input.ViewID ||
                    (this.ViewID != null &&
                    this.ViewID.Equals(input.ViewID))
                ) && 
                (
                    this.UsingView == input.UsingView ||
                    (this.UsingView != null &&
                    this.UsingView.Equals(input.UsingView))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.W != null)
                    hashCode = hashCode * 59 + this.W.GetHashCode();
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.ViewID != null)
                    hashCode = hashCode * 59 + this.ViewID.GetHashCode();
                if (this.UsingView != null)
                    hashCode = hashCode * 59 + this.UsingView.GetHashCode();
                return hashCode;
            }
        }

    }

}
