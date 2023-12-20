using Milimoe.FunGame.Core.Library.Constant;

namespace Milimoe.FunGame.GameMode.OfficialStandard
{
    public class OfficialModeFastAuto : Core.Library.Common.Addon.GameMode
    {
        public override string Name => "OfficialModeFastAuto";

        public override string Description => RoomSet.GetTypeString(RoomType.FastAuto);

        public override string Version => FunGameInfo.FunGame_Version;

        public override string Author => FunGameInfo.FunGame_CopyRight;

        public override string DefaultMap => Maps[0];

        public override string[] Maps => ["OfficialMap16x16"];

        public override RoomType RoomType => RoomType.FastAuto;
    }
}
