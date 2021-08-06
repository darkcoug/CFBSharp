/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.1.4
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using CFBSharp.Client;
using CFBSharp.Model;

namespace CFBSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDrivesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Drive data and results
        /// </summary>
        /// <remarks>
        /// Get game drives
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>ICollection&lt;Drive&gt;</returns>
        ICollection<Drive> GetDrives (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null);

        /// <summary>
        /// Drive data and results
        /// </summary>
        /// <remarks>
        /// Get game drives
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;Drive&gt;</returns>
        ApiResponse<ICollection<Drive>> GetDrivesWithHttpInfo (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Drive data and results
        /// </summary>
        /// <remarks>
        /// Get game drives
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>Task of ICollection&lt;Drive&gt;</returns>
        System.Threading.Tasks.Task<ICollection<Drive>> GetDrivesAsync (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null);

        /// <summary>
        /// Drive data and results
        /// </summary>
        /// <remarks>
        /// Get game drives
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;Drive&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<Drive>>> GetDrivesAsyncWithHttpInfo (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DrivesApi : IDrivesApi
    {
        private CFBSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrivesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DrivesApi(String basePath)
        {
            this.Configuration = new CFBSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrivesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DrivesApi(CFBSharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = CFBSharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CFBSharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CFBSharp.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Drive data and results Get game drives
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>ICollection&lt;Drive&gt;</returns>
        public ICollection<Drive> GetDrives (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null)
        {
             ApiResponse<ICollection<Drive>> localVarResponse = GetDrivesWithHttpInfo(year, seasonType, week, team, offense, defense, conference, offenseConference, defenseConference);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Drive data and results Get game drives
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;Drive&gt;</returns>
        public ApiResponse< ICollection<Drive> > GetDrivesWithHttpInfo (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null)
        {
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling DrivesApi->GetDrives");

            var localVarPath = "./drives";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (seasonType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seasonType", seasonType)); // query parameter
            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (week != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "week", week)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (offense != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offense", offense)); // query parameter
            if (defense != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "defense", defense)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter
            if (offenseConference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offenseConference", offenseConference)); // query parameter
            if (defenseConference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "defenseConference", defenseConference)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDrives", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<Drive>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<Drive>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Drive>)));
        }

        /// <summary>
        /// Drive data and results Get game drives
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>Task of ICollection&lt;Drive&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<Drive>> GetDrivesAsync (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null)
        {
             ApiResponse<ICollection<Drive>> localVarResponse = await GetDrivesAsyncWithHttpInfo(year, seasonType, week, team, offense, defense, conference, offenseConference, defenseConference);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Drive data and results Get game drives
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter</param>
        /// <param name="seasonType">Season type filter (optional, default to regular)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="team">Team filter (optional)</param>
        /// <param name="offense">Offensive team filter (optional)</param>
        /// <param name="defense">Defensive team filter (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <param name="offenseConference">Offensive conference filter (optional)</param>
        /// <param name="defenseConference">Defensive conference filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;Drive&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<Drive>>> GetDrivesAsyncWithHttpInfo (int? year, string seasonType = null, int? week = null, string team = null, string offense = null, string defense = null, string conference = null, string offenseConference = null, string defenseConference = null)
        {
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling DrivesApi->GetDrives");

            var localVarPath = "./drives";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (seasonType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seasonType", seasonType)); // query parameter
            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (week != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "week", week)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (offense != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offense", offense)); // query parameter
            if (defense != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "defense", defense)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter
            if (offenseConference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offenseConference", offenseConference)); // query parameter
            if (defenseConference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "defenseConference", defenseConference)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDrives", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<Drive>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<Drive>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Drive>)));
        }

    }
}
