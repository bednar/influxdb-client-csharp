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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// GaugeViewProperties
    /// </summary>
    [DataContract]
    public partial class GaugeViewProperties : ViewProperties,  IEquatable<GaugeViewProperties>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Gauge for value: gauge
            /// </summary>
            [EnumMember(Value = "gauge")]
            Gauge = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines Shape
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShapeEnum
        {
            /// <summary>
            /// Enum ChronografV2 for value: chronograf-v2
            /// </summary>
            [EnumMember(Value = "chronograf-v2")]
            ChronografV2 = 1

        }

        /// <summary>
        /// Gets or Sets Shape
        /// </summary>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public ShapeEnum Shape { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GaugeViewProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GaugeViewProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GaugeViewProperties" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="queries">queries (required).</param>
        /// <param name="colors">Colors define color encoding of data into a visualization (required).</param>
        /// <param name="shape">shape (required).</param>
        /// <param name="note">note (required).</param>
        /// <param name="showNoteWhenEmpty">if true, will display note when empty (required).</param>
        /// <param name="prefix">prefix (required).</param>
        /// <param name="suffix">suffix (required).</param>
        /// <param name="legend">legend (required).</param>
        /// <param name="decimalPlaces">decimalPlaces (required).</param>
        public GaugeViewProperties(TypeEnum type = default(TypeEnum), List<DashboardQuery> queries = default(List<DashboardQuery>), List<DashboardColor> colors = default(List<DashboardColor>), ShapeEnum shape = default(ShapeEnum), string note = default(string), bool? showNoteWhenEmpty = default(bool?), string prefix = default(string), string suffix = default(string), Legend legend = default(Legend), DecimalPlaces decimalPlaces = default(DecimalPlaces)) : base()
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new InvalidDataException("queries is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Queries = queries;
            }
            // to ensure "colors" is required (not null)
            if (colors == null)
            {
                throw new InvalidDataException("colors is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Colors = colors;
            }
            // to ensure "shape" is required (not null)
            if (shape == null)
            {
                throw new InvalidDataException("shape is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Shape = shape;
            }
            // to ensure "note" is required (not null)
            if (note == null)
            {
                throw new InvalidDataException("note is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Note = note;
            }
            // to ensure "showNoteWhenEmpty" is required (not null)
            if (showNoteWhenEmpty == null)
            {
                throw new InvalidDataException("showNoteWhenEmpty is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.ShowNoteWhenEmpty = showNoteWhenEmpty;
            }
            // to ensure "prefix" is required (not null)
            if (prefix == null)
            {
                throw new InvalidDataException("prefix is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Prefix = prefix;
            }
            // to ensure "suffix" is required (not null)
            if (suffix == null)
            {
                throw new InvalidDataException("suffix is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Suffix = suffix;
            }
            // to ensure "legend" is required (not null)
            if (legend == null)
            {
                throw new InvalidDataException("legend is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.Legend = legend;
            }
            // to ensure "decimalPlaces" is required (not null)
            if (decimalPlaces == null)
            {
                throw new InvalidDataException("decimalPlaces is a required property for GaugeViewProperties and cannot be null");
            }
            else
            {
                this.DecimalPlaces = decimalPlaces;
            }
        }


        /// <summary>
        /// Gets or Sets Queries
        /// </summary>
        [DataMember(Name="queries", EmitDefaultValue=false)]
        public List<DashboardQuery> Queries { get; set; }

        /// <summary>
        /// Colors define color encoding of data into a visualization
        /// </summary>
        /// <value>Colors define color encoding of data into a visualization</value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<DashboardColor> Colors { get; set; }


        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// if true, will display note when empty
        /// </summary>
        /// <value>if true, will display note when empty</value>
        [DataMember(Name="showNoteWhenEmpty", EmitDefaultValue=false)]
        public bool? ShowNoteWhenEmpty { get; set; }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Suffix
        /// </summary>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or Sets Legend
        /// </summary>
        [DataMember(Name="legend", EmitDefaultValue=false)]
        public Legend Legend { get; set; }

        /// <summary>
        /// Gets or Sets DecimalPlaces
        /// </summary>
        [DataMember(Name="decimalPlaces", EmitDefaultValue=false)]
        public DecimalPlaces DecimalPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaugeViewProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ShowNoteWhenEmpty: ").Append(ShowNoteWhenEmpty).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Legend: ").Append(Legend).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
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
            return this.Equals(input as GaugeViewProperties);
        }

        /// <summary>
        /// Returns true if GaugeViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of GaugeViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GaugeViewProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
                ) && base.Equals(input) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
                ) && base.Equals(input) && 
                (
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
                ) && base.Equals(input) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && base.Equals(input) && 
                (
                    this.ShowNoteWhenEmpty == input.ShowNoteWhenEmpty ||
                    (this.ShowNoteWhenEmpty != null &&
                    this.ShowNoteWhenEmpty.Equals(input.ShowNoteWhenEmpty))
                ) && base.Equals(input) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && base.Equals(input) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && base.Equals(input) && 
                (
                    
                    (this.Legend != null &&
                    this.Legend.Equals(input.Legend))
                ) && base.Equals(input) && 
                (
                    
                    (this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(input.DecimalPlaces))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.ShowNoteWhenEmpty != null)
                    hashCode = hashCode * 59 + this.ShowNoteWhenEmpty.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.Legend != null)
                    hashCode = hashCode * 59 + this.Legend.GetHashCode();
                if (this.DecimalPlaces != null)
                    hashCode = hashCode * 59 + this.DecimalPlaces.GetHashCode();
                return hashCode;
            }
        }

    }

}