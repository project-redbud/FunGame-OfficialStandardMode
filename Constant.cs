using Milimoe.FunGame.Core.Library.Common.Addon;

namespace Milimoe.FunGame.GameModule.OfficialStandard
{
    public class GameModuleConstant
    {
        public static GameModuleDepend GameModuleDepend => _depends;
        public const string GameModuleFastAuto = "fungame.standard.fastauto";
        public const string StandardMap16x16 = "fungame.standard.map16x16";

        private static readonly string[] Maps = [StandardMap16x16];
        private static readonly string[] Characters = [];
        private static readonly string[] Skills = [];
        private static readonly string[] Items = [];
        private static readonly GameModuleDepend _depends = new(Maps, Characters, Skills, Items);
    }
}
