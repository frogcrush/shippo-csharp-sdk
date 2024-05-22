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
    using Shippo.Utils;
    
    /// <summary>
    /// Specify that the package contains Dry Ice (FedEx, Veho, and UPS only).
    /// </summary>
    public class DryIce
    {

        /// <summary>
        /// Mandatory. Specifies that the package contains Dry Ice.
        /// </summary>
        [JsonProperty("contains_dry_ice")]
        public bool? ContainsDryIce { get; set; }

        /// <summary>
        /// Mandatory. Units must be in Kilograms. Cannot be greater than package weight.
        /// </summary>
        [JsonProperty("weight")]
        public string? Weight { get; set; }
    }
}