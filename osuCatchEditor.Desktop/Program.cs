using osu.Framework.Platform;
using osu.Framework;
using osuCatchEditor.Game;

namespace osuCatchEditor.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"osuCatchEditor"))
            using (osu.Framework.Game game = new osuCatchEditorGame())
                host.Run(game);
        }
    }
}
