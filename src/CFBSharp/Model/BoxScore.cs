/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.1.0
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = CFBSharp.Client.SwaggerDateConverter;

namespace CFBSharp.Model
{
    /// <summary>
    /// BoxScore
    /// </summary>
    [DataContract]
    public partial class BoxScore :  IEquatable<BoxScore>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScore" /> class.
        /// </summary>
        /// <param name="teams">teams.</param>
        /// <param name="players">players.</param>
        public BoxScore(Object teams = default(Object), Object players = default(Object))
        {
            this.Teams = teams;
            this.Players = players;
        }
        
        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public Object Teams { get; set; }

        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [DataMember(Name="players", EmitDefaultValue=false)]
        public Object Players { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScore {\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
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
            return this.Equals(input as BoxScore);
        }

        /// <summary>
        /// Returns true if BoxScore instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Teams == input.Teams ||
                    (this.Teams != null &&
                    this.Teams.Equals(input.Teams))
                ) && 
                (
                    this.Players == input.Players ||
                    (this.Players != null &&
                    this.Players.Equals(input.Players))
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
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
                if (this.Players != null)
                    hashCode = hashCode * 59 + this.Players.GetHashCode();
                return hashCode;
            }
        }
    }

}
