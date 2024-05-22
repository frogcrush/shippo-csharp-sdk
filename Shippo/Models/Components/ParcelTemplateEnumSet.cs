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
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System.Numerics;
    using System;
    

    public class ParcelTemplateEnumSetType
    {
        private ParcelTemplateEnumSetType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ParcelTemplateEnumSetType ParcelTemplateFedExEnum { get { return new ParcelTemplateEnumSetType("ParcelTemplateFedExEnum"); } }
        
        public static ParcelTemplateEnumSetType ParcelTemplateUPSEnum { get { return new ParcelTemplateEnumSetType("ParcelTemplateUPSEnum"); } }
        
        public static ParcelTemplateEnumSetType ParcelTemplateUSPSEnum { get { return new ParcelTemplateEnumSetType("ParcelTemplateUSPSEnum"); } }
        
        public static ParcelTemplateEnumSetType ParcelTemplateDHLeCommerceEnum { get { return new ParcelTemplateEnumSetType("ParcelTemplateDHLeCommerceEnum"); } }
        
        public static ParcelTemplateEnumSetType ParcelTemplateDPDUKEnum { get { return new ParcelTemplateEnumSetType("ParcelTemplateDPDUKEnum"); } }
        
        public static ParcelTemplateEnumSetType ParcelTemplateCouriersPleaseEnum { get { return new ParcelTemplateEnumSetType("ParcelTemplateCouriersPleaseEnum"); } }
        
        public static ParcelTemplateEnumSetType ParcelTemplateAramexAustraliaEnum { get { return new ParcelTemplateEnumSetType("ParcelTemplateAramexAustraliaEnum"); } }
        
        public static ParcelTemplateEnumSetType Null { get { return new ParcelTemplateEnumSetType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ParcelTemplateEnumSetType v) { return v.Value; }
        public static ParcelTemplateEnumSetType FromString(string v) {
            switch(v) {
                case "ParcelTemplateFedExEnum": return ParcelTemplateFedExEnum;
                case "ParcelTemplateUPSEnum": return ParcelTemplateUPSEnum;
                case "ParcelTemplateUSPSEnum": return ParcelTemplateUSPSEnum;
                case "ParcelTemplateDHLeCommerceEnum": return ParcelTemplateDHLeCommerceEnum;
                case "ParcelTemplateDPDUKEnum": return ParcelTemplateDPDUKEnum;
                case "ParcelTemplateCouriersPleaseEnum": return ParcelTemplateCouriersPleaseEnum;
                case "ParcelTemplateAramexAustraliaEnum": return ParcelTemplateAramexAustraliaEnum;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ParcelTemplateEnumSetType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ParcelTemplateEnumSetType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    
/// <summary>
/// If template is passed, `length`, `width`, `height`, and `distance_unit` are not required
/// </summary>
    [JsonConverter(typeof(ParcelTemplateEnumSet.ParcelTemplateEnumSetConverter))]
    public class ParcelTemplateEnumSet {
        public ParcelTemplateEnumSet(ParcelTemplateEnumSetType type) {
            Type = type;
        }
        public ParcelTemplateFedExEnum? ParcelTemplateFedExEnum { get; set; } 
        public ParcelTemplateUPSEnum? ParcelTemplateUPSEnum { get; set; } 
        public ParcelTemplateUSPSEnum? ParcelTemplateUSPSEnum { get; set; } 
        public ParcelTemplateDHLeCommerceEnum? ParcelTemplateDHLeCommerceEnum { get; set; } 
        public ParcelTemplateDPDUKEnum? ParcelTemplateDPDUKEnum { get; set; } 
        public ParcelTemplateCouriersPleaseEnum? ParcelTemplateCouriersPleaseEnum { get; set; } 
        public ParcelTemplateAramexAustraliaEnum? ParcelTemplateAramexAustraliaEnum { get; set; } 

        public ParcelTemplateEnumSetType Type { get; set; }


        public static ParcelTemplateEnumSet CreateParcelTemplateFedExEnum(ParcelTemplateFedExEnum parcelTemplateFedExEnum) {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.ParcelTemplateFedExEnum;

            ParcelTemplateEnumSet res = new ParcelTemplateEnumSet(typ);
            res.ParcelTemplateFedExEnum = parcelTemplateFedExEnum;
            return res;
        }

        public static ParcelTemplateEnumSet CreateParcelTemplateUPSEnum(ParcelTemplateUPSEnum parcelTemplateUPSEnum) {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.ParcelTemplateUPSEnum;

            ParcelTemplateEnumSet res = new ParcelTemplateEnumSet(typ);
            res.ParcelTemplateUPSEnum = parcelTemplateUPSEnum;
            return res;
        }

        public static ParcelTemplateEnumSet CreateParcelTemplateUSPSEnum(ParcelTemplateUSPSEnum parcelTemplateUSPSEnum) {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.ParcelTemplateUSPSEnum;

            ParcelTemplateEnumSet res = new ParcelTemplateEnumSet(typ);
            res.ParcelTemplateUSPSEnum = parcelTemplateUSPSEnum;
            return res;
        }

        public static ParcelTemplateEnumSet CreateParcelTemplateDHLeCommerceEnum(ParcelTemplateDHLeCommerceEnum parcelTemplateDHLeCommerceEnum) {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.ParcelTemplateDHLeCommerceEnum;

            ParcelTemplateEnumSet res = new ParcelTemplateEnumSet(typ);
            res.ParcelTemplateDHLeCommerceEnum = parcelTemplateDHLeCommerceEnum;
            return res;
        }

        public static ParcelTemplateEnumSet CreateParcelTemplateDPDUKEnum(ParcelTemplateDPDUKEnum parcelTemplateDPDUKEnum) {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.ParcelTemplateDPDUKEnum;

            ParcelTemplateEnumSet res = new ParcelTemplateEnumSet(typ);
            res.ParcelTemplateDPDUKEnum = parcelTemplateDPDUKEnum;
            return res;
        }

        public static ParcelTemplateEnumSet CreateParcelTemplateCouriersPleaseEnum(ParcelTemplateCouriersPleaseEnum parcelTemplateCouriersPleaseEnum) {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.ParcelTemplateCouriersPleaseEnum;

            ParcelTemplateEnumSet res = new ParcelTemplateEnumSet(typ);
            res.ParcelTemplateCouriersPleaseEnum = parcelTemplateCouriersPleaseEnum;
            return res;
        }

        public static ParcelTemplateEnumSet CreateParcelTemplateAramexAustraliaEnum(ParcelTemplateAramexAustraliaEnum parcelTemplateAramexAustraliaEnum) {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.ParcelTemplateAramexAustraliaEnum;

            ParcelTemplateEnumSet res = new ParcelTemplateEnumSet(typ);
            res.ParcelTemplateAramexAustraliaEnum = parcelTemplateAramexAustraliaEnum;
            return res;
        }

        public static ParcelTemplateEnumSet CreateNull() {
            ParcelTemplateEnumSetType typ = ParcelTemplateEnumSetType.Null;
            return new ParcelTemplateEnumSet(typ);
        }

        public class ParcelTemplateEnumSetConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ParcelTemplateEnumSet);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    ParcelTemplateFedExEnum? parcelTemplateFedExEnum = ResponseBodyDeserializer.Deserialize<ParcelTemplateFedExEnum>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ParcelTemplateEnumSet(ParcelTemplateEnumSetType.ParcelTemplateFedExEnum) {
                        ParcelTemplateFedExEnum = parcelTemplateFedExEnum
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    ParcelTemplateUPSEnum? parcelTemplateUPSEnum = ResponseBodyDeserializer.Deserialize<ParcelTemplateUPSEnum>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ParcelTemplateEnumSet(ParcelTemplateEnumSetType.ParcelTemplateUPSEnum) {
                        ParcelTemplateUPSEnum = parcelTemplateUPSEnum
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    ParcelTemplateUSPSEnum? parcelTemplateUSPSEnum = ResponseBodyDeserializer.Deserialize<ParcelTemplateUSPSEnum>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ParcelTemplateEnumSet(ParcelTemplateEnumSetType.ParcelTemplateUSPSEnum) {
                        ParcelTemplateUSPSEnum = parcelTemplateUSPSEnum
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    ParcelTemplateDHLeCommerceEnum? parcelTemplateDHLeCommerceEnum = ResponseBodyDeserializer.Deserialize<ParcelTemplateDHLeCommerceEnum>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ParcelTemplateEnumSet(ParcelTemplateEnumSetType.ParcelTemplateDHLeCommerceEnum) {
                        ParcelTemplateDHLeCommerceEnum = parcelTemplateDHLeCommerceEnum
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    ParcelTemplateDPDUKEnum? parcelTemplateDPDUKEnum = ResponseBodyDeserializer.Deserialize<ParcelTemplateDPDUKEnum>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ParcelTemplateEnumSet(ParcelTemplateEnumSetType.ParcelTemplateDPDUKEnum) {
                        ParcelTemplateDPDUKEnum = parcelTemplateDPDUKEnum
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    ParcelTemplateCouriersPleaseEnum? parcelTemplateCouriersPleaseEnum = ResponseBodyDeserializer.Deserialize<ParcelTemplateCouriersPleaseEnum>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ParcelTemplateEnumSet(ParcelTemplateEnumSetType.ParcelTemplateCouriersPleaseEnum) {
                        ParcelTemplateCouriersPleaseEnum = parcelTemplateCouriersPleaseEnum
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    ParcelTemplateAramexAustraliaEnum? parcelTemplateAramexAustraliaEnum = ResponseBodyDeserializer.Deserialize<ParcelTemplateAramexAustraliaEnum>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ParcelTemplateEnumSet(ParcelTemplateEnumSetType.ParcelTemplateAramexAustraliaEnum) {
                        ParcelTemplateAramexAustraliaEnum = parcelTemplateAramexAustraliaEnum
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                ParcelTemplateEnumSet res = (ParcelTemplateEnumSet)value;
                if (ParcelTemplateEnumSetType.FromString(res.Type).Equals(ParcelTemplateEnumSetType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ParcelTemplateFedExEnum != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ParcelTemplateFedExEnum));
                    return;
                }
                if (res.ParcelTemplateUPSEnum != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ParcelTemplateUPSEnum));
                    return;
                }
                if (res.ParcelTemplateUSPSEnum != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ParcelTemplateUSPSEnum));
                    return;
                }
                if (res.ParcelTemplateDHLeCommerceEnum != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ParcelTemplateDHLeCommerceEnum));
                    return;
                }
                if (res.ParcelTemplateDPDUKEnum != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ParcelTemplateDPDUKEnum));
                    return;
                }
                if (res.ParcelTemplateCouriersPleaseEnum != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ParcelTemplateCouriersPleaseEnum));
                    return;
                }
                if (res.ParcelTemplateAramexAustraliaEnum != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ParcelTemplateAramexAustraliaEnum));
                    return;
                }

            }
        }

    }

}