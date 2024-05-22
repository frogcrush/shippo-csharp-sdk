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
    /// | colissimo_home | Domicile|<br/>
    /// | colissimo_pick_up_point | Point Retrait|<br/>
    /// | colissimo_return_mainland_france | Retour France|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServiceLevelColissimoEnum
    {
        [JsonProperty("colissimo_home")]
        ColissimoHome,
        [JsonProperty("colissimo_pick_up_point")]
        ColissimoPickUpPoint,
        [JsonProperty("colissimo_return_mainland_france")]
        ColissimoReturnMainlandFrance,
    }

    public static class ServiceLevelColissimoEnumExtension
    {
        public static string Value(this ServiceLevelColissimoEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceLevelColissimoEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceLevelColissimoEnum).GetFields())
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

                    if (enumVal is ServiceLevelColissimoEnum)
                    {
                        return (ServiceLevelColissimoEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceLevelColissimoEnum");
        }
    }

}