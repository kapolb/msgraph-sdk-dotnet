// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ConversationThreadsCollectionRequestBuilder.
    /// </summary>
    public partial class ConversationThreadsCollectionRequestBuilder : BaseRequestBuilder, IConversationThreadsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ConversationThreadsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ConversationThreadsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IConversationThreadsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IConversationThreadsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ConversationThreadsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConversationThreadRequestBuilder"/> for the specified ConversationConversationThread.
        /// </summary>
        /// <param name="id">The ID for the ConversationConversationThread.</param>
        /// <returns>The <see cref="IConversationThreadRequestBuilder"/>.</returns>
        public IConversationThreadRequestBuilder this[string id]
        {
            get
            {
                return new ConversationThreadRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
