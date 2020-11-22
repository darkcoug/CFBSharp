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
    public interface IRatingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Historical SP+ ratings by conference
        /// </summary>
        /// <remarks>
        /// Get average SP+ historical rating data by conference
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ICollection&lt;ConferenceSPRating&gt;</returns>
        ICollection<ConferenceSPRating> GetConferenceSPRatings (int? year = null, string conference = null);

        /// <summary>
        /// Historical SP+ ratings by conference
        /// </summary>
        /// <remarks>
        /// Get average SP+ historical rating data by conference
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;ConferenceSPRating&gt;</returns>
        ApiResponse<ICollection<ConferenceSPRating>> GetConferenceSPRatingsWithHttpInfo (int? year = null, string conference = null);
        /// <summary>
        /// Historical SP+ ratings
        /// </summary>
        /// <remarks>
        /// SP+ rating data
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>ICollection&lt;TeamSPRating&gt;</returns>
        ICollection<TeamSPRating> GetSPRatings (int? year = null, string team = null);

        /// <summary>
        /// Historical SP+ ratings
        /// </summary>
        /// <remarks>
        /// SP+ rating data
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;TeamSPRating&gt;</returns>
        ApiResponse<ICollection<TeamSPRating>> GetSPRatingsWithHttpInfo (int? year = null, string team = null);
        /// <summary>
        /// Historical SRS ratings
        /// </summary>
        /// <remarks>
        /// SRS rating data (requires either a year or team specified)
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>ICollection&lt;TeamSRSRating&gt;</returns>
        ICollection<TeamSRSRating> GetSRSRatings (int? year = null, string team = null, string conference = null);

        /// <summary>
        /// Historical SRS ratings
        /// </summary>
        /// <remarks>
        /// SRS rating data (requires either a year or team specified)
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;TeamSRSRating&gt;</returns>
        ApiResponse<ICollection<TeamSRSRating>> GetSRSRatingsWithHttpInfo (int? year = null, string team = null, string conference = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Historical SP+ ratings by conference
        /// </summary>
        /// <remarks>
        /// Get average SP+ historical rating data by conference
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ICollection&lt;ConferenceSPRating&gt;</returns>
        System.Threading.Tasks.Task<ICollection<ConferenceSPRating>> GetConferenceSPRatingsAsync (int? year = null, string conference = null);

        /// <summary>
        /// Historical SP+ ratings by conference
        /// </summary>
        /// <remarks>
        /// Get average SP+ historical rating data by conference
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;ConferenceSPRating&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<ConferenceSPRating>>> GetConferenceSPRatingsAsyncWithHttpInfo (int? year = null, string conference = null);
        /// <summary>
        /// Historical SP+ ratings
        /// </summary>
        /// <remarks>
        /// SP+ rating data
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>Task of ICollection&lt;TeamSPRating&gt;</returns>
        System.Threading.Tasks.Task<ICollection<TeamSPRating>> GetSPRatingsAsync (int? year = null, string team = null);

        /// <summary>
        /// Historical SP+ ratings
        /// </summary>
        /// <remarks>
        /// SP+ rating data
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;TeamSPRating&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<TeamSPRating>>> GetSPRatingsAsyncWithHttpInfo (int? year = null, string team = null);
        /// <summary>
        /// Historical SRS ratings
        /// </summary>
        /// <remarks>
        /// SRS rating data (requires either a year or team specified)
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>Task of ICollection&lt;TeamSRSRating&gt;</returns>
        System.Threading.Tasks.Task<ICollection<TeamSRSRating>> GetSRSRatingsAsync (int? year = null, string team = null, string conference = null);

        /// <summary>
        /// Historical SRS ratings
        /// </summary>
        /// <remarks>
        /// SRS rating data (requires either a year or team specified)
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;TeamSRSRating&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<TeamSRSRating>>> GetSRSRatingsAsyncWithHttpInfo (int? year = null, string team = null, string conference = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RatingsApi : IRatingsApi
    {
        private CFBSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RatingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RatingsApi(String basePath)
        {
            this.Configuration = new CFBSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RatingsApi(CFBSharp.Client.Configuration configuration = null)
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
        /// Historical SP+ ratings by conference Get average SP+ historical rating data by conference
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ICollection&lt;ConferenceSPRating&gt;</returns>
        public ICollection<ConferenceSPRating> GetConferenceSPRatings (int? year = null, string conference = null)
        {
             ApiResponse<ICollection<ConferenceSPRating>> localVarResponse = GetConferenceSPRatingsWithHttpInfo(year, conference);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Historical SP+ ratings by conference Get average SP+ historical rating data by conference
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;ConferenceSPRating&gt;</returns>
        public ApiResponse< ICollection<ConferenceSPRating> > GetConferenceSPRatingsWithHttpInfo (int? year = null, string conference = null)
        {

            var localVarPath = "./ratings/sp/conferences";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetConferenceSPRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<ConferenceSPRating>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<ConferenceSPRating>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ConferenceSPRating>)));
        }

        /// <summary>
        /// Historical SP+ ratings by conference Get average SP+ historical rating data by conference
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ICollection&lt;ConferenceSPRating&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<ConferenceSPRating>> GetConferenceSPRatingsAsync (int? year = null, string conference = null)
        {
             ApiResponse<ICollection<ConferenceSPRating>> localVarResponse = await GetConferenceSPRatingsAsyncWithHttpInfo(year, conference);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Historical SP+ ratings by conference Get average SP+ historical rating data by conference
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;ConferenceSPRating&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<ConferenceSPRating>>> GetConferenceSPRatingsAsyncWithHttpInfo (int? year = null, string conference = null)
        {

            var localVarPath = "./ratings/sp/conferences";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetConferenceSPRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<ConferenceSPRating>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<ConferenceSPRating>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ConferenceSPRating>)));
        }

        /// <summary>
        /// Historical SP+ ratings SP+ rating data
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>ICollection&lt;TeamSPRating&gt;</returns>
        public ICollection<TeamSPRating> GetSPRatings (int? year = null, string team = null)
        {
             ApiResponse<ICollection<TeamSPRating>> localVarResponse = GetSPRatingsWithHttpInfo(year, team);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Historical SP+ ratings SP+ rating data
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;TeamSPRating&gt;</returns>
        public ApiResponse< ICollection<TeamSPRating> > GetSPRatingsWithHttpInfo (int? year = null, string team = null)
        {

            var localVarPath = "./ratings/sp";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSPRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<TeamSPRating>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<TeamSPRating>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TeamSPRating>)));
        }

        /// <summary>
        /// Historical SP+ ratings SP+ rating data
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>Task of ICollection&lt;TeamSPRating&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<TeamSPRating>> GetSPRatingsAsync (int? year = null, string team = null)
        {
             ApiResponse<ICollection<TeamSPRating>> localVarResponse = await GetSPRatingsAsyncWithHttpInfo(year, team);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Historical SP+ ratings SP+ rating data
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;TeamSPRating&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<TeamSPRating>>> GetSPRatingsAsyncWithHttpInfo (int? year = null, string team = null)
        {

            var localVarPath = "./ratings/sp";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSPRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<TeamSPRating>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<TeamSPRating>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TeamSPRating>)));
        }

        /// <summary>
        /// Historical SRS ratings SRS rating data (requires either a year or team specified)
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>ICollection&lt;TeamSRSRating&gt;</returns>
        public ICollection<TeamSRSRating> GetSRSRatings (int? year = null, string team = null, string conference = null)
        {
             ApiResponse<ICollection<TeamSRSRating>> localVarResponse = GetSRSRatingsWithHttpInfo(year, team, conference);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Historical SRS ratings SRS rating data (requires either a year or team specified)
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;TeamSRSRating&gt;</returns>
        public ApiResponse< ICollection<TeamSRSRating> > GetSRSRatingsWithHttpInfo (int? year = null, string team = null, string conference = null)
        {

            var localVarPath = "./ratings/srs";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSRSRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<TeamSRSRating>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<TeamSRSRating>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TeamSRSRating>)));
        }

        /// <summary>
        /// Historical SRS ratings SRS rating data (requires either a year or team specified)
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>Task of ICollection&lt;TeamSRSRating&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<TeamSRSRating>> GetSRSRatingsAsync (int? year = null, string team = null, string conference = null)
        {
             ApiResponse<ICollection<TeamSRSRating>> localVarResponse = await GetSRSRatingsAsyncWithHttpInfo(year, team, conference);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Historical SRS ratings SRS rating data (requires either a year or team specified)
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Season filter (required if team not specified) (optional)</param>
        /// <param name="team">Team filter (required if year not specified) (optional)</param>
        /// <param name="conference">Conference filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;TeamSRSRating&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<TeamSRSRating>>> GetSRSRatingsAsyncWithHttpInfo (int? year = null, string team = null, string conference = null)
        {

            var localVarPath = "./ratings/srs";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSRSRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<TeamSRSRating>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<TeamSRSRating>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TeamSRSRating>)));
        }

    }
}
