/* 
 * Mantle API
 *
 * Most endpoints require authentication with an <strong>API key</strong><br><br>                                         You must first authenticate with your account by logging in your account on <strong><a target='_blank' href='https://www.mantleblockchain.com'/>mantleblockchain.com</a></strong>.<br>                                         Then, you will need to navigate to the <strong>My API Key</strong> page in the Settings section.<br>                                         You need to have the role administrator of your organization to generate an <strong>API Key</strong>.<br><br>                                         Then use this <strong>API Key</strong> in all your requests with the following header:<br><br>                                         <strong>[ x-api-key: API_KEY ]</strong><br><br>For more information on the different product and more, you can refer to the <a target='_blank' href='https://docs.mantleblockchain.com/v1.0/documentation/home'><strong>knowledge base</strong></a>
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = mantle.lib.Client.SwaggerDateConverter;

namespace mantle.lib.Model
{
    /// <summary>
    /// TrackerBatchTransferBulkRequest
    /// </summary>
    [DataContract]
    public partial class TrackerBatchTransferBulkRequest :  IEquatable<TrackerBatchTransferBulkRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerBatchTransferBulkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackerBatchTransferBulkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerBatchTransferBulkRequest" /> class.
        /// </summary>
        /// <param name="assetId">assetId (required).</param>
        /// <param name="recipientEmail">recipientEmail (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="batchIds">batchIds.</param>
        public TrackerBatchTransferBulkRequest(string assetId = default(string), string recipientEmail = default(string), int? amount = default(int?), List<string> batchIds = default(List<string>))
        {
            // to ensure "assetId" is required (not null)
            if (assetId == null)
            {
                throw new InvalidDataException("assetId is a required property for TrackerBatchTransferBulkRequest and cannot be null");
            }
            else
            {
                this.AssetId = assetId;
            }
            // to ensure "recipientEmail" is required (not null)
            if (recipientEmail == null)
            {
                throw new InvalidDataException("recipientEmail is a required property for TrackerBatchTransferBulkRequest and cannot be null");
            }
            else
            {
                this.RecipientEmail = recipientEmail;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TrackerBatchTransferBulkRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            this.BatchIds = batchIds;
        }
        
        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name="assetId", EmitDefaultValue=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or Sets RecipientEmail
        /// </summary>
        [DataMember(Name="recipientEmail", EmitDefaultValue=false)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or Sets BatchIds
        /// </summary>
        [DataMember(Name="batchIds", EmitDefaultValue=false)]
        public List<string> BatchIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackerBatchTransferBulkRequest {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BatchIds: ").Append(BatchIds).Append("\n");
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
            return this.Equals(input as TrackerBatchTransferBulkRequest);
        }

        /// <summary>
        /// Returns true if TrackerBatchTransferBulkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackerBatchTransferBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackerBatchTransferBulkRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.RecipientEmail == input.RecipientEmail ||
                    (this.RecipientEmail != null &&
                    this.RecipientEmail.Equals(input.RecipientEmail))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BatchIds == input.BatchIds ||
                    this.BatchIds != null &&
                    this.BatchIds.SequenceEqual(input.BatchIds)
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
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.RecipientEmail != null)
                    hashCode = hashCode * 59 + this.RecipientEmail.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BatchIds != null)
                    hashCode = hashCode * 59 + this.BatchIds.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // RecipientEmail (string) maxLength
            if(this.RecipientEmail != null && this.RecipientEmail.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientEmail, length must be less than 200.", new [] { "RecipientEmail" });
            }

            // RecipientEmail (string) minLength
            if(this.RecipientEmail != null && this.RecipientEmail.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientEmail, length must be greater than 0.", new [] { "RecipientEmail" });
            }

            yield break;
        }
    }

}
