/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.17
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
    /// Play
    /// </summary>
    [DataContract]
    public partial class Play :  IEquatable<Play>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Play" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="driveId">driveId.</param>
        /// <param name="gameId">gameId.</param>
        /// <param name="driveNumber">driveNumber.</param>
        /// <param name="playNumber">playNumber.</param>
        /// <param name="offense">offense.</param>
        /// <param name="offenseConference">offenseConference.</param>
        /// <param name="offenseScore">offenseScore.</param>
        /// <param name="defense">defense.</param>
        /// <param name="home">home.</param>
        /// <param name="away">away.</param>
        /// <param name="defenseConference">defenseConference.</param>
        /// <param name="defenseScore">defenseScore.</param>
        /// <param name="period">period.</param>
        /// <param name="clock">clock.</param>
        /// <param name="offenseTimeouts">offenseTimeouts.</param>
        /// <param name="defenseTimeouts">defenseTimeouts.</param>
        /// <param name="yardLine">yardLine.</param>
        /// <param name="yardsToGoal">yardsToGoal.</param>
        /// <param name="down">down.</param>
        /// <param name="distance">distance.</param>
        /// <param name="yardsGained">yardsGained.</param>
        /// <param name="scoring">scoring.</param>
        /// <param name="playType">playType.</param>
        /// <param name="playText">playText.</param>
        /// <param name="ppa">ppa.</param>
        public Play(int? id = default(int?), int? driveId = default(int?), int? gameId = default(int?), int? driveNumber = default(int?), int? playNumber = default(int?), string offense = default(string), string offenseConference = default(string), int? offenseScore = default(int?), string defense = default(string), string home = default(string), string away = default(string), string defenseConference = default(string), int? defenseScore = default(int?), int? period = default(int?), DriveStartTime clock = default(DriveStartTime), int? offenseTimeouts = default(int?), int? defenseTimeouts = default(int?), int? yardLine = default(int?), int? yardsToGoal = default(int?), int? down = default(int?), int? distance = default(int?), int? yardsGained = default(int?), bool? scoring = default(bool?), string playType = default(string), string playText = default(string), decimal? ppa = default(decimal?))
        {
            this.Id = id;
            this.DriveId = driveId;
            this.GameId = gameId;
            this.DriveNumber = driveNumber;
            this.PlayNumber = playNumber;
            this.Offense = offense;
            this.OffenseConference = offenseConference;
            this.OffenseScore = offenseScore;
            this.Defense = defense;
            this.Home = home;
            this.Away = away;
            this.DefenseConference = defenseConference;
            this.DefenseScore = defenseScore;
            this.Period = period;
            this.Clock = clock;
            this.OffenseTimeouts = offenseTimeouts;
            this.DefenseTimeouts = defenseTimeouts;
            this.YardLine = yardLine;
            this.YardsToGoal = yardsToGoal;
            this.Down = down;
            this.Distance = distance;
            this.YardsGained = yardsGained;
            this.Scoring = scoring;
            this.PlayType = playType;
            this.PlayText = playText;
            this.Ppa = ppa;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets DriveId
        /// </summary>
        [DataMember(Name="drive_id", EmitDefaultValue=false)]
        public int? DriveId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="game_id", EmitDefaultValue=false)]
        public int? GameId { get; set; }

        /// <summary>
        /// Gets or Sets DriveNumber
        /// </summary>
        [DataMember(Name="drive_number", EmitDefaultValue=false)]
        public int? DriveNumber { get; set; }

        /// <summary>
        /// Gets or Sets PlayNumber
        /// </summary>
        [DataMember(Name="play_number", EmitDefaultValue=false)]
        public int? PlayNumber { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name="offense", EmitDefaultValue=false)]
        public string Offense { get; set; }

        /// <summary>
        /// Gets or Sets OffenseConference
        /// </summary>
        [DataMember(Name="offense_conference", EmitDefaultValue=false)]
        public string OffenseConference { get; set; }

        /// <summary>
        /// Gets or Sets OffenseScore
        /// </summary>
        [DataMember(Name="offense_score", EmitDefaultValue=false)]
        public int? OffenseScore { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name="defense", EmitDefaultValue=false)]
        public string Defense { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name="home", EmitDefaultValue=false)]
        public string Home { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [DataMember(Name="away", EmitDefaultValue=false)]
        public string Away { get; set; }

        /// <summary>
        /// Gets or Sets DefenseConference
        /// </summary>
        [DataMember(Name="defense_conference", EmitDefaultValue=false)]
        public string DefenseConference { get; set; }

        /// <summary>
        /// Gets or Sets DefenseScore
        /// </summary>
        [DataMember(Name="defense_score", EmitDefaultValue=false)]
        public int? DefenseScore { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [DataMember(Name="clock", EmitDefaultValue=false)]
        public DriveStartTime Clock { get; set; }

        /// <summary>
        /// Gets or Sets OffenseTimeouts
        /// </summary>
        [DataMember(Name="offense_timeouts", EmitDefaultValue=false)]
        public int? OffenseTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets DefenseTimeouts
        /// </summary>
        [DataMember(Name="defense_timeouts", EmitDefaultValue=false)]
        public int? DefenseTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets YardLine
        /// </summary>
        [DataMember(Name="yard_line", EmitDefaultValue=false)]
        public int? YardLine { get; set; }

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [DataMember(Name="yards_to_goal", EmitDefaultValue=false)]
        public int? YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets Down
        /// </summary>
        [DataMember(Name="down", EmitDefaultValue=false)]
        public int? Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// Gets or Sets YardsGained
        /// </summary>
        [DataMember(Name="yards_gained", EmitDefaultValue=false)]
        public int? YardsGained { get; set; }

        /// <summary>
        /// Gets or Sets Scoring
        /// </summary>
        [DataMember(Name="scoring", EmitDefaultValue=false)]
        public bool? Scoring { get; set; }

        /// <summary>
        /// Gets or Sets PlayType
        /// </summary>
        [DataMember(Name="play_type", EmitDefaultValue=false)]
        public string PlayType { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [DataMember(Name="play_text", EmitDefaultValue=false)]
        public string PlayText { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name="ppa", EmitDefaultValue=false)]
        public decimal? Ppa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Play {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  DriveNumber: ").Append(DriveNumber).Append("\n");
            sb.Append("  PlayNumber: ").Append(PlayNumber).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  OffenseConference: ").Append(OffenseConference).Append("\n");
            sb.Append("  OffenseScore: ").Append(OffenseScore).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
            sb.Append("  DefenseConference: ").Append(DefenseConference).Append("\n");
            sb.Append("  DefenseScore: ").Append(DefenseScore).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  OffenseTimeouts: ").Append(OffenseTimeouts).Append("\n");
            sb.Append("  DefenseTimeouts: ").Append(DefenseTimeouts).Append("\n");
            sb.Append("  YardLine: ").Append(YardLine).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  YardsGained: ").Append(YardsGained).Append("\n");
            sb.Append("  Scoring: ").Append(Scoring).Append("\n");
            sb.Append("  PlayType: ").Append(PlayType).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
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
            return this.Equals(input as Play);
        }

        /// <summary>
        /// Returns true if Play instances are equal
        /// </summary>
        /// <param name="input">Instance of Play to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Play input)
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
                    this.DriveId == input.DriveId ||
                    (this.DriveId != null &&
                    this.DriveId.Equals(input.DriveId))
                ) && 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.DriveNumber == input.DriveNumber ||
                    (this.DriveNumber != null &&
                    this.DriveNumber.Equals(input.DriveNumber))
                ) && 
                (
                    this.PlayNumber == input.PlayNumber ||
                    (this.PlayNumber != null &&
                    this.PlayNumber.Equals(input.PlayNumber))
                ) && 
                (
                    this.Offense == input.Offense ||
                    (this.Offense != null &&
                    this.Offense.Equals(input.Offense))
                ) && 
                (
                    this.OffenseConference == input.OffenseConference ||
                    (this.OffenseConference != null &&
                    this.OffenseConference.Equals(input.OffenseConference))
                ) && 
                (
                    this.OffenseScore == input.OffenseScore ||
                    (this.OffenseScore != null &&
                    this.OffenseScore.Equals(input.OffenseScore))
                ) && 
                (
                    this.Defense == input.Defense ||
                    (this.Defense != null &&
                    this.Defense.Equals(input.Defense))
                ) && 
                (
                    this.Home == input.Home ||
                    (this.Home != null &&
                    this.Home.Equals(input.Home))
                ) && 
                (
                    this.Away == input.Away ||
                    (this.Away != null &&
                    this.Away.Equals(input.Away))
                ) && 
                (
                    this.DefenseConference == input.DefenseConference ||
                    (this.DefenseConference != null &&
                    this.DefenseConference.Equals(input.DefenseConference))
                ) && 
                (
                    this.DefenseScore == input.DefenseScore ||
                    (this.DefenseScore != null &&
                    this.DefenseScore.Equals(input.DefenseScore))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Clock == input.Clock ||
                    (this.Clock != null &&
                    this.Clock.Equals(input.Clock))
                ) && 
                (
                    this.OffenseTimeouts == input.OffenseTimeouts ||
                    (this.OffenseTimeouts != null &&
                    this.OffenseTimeouts.Equals(input.OffenseTimeouts))
                ) && 
                (
                    this.DefenseTimeouts == input.DefenseTimeouts ||
                    (this.DefenseTimeouts != null &&
                    this.DefenseTimeouts.Equals(input.DefenseTimeouts))
                ) && 
                (
                    this.YardLine == input.YardLine ||
                    (this.YardLine != null &&
                    this.YardLine.Equals(input.YardLine))
                ) && 
                (
                    this.YardsToGoal == input.YardsToGoal ||
                    (this.YardsToGoal != null &&
                    this.YardsToGoal.Equals(input.YardsToGoal))
                ) && 
                (
                    this.Down == input.Down ||
                    (this.Down != null &&
                    this.Down.Equals(input.Down))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.YardsGained == input.YardsGained ||
                    (this.YardsGained != null &&
                    this.YardsGained.Equals(input.YardsGained))
                ) && 
                (
                    this.Scoring == input.Scoring ||
                    (this.Scoring != null &&
                    this.Scoring.Equals(input.Scoring))
                ) && 
                (
                    this.PlayType == input.PlayType ||
                    (this.PlayType != null &&
                    this.PlayType.Equals(input.PlayType))
                ) && 
                (
                    this.PlayText == input.PlayText ||
                    (this.PlayText != null &&
                    this.PlayText.Equals(input.PlayText))
                ) && 
                (
                    this.Ppa == input.Ppa ||
                    (this.Ppa != null &&
                    this.Ppa.Equals(input.Ppa))
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
                if (this.DriveId != null)
                    hashCode = hashCode * 59 + this.DriveId.GetHashCode();
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.DriveNumber != null)
                    hashCode = hashCode * 59 + this.DriveNumber.GetHashCode();
                if (this.PlayNumber != null)
                    hashCode = hashCode * 59 + this.PlayNumber.GetHashCode();
                if (this.Offense != null)
                    hashCode = hashCode * 59 + this.Offense.GetHashCode();
                if (this.OffenseConference != null)
                    hashCode = hashCode * 59 + this.OffenseConference.GetHashCode();
                if (this.OffenseScore != null)
                    hashCode = hashCode * 59 + this.OffenseScore.GetHashCode();
                if (this.Defense != null)
                    hashCode = hashCode * 59 + this.Defense.GetHashCode();
                if (this.Home != null)
                    hashCode = hashCode * 59 + this.Home.GetHashCode();
                if (this.Away != null)
                    hashCode = hashCode * 59 + this.Away.GetHashCode();
                if (this.DefenseConference != null)
                    hashCode = hashCode * 59 + this.DefenseConference.GetHashCode();
                if (this.DefenseScore != null)
                    hashCode = hashCode * 59 + this.DefenseScore.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Clock != null)
                    hashCode = hashCode * 59 + this.Clock.GetHashCode();
                if (this.OffenseTimeouts != null)
                    hashCode = hashCode * 59 + this.OffenseTimeouts.GetHashCode();
                if (this.DefenseTimeouts != null)
                    hashCode = hashCode * 59 + this.DefenseTimeouts.GetHashCode();
                if (this.YardLine != null)
                    hashCode = hashCode * 59 + this.YardLine.GetHashCode();
                if (this.YardsToGoal != null)
                    hashCode = hashCode * 59 + this.YardsToGoal.GetHashCode();
                if (this.Down != null)
                    hashCode = hashCode * 59 + this.Down.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.YardsGained != null)
                    hashCode = hashCode * 59 + this.YardsGained.GetHashCode();
                if (this.Scoring != null)
                    hashCode = hashCode * 59 + this.Scoring.GetHashCode();
                if (this.PlayType != null)
                    hashCode = hashCode * 59 + this.PlayType.GetHashCode();
                if (this.PlayText != null)
                    hashCode = hashCode * 59 + this.PlayText.GetHashCode();
                if (this.Ppa != null)
                    hashCode = hashCode * 59 + this.Ppa.GetHashCode();
                return hashCode;
            }
        }
    }

}
