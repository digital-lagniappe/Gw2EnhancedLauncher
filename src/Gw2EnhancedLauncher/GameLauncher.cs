using System.Diagnostics;
using System.IO;

namespace Gw2EnhancedLauncher
{
    internal class GameLauncher
    {
        private readonly string gamePath;

        public GameLauncher(string gameFolderPath)
        {
            this.gamePath = gameFolderPath;
        }
        
        public void Launch()
        {
            this.Launch(new GameLauncherConfig());
        }

        public void Launch(GameLauncherConfig config)
        {
            var file = Path.Combine(this.gamePath, "gw2-64.exe");
            var args = this.BuildArgumentList(config);
            var app = new Process();
            app.StartInfo.FileName = file;
            app.StartInfo.Arguments = args;
            app.Start();
        }

        private string BuildArgumentList(GameLauncherConfig config)
        {
            var args = new System.Text.StringBuilder();
            args.AppendIf(" -bmp", config.UseBmpScreenshots);
            return args.ToString().Trim();
        }
    }
}
