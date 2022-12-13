﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MyJetWallet.B2C2.Client.Models.WebSocket;

namespace MyJetWallet.B2C2.Client
{
    public interface IB2С2WebSocketClient : IDisposable
    {
        Task SubscribeAsync(string instrument, decimal[] levels, Func<PriceMessage, Task> handler,
            CancellationToken ct = default(CancellationToken));

        Task UnsubscribeAsync(string instrument, CancellationToken ct = default(CancellationToken));
    }
}
