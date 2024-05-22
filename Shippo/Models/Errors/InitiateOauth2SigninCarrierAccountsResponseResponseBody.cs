//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Errors
{
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System;
    
    /// <summary>
    /// Invalid carrier account provided by the user
    /// </summary>
    public class InitiateOauth2SigninCarrierAccountsResponseResponseBody : Exception
    {

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("detail")]
        public string? Detail { get; set; }

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;
    }
}