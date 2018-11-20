/* 
 * Mantle API
 *
 * Most endpoints require authentication with an API key.  You must first authenticate with your account by logging in your account on app.mantle.services. Then, you will need to navigate to the \"My API Key\" page in the Administration section. You might need to have the user administrator of your organization generate you an API Key first.  You must then use this API Key in all your requests with the following header:  [ x-api-key: API_KEY ].
 *
 * OpenAPI spec version: v1
 * 
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
using SwaggerDateConverter = mantle.lib.Client.SwaggerDateConverter;

namespace mantle.lib.Model
{
    /// <summary>
    /// UserLoginResponse
    /// </summary>
    [DataContract]
    public partial class UserLoginResponse :  IEquatable<UserLoginResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLoginResponse" /> class.
        /// </summary>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="User">User.</param>
        public UserLoginResponse(string AccessToken = default(string), User User = default(User))
        {
            this.AccessToken = AccessToken;
            this.User = User;
        }
        
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLoginResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as UserLoginResponse);
        }

        /// <summary>
        /// Returns true if UserLoginResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLoginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLoginResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }
    }

}
