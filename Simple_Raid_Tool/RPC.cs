using DiscordRPC;

namespace Simple_Raid_Tool
{
    internal class RPC
    {
        public static DiscordRpcClient client;
        public static Timestamps rpctimestamp { get; set; }
        private static RichPresence presence;
        public static void InitializeRPC()
        {
            client = new DiscordRpcClient("1237569158246436964");
            client.Initialize();
            Button[] buttons = { new Button() { Label = "Discord Server", Url = "https://discord.gg/faiz3n0p" } };

            presence = new RichPresence()
            {
                Details = "At4cando servidores de Discord...",
                State = "by $ FaiZz",
                Timestamps = rpctimestamp,
                Buttons = buttons,

                Assets = new Assets()
                {
                    LargeImageKey = "simple_raid_tool_rpcccc",
                    LargeImageText = "Simple Raid Tool",
                    SmallImageKey = "",
                    SmallImageText = ""
                }
            };
            SetState("~ by $ FaiZz");
        }
        public static void SetState(string state, bool watching = false)
        {
            presence.State = state;
            client.SetPresence(presence);
        }
    }
}
