using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Grpc.Net.Client;
using GrpcService1;
using System;
using System.Threading.Tasks;

namespace GrpcBench
{
    public class Program
    {
        GrpcChannel channel;
        Greeter.GreeterClient client;

        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Program>();
        }

        [GlobalSetup]
        public void Setup()
        {
            channel = GrpcChannel.ForAddress("https://localhost:5001");
            client = new Greeter.GreeterClient(channel);
        }

        [GlobalCleanup]
        public void TearDown() 
        {
            channel.Dispose();
        }

        [Benchmark]
        public async Task Bench()
        {
            await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
        }
    }
}
