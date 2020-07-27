﻿namespace TelnyxTests.Services.Wireless.SimCards
{
    using System.Threading.Tasks;
    using Telnyx;
    using Telnyx.net.Entities.Wireless.SimCards;
    using Telnyx.net.Services.Wireless.SimCards;
    using Xunit;

    public class SimCardEnableServiceTest : BaseTelnyxTest
    {
        private readonly SimCardEnableService service;
        private readonly BaseOptions baseOptions;

        private const string parentId = "6a09cdc3-8948-47f0-aa62-74ac943d6c58";

        public SimCardEnableServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new SimCardEnableService();
            this.baseOptions = new BaseOptions();
        }

        [Fact]
        public void Create()
        {
            var result = this.service.Create(parentId, this.baseOptions);
            Assert.NotNull(result);
            Assert.Equal(typeof(SimCardRecord), result.GetType());
        }

        [Fact]
        public async Task CreateAsync()
        {
            var result = await this.service.CreateAsync(parentId, this.baseOptions);
            Assert.NotNull(result);
            Assert.Equal(typeof(SimCardRecord), result.GetType());
        }
    }
}
