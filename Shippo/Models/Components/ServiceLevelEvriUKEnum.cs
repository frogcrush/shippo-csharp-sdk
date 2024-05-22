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
    using System;
    
    /// <summary>
    /// |Token | Service name|<br/>
    /// 
    /// <remarks>
    /// |:---|:---|<br/>
    /// | hermes_uk_courier_service | Courier Collection|<br/>
    /// | hermes_uk_parcelshop_dropoff | ParcelShop Drop-Off|<br/>
    /// | hermes_uk_parcelshop_dropoff_nextday | ParcelShop Drop-Off Next Day|<br/>
    /// | hermes_uk_postable | Postable|<br/>
    /// | hermes_uk_postable_nextday | Postable Next Day|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServiceLevelEvriUKEnum
    {
        [JsonProperty("hermes_uk_courier_service")]
        HermesUkCourierService,
        [JsonProperty("hermes_uk_parcelshop_dropoff")]
        HermesUkParcelshopDropoff,
        [JsonProperty("hermes_uk_parcelshop_dropoff_nextday")]
        HermesUkParcelshopDropoffNextday,
        [JsonProperty("hermes_uk_postable")]
        HermesUkPostable,
        [JsonProperty("hermes_uk_postable_nextday")]
        HermesUkPostableNextday,
    }

    public static class ServiceLevelEvriUKEnumExtension
    {
        public static string Value(this ServiceLevelEvriUKEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceLevelEvriUKEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceLevelEvriUKEnum).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ServiceLevelEvriUKEnum)
                    {
                        return (ServiceLevelEvriUKEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceLevelEvriUKEnum");
        }
    }

}