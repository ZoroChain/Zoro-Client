using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Net;
using Zoro;
using Zoro.Network.P2P;

namespace Zoro_Client.Properties
{
    internal sealed partial class Settings
    {
        public PathsSettings Paths { get; }
        public P2PSettings P2P { get; }
        public BrowserSettings Urls { get; }
        public ContractSettings Contracts { get; }
        public string PluginURL { get; }
        public RPCSettings RPC { get; }

        public Settings()
        {
            if (NeedUpgrade)
            {
                Upgrade();
                NeedUpgrade = false;
                Save();
            }
            IConfigurationSection section = new ConfigurationBuilder().AddJsonFile("config.json").Build().GetSection("ApplicationConfiguration");
            this.Paths = new PathsSettings(section.GetSection("Paths"));
            this.P2P = new P2PSettings(section.GetSection("P2P"));
            this.Urls = new BrowserSettings(section.GetSection("Urls"));
            this.Contracts = new ContractSettings(section.GetSection("Contracts"));
            this.RPC = new RPCSettings(section.GetSection("RPC"));
            this.PluginURL = section.GetSection("PluginURL").Value;
        }
    }

    internal class PathsSettings
    {
        public string Chain { get; }

        public string RelativePath { get; }

        public PathsSettings(IConfigurationSection section)
        {
            this.Chain = string.Format(section.GetSection("Chain").Value, Message.Magic.ToString("X8"));
            this.RelativePath = section.GetSection("RelativePath")?.Value ?? "";
        }
    }

    internal class P2PSettings
    {
        public ushort Port { get; }
        public ushort WsPort { get; }

        public P2PSettings(IConfigurationSection section)
        {
            this.Port = ushort.Parse(section.GetSection("Port").Value);
            this.WsPort = ushort.Parse(section.GetSection("WsPort").Value);
        }
    }

    internal class BrowserSettings
    {
        public string AddressUrl { get; }
        public string AssetUrl { get; }
        public string TransactionUrl { get; }

        public BrowserSettings(IConfigurationSection section)
        {
            this.AddressUrl = section.GetSection("AddressUrl").Value;
            this.AssetUrl = section.GetSection("AssetUrl").Value;
            this.TransactionUrl = section.GetSection("TransactionUrl").Value;
        }
    }

    internal class ContractSettings
    {
        public UInt160[] NEP5 { get; }

        public ContractSettings(IConfigurationSection section)
        {
            this.NEP5 = section.GetSection("NEP5").GetChildren().Select(p => UInt160.Parse(p.Value)).ToArray();
        }
    }

    internal class RPCSettings
    {
        public IPAddress BindAddress { get; }
        public ushort Port { get; }
        public string SslCert { get; }
        public string SslCertPassword { get; }

        public bool IsActive { get; }

        public RPCSettings(IConfigurationSection section)
        {
            this.BindAddress = IPAddress.Parse(section.GetSection("BindAddress").Value);
            this.Port = ushort.Parse(section.GetSection("Port").Value);
            this.SslCert = section.GetSection("SslCert").Value;
            this.SslCertPassword = section.GetSection("SslCertPassword").Value;
            this.IsActive = bool.Parse(section.GetSection("IsActive").Value);
        }
    }
}
