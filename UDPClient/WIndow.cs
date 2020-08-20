using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDPClient.Model;
using UDPClient.Properties;

namespace UDPClient
{
    public partial class Window : Form
    {
        Dictionary<int, string> dictNameImage;
        Interaction interaction;
        string ip;
        int port;
        public Window()
        {
            InitializeComponent();
            interaction = new Interaction();
            dictNameImage = new Dictionary<int, string>();
            backgroundImageList.Images.Add(Resources.background1);
            backgroundImageList.Images.Add(Resources.background2);
            backgroundImageList.Images.Add(Resources.background3);
            backgroundImageList.Images.Add(Resources.background4);
            backgroundImageList.Images.Add(Resources.background_keno);
            backgroundImageList.Images.Add(Resources.background_lucky6);
            backGroundButton.ImageIndex = 0;
            dictNameImage.Add(0, "background1.png");
            dictNameImage.Add(1, "background2.png");
            dictNameImage.Add(2, "background3.png");
            dictNameImage.Add(3, "background4.png");
            dictNameImage.Add(4, "background_keno.png");
            dictNameImage.Add(5, "background_lucky6.png");
        }

        private void ConnectButtonClick(object sender, EventArgs e)
        {
            ip = ipTextBox.Text;
            port = int.Parse(portTextBox.Text);
            try
            {
                interaction.Connect(ip, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GameModeButtonClick(object sender, EventArgs e)
        {
            SendOrReceiveAnException(Command.GameMode(gameModeComboBox.Text));
            //КОД смены мода
        }
        private void TalkingButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Talking());
        private void NewGameButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.NewGame());
        private void ClapButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Clap());
        private void CheerButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Cheer());
        private void ShowAvatarButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.ShowAvatar());
        private void HideAvatarButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.HideAvatar());
        private void AvatarPositionButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.AvatarPosition(int.Parse(positionXTextBox.Text), int.Parse(positionYTextBox.Text)));
        private void AvatarScaleButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.AvatarScale(int.Parse(xTextBox.Text)));
        private void NumberOfBallsToPickButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.NumberOfBallsToPick(int.Parse(numberOfBallsToPickTextBox.Text)));
        private void DelayAfterEachBallButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.DelayAfterEachBall(int.Parse(delayAfterEachBallTextBox.Text)));
        private void DrawBallButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.DrawBall(int.Parse(numberBallTextBox.Text), colorBallComboBox.Text));
        private void SetBackGroundButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.SetBackground(dictNameImage[backGroundButton.ImageIndex]));
        private void BackgroundImageButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (++button.ImageIndex == button.ImageList.Images.Count)
                button.ImageIndex = 0;
        }
        private void IsDigitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void IpTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        private void SendOrReceiveAnException(string command)
        {
            try
            {
                interaction.Send(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
