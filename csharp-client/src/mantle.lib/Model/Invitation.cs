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
    /// Invitation
    /// </summary>
    [DataContract]
    public partial class Invitation :  IEquatable<Invitation>
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 2,
            
            /// <summary>
            /// Enum Deleted for value: Deleted
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted = 3
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines Roles
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RolesEnum
        {
            
            /// <summary>
            /// Enum MCKeeperAdmin for value: MCKeeperAdmin
            /// </summary>
            [EnumMember(Value = "MCKeeperAdmin")]
            MCKeeperAdmin = 1,
            
            /// <summary>
            /// Enum MCBilling for value: MCBilling
            /// </summary>
            [EnumMember(Value = "MCBilling")]
            MCBilling = 2,
            
            /// <summary>
            /// Enum MCUserAdmin for value: MCUserAdmin
            /// </summary>
            [EnumMember(Value = "MCUserAdmin")]
            MCUserAdmin = 3,
            
            /// <summary>
            /// Enum MCTrackerAdmin for value: MCTrackerAdmin
            /// </summary>
            [EnumMember(Value = "MCTrackerAdmin")]
            MCTrackerAdmin = 4,
            
            /// <summary>
            /// Enum MCTrackerUser for value: MCTrackerUser
            /// </summary>
            [EnumMember(Value = "MCTrackerUser")]
            MCTrackerUser = 5,
            
            /// <summary>
            /// Enum MCAuthenticityUser for value: MCAuthenticityUser
            /// </summary>
            [EnumMember(Value = "MCAuthenticityUser")]
            MCAuthenticityUser = 6
        }


        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<RolesEnum> Roles { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invitation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="CreatedByCognitoUserId">CreatedByCognitoUserId.</param>
        /// <param name="NewUserEmail">NewUserEmail.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="CreationDateTime">CreationDateTime.</param>
        public Invitation(string Id = default(string), string ClientId = default(string), string CreatedByCognitoUserId = default(string), string NewUserEmail = default(string), StatusEnum? Status = default(StatusEnum?), List<RolesEnum> Roles = default(List<RolesEnum>), DateTime? CreationDateTime = default(DateTime?))
        {
            this.Id = Id;
            this.ClientId = ClientId;
            this.CreatedByCognitoUserId = CreatedByCognitoUserId;
            this.NewUserEmail = NewUserEmail;
            this.Status = Status;
            this.Roles = Roles;
            this.CreationDateTime = CreationDateTime;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByCognitoUserId
        /// </summary>
        [DataMember(Name="createdByCognitoUserId", EmitDefaultValue=false)]
        public string CreatedByCognitoUserId { get; set; }

        /// <summary>
        /// Gets or Sets NewUserEmail
        /// </summary>
        [DataMember(Name="newUserEmail", EmitDefaultValue=false)]
        public string NewUserEmail { get; set; }



        /// <summary>
        /// Gets or Sets CreationDateTime
        /// </summary>
        [DataMember(Name="creationDateTime", EmitDefaultValue=false)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invitation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CreatedByCognitoUserId: ").Append(CreatedByCognitoUserId).Append("\n");
            sb.Append("  NewUserEmail: ").Append(NewUserEmail).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
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
            return this.Equals(input as Invitation);
        }

        /// <summary>
        /// Returns true if Invitation instances are equal
        /// </summary>
        /// <param name="input">Instance of Invitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invitation input)
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
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.CreatedByCognitoUserId == input.CreatedByCognitoUserId ||
                    (this.CreatedByCognitoUserId != null &&
                    this.CreatedByCognitoUserId.Equals(input.CreatedByCognitoUserId))
                ) && 
                (
                    this.NewUserEmail == input.NewUserEmail ||
                    (this.NewUserEmail != null &&
                    this.NewUserEmail.Equals(input.NewUserEmail))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.CreationDateTime == input.CreationDateTime ||
                    (this.CreationDateTime != null &&
                    this.CreationDateTime.Equals(input.CreationDateTime))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.CreatedByCognitoUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByCognitoUserId.GetHashCode();
                if (this.NewUserEmail != null)
                    hashCode = hashCode * 59 + this.NewUserEmail.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.CreationDateTime != null)
                    hashCode = hashCode * 59 + this.CreationDateTime.GetHashCode();
                return hashCode;
            }
        }
    }

}