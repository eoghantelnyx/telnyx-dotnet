﻿namespace Telnyx
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CallControlForkStopService
    /// </summary>
    public class CallControlForkStopService : Service<CallAnswerResponse>,
        INestedCreatableWithIdInMid<CallAnswerResponse, CallControlForkStopCreateOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlForkStopService"/> class.
        /// </summary>
        public CallControlForkStopService()
        : base(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlForkStopService"/> class.
        /// </summary>
        /// <param name="apiKey">api key</param>
        public CallControlForkStopService(string apiKey)
            : base(apiKey)
        {
        }

        /// <inheritdoc/>
        public override string BasePath => "/calls";

        /// <inheritdoc/>
        public virtual CallAnswerResponse Create(string id, CallControlForkStopCreateOptions options, string postFix = "actions/fork_stop", RequestOptions requestOptions = null)
        {
            return this.CreateEntity(id, postFix, options, requestOptions);
        }

        /// <inheritdoc/>
        public Task<CallAnswerResponse> CreateAsync(string parentId, CallControlForkStopCreateOptions createOptions, string postFix = "actions/fork_stop", RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(parentId, postFix, createOptions, requestOptions, cancellationToken);
        }
    }
}