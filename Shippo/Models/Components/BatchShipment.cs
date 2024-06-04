//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Components
{
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System.Collections.Generic;
    
    public class BatchShipment
    {

        /// <summary>
        /// Object ID of the carrier account to be used for this shipment (will override batch default)
        /// </summary>
        [JsonProperty("carrier_account")]
        public string? CarrierAccount { get; set; }

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you want <br/>
        /// 
        /// <remarks>
        /// to attach to the object.
        /// </remarks>
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// A token that sets the shipping method for the batch, overriding the batch default. <br/>
        /// 
        /// <remarks>
        /// Servicelevel tokens can be found &lt;a href=&quot;#tag/Service-Levels&quot;&gt;in this list&lt;/a&gt; <br/>
        /// or &lt;a href=&quot;#operation/ListCarrierAccounts&quot;&gt;at this endpoint&lt;/a&gt;.
        /// </remarks>
        /// </summary>
        [JsonProperty("servicelevel_token")]
        public string? ServicelevelToken { get; set; }

        /// <summary>
        /// List of Shipment and Transaction error messages.
        /// </summary>
        [JsonProperty("messages")]
        public List<object>? Messages { get; set; }

        /// <summary>
        /// Object ID of this batch shipment. Can be used in the remove_shipments endpoint.
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// Object ID of the shipment object created for this batch shipment.
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; } = default!;

        /// <summary>
        /// `INVALID` batch shipments cannot be purchased and will have to be removed, fixed, and added to the batch again.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// `VALID` batch shipments can be purchased. &lt;br&gt;<br/>
        /// Batch shipments with the status `TRANSACTION_FAILED` were not able to be purchased and the error will be displayed on the message field&lt;br&gt; <br/>
        /// `INCOMPLETE` batch shipments have an issue with the Address and will need to be removed, fixed, and added to the batch again.
        /// </remarks>
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; } = default!;

        /// <summary>
        /// Object ID of the transaction object created for this batch shipment.
        /// </summary>
        [JsonProperty("transaction")]
        public string? Transaction { get; set; }
    }
}