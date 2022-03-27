using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Grpc.Net.Client;
using GrpcService1;
using System.Threading.Tasks;

namespace GrpcBench
{
    [SimpleJob(launchCount: 1, warmupCount: 5, targetCount: 20)]
    public class Program
    {
        GrpcChannel channel;
        Entitlements.EntitlementsClient client;

        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Program>();
        }

        [GlobalSetup]
        public void Setup()
        {
            channel = GrpcChannel.ForAddress("https://localhost:5001");
            client = new Entitlements.EntitlementsClient(channel);
        }

        [GlobalCleanup]
        public void TearDown() 
        {
            channel.Dispose();
        }

        [Benchmark(Baseline = true)]
        public async Task IsEntitled()
        {
            await client.IsEntitledAsync(new IsEntitledRequest
            {
                Identifier = "saved/system.environment/public/ldn/MdxDebug",
                Verb = "Read",
                SimulateWork = false
            });
        }

        [Benchmark]
        public async Task IsEntitled_Simulate_1ms_Of_Work()
        {
            await client.IsEntitledAsync(new IsEntitledRequest
            {
                Identifier = "saved/system.environment/public/ldn/MdxDebug",
                Verb = "Read",
                SimulateWork = true
            });
        }
    }
}
