using Zoro;
using Zoro.Plugins;

namespace Zoro_Client
{
    internal class AppChainService
    {
        public AppChainService()
        {
        }

        private void Log(string message, LogLevel level = LogLevel.Info)
        {
            PluginManager.Singleton.Log(nameof(AppChainService), level, message, UInt160.Zero);
        }

        private static bool NoWallet()
        {
            if (Program.Wallet != null) return false;           
            return true;
        }
    }
}