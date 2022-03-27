using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace GrpcService1
{
    public class EntitlementsService : Entitlements.EntitlementsBase
    {
        private readonly ILogger<EntitlementsService> _logger;
        public EntitlementsService(ILogger<EntitlementsService> logger)
        {
            _logger = logger;
        }
        
        public override Task<IsEntitledResponse> IsEntitled(IsEntitledRequest request, ServerCallContext context)
        {
            bool isEntitled = IsEntitled(request.Identifier, request.Verb, request.SimulateWork);

            return Task.FromResult(new IsEntitledResponse
            {
                Entitled = isEntitled
            });
        }

        private bool IsEntitled(string request, string verb, bool simulateWork)
        {
            if (simulateWork)
            {
                // simulate work
                Thread.SpinWait(10000);
            }

            return false;
        }
    }
}
