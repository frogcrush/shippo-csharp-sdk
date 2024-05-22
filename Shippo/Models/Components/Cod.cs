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
    
    /// <summary>
    /// Specify collection on delivery details (UPS only).
    /// </summary>
    public class Cod
    {

        /// <summary>
        /// Amount to be collected.
        /// </summary>
        [JsonProperty("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// Currency for the amount to be collected. Currently only USD is supported for UPS.
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Secured funds include money orders, certified cheques and others (see <br/>
        /// 
        /// <remarks>
        /// &lt;a href=&quot;https://www.ups.com/content/us/en/shipping/time/service/value_added/cod.html&quot;&gt;UPS&lt;/a&gt; for details). <br/>
        /// If no payment_method inputted the value defaults to &quot;ANY&quot;.)
        /// </remarks>
        /// </summary>
        [JsonProperty("payment_method")]
        public PaymentMethod? PaymentMethod { get; set; }
    }
}