using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Zoro;
using Zoro.Ledger;
using Zoro.Network.P2P;
using Zoro.Persistence.LevelDB;
using Zoro.Plugins;
using Zoro_Client.Properties;

namespace Zoro_Client
{
    internal class MainService
    {

        private const string PeerStatePath = "peers.dat";

        private LevelDBStore store;
        private ZoroChainSystem system;
        private AppChainService appchainService;

        protected string Prompt => "zoro";
        public string ServiceName => "Zoro-CLI";

        public MainService()
        {
            appchainService = new AppChainService();
        }

        private static bool NoWallet()
        {
            if (Program.Wallet != null) return false;            
            return true;
        }

        public void Run()
        {
            OnStart();
        }

        protected internal void OnStart()
        {
            string chainPath = Settings.Default.Paths.Chain;
            string relativePath = Settings.Default.Paths.RelativePath;
            string path = relativePath.Length > 0 ? relativePath + chainPath : Path.GetFullPath(chainPath);

            store = new LevelDBStore(path);
            system = new ZoroChainSystem(store, Settings.Default.Paths.RelativePath);

            system.StartNode(UInt160.Zero, Settings.Default.P2P.Port, Settings.Default.P2P.WsPort);

            if (Settings.Default.RPC.IsActive)
            {
                system.StartRpc(IPAddress.Any,
                    Settings.Default.RPC.Port,
                    wallet: Program.Wallet,
                    sslCert: Settings.Default.RPC.SslCert,
                    password: Settings.Default.RPC.SslCertPassword);
            }
        }

        public void OnStop()
        {
            system.SaveRecentPeers();
            system.Dispose();            
        }

    }

}