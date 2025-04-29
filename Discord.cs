using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace Breaworlds_PrivateServerManager
{
    internal class Discord
    {
        public static DiscordRpcClient client = new DiscordRpcClient("1318743749068587128");

        public static void InitRPC()
        {
            Debug.WriteLine("Start RPC");
            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Selecting A Server",
                State = "Idle",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "Breaworlds Private Server Manager"
                }
            });

            var timer = new System.Timers.Timer(150);
            timer.Elapsed += (sender, args) => { client.Invoke(); };
            timer.Start();
        }

        public static void UpdateRPC(string detail, string status, bool timer)
        {
            Debug.WriteLine("Update RPC");
            if (timer)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = detail,
                    State = status,
                    Timestamps = Timestamps.Now
                });
            }
            else
            {
                client.SetPresence(new RichPresence()
                {
                    Details = detail,
                    State = status,
                });
            }
        }

        public static void KillRPC()
        {
            client.Dispose();
        }
    }
}
