﻿using System.Collections;
using Milimoe.FunGame.Core.Api.Utility;
using Milimoe.FunGame.Core.Entity;
using Milimoe.FunGame.Core.Interface.Base;
using Milimoe.FunGame.Core.Library.Common.Addon;
using Milimoe.FunGame.Core.Library.Constant;
using Milimoe.FunGame.GameModule.OfficialStandard;

namespace Milimoe.FunGame.GameMode.OfficialStandard
{
    public class FastAutoServer : GameModuleServer
    {
        public override string Name => "OfficialModeFastAuto";

        public override string Description => RoomSet.GetTypeString(RoomType.FastAuto);

        public override string Version => FunGameInfo.FunGame_Version;

        public override string Author => FunGameInfo.FunGame_CopyRight;

        public override string DefaultMap => GameModuleDepend.MapsDepend.Length > 0 ? GameModuleDepend.MapsDepend[0] : "";

        public override GameModuleDepend GameModuleDepend => GameModuleConstant.GameModuleDepend;

        public override Hashtable GamingMessageHandler(string username, GamingType type, Hashtable data)
        {
            Hashtable result = [];
            switch (type)
            {
                case GamingType.Connect:
                    break;
                case GamingType.Disconnect:
                    break;
                case GamingType.Reconnect:
                    break;
                case GamingType.BanCharacter:
                    break;
                case GamingType.PickCharacter:
                    break;
                case GamingType.Random:
                    break;
                case GamingType.Round:
                    break;
                case GamingType.LevelUp:
                    break;
                case GamingType.Move:
                    break;
                case GamingType.Attack:
                    break;
                case GamingType.Skill:
                    break;
                case GamingType.Item:
                    break;
                case GamingType.Magic:
                    break;
                case GamingType.Buy:
                    break;
                case GamingType.SuperSkill:
                    break;
                case GamingType.Pause:
                    break;
                case GamingType.Unpause:
                    break;
                case GamingType.Surrender:
                    break;
                case GamingType.UpdateInfo:
                    break;
                case GamingType.Punish:
                    break;
                case GamingType.None:
                default:
                    break;
            }
            return result;
        }

        protected Room Room = General.HallInstance;
        protected List<User> Users = [];
        protected IServerModel? RoomMaster;
        protected Dictionary<string, IServerModel> All = [];

        public override bool StartServer(string GameModule, Room Room, List<User> Users, IServerModel RoomMasterServerModel, Dictionary<string, IServerModel> ServerModels, params object[] Args)
        {
            // 将参数转为本地属性
            this.Room = Room;
            this.Users = Users;
            RoomMaster = RoomMasterServerModel;
            All = ServerModels;
            // 创建一个线程执行Test()
            TaskUtility.NewTask(TestMode).OnError(Controller.Error);
            return true;
        }

        private async Task TestMode()
        {
            await Task.Delay(20 * 1000);
            Controller.WriteLine("房间 " + Room.Roomid + " 的游戏结束！向所有玩家发送游戏结束通知。");
            foreach (IServerModel s in All.Values)
            {
                if (s != null && s.Socket != null)
                {
                    s.Send(s.Socket, SocketMessageType.EndGame, Room, Users);
                }
            }
        }
    }
}
