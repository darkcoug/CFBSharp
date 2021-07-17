/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.1.1
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
    /// DraftPick
    /// </summary>
    [DataContract]
    public partial class DraftPick :  IEquatable<DraftPick>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftPick" /> class.
        /// </summary>
        /// <param name="collegeAthleteId">collegeAthleteId.</param>
        /// <param name="nflAthleteId">nflAthleteId.</param>
        /// <param name="collegeId">collegeId.</param>
        /// <param name="collegeTeam">collegeTeam.</param>
        /// <param name="collegeConference">collegeConference.</param>
        /// <param name="nflTeam">nflTeam.</param>
        /// <param name="year">year.</param>
        /// <param name="overall">overall.</param>
        /// <param name="round">round.</param>
        /// <param name="pick">pick.</param>
        /// <param name="name">name.</param>
        /// <param name="position">position.</param>
        /// <param name="height">height.</param>
        /// <param name="weight">weight.</param>
        /// <param name="preDraftRanking">preDraftRanking.</param>
        /// <param name="preDraftPositionRanking">preDraftPositionRanking.</param>
        /// <param name="preDraftGrade">preDraftGrade.</param>
        /// <param name="hometownInfo">hometownInfo.</param>
        public DraftPick(int? collegeAthleteId = default(int?), int? nflAthleteId = default(int?), int? collegeId = default(int?), string collegeTeam = default(string), string collegeConference = default(string), string nflTeam = default(string), int? year = default(int?), int? overall = default(int?), int? round = default(int?), int? pick = default(int?), string name = default(string), string position = default(string), int? height = default(int?), int? weight = default(int?), int? preDraftRanking = default(int?), int? preDraftPositionRanking = default(int?), int? preDraftGrade = default(int?), Object hometownInfo = default(Object))
        {
            this.CollegeAthleteId = collegeAthleteId;
            this.NflAthleteId = nflAthleteId;
            this.CollegeId = collegeId;
            this.CollegeTeam = collegeTeam;
            this.CollegeConference = collegeConference;
            this.NflTeam = nflTeam;
            this.Year = year;
            this.Overall = overall;
            this.Round = round;
            this.Pick = pick;
            this.Name = name;
            this.Position = position;
            this.Height = height;
            this.Weight = weight;
            this.PreDraftRanking = preDraftRanking;
            this.PreDraftPositionRanking = preDraftPositionRanking;
            this.PreDraftGrade = preDraftGrade;
            this.HometownInfo = hometownInfo;
        }
        
        /// <summary>
        /// Gets or Sets CollegeAthleteId
        /// </summary>
        [DataMember(Name="collegeAthleteId", EmitDefaultValue=false)]
        public int? CollegeAthleteId { get; set; }

        /// <summary>
        /// Gets or Sets NflAthleteId
        /// </summary>
        [DataMember(Name="nflAthleteId", EmitDefaultValue=false)]
        public int? NflAthleteId { get; set; }

        /// <summary>
        /// Gets or Sets CollegeId
        /// </summary>
        [DataMember(Name="collegeId", EmitDefaultValue=false)]
        public int? CollegeId { get; set; }

        /// <summary>
        /// Gets or Sets CollegeTeam
        /// </summary>
        [DataMember(Name="collegeTeam", EmitDefaultValue=false)]
        public string CollegeTeam { get; set; }

        /// <summary>
        /// Gets or Sets CollegeConference
        /// </summary>
        [DataMember(Name="collegeConference", EmitDefaultValue=false)]
        public string CollegeConference { get; set; }

        /// <summary>
        /// Gets or Sets NflTeam
        /// </summary>
        [DataMember(Name="nflTeam", EmitDefaultValue=false)]
        public string NflTeam { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public int? Overall { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public int? Round { get; set; }

        /// <summary>
        /// Gets or Sets Pick
        /// </summary>
        [DataMember(Name="pick", EmitDefaultValue=false)]
        public int? Pick { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets PreDraftRanking
        /// </summary>
        [DataMember(Name="preDraftRanking", EmitDefaultValue=false)]
        public int? PreDraftRanking { get; set; }

        /// <summary>
        /// Gets or Sets PreDraftPositionRanking
        /// </summary>
        [DataMember(Name="preDraftPositionRanking", EmitDefaultValue=false)]
        public int? PreDraftPositionRanking { get; set; }

        /// <summary>
        /// Gets or Sets PreDraftGrade
        /// </summary>
        [DataMember(Name="preDraftGrade", EmitDefaultValue=false)]
        public int? PreDraftGrade { get; set; }

        /// <summary>
        /// Gets or Sets HometownInfo
        /// </summary>
        [DataMember(Name="hometownInfo", EmitDefaultValue=false)]
        public Object HometownInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DraftPick {\n");
            sb.Append("  CollegeAthleteId: ").Append(CollegeAthleteId).Append("\n");
            sb.Append("  NflAthleteId: ").Append(NflAthleteId).Append("\n");
            sb.Append("  CollegeId: ").Append(CollegeId).Append("\n");
            sb.Append("  CollegeTeam: ").Append(CollegeTeam).Append("\n");
            sb.Append("  CollegeConference: ").Append(CollegeConference).Append("\n");
            sb.Append("  NflTeam: ").Append(NflTeam).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  Pick: ").Append(Pick).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  PreDraftRanking: ").Append(PreDraftRanking).Append("\n");
            sb.Append("  PreDraftPositionRanking: ").Append(PreDraftPositionRanking).Append("\n");
            sb.Append("  PreDraftGrade: ").Append(PreDraftGrade).Append("\n");
            sb.Append("  HometownInfo: ").Append(HometownInfo).Append("\n");
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
            return this.Equals(input as DraftPick);
        }

        /// <summary>
        /// Returns true if DraftPick instances are equal
        /// </summary>
        /// <param name="input">Instance of DraftPick to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DraftPick input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollegeAthleteId == input.CollegeAthleteId ||
                    (this.CollegeAthleteId != null &&
                    this.CollegeAthleteId.Equals(input.CollegeAthleteId))
                ) && 
                (
                    this.NflAthleteId == input.NflAthleteId ||
                    (this.NflAthleteId != null &&
                    this.NflAthleteId.Equals(input.NflAthleteId))
                ) && 
                (
                    this.CollegeId == input.CollegeId ||
                    (this.CollegeId != null &&
                    this.CollegeId.Equals(input.CollegeId))
                ) && 
                (
                    this.CollegeTeam == input.CollegeTeam ||
                    (this.CollegeTeam != null &&
                    this.CollegeTeam.Equals(input.CollegeTeam))
                ) && 
                (
                    this.CollegeConference == input.CollegeConference ||
                    (this.CollegeConference != null &&
                    this.CollegeConference.Equals(input.CollegeConference))
                ) && 
                (
                    this.NflTeam == input.NflTeam ||
                    (this.NflTeam != null &&
                    this.NflTeam.Equals(input.NflTeam))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Overall == input.Overall ||
                    (this.Overall != null &&
                    this.Overall.Equals(input.Overall))
                ) && 
                (
                    this.Round == input.Round ||
                    (this.Round != null &&
                    this.Round.Equals(input.Round))
                ) && 
                (
                    this.Pick == input.Pick ||
                    (this.Pick != null &&
                    this.Pick.Equals(input.Pick))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.PreDraftRanking == input.PreDraftRanking ||
                    (this.PreDraftRanking != null &&
                    this.PreDraftRanking.Equals(input.PreDraftRanking))
                ) && 
                (
                    this.PreDraftPositionRanking == input.PreDraftPositionRanking ||
                    (this.PreDraftPositionRanking != null &&
                    this.PreDraftPositionRanking.Equals(input.PreDraftPositionRanking))
                ) && 
                (
                    this.PreDraftGrade == input.PreDraftGrade ||
                    (this.PreDraftGrade != null &&
                    this.PreDraftGrade.Equals(input.PreDraftGrade))
                ) && 
                (
                    this.HometownInfo == input.HometownInfo ||
                    (this.HometownInfo != null &&
                    this.HometownInfo.Equals(input.HometownInfo))
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
                if (this.CollegeAthleteId != null)
                    hashCode = hashCode * 59 + this.CollegeAthleteId.GetHashCode();
                if (this.NflAthleteId != null)
                    hashCode = hashCode * 59 + this.NflAthleteId.GetHashCode();
                if (this.CollegeId != null)
                    hashCode = hashCode * 59 + this.CollegeId.GetHashCode();
                if (this.CollegeTeam != null)
                    hashCode = hashCode * 59 + this.CollegeTeam.GetHashCode();
                if (this.CollegeConference != null)
                    hashCode = hashCode * 59 + this.CollegeConference.GetHashCode();
                if (this.NflTeam != null)
                    hashCode = hashCode * 59 + this.NflTeam.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Overall != null)
                    hashCode = hashCode * 59 + this.Overall.GetHashCode();
                if (this.Round != null)
                    hashCode = hashCode * 59 + this.Round.GetHashCode();
                if (this.Pick != null)
                    hashCode = hashCode * 59 + this.Pick.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.PreDraftRanking != null)
                    hashCode = hashCode * 59 + this.PreDraftRanking.GetHashCode();
                if (this.PreDraftPositionRanking != null)
                    hashCode = hashCode * 59 + this.PreDraftPositionRanking.GetHashCode();
                if (this.PreDraftGrade != null)
                    hashCode = hashCode * 59 + this.PreDraftGrade.GetHashCode();
                if (this.HometownInfo != null)
                    hashCode = hashCode * 59 + this.HometownInfo.GetHashCode();
                return hashCode;
            }
        }
    }

}