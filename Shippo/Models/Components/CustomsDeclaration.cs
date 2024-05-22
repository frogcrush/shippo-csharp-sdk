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
    using System.Collections.Generic;
    using System;
    
    public class CustomsDeclaration
    {

        /// <summary>
        /// **required if eel_pfc is `AES_ITN`**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// AES / ITN reference of the shipment.
        /// </remarks>
        /// </summary>
        [JsonProperty("aes_itn")]
        public string? AesItn { get; set; }

        /// <summary>
        /// B13A Option details are obtained by filing a B13A Canada Export Declaration via the Canadian Export Reporting System (CERS). <br/>
        /// 
        /// <remarks>
        /// &lt;a href=&quot;https://www.cbsa-asfc.gc.ca/services/export/guide-eng.html&quot; target=&quot;_blank&quot; rel=&quot;noopener noreferrer&quot;&gt; More information on reporting commercial exports from Canada. &lt;/a&gt;<br/>
        /// Allowed values available &lt;a href=&quot;#tag/Customs-Declaration-B13A-Filing-Option&quot;&gt;here&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("b13a_filing_option")]
        public string? B13aFilingOption { get; set; }

        /// <summary>
        /// **must be provided if and only if b13a_filing_option is provided**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Represents:&lt;br&gt; the Proof of Report (POR) Number when b13a_filing_option is `FILED_ELECTRONICALLY`;&lt;br&gt; <br/>
        /// the Summary ID Number when b13a_filing_option is `SUMMARY_REPORTING`;&lt;br&gt; <br/>
        /// or the Exemption Number when b13a_filing_option is `NOT_REQUIRED`.
        /// </remarks>
        /// </summary>
        [JsonProperty("b13a_number")]
        public string? B13aNumber { get; set; }

        /// <summary>
        /// Certificate reference of the shipment.
        /// </summary>
        [JsonProperty("certificate")]
        public string? Certificate { get; set; }

        /// <summary>
        /// Expresses that the certify_signer has provided all information of this customs declaration truthfully.
        /// </summary>
        [JsonProperty("certify")]
        public bool Certify { get; set; } = default!;

        /// <summary>
        /// Name of the person who created the customs declaration and is responsible for the validity of all <br/>
        /// 
        /// <remarks>
        /// information provided.
        /// </remarks>
        /// </summary>
        [JsonProperty("certify_signer")]
        public string CertifySigner { get; set; } = default!;

        [JsonProperty("commercial_invoice")]
        public bool? CommercialInvoice { get; set; }

        /// <summary>
        /// **required if contents_type is `OTHER`**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Explanation of the type of goods of the shipment.
        /// </remarks>
        /// </summary>
        [JsonProperty("contents_explanation")]
        public string? ContentsExplanation { get; set; }

        /// <summary>
        /// Disclaimer for the shipment and customs information that have been provided.
        /// </summary>
        [JsonProperty("disclaimer")]
        public string? Disclaimer { get; set; }

        /// <summary>
        /// Exporter reference of an export shipment.
        /// </summary>
        [JsonProperty("exporter_reference")]
        public string? ExporterReference { get; set; }

        /// <summary>
        /// Importer reference of an import shipment.
        /// </summary>
        [JsonProperty("importer_reference")]
        public string? ImporterReference { get; set; }

        /// <summary>
        /// Indicates whether the shipment&apos;s destination VAT has been collected. May be required for some destinations.
        /// </summary>
        [JsonProperty("is_vat_collected")]
        public object? IsVatCollected { get; set; }

        /// <summary>
        /// Invoice reference of the shipment.
        /// </summary>
        [JsonProperty("invoice")]
        public string? Invoice { get; set; }

        /// <summary>
        /// License reference of the shipment.
        /// </summary>
        [JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you <br/>
        /// 
        /// <remarks>
        /// want to attach to the object.
        /// </remarks>
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional notes to be included in the customs declaration.
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Object ID of the Importer address.
        /// </summary>
        [JsonProperty("address_importer")]
        public CustomsDeclarationAddressImporter? AddressImporter { get; set; }

        /// <summary>
        /// Type of goods of the shipment.  <br/>
        /// 
        /// <remarks>
        /// Allowed values available &lt;a href=&quot;#tag/Customs-Declaration-Contents-Type&quot;&gt;here&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("contents_type")]
        public string ContentsType { get; set; } = default!;

        /// <summary>
        /// EEL / PFC type of the shipment. For most shipments from the US to CA, `NOEEI_30_36` is applicable; for most <br/>
        /// 
        /// <remarks>
        /// other shipments from the US, `NOEEI_30_37_a` is applicable.<br/>
        /// Allowed values available &lt;a href=&quot;#tag/Customs-Declaration-EELPFC&quot;&gt;here&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("eel_pfc")]
        public string? EelPfc { get; set; }

        /// <summary>
        /// Additional exporter identification that may be required to ship in certain countries
        /// </summary>
        [JsonProperty("exporter_identification")]
        public CustomsExporterIdentification? ExporterIdentification { get; set; }

        /// <summary>
        /// The incoterm reference of the shipment. FCA is available for DHL Express and FedEx only. <br/>
        /// 
        /// <remarks>
        /// eDAP is available for DPD UK only. DAP is available for DHL Express and DPD UK.<br/>
        /// If expecting DAP for other carriers, please use DDU.<br/>
        /// Allowed values available &lt;a href=&quot;#tag/Customs-Declaration-Incoterm&quot;&gt;here&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("incoterm")]
        public string? Incoterm { get; set; }

        /// <summary>
        /// Additional invoiced charges to be shown on the Customs Declaration Commercial Invoice.
        /// </summary>
        [JsonProperty("invoiced_charges")]
        public CustomsInvoicedCharges? InvoicedCharges { get; set; }

        /// <summary>
        /// Distinct Parcel content items as Customs Items object_ids.
        /// </summary>
        [JsonProperty("items")]
        public List<string> Items { get; set; } = default!;

        /// <summary>
        /// Indicates how the carrier should proceed in case the shipment can&apos;t be delivered.<br/>
        /// 
        /// <remarks>
        /// Allowed values available &lt;a href=&quot;#tag/Customs-Declaration-Non-Delivery-Option&quot;&gt;here&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("non_delivery_option")]
        public string NonDeliveryOption { get; set; } = default!;

        /// <summary>
        /// Date and time of object creation.
        /// </summary>
        [JsonProperty("object_created")]
        public DateTime? ObjectCreated { get; set; }

        /// <summary>
        /// Unique identifier of the given object.
        /// </summary>
        [JsonProperty("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// Username of the user who created the object.
        /// </summary>
        [JsonProperty("object_owner")]
        public string? ObjectOwner { get; set; }

        /// <summary>
        /// Indicates the validity of the enclosing object
        /// </summary>
        [JsonProperty("object_state")]
        public ObjectStateEnum? ObjectState { get; set; }

        /// <summary>
        /// Date and time of last object update.
        /// </summary>
        [JsonProperty("object_updated")]
        public DateTime? ObjectUpdated { get; set; }

        /// <summary>
        /// Indicates whether the object has been created in test mode.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }
    }
}