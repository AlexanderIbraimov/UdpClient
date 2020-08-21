using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPClient.Model
{
    public static class Command
    {
        public static string Talking() => "Talking";

        public static string Clap() => "Clap";

        public static string Cheer() => "Cheer";

        public static string ShowAvatar() => "ShowAvatar";

        public static string HideAvatar() => "HideAvatar";

        public static string AvatarPosition(int x, int y) => $"AvatarPosition:{x},{y}";

        public static string AvatarScale(int x) => $"AvatarScale:{x}";

        public static string NumberOfBallsToPick(int number) => $"NumberOfBallsToPick:{number}";

        public static string DelayAfterEachBall(int number) => $"delayAfterEachBall:{number}";

        public static string DrawBall(int number, string color) => $"DrawBall:{number}:{color}";

        public static string NewGame() => "NewGame";

        public static string SetBackground(string imageName) => $"SetBackground:{imageName}";

        public static string PlayAudioOnce(string audioName) => $"PlayAudioOnce:{audioName}";

        public static string PlayAudioLoop(string audioName) => $"PlayAudioLoop:{audioName}";
        
        public static string ZoomToModel() => "ZoomToModel";

        public static string ZoomToScreen() => "ZoomToScreen";

        public static string Mode(int n) => $"Mode{n}";

        public static string Spin(int n, int result) => $"Mode{n}:{result}";
        
        public static string GameMode(string mode) => $"GameMode:{mode}";
    }
}