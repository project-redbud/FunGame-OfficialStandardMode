using Milimoe.FunGame.Core.Entity;
using Milimoe.FunGame.Core.Library.Common.Addon;
using Milimoe.FunGame.Core.Library.Common.Event;
using Milimoe.FunGame.Core.Library.Constant;
using Milimoe.FunGame.Core.Model;

namespace Milimoe.FunGame.GameModule.OfficialStandard
{
    public class FastAuto : Core.Library.Common.Addon.GameModule
    {
        public override string Name => "OfficialModeFastAuto";

        public override string Description => RoomSet.GetTypeString(RoomType.FastAuto);

        public override string Version => FunGameInfo.FunGame_Version;

        public override string Author => FunGameInfo.FunGame_CopyRight;

        public override string DefaultMap => GameModuleDepend.MapsDepend.Length > 0 ? GameModuleDepend.MapsDepend[0] : "";

        public override GameModuleDepend GameModuleDepend => GameModuleConstant.GameModuleDepend;

        public override RoomType RoomType => RoomType.FastAuto;

        protected Gaming? Instance;
        protected Room room = General.HallInstance;
        protected List<User> users = [];
        protected Dictionary<string, Character> characters = [];

        public override void StartGame(Gaming instance, params object[] args)
        {
            Instance = instance;
            GamingEventArgs eventArgs = instance.EventArgs;
            room = eventArgs.Room;
            users = eventArgs.Users;
        }
    }
}
