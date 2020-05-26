using System.Threading.Tasks;
using Akka.Actor;

namespace Akka13
{
    class Program
    {
        private static readonly string Config = @"
        {
           akka{
            actor.provider = cluster
            remote.dot-netty.tcp.hostname = ""localhost""
            remote.dot-netty.tcp.port = 9445
            cluster.seed-nodes = [""akka.tcp://testSys@localhost:9445,akka.tcp://testSys@localhost:9446""]
           }
        ";

        static async Task Main(string[] args)
        {
            using (var actorSystem = ActorSystem.Create("testSys", Config))
            {
                await actorSystem.WhenTerminated;
            }
        }
    }
}
