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
    /// InvitationSignUpResponse
    /// </summary>
    [DataContract]
    public partial class InvitationSignUpResponse :  IEquatable<InvitationSignUpResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationSignUpResponse" /> class.
        /// </summary>
        /// <param name="Invitation">Invitation.</param>
        /// <param name="ClientName">ClientName.</param>
        public InvitationSignUpResponse(Invitation Invitation = default(Invitation), string ClientName = default(string))
        {
            this.Invitation = Invitation;
            this.ClientName = ClientName;
        }
        
        /// <summary>
        /// Gets or Sets Invitation
        /// </summary>
        [DataMember(Name="invitation", EmitDefaultValue=false)]
        public Invitation Invitation { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="clientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationSignUpResponse {\n");
            sb.Append("  Invitation: ").Append(Invitation).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
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
            return this.Equals(input as InvitationSignUpResponse);
        }

        /// <summary>
        /// Returns true if InvitationSignUpResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InvitationSignUpResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationSignUpResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invitation == input.Invitation ||
                    (this.Invitation != null &&
                    this.Invitation.Equals(input.Invitation))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
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
                if (this.Invitation != null)
                    hashCode = hashCode * 59 + this.Invitation.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                return hashCode;
            }
        }
    }

}
