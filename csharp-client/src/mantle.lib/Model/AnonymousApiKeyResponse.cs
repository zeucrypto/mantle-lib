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
    /// AnonymousApiKeyResponse
    /// </summary>
    [DataContract]
    public partial class AnonymousApiKeyResponse :  IEquatable<AnonymousApiKeyResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymousApiKeyResponse" /> class.
        /// </summary>
        /// <param name="UserName">UserName.</param>
        /// <param name="CognitoUserId">CognitoUserId.</param>
        /// <param name="CreationDate">CreationDate.</param>
        public AnonymousApiKeyResponse(string UserName = default(string), string CognitoUserId = default(string), DateTime? CreationDate = default(DateTime?))
        {
            this.UserName = UserName;
            this.CognitoUserId = CognitoUserId;
            this.CreationDate = CreationDate;
        }
        
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets CognitoUserId
        /// </summary>
        [DataMember(Name="cognitoUserId", EmitDefaultValue=false)]
        public string CognitoUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnonymousApiKeyResponse {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  CognitoUserId: ").Append(CognitoUserId).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
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
            return this.Equals(input as AnonymousApiKeyResponse);
        }

        /// <summary>
        /// Returns true if AnonymousApiKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AnonymousApiKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnonymousApiKeyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.CognitoUserId == input.CognitoUserId ||
                    (this.CognitoUserId != null &&
                    this.CognitoUserId.Equals(input.CognitoUserId))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.CognitoUserId != null)
                    hashCode = hashCode * 59 + this.CognitoUserId.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
