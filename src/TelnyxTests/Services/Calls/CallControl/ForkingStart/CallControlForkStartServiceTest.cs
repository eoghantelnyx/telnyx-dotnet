﻿// <copyright file="CallControlForkStartServiceTest.cs" company="Telnyx">
// Copyright (c) Telnyx. All rights reserved.
// </copyright>

namespace TelnyxTests.Services.Calls.CallCommands
{
    using System.Threading.Tasks;
    using Telnyx;
    using Xunit;

    public class CallControlForkStartServiceTest : BaseTelnyxTest
    {
        private const string CallControllId = "call_123";

        private readonly CallControlForkStartService service;
        private readonly CallControlForkStartOptions createOptions;

        public CallControlForkStartServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new CallControlForkStartService();

            this.createOptions = new CallControlForkStartOptions()
            {
                ClientState = "aGF2ZSBhIG5pY2UgZGF5ID1d",
                CommandId = new System.Guid("891510ac-f3e4-11e8-af5b-de00688a4901"),
                Target = "udp:192.0.2.1:9000",
                Rx = "udp:192.0.2.1:9000",
                Tx = "udp:192.0.2.1:9000"
            };
        }

        [Fact]
        public void Create()
        {
            var message = this.service.Create(CallControllId, this.createOptions);
            //this.AssertRequest(HttpMethod.Post, $"/v2/calls/{CallControllId}/actions/fork_start");
            Assert.NotNull(message);
            Assert.Equal(typeof(CallForkStartResponse), message.GetType());
        }

        [Fact]
        public async Task CreateAsync()
        {
            var message = await this.service.CreateAsync(CallControllId, this.createOptions);
            //this.AssertRequest(HttpMethod.Post, $"/v2/calls/{CallControllId}/actions/fork_start");
            Assert.NotNull(message);
            Assert.Equal(typeof(CallForkStartResponse), message.GetType());
        }
    }
}
