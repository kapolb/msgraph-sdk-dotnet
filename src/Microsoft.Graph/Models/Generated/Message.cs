// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Message.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Message : OutlookItem
    {
    
        /// <summary>
        /// Gets or sets received date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "receivedDateTime", Required = Required.Default)]
        public DateTimeOffset? ReceivedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets sent date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sentDateTime", Required = Required.Default)]
        public DateTimeOffset? SentDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets internet message id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "internetMessageId", Required = Required.Default)]
        public string InternetMessageId { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Required.Default)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets body preview.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bodyPreview", Required = Required.Default)]
        public string BodyPreview { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Required.Default)]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets sender.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sender", Required = Required.Default)]
        public Recipient Sender { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "from", Required = Required.Default)]
        public Recipient From { get; set; }
    
        /// <summary>
        /// Gets or sets to recipients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "toRecipients", Required = Required.Default)]
        public IEnumerable<Recipient> ToRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets cc recipients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ccRecipients", Required = Required.Default)]
        public IEnumerable<Recipient> CcRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets bcc recipients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bccRecipients", Required = Required.Default)]
        public IEnumerable<Recipient> BccRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets reply to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replyTo", Required = Required.Default)]
        public IEnumerable<Recipient> ReplyTo { get; set; }
    
        /// <summary>
        /// Gets or sets conversation id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversationId", Required = Required.Default)]
        public string ConversationId { get; set; }
    
        /// <summary>
        /// Gets or sets unique body.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uniqueBody", Required = Required.Default)]
        public ItemBody UniqueBody { get; set; }
    
        /// <summary>
        /// Gets or sets is delivery receipt requested.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeliveryReceiptRequested", Required = Required.Default)]
        public bool? IsDeliveryReceiptRequested { get; set; }
    
        /// <summary>
        /// Gets or sets is read receipt requested.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isReadReceiptRequested", Required = Required.Default)]
        public bool? IsReadReceiptRequested { get; set; }
    
        /// <summary>
        /// Gets or sets is read.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isRead", Required = Required.Default)]
        public bool? IsRead { get; set; }
    
        /// <summary>
        /// Gets or sets is draft.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDraft", Required = Required.Default)]
        public bool? IsDraft { get; set; }
    
        /// <summary>
        /// Gets or sets web link.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webLink", Required = Required.Default)]
        public string WebLink { get; set; }
    
        /// <summary>
        /// Gets or sets inference classification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inferenceClassification", Required = Required.Default)]
        public InferenceClassificationType? InferenceClassification { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attachments", Required = Required.Default)]
        public IMessageAttachmentsCollectionPage Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Required.Default)]
        public IMessageExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Required.Default)]
        public IMessageSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Required.Default)]
        public IMessageMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
    }
}

