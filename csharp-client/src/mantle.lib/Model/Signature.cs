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
    /// Signature
    /// </summary>
    [DataContract]
    public partial class Signature :  IEquatable<Signature>
    {
        /// <summary>
        /// Defines BlockchainStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlockchainStatusEnum
        {
            
            /// <summary>
            /// Enum Unconfirmed for value: Unconfirmed
            /// </summary>
            [EnumMember(Value = "Unconfirmed")]
            Unconfirmed = 1,
            
            /// <summary>
            /// Enum Confirmed for value: Confirmed
            /// </summary>
            [EnumMember(Value = "Confirmed")]
            Confirmed = 2,
            
            /// <summary>
            /// Enum Corrupted for value: Corrupted
            /// </summary>
            [EnumMember(Value = "Corrupted")]
            Corrupted = 3
        }

        /// <summary>
        /// Gets or Sets BlockchainStatus
        /// </summary>
        [DataMember(Name="blockchainStatus", EmitDefaultValue=false)]
        public BlockchainStatusEnum? BlockchainStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="BlockchainStatus">BlockchainStatus.</param>
        /// <param name="OwnerEmail">OwnerEmail.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="IsDeleted">IsDeleted.</param>
        public Signature(string Id = default(string), BlockchainStatusEnum? BlockchainStatus = default(BlockchainStatusEnum?), string OwnerEmail = default(string), string DisplayName = default(string), DateTime? CreationDate = default(DateTime?), bool? IsDeleted = default(bool?))
        {
            this.Id = Id;
            this.BlockchainStatus = BlockchainStatus;
            this.OwnerEmail = OwnerEmail;
            this.DisplayName = DisplayName;
            this.CreationDate = CreationDate;
            this.IsDeleted = IsDeleted;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Gets or Sets OwnerEmail
        /// </summary>
        [DataMember(Name="ownerEmail", EmitDefaultValue=false)]
        public string OwnerEmail { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BlockchainStatus: ").Append(BlockchainStatus).Append("\n");
            sb.Append("  OwnerEmail: ").Append(OwnerEmail).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as Signature);
        }

        /// <summary>
        /// Returns true if Signature instances are equal
        /// </summary>
        /// <param name="input">Instance of Signature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signature input)
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
                    this.BlockchainStatus == input.BlockchainStatus ||
                    (this.BlockchainStatus != null &&
                    this.BlockchainStatus.Equals(input.BlockchainStatus))
                ) && 
                (
                    this.OwnerEmail == input.OwnerEmail ||
                    (this.OwnerEmail != null &&
                    this.OwnerEmail.Equals(input.OwnerEmail))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
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
                if (this.BlockchainStatus != null)
                    hashCode = hashCode * 59 + this.BlockchainStatus.GetHashCode();
                if (this.OwnerEmail != null)
                    hashCode = hashCode * 59 + this.OwnerEmail.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                return hashCode;
            }
        }
    }

}
