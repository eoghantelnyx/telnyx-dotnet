﻿namespace Telnyx.net.Services.OutboundVoiceProfiles
{
    using System.Threading;
    using System.Threading.Tasks;
    using Telnyx.net.Entities;
    using Telnyx.net.Entities.OutboundVoiceProfiles;

    public class OutboundVoiceProfileService : Service<OutboundVoiceProfile>,
        IListable<OutboundVoiceProfile, ListOutboundVoiceProfileOptions>,
        IRetrievable<OutboundVoiceProfile>,
        IDeletable<OutboundVoiceProfile>,
        ICreatable<OutboundVoiceProfile, CreateOutboundVoiceProfileOptions>,
        IUpdatable<OutboundVoiceProfile, CreateOutboundVoiceProfileOptions>
    {
        public override string BasePath => "/outbound_voice_profiles";

        public OutboundVoiceProfile Create(CreateOutboundVoiceProfileOptions createOptions, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(createOptions, requestOptions);
        }

        public Task<OutboundVoiceProfile> CreateAsync(CreateOutboundVoiceProfileOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(createOptions, requestOptions, cancellationToken);
        }

        public OutboundVoiceProfile Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

        public async Task<OutboundVoiceProfile> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public OutboundVoiceProfile Get(string id, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, null, requestOptions);
        }

        public async Task<OutboundVoiceProfile> GetAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await this.GetEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public TelnyxList<OutboundVoiceProfile> List(ListOutboundVoiceProfileOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(listOptions, requestOptions);
        }

        public async Task<TelnyxList<OutboundVoiceProfile>> ListAsync(ListOutboundVoiceProfileOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await this.ListEntitiesAsync(listOptions, requestOptions, cancellationToken);
        }

        public OutboundVoiceProfile Update(string id, CreateOutboundVoiceProfileOptions updateOptions, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, updateOptions, requestOptions);
        }

        public async Task<OutboundVoiceProfile> UpdateAsync(string id, CreateOutboundVoiceProfileOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await this.UpdateEntityAsync(id, updateOptions, requestOptions, cancellationToken);
        }
    }
}
