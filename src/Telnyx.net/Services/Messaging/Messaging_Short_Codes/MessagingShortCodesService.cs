﻿namespace Telnyx
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MessagingShortCodesService
    /// </summary>
    public class MessagingShortCodesService : Service<MessagingShortCode>,
        IListable<MessagingShortCode, MessagingShortCodeListOptions>,
        IUpdatable<MessagingShortCode, MessagingShortCodeUpdate>,
        IRetrievable<MessagingShortCode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingShortCodesService"/> class.
        /// </summary>
        public MessagingShortCodesService()
            : base(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingShortCodesService"/> class.
        /// </summary>
        /// <param name="apiKey">api key</param>
        public MessagingShortCodesService(string apiKey)
            : base(apiKey)
        {
        }

        /// <inheritdoc/>
        public override string BasePath => "/short_codes";

        /// <inheritdoc/>
        public MessagingShortCode Get(string id, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, null, requestOptions);
        }

        /// <inheritdoc/>
        public Task<MessagingShortCode> GetAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(id, null, requestOptions, cancellationToken);
        }

        /// <inheritdoc/>
        public TelnyxList<MessagingShortCode> List(MessagingShortCodeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(listOptions, requestOptions);
        }

        /// <inheritdoc/>
        public Task<TelnyxList<MessagingShortCode>> ListAsync(MessagingShortCodeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(listOptions, requestOptions, cancellationToken);
        }

        /// <inheritdoc/>
        public MessagingShortCode Update(string id, MessagingShortCodeUpdate updateOptions, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, updateOptions, requestOptions);
        }

        /// <inheritdoc/>
        public Task<MessagingShortCode> UpdateAsync(string id, MessagingShortCodeUpdate updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(id, updateOptions, requestOptions, cancellationToken);
        }
    }
}
