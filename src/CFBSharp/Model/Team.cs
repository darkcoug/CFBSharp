/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.0
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
    /// Team
    /// </summary>
    [DataContract]
    public partial class Team :  IEquatable<Team>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="school">school.</param>
        /// <param name="mascot">mascot.</param>
        /// <param name="abbreviation">abbreviation.</param>
        /// <param name="altName1">altName1.</param>
        /// <param name="altName2">altName2.</param>
        /// <param name="altName3">altName3.</param>
        /// <param name="classification">classification.</param>
        /// <param name="conference">conference.</param>
        /// <param name="division">division.</param>
        /// <param name="color">color.</param>
        /// <param name="altColor">altColor.</param>
        /// <param name="logos">logos.</param>
        /// <param name="location">location.</param>
        public Team(int? id = default(int?), string school = default(string), string mascot = default(string), string abbreviation = default(string), string altName1 = default(string), string altName2 = default(string), string altName3 = default(string), string classification = default(string), string conference = default(string), string division = default(string), string color = default(string), string altColor = default(string), List<string> logos = default(List<string>), Object location = default(Object))
        {
            this.Id = id;
            this.School = school;
            this.Mascot = mascot;
            this.Abbreviation = abbreviation;
            this.AltName1 = altName1;
            this.AltName2 = altName2;
            this.AltName3 = altName3;
            this.Classification = classification;
            this.Conference = conference;
            this.Division = division;
            this.Color = color;
            this.AltColor = altColor;
            this.Logos = logos;
            this.Location = location;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Mascot
        /// </summary>
        [DataMember(Name="mascot", EmitDefaultValue=false)]
        public string Mascot { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets AltName1
        /// </summary>
        [DataMember(Name="alt_name_1", EmitDefaultValue=false)]
        public string AltName1 { get; set; }

        /// <summary>
        /// Gets or Sets AltName2
        /// </summary>
        [DataMember(Name="alt_name_2", EmitDefaultValue=false)]
        public string AltName2 { get; set; }

        /// <summary>
        /// Gets or Sets AltName3
        /// </summary>
        [DataMember(Name="alt_name_3", EmitDefaultValue=false)]
        public string AltName3 { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public string Division { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets AltColor
        /// </summary>
        [DataMember(Name="alt_color", EmitDefaultValue=false)]
        public string AltColor { get; set; }

        /// <summary>
        /// Gets or Sets Logos
        /// </summary>
        [DataMember(Name="logos", EmitDefaultValue=false)]
        public List<string> Logos { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Object Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Team {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Mascot: ").Append(Mascot).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  AltName1: ").Append(AltName1).Append("\n");
            sb.Append("  AltName2: ").Append(AltName2).Append("\n");
            sb.Append("  AltName3: ").Append(AltName3).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  AltColor: ").Append(AltColor).Append("\n");
            sb.Append("  Logos: ").Append(Logos).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as Team);
        }

        /// <summary>
        /// Returns true if Team instances are equal
        /// </summary>
        /// <param name="input">Instance of Team to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Team input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.Mascot == input.Mascot ||
                    (this.Mascot != null &&
                    this.Mascot.Equals(input.Mascot))
                ) && 
                (
                    this.Abbreviation == input.Abbreviation ||
                    (this.Abbreviation != null &&
                    this.Abbreviation.Equals(input.Abbreviation))
                ) && 
                (
                    this.AltName1 == input.AltName1 ||
                    (this.AltName1 != null &&
                    this.AltName1.Equals(input.AltName1))
                ) && 
                (
                    this.AltName2 == input.AltName2 ||
                    (this.AltName2 != null &&
                    this.AltName2.Equals(input.AltName2))
                ) && 
                (
                    this.AltName3 == input.AltName3 ||
                    (this.AltName3 != null &&
                    this.AltName3.Equals(input.AltName3))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.Division == input.Division ||
                    (this.Division != null &&
                    this.Division.Equals(input.Division))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.AltColor == input.AltColor ||
                    (this.AltColor != null &&
                    this.AltColor.Equals(input.AltColor))
                ) && 
                (
                    this.Logos == input.Logos ||
                    this.Logos != null &&
                    this.Logos.SequenceEqual(input.Logos)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.Mascot != null)
                    hashCode = hashCode * 59 + this.Mascot.GetHashCode();
                if (this.Abbreviation != null)
                    hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                if (this.AltName1 != null)
                    hashCode = hashCode * 59 + this.AltName1.GetHashCode();
                if (this.AltName2 != null)
                    hashCode = hashCode * 59 + this.AltName2.GetHashCode();
                if (this.AltName3 != null)
                    hashCode = hashCode * 59 + this.AltName3.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.Division != null)
                    hashCode = hashCode * 59 + this.Division.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.AltColor != null)
                    hashCode = hashCode * 59 + this.AltColor.GetHashCode();
                if (this.Logos != null)
                    hashCode = hashCode * 59 + this.Logos.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }

}
