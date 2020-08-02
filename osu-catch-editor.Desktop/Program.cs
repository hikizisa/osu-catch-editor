using osu.Framework.Platform;
using osu.Framework;
using osu_catch_editor.Game;

namespace osu_catch_editor.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"osu_catch_editor"))
            using (osu.Framework.Game game = new osu_catch_editorGame())
                host.Run(game);
        }
    }
}
