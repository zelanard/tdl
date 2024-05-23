using AudrinoKeyPad;
using System.Threading;

namespace tdl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and start a thread for WebServer
            Thread webServerThread = new Thread(() =>
            {
                WebServer webServer = new WebServer();
                webServer.Host();
            });
            webServerThread.Start();
        }
    }
}
