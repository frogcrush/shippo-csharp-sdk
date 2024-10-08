//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Requests
{
    using Shippo.Utils;
    
    public class GetTrackRequest
    {

        /// <summary>
        /// Tracking number
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=TrackingNumber")]
        public string TrackingNumber { get; set; } = default!;

        /// <summary>
        /// Name of the carrier
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=Carrier")]
        public string Carrier { get; set; } = default!;

        /// <summary>
        /// String used to pick a non-default API version to use
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=SHIPPO-API-VERSION")]
        public string? ShippoApiVersion { get; set; }
    }
}