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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using InfluxDB.Client.Api.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// selects one of two expressions, &#x60;Alternate&#x60; or &#x60;Consequent&#x60;, depending on a third boolean expression, &#x60;Test&#x60;
    /// </summary>
    [DataContract]
    public partial class ConditionalExpression :  IEquatable<ConditionalExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalExpression" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="test">test.</param>
        /// <param name="alternate">alternate.</param>
        /// <param name="consequent">consequent.</param>
        public ConditionalExpression(string type = default(string), Expression test = default(Expression), Expression alternate = default(Expression), Expression consequent = default(Expression))
        {
            this.Type = type;
            this.Test = test;
            this.Alternate = alternate;
            this.Consequent = consequent;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        [JsonConverter(typeof(ConditionalExpressionTestAdapter))]
        public Expression Test { get; set; }

        /// <summary>
        /// Gets or Sets Alternate
        /// </summary>
        [DataMember(Name="alternate", EmitDefaultValue=false)]
        [JsonConverter(typeof(ConditionalExpressionAlternateAdapter))]
        public Expression Alternate { get; set; }

        /// <summary>
        /// Gets or Sets Consequent
        /// </summary>
        [DataMember(Name="consequent", EmitDefaultValue=false)]
        [JsonConverter(typeof(ConditionalExpressionConsequentAdapter))]
        public Expression Consequent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalExpression {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  Alternate: ").Append(Alternate).Append("\n");
            sb.Append("  Consequent: ").Append(Consequent).Append("\n");
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
            return this.Equals(input as ConditionalExpression);
        }

        /// <summary>
        /// Returns true if ConditionalExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionalExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionalExpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
                ) && 
                (
                    
                    (this.Alternate != null &&
                    this.Alternate.Equals(input.Alternate))
                ) && 
                (
                    
                    (this.Consequent != null &&
                    this.Consequent.Equals(input.Consequent))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                if (this.Alternate != null)
                    hashCode = hashCode * 59 + this.Alternate.GetHashCode();
                if (this.Consequent != null)
                    hashCode = hashCode * 59 + this.Consequent.GetHashCode();
                return hashCode;
            }
        }

    public class ConditionalExpressionAlternateAdapter : JsonConverter
    {
        private static readonly Dictionary<string[], Type> Types = new Dictionary<string[], Type>(new DiscriminatorComparer<string>())
        {
            {new []{ "ArrayExpression" }, typeof(ArrayExpression)},
            {new []{ "FunctionExpression" }, typeof(FunctionExpression)},
            {new []{ "BinaryExpression" }, typeof(BinaryExpression)},
            {new []{ "CallExpression" }, typeof(CallExpression)},
            {new []{ "ConditionalExpression" }, typeof(ConditionalExpression)},
            {new []{ "LogicalExpression" }, typeof(LogicalExpression)},
            {new []{ "MemberExpression" }, typeof(MemberExpression)},
            {new []{ "IndexExpression" }, typeof(IndexExpression)},
            {new []{ "ObjectExpression" }, typeof(ObjectExpression)},
            {new []{ "PipeExpression" }, typeof(PipeExpression)},
            {new []{ "UnaryExpression" }, typeof(UnaryExpression)},
            {new []{ "BooleanLiteral" }, typeof(BooleanLiteral)},
            {new []{ "DateTimeLiteral" }, typeof(DateTimeLiteral)},
            {new []{ "DurationLiteral" }, typeof(DurationLiteral)},
            {new []{ "FloatLiteral" }, typeof(FloatLiteral)},
            {new []{ "IntegerLiteral" }, typeof(IntegerLiteral)},
            {new []{ "PipeLiteral" }, typeof(PipeLiteral)},
            {new []{ "RegexpLiteral" }, typeof(RegexpLiteral)},
            {new []{ "StringLiteral" }, typeof(StringLiteral)},
            {new []{ "UnsignedIntegerLiteral" }, typeof(UnsignedIntegerLiteral)},
            {new []{ "Identifier" }, typeof(Identifier)},
        };

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Deserialize(reader, objectType, serializer);
        }

        private object Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:

                    var jObject = JObject.Load(reader);

                    var discriminator = new []{ "type" }.Select(key => jObject[key].ToString()).ToArray();

                    Types.TryGetValue(discriminator, out var type);

                    return serializer.Deserialize(jObject.CreateReader(), type);

                case JsonToken.StartArray:
                    return DeserializeArray(reader, objectType, serializer);

                default:
                    return serializer.Deserialize(reader, objectType);
            }
        }

        private IList DeserializeArray(JsonReader reader, Type targetType, JsonSerializer serializer)
        {
            var elementType = targetType.GenericTypeArguments.FirstOrDefault();

            var list = (IList) Activator.CreateInstance(targetType);
            while (reader.Read() && reader.TokenType != JsonToken.EndArray)
            {
                list.Add(Deserialize(reader, elementType, serializer));
            }

            return list;
        }
    }
    public class ConditionalExpressionTestAdapter : JsonConverter
    {
        private static readonly Dictionary<string[], Type> Types = new Dictionary<string[], Type>(new DiscriminatorComparer<string>())
        {
            {new []{ "ArrayExpression" }, typeof(ArrayExpression)},
            {new []{ "FunctionExpression" }, typeof(FunctionExpression)},
            {new []{ "BinaryExpression" }, typeof(BinaryExpression)},
            {new []{ "CallExpression" }, typeof(CallExpression)},
            {new []{ "ConditionalExpression" }, typeof(ConditionalExpression)},
            {new []{ "LogicalExpression" }, typeof(LogicalExpression)},
            {new []{ "MemberExpression" }, typeof(MemberExpression)},
            {new []{ "IndexExpression" }, typeof(IndexExpression)},
            {new []{ "ObjectExpression" }, typeof(ObjectExpression)},
            {new []{ "PipeExpression" }, typeof(PipeExpression)},
            {new []{ "UnaryExpression" }, typeof(UnaryExpression)},
            {new []{ "BooleanLiteral" }, typeof(BooleanLiteral)},
            {new []{ "DateTimeLiteral" }, typeof(DateTimeLiteral)},
            {new []{ "DurationLiteral" }, typeof(DurationLiteral)},
            {new []{ "FloatLiteral" }, typeof(FloatLiteral)},
            {new []{ "IntegerLiteral" }, typeof(IntegerLiteral)},
            {new []{ "PipeLiteral" }, typeof(PipeLiteral)},
            {new []{ "RegexpLiteral" }, typeof(RegexpLiteral)},
            {new []{ "StringLiteral" }, typeof(StringLiteral)},
            {new []{ "UnsignedIntegerLiteral" }, typeof(UnsignedIntegerLiteral)},
            {new []{ "Identifier" }, typeof(Identifier)},
        };

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Deserialize(reader, objectType, serializer);
        }

        private object Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:

                    var jObject = JObject.Load(reader);

                    var discriminator = new []{ "type" }.Select(key => jObject[key].ToString()).ToArray();

                    Types.TryGetValue(discriminator, out var type);

                    return serializer.Deserialize(jObject.CreateReader(), type);

                case JsonToken.StartArray:
                    return DeserializeArray(reader, objectType, serializer);

                default:
                    return serializer.Deserialize(reader, objectType);
            }
        }

        private IList DeserializeArray(JsonReader reader, Type targetType, JsonSerializer serializer)
        {
            var elementType = targetType.GenericTypeArguments.FirstOrDefault();

            var list = (IList) Activator.CreateInstance(targetType);
            while (reader.Read() && reader.TokenType != JsonToken.EndArray)
            {
                list.Add(Deserialize(reader, elementType, serializer));
            }

            return list;
        }
    }
    public class ConditionalExpressionConsequentAdapter : JsonConverter
    {
        private static readonly Dictionary<string[], Type> Types = new Dictionary<string[], Type>(new DiscriminatorComparer<string>())
        {
            {new []{ "ArrayExpression" }, typeof(ArrayExpression)},
            {new []{ "FunctionExpression" }, typeof(FunctionExpression)},
            {new []{ "BinaryExpression" }, typeof(BinaryExpression)},
            {new []{ "CallExpression" }, typeof(CallExpression)},
            {new []{ "ConditionalExpression" }, typeof(ConditionalExpression)},
            {new []{ "LogicalExpression" }, typeof(LogicalExpression)},
            {new []{ "MemberExpression" }, typeof(MemberExpression)},
            {new []{ "IndexExpression" }, typeof(IndexExpression)},
            {new []{ "ObjectExpression" }, typeof(ObjectExpression)},
            {new []{ "PipeExpression" }, typeof(PipeExpression)},
            {new []{ "UnaryExpression" }, typeof(UnaryExpression)},
            {new []{ "BooleanLiteral" }, typeof(BooleanLiteral)},
            {new []{ "DateTimeLiteral" }, typeof(DateTimeLiteral)},
            {new []{ "DurationLiteral" }, typeof(DurationLiteral)},
            {new []{ "FloatLiteral" }, typeof(FloatLiteral)},
            {new []{ "IntegerLiteral" }, typeof(IntegerLiteral)},
            {new []{ "PipeLiteral" }, typeof(PipeLiteral)},
            {new []{ "RegexpLiteral" }, typeof(RegexpLiteral)},
            {new []{ "StringLiteral" }, typeof(StringLiteral)},
            {new []{ "UnsignedIntegerLiteral" }, typeof(UnsignedIntegerLiteral)},
            {new []{ "Identifier" }, typeof(Identifier)},
        };

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Deserialize(reader, objectType, serializer);
        }

        private object Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:

                    var jObject = JObject.Load(reader);

                    var discriminator = new []{ "type" }.Select(key => jObject[key].ToString()).ToArray();

                    Types.TryGetValue(discriminator, out var type);

                    return serializer.Deserialize(jObject.CreateReader(), type);

                case JsonToken.StartArray:
                    return DeserializeArray(reader, objectType, serializer);

                default:
                    return serializer.Deserialize(reader, objectType);
            }
        }

        private IList DeserializeArray(JsonReader reader, Type targetType, JsonSerializer serializer)
        {
            var elementType = targetType.GenericTypeArguments.FirstOrDefault();

            var list = (IList) Activator.CreateInstance(targetType);
            while (reader.Read() && reader.TokenType != JsonToken.EndArray)
            {
                list.Add(Deserialize(reader, elementType, serializer));
            }

            return list;
        }
    }
    }

}
