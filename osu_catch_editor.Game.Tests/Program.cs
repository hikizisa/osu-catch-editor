using osu.Framework;
using osu.Framework.Platform;

namespace osu_catch_editor.Game.Tests
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost("visual-tests"))
            using (var game = new osu_catch_editorTestBrowser())
                host.Run(game);
        }
    }
}
