/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.1.3
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
    /// GameWeather
    /// </summary>
    [DataContract]
    public partial class GameWeather :  IEquatable<GameWeather>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameWeather" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="seasonType">seasonType.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="isStartTimeTBD">isStartTimeTBD.</param>
        /// <param name="homeTeam">homeTeam.</param>
        /// <param name="homeConference">homeConference.</param>
        /// <param name="awayTeam">awayTeam.</param>
        /// <param name="awayConference">awayConference.</param>
        /// <param name="venueId">venueId.</param>
        /// <param name="venue">venue.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="dewPoint">dewPoint.</param>
        /// <param name="humidity">humidity.</param>
        /// <param name="precipitation">precipitation.</param>
        /// <param name="snowfall">snowfall.</param>
        /// <param name="windDirection">windDirection.</param>
        /// <param name="windSpeed">windSpeed.</param>
        /// <param name="pressure">pressure.</param>
        /// <param name="weatherConditionCode">weatherConditionCode.</param>
        /// <param name="weatherCondition">weatherCondition.</param>
        public GameWeather(int? id = default(int?), int? season = default(int?), int? week = default(int?), string seasonType = default(string), string startTime = default(string), bool? isStartTimeTBD = default(bool?), string homeTeam = default(string), string homeConference = default(string), string awayTeam = default(string), string awayConference = default(string), int? venueId = default(int?), string venue = default(string), decimal? temperature = default(decimal?), decimal? dewPoint = default(decimal?), decimal? humidity = default(decimal?), decimal? precipitation = default(decimal?), decimal? snowfall = default(decimal?), decimal? windDirection = default(decimal?), decimal? windSpeed = default(decimal?), decimal? pressure = default(decimal?), int? weatherConditionCode = default(int?), string weatherCondition = default(string))
        {
            this.Id = id;
            this.Season = season;
            this.Week = week;
            this.SeasonType = seasonType;
            this.StartTime = startTime;
            this.IsStartTimeTBD = isStartTimeTBD;
            this.HomeTeam = homeTeam;
            this.HomeConference = homeConference;
            this.AwayTeam = awayTeam;
            this.AwayConference = awayConference;
            this.VenueId = venueId;
            this.Venue = venue;
            this.Temperature = temperature;
            this.DewPoint = dewPoint;
            this.Humidity = humidity;
            this.Precipitation = precipitation;
            this.Snowfall = snowfall;
            this.WindDirection = windDirection;
            this.WindSpeed = windSpeed;
            this.Pressure = pressure;
            this.WeatherConditionCode = weatherConditionCode;
            this.WeatherCondition = weatherCondition;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name="seasonType", EmitDefaultValue=false)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets IsStartTimeTBD
        /// </summary>
        [DataMember(Name="isStartTimeTBD", EmitDefaultValue=false)]
        public bool? IsStartTimeTBD { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name="homeTeam", EmitDefaultValue=false)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeConference
        /// </summary>
        [DataMember(Name="homeConference", EmitDefaultValue=false)]
        public string HomeConference { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name="awayTeam", EmitDefaultValue=false)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayConference
        /// </summary>
        [DataMember(Name="awayConference", EmitDefaultValue=false)]
        public string AwayConference { get; set; }

        /// <summary>
        /// Gets or Sets VenueId
        /// </summary>
        [DataMember(Name="venueId", EmitDefaultValue=false)]
        public int? VenueId { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name="venue", EmitDefaultValue=false)]
        public string Venue { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public decimal? Temperature { get; set; }

        /// <summary>
        /// Gets or Sets DewPoint
        /// </summary>
        [DataMember(Name="dewPoint", EmitDefaultValue=false)]
        public decimal? DewPoint { get; set; }

        /// <summary>
        /// Gets or Sets Humidity
        /// </summary>
        [DataMember(Name="humidity", EmitDefaultValue=false)]
        public decimal? Humidity { get; set; }

        /// <summary>
        /// Gets or Sets Precipitation
        /// </summary>
        [DataMember(Name="precipitation", EmitDefaultValue=false)]
        public decimal? Precipitation { get; set; }

        /// <summary>
        /// Gets or Sets Snowfall
        /// </summary>
        [DataMember(Name="snowfall", EmitDefaultValue=false)]
        public decimal? Snowfall { get; set; }

        /// <summary>
        /// Gets or Sets WindDirection
        /// </summary>
        [DataMember(Name="windDirection", EmitDefaultValue=false)]
        public decimal? WindDirection { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [DataMember(Name="windSpeed", EmitDefaultValue=false)]
        public decimal? WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Pressure
        /// </summary>
        [DataMember(Name="pressure", EmitDefaultValue=false)]
        public decimal? Pressure { get; set; }

        /// <summary>
        /// Gets or Sets WeatherConditionCode
        /// </summary>
        [DataMember(Name="weatherConditionCode", EmitDefaultValue=false)]
        public int? WeatherConditionCode { get; set; }

        /// <summary>
        /// Gets or Sets WeatherCondition
        /// </summary>
        [DataMember(Name="weatherCondition", EmitDefaultValue=false)]
        public string WeatherCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameWeather {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  IsStartTimeTBD: ").Append(IsStartTimeTBD).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  HomeConference: ").Append(HomeConference).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  AwayConference: ").Append(AwayConference).Append("\n");
            sb.Append("  VenueId: ").Append(VenueId).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  DewPoint: ").Append(DewPoint).Append("\n");
            sb.Append("  Humidity: ").Append(Humidity).Append("\n");
            sb.Append("  Precipitation: ").Append(Precipitation).Append("\n");
            sb.Append("  Snowfall: ").Append(Snowfall).Append("\n");
            sb.Append("  WindDirection: ").Append(WindDirection).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
            sb.Append("  WeatherConditionCode: ").Append(WeatherConditionCode).Append("\n");
            sb.Append("  WeatherCondition: ").Append(WeatherCondition).Append("\n");
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
            return this.Equals(input as GameWeather);
        }

        /// <summary>
        /// Returns true if GameWeather instances are equal
        /// </summary>
        /// <param name="input">Instance of GameWeather to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameWeather input)
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
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.SeasonType == input.SeasonType ||
                    (this.SeasonType != null &&
                    this.SeasonType.Equals(input.SeasonType))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.IsStartTimeTBD == input.IsStartTimeTBD ||
                    (this.IsStartTimeTBD != null &&
                    this.IsStartTimeTBD.Equals(input.IsStartTimeTBD))
                ) && 
                (
                    this.HomeTeam == input.HomeTeam ||
                    (this.HomeTeam != null &&
                    this.HomeTeam.Equals(input.HomeTeam))
                ) && 
                (
                    this.HomeConference == input.HomeConference ||
                    (this.HomeConference != null &&
                    this.HomeConference.Equals(input.HomeConference))
                ) && 
                (
                    this.AwayTeam == input.AwayTeam ||
                    (this.AwayTeam != null &&
                    this.AwayTeam.Equals(input.AwayTeam))
                ) && 
                (
                    this.AwayConference == input.AwayConference ||
                    (this.AwayConference != null &&
                    this.AwayConference.Equals(input.AwayConference))
                ) && 
                (
                    this.VenueId == input.VenueId ||
                    (this.VenueId != null &&
                    this.VenueId.Equals(input.VenueId))
                ) && 
                (
                    this.Venue == input.Venue ||
                    (this.Venue != null &&
                    this.Venue.Equals(input.Venue))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) && 
                (
                    this.DewPoint == input.DewPoint ||
                    (this.DewPoint != null &&
                    this.DewPoint.Equals(input.DewPoint))
                ) && 
                (
                    this.Humidity == input.Humidity ||
                    (this.Humidity != null &&
                    this.Humidity.Equals(input.Humidity))
                ) && 
                (
                    this.Precipitation == input.Precipitation ||
                    (this.Precipitation != null &&
                    this.Precipitation.Equals(input.Precipitation))
                ) && 
                (
                    this.Snowfall == input.Snowfall ||
                    (this.Snowfall != null &&
                    this.Snowfall.Equals(input.Snowfall))
                ) && 
                (
                    this.WindDirection == input.WindDirection ||
                    (this.WindDirection != null &&
                    this.WindDirection.Equals(input.WindDirection))
                ) && 
                (
                    this.WindSpeed == input.WindSpeed ||
                    (this.WindSpeed != null &&
                    this.WindSpeed.Equals(input.WindSpeed))
                ) && 
                (
                    this.Pressure == input.Pressure ||
                    (this.Pressure != null &&
                    this.Pressure.Equals(input.Pressure))
                ) && 
                (
                    this.WeatherConditionCode == input.WeatherConditionCode ||
                    (this.WeatherConditionCode != null &&
                    this.WeatherConditionCode.Equals(input.WeatherConditionCode))
                ) && 
                (
                    this.WeatherCondition == input.WeatherCondition ||
                    (this.WeatherCondition != null &&
                    this.WeatherCondition.Equals(input.WeatherCondition))
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.SeasonType != null)
                    hashCode = hashCode * 59 + this.SeasonType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.IsStartTimeTBD != null)
                    hashCode = hashCode * 59 + this.IsStartTimeTBD.GetHashCode();
                if (this.HomeTeam != null)
                    hashCode = hashCode * 59 + this.HomeTeam.GetHashCode();
                if (this.HomeConference != null)
                    hashCode = hashCode * 59 + this.HomeConference.GetHashCode();
                if (this.AwayTeam != null)
                    hashCode = hashCode * 59 + this.AwayTeam.GetHashCode();
                if (this.AwayConference != null)
                    hashCode = hashCode * 59 + this.AwayConference.GetHashCode();
                if (this.VenueId != null)
                    hashCode = hashCode * 59 + this.VenueId.GetHashCode();
                if (this.Venue != null)
                    hashCode = hashCode * 59 + this.Venue.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
                if (this.DewPoint != null)
                    hashCode = hashCode * 59 + this.DewPoint.GetHashCode();
                if (this.Humidity != null)
                    hashCode = hashCode * 59 + this.Humidity.GetHashCode();
                if (this.Precipitation != null)
                    hashCode = hashCode * 59 + this.Precipitation.GetHashCode();
                if (this.Snowfall != null)
                    hashCode = hashCode * 59 + this.Snowfall.GetHashCode();
                if (this.WindDirection != null)
                    hashCode = hashCode * 59 + this.WindDirection.GetHashCode();
                if (this.WindSpeed != null)
                    hashCode = hashCode * 59 + this.WindSpeed.GetHashCode();
                if (this.Pressure != null)
                    hashCode = hashCode * 59 + this.Pressure.GetHashCode();
                if (this.WeatherConditionCode != null)
                    hashCode = hashCode * 59 + this.WeatherConditionCode.GetHashCode();
                if (this.WeatherCondition != null)
                    hashCode = hashCode * 59 + this.WeatherCondition.GetHashCode();
                return hashCode;
            }
        }
    }

}
