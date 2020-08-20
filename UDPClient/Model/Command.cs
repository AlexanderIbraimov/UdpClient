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
        //
        public static string ZoomToModel() => "ZoomToModel";

        public static string ZoomToScreen() => "ZoomToScreen";

        public static string Mode(int n) => $"Mode{n}";

        public static string Spin(int n, int result) => $"Mode{n}:{result}";
        //
        public static string GameMode(string mode) => $"GameMode:{mode}";
    }
}
/*
Talking	Trigger Avatar talking animation
Clap	Trigger Avatar clapping animation
Cheer	Trigger Avatar cheering animation
ShowAvatar	Show 3D Avatar
HideAvatar	Hide 3D Avatar
AvatarPosition:x,y	Bottom Left(0,0) Top Right(1920,1080)
AvatarScale:x	Default is 5 (1-10)
AvatarScale:x	Default is 5

ZoomToModel	Zoom to Model/Avatar
ZoomToScreen	Zoom out to see whole screen
Mode1	Two Wheels
Mode2	Left Wheel
Mode3	Right Wheel
Spin1:2	Spin left wheel to result : 2
Ensure that the result is on the wheel first.
To hit star “Spin1:x”
Spin2:2	Spin right wheel to result : 2
Ensure that the result is on the wheel first.
To hit star “Spin2:x”

SetBackground:background1.png	Image size : 1920x1080Format png, jpgImages must be inside stream assets before
PlayAudioOnce:1.mp3	Play 1.mp3 once
PlayAudioLoop:1.mp3	Play 1.mp3 on loop

Universal command for any game mode
Command	Description
Lotto	Load lotto
Keno	Load Keno
SpinTheWheel	Load Spin the wheel
VideoPresentor	Load video background


GameMode:video
GameMode:keno
GameMode:lotto
GameMode:spinthewheel

 */