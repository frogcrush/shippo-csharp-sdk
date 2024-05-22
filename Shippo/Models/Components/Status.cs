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
    /// `INVALID` batch shipments cannot be purchased and will have to be removed, fixed, and added to the batch again.&lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// `VALID` batch shipments can be purchased. &lt;br&gt;<br/>
    /// Batch shipments with the status `TRANSACTION_FAILED` were not able to be purchased and the error will be displayed on the message field&lt;br&gt; <br/>
    /// `INCOMPLETE` batch shipments have an issue with the Address and will need to be removed, fixed, and added to the batch again.
    /// </remarks>
    /// </summary>
    public enum Status
    {
        [JsonProperty("INVALID")]
        Invalid,
        [JsonProperty("VALID")]
        Valid,
        [JsonProperty("INCOMPLETE")]
        Incomplete,
        [JsonProperty("TRANSACTION_FAILED")]
        TransactionFailed,
    }

    public static class StatusExtension
    {
        public static string Value(this Status value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Status ToEnum(this string value)
        {
            foreach(var field in typeof(Status).GetFields())
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

                    if (enumVal is Status)
                    {
                        return (Status)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Status");
        }
    }

}