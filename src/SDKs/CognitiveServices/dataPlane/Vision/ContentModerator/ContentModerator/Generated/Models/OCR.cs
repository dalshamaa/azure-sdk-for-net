// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains the text found in image for the language specified.
    /// </summary>
    public partial class OCR
    {
        /// <summary>
        /// Initializes a new instance of the OCR class.
        /// </summary>
        public OCR()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OCR class.
        /// </summary>
        /// <param name="status">The evaluate status</param>
        /// <param name="metadata">Array of KeyValue.</param>
        /// <param name="trackingId">The tracking id.</param>
        /// <param name="cacheId">The cache id.</param>
        /// <param name="language">The ISO 639-3 code.</param>
        /// <param name="text">The found text.</param>
        /// <param name="candidates">The list of candidate text.</param>
        public OCR(Status status = default(Status), IList<KeyValuePair> metadata = default(IList<KeyValuePair>), string trackingId = default(string), string cacheId = default(string), string language = default(string), string text = default(string), IList<Candidate> candidates = default(IList<Candidate>))
        {
            Status = status;
            Metadata = metadata;
            TrackingId = trackingId;
            CacheId = cacheId;
            Language = language;
            Text = text;
            Candidates = candidates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the evaluate status
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets array of KeyValue.
        /// </summary>
        [JsonProperty(PropertyName = "Metadata")]
        public IList<KeyValuePair> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the tracking id.
        /// </summary>
        [JsonProperty(PropertyName = "TrackingId")]
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or sets the cache id.
        /// </summary>
        [JsonProperty(PropertyName = "CacheId")]
        public string CacheId { get; set; }

        /// <summary>
        /// Gets or sets the ISO 639-3 code.
        /// </summary>
        [JsonProperty(PropertyName = "Language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the found text.
        /// </summary>
        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the list of candidate text.
        /// </summary>
        [JsonProperty(PropertyName = "Candidates")]
        public IList<Candidate> Candidates { get; set; }

    }
}
