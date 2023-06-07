﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telnyx.net.Entities;
using Telnyx.net.Entities.NumberPortouts;

namespace Telnyx.net.Services.NumberPortouts
{
    public class SupportingDocumentsOnAPortoutRequestService : Service<PortOutSupportingDocument>
    {
        public SupportingDocumentsOnAPortoutRequestService()
           : base(null) { }

        public SupportingDocumentsOnAPortoutRequestService(string apiKey)
            : base(apiKey) { }

        public override string BasePath => "/portouts";
        public override string PostPath => "/supporting_documents";

        public TelnyxList<PortOutSupportingDocument> ListSupportingDocumentsOnAPortoutRequest(string id, RequestOptions reqOpts = null)
        {
            return this.ListEntities(this.PostPath, null, reqOpts, id);
        }

        public async Task<TelnyxList<PortOutSupportingDocument>> ListSupportingDocumentsOnAPortoutRequestAsync(string id, RequestOptions reqOpts = null, CancellationToken ct = default)
        {
            return await this.ListEntitiesAsync(this.PostPath, null, reqOpts, ct, id);
        }

        public virtual PortOutSupportingDocument CreateAListOfSupportingDocumentsOnAPortoutRequest(string id, CreateAListOfSupportingDocumentsOnAPortoutRequestOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(id, options, requestOptions, this.PostPath);
        }

        public async Task<PortOutSupportingDocument> CreateAListOfSupportingDocumentsOnAPortoutRequestAsync(string id, CreateAListOfSupportingDocumentsOnAPortoutRequestOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this.CreateEntityAsync(id, createOptions, requestOptions, cancellationToken, this.PostPath);
        }

        internal object ListAllCommentsForAPortoutRequest(string id, RequestOptions requestOptions)
        {
            throw new NotImplementedException();
        }

        internal Task ListAllCommentsForAPortoutRequestAsync(string id, RequestOptions requestOptions, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        internal object CreateCommentsForAPortoutRequest(string id, CreateCommentsForAPortoutRequestOptions createCommentsForAPortoutRequestOptions, RequestOptions requestOptions)
        {
            throw new NotImplementedException();
        }
    }
}