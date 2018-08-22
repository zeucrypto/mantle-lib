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
    /// TrackerAsset
    /// </summary>
    [DataContract]
    public partial class TrackerAsset :  IEquatable<TrackerAsset>
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
            /// Enum Errored for value: Errored
            /// </summary>
            [EnumMember(Value = "Errored")]
            Errored = 3
        }

        /// <summary>
        /// Gets or Sets BlockchainStatus
        /// </summary>
        [DataMember(Name="blockchainStatus", EmitDefaultValue=false)]
        public BlockchainStatusEnum? BlockchainStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerAsset" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="BlockchainStatus">BlockchainStatus.</param>
        /// <param name="CreationDate">CreationDate.</param>
        public TrackerAsset(string Id = default(string), string Name = default(string), BlockchainStatusEnum? BlockchainStatus = default(BlockchainStatusEnum?), DateTime? CreationDate = default(DateTime?))
        {
            this.Id = Id;
            this.Name = Name;
            this.BlockchainStatus = BlockchainStatus;
            this.CreationDate = CreationDate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


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
            sb.Append("class TrackerAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BlockchainStatus: ").Append(BlockchainStatus).Append("\n");
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
            return this.Equals(input as TrackerAsset);
        }

        /// <summary>
        /// Returns true if TrackerAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackerAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackerAsset input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.BlockchainStatus == input.BlockchainStatus ||
                    (this.BlockchainStatus != null &&
                    this.BlockchainStatus.Equals(input.BlockchainStatus))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BlockchainStatus != null)
                    hashCode = hashCode * 59 + this.BlockchainStatus.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
