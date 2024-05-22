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
    /// Address represents the address as retrieved from the database
    /// </summary>
    public class AddressCreateRequest
    {

        /// <summary>
        /// **required for purchase**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// First and Last Name of the addressee
        /// </remarks>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// **required for purchase**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// First street line, 35 character limit. Usually street number and street name (except for DHL Germany, see street_no).
        /// </remarks>
        /// </summary>
        [JsonProperty("street1")]
        public string? Street1 { get; set; }

        /// <summary>
        /// Second street line, 35 character limit.
        /// </summary>
        [JsonProperty("street2")]
        public string? Street2 { get; set; }

        /// <summary>
        /// Third street line, 35 character limit. <br/>
        /// 
        /// <remarks>
        /// Only accepted for USPS international shipments, UPS domestic and UPS international shipments.
        /// </remarks>
        /// </summary>
        [JsonProperty("street3")]
        public string? Street3 { get; set; }

        /// <summary>
        /// Street number of the addressed building. <br/>
        /// 
        /// <remarks>
        /// This field can be included in street1 for all carriers except for DHL Germany.
        /// </remarks>
        /// </summary>
        [JsonProperty("street_no")]
        public string? StreetNo { get; set; }

        /// <summary>
        /// **required for purchase**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Name of a city. When creating a Quote Address, sending a city is optional but will yield more accurate Rates. <br/>
        /// Please bear in mind that city names may be ambiguous (there are 34 Springfields in the US). Pass in a state <br/>
        /// or a ZIP code (see below), if known, it will yield more accurate results.
        /// </remarks>
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// **required for purchase for some countries**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// State/Province values are required for shipments from/to the US, AU, and CA. UPS requires province for some <br/>
        /// countries (i.e Ireland). To receive more accurate quotes, passing this field is recommended. Most carriers <br/>
        /// only accept two or three character state abbreviations.
        /// </remarks>
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// **required for purchase**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Postal code of an Address. When creating a Quote Addresses, sending a ZIP is optional but will yield more <br/>
        /// accurate Rates.
        /// </remarks>
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// Example: `US` or `DE`. All accepted values can be found on the <br/>
        /// 
        /// <remarks>
        /// &lt;a href=&quot;http://www.iso.org/&quot; target=&quot;blank&quot;&gt;Official ISO Website&lt;/a&gt;.<br/>
        /// Sending a country is always required.
        /// </remarks>
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; } = default!;

        /// <summary>
        /// Addresses containing a phone number allow carriers to call the recipient when delivering the Parcel. This <br/>
        /// 
        /// <remarks>
        /// increases the probability of delivery and helps to avoid accessorial charges after a Parcel has been shipped.    
        /// </remarks>
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// E-mail address of the contact person, RFC3696/5321-compliant.
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("is_residential")]
        public bool? IsResidential { get; set; }

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
        /// Set to true to validate Address object.
        /// </summary>
        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}