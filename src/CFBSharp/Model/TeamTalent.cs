/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.13
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
    /// TeamTalent
    /// </summary>
    [DataContract]
    public partial class TeamTalent :  IEquatable<TeamTalent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamTalent" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="school">school.</param>
        /// <param name="talent">talent.</param>
        public TeamTalent(int? year = default(int?), string school = default(string), decimal? talent = default(decimal?))
        {
            this.Year = year;
            this.School = school;
            this.Talent = talent;
        }
        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Talent
        /// </summary>
        [DataMember(Name="talent", EmitDefaultValue=false)]
        public decimal? Talent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamTalent {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Talent: ").Append(Talent).Append("\n");
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
            return this.Equals(input as TeamTalent);
        }

        /// <summary>
        /// Returns true if TeamTalent instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamTalent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamTalent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.Talent == input.Talent ||
                    (this.Talent != null &&
                    this.Talent.Equals(input.Talent))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.Talent != null)
                    hashCode = hashCode * 59 + this.Talent.GetHashCode();
                return hashCode;
            }
        }
    }

}
