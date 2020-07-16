/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.3
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
    /// PlayerUsageUsage
    /// </summary>
    [DataContract]
    public partial class PlayerUsageUsage :  IEquatable<PlayerUsageUsage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerUsageUsage" /> class.
        /// </summary>
        /// <param name="overall">overall.</param>
        /// <param name="pass">pass.</param>
        /// <param name="rush">rush.</param>
        /// <param name="firstDown">firstDown.</param>
        /// <param name="secondDown">secondDown.</param>
        /// <param name="thirdDown">thirdDown.</param>
        /// <param name="standardDowns">standardDowns.</param>
        /// <param name="passingDowns">passingDowns.</param>
        public PlayerUsageUsage(decimal? overall = default(decimal?), decimal? pass = default(decimal?), decimal? rush = default(decimal?), decimal? firstDown = default(decimal?), decimal? secondDown = default(decimal?), decimal? thirdDown = default(decimal?), decimal? standardDowns = default(decimal?), decimal? passingDowns = default(decimal?))
        {
            this.Overall = overall;
            this.Pass = pass;
            this.Rush = rush;
            this.FirstDown = firstDown;
            this.SecondDown = secondDown;
            this.ThirdDown = thirdDown;
            this.StandardDowns = standardDowns;
            this.PassingDowns = passingDowns;
        }
        
        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public decimal? Overall { get; set; }

        /// <summary>
        /// Gets or Sets Pass
        /// </summary>
        [DataMember(Name="pass", EmitDefaultValue=false)]
        public decimal? Pass { get; set; }

        /// <summary>
        /// Gets or Sets Rush
        /// </summary>
        [DataMember(Name="rush", EmitDefaultValue=false)]
        public decimal? Rush { get; set; }

        /// <summary>
        /// Gets or Sets FirstDown
        /// </summary>
        [DataMember(Name="firstDown", EmitDefaultValue=false)]
        public decimal? FirstDown { get; set; }

        /// <summary>
        /// Gets or Sets SecondDown
        /// </summary>
        [DataMember(Name="secondDown", EmitDefaultValue=false)]
        public decimal? SecondDown { get; set; }

        /// <summary>
        /// Gets or Sets ThirdDown
        /// </summary>
        [DataMember(Name="thirdDown", EmitDefaultValue=false)]
        public decimal? ThirdDown { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [DataMember(Name="standardDowns", EmitDefaultValue=false)]
        public decimal? StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [DataMember(Name="passingDowns", EmitDefaultValue=false)]
        public decimal? PassingDowns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerUsageUsage {\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  Pass: ").Append(Pass).Append("\n");
            sb.Append("  Rush: ").Append(Rush).Append("\n");
            sb.Append("  FirstDown: ").Append(FirstDown).Append("\n");
            sb.Append("  SecondDown: ").Append(SecondDown).Append("\n");
            sb.Append("  ThirdDown: ").Append(ThirdDown).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
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
            return this.Equals(input as PlayerUsageUsage);
        }

        /// <summary>
        /// Returns true if PlayerUsageUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerUsageUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerUsageUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Overall == input.Overall ||
                    (this.Overall != null &&
                    this.Overall.Equals(input.Overall))
                ) && 
                (
                    this.Pass == input.Pass ||
                    (this.Pass != null &&
                    this.Pass.Equals(input.Pass))
                ) && 
                (
                    this.Rush == input.Rush ||
                    (this.Rush != null &&
                    this.Rush.Equals(input.Rush))
                ) && 
                (
                    this.FirstDown == input.FirstDown ||
                    (this.FirstDown != null &&
                    this.FirstDown.Equals(input.FirstDown))
                ) && 
                (
                    this.SecondDown == input.SecondDown ||
                    (this.SecondDown != null &&
                    this.SecondDown.Equals(input.SecondDown))
                ) && 
                (
                    this.ThirdDown == input.ThirdDown ||
                    (this.ThirdDown != null &&
                    this.ThirdDown.Equals(input.ThirdDown))
                ) && 
                (
                    this.StandardDowns == input.StandardDowns ||
                    (this.StandardDowns != null &&
                    this.StandardDowns.Equals(input.StandardDowns))
                ) && 
                (
                    this.PassingDowns == input.PassingDowns ||
                    (this.PassingDowns != null &&
                    this.PassingDowns.Equals(input.PassingDowns))
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
                if (this.Overall != null)
                    hashCode = hashCode * 59 + this.Overall.GetHashCode();
                if (this.Pass != null)
                    hashCode = hashCode * 59 + this.Pass.GetHashCode();
                if (this.Rush != null)
                    hashCode = hashCode * 59 + this.Rush.GetHashCode();
                if (this.FirstDown != null)
                    hashCode = hashCode * 59 + this.FirstDown.GetHashCode();
                if (this.SecondDown != null)
                    hashCode = hashCode * 59 + this.SecondDown.GetHashCode();
                if (this.ThirdDown != null)
                    hashCode = hashCode * 59 + this.ThirdDown.GetHashCode();
                if (this.StandardDowns != null)
                    hashCode = hashCode * 59 + this.StandardDowns.GetHashCode();
                if (this.PassingDowns != null)
                    hashCode = hashCode * 59 + this.PassingDowns.GetHashCode();
                return hashCode;
            }
        }
    }

}
