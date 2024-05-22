//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Requests
{
    using Shippo.Utils;
    
    public class ListShipmentRatesRequest
    {

        /// <summary>
        /// Object ID of the shipment to update
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ShipmentId")]
        public string ShipmentId { get; set; } = default!;

        /// <summary>
        /// The page number you want to select
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public long? Page { get; set; } = 1;

        /// <summary>
        /// The number of results to return per page (max 100)
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=results")]
        public long? Results { get; set; } = 25;

        /// <summary>
        /// String used to pick a non-default API version to use
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=SHIPPO-API-VERSION")]
        public string? ShippoApiVersion { get; set; }
    }
}