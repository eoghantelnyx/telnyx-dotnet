﻿namespace Telnyx
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// UnHoldConferenceService
    /// </summary>
    public class UnHoldConferenceService : Service<CallAnswerResponse>,
        INestedCreatableWithIdInMid<CallAnswerResponse, HoldConferenceCreateOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnHoldConferenceService"/> class.
        /// </summary>
        public UnHoldConferenceService()
        : base(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnHoldConferenceService"/> class.
        /// </summary>
        /// <param name="apiKey">api key</param>
        public UnHoldConferenceService(string apiKey)
            : base(apiKey)
        {
        }

        /// <inheritdoc/>
        public override string BasePath => "/conferences";

        /// <inheritdoc/>
        public virtual CallAnswerResponse Create(string id, HoldConferenceCreateOptions options, string postFix = "actions/unhold", RequestOptions requestOptions = null)
        {
            return this.CreateEntity(id, postFix, options, requestOptions);
        }

        /// <inheritdoc/>
        public Task<CallAnswerResponse> CreateAsync(string parentId, HoldConferenceCreateOptions createOptions, string postFix = "actions/unhold", RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(parentId, postFix, createOptions, requestOptions, cancellationToken);
        }
    }
}