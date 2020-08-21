using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
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
        private string CurrentMode = "keno";
        public Window()
        {
            InitializeComponent();
            Controls.Remove(tableLayoutPanel3);
            Controls.Remove(tableLayoutPanel4);
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
        private void SaveButtonClick(object sender, EventArgs e)
        {
            var ip = ipTextBox.Text;
            var port = (int)portNumericUpDown.Value;
            if (IPAddress.TryParse(ip, out IPAddress host))
            {
                interaction = new Interaction(ip, port);
                Controls.Add(tableLayoutPanel3);
                Controls.Add(tableLayoutPanel4);
                EnabledElement(Controls);
                if (!hideAvatarButton.Enabled) 
                    Controls.Remove(tableLayoutPanel4);
                if(CurrentMode != "spinthewheel")
                    Controls.Remove(tableLayoutPanel3);
            }
            else
            {
                ipTextBox.Text = "127.0.0.1";
                portNumericUpDown.Value = 3333;
                MessageBox.Show("IP address or host specified incorrectly");
            }
            loadComboBox.Text = CurrentMode;
        }
        private void EnabledElement(Control.ControlCollection cc)
        {
            foreach (var item in cc)
            {
                var control = (Control)item;
                control.Enabled = true;
                if (control.Controls.Count > 0)
                    EnabledElement(control.Controls);
            }
            hideAvatarButton.Enabled = false;
        }
        private void GameModeButtonClick(object sender, EventArgs e)
        {
            SendOrReceiveAnException(Command.GameMode(loadComboBox.Text));
            switch (loadComboBox.Text)
            {
                case "keno":
                    Controls.Remove(tableLayoutPanel3);
                    Controls.Add(tableLayoutPanel1);
                    break;
                case "lotto":
                    Controls.Remove(tableLayoutPanel3);
                    Controls.Add(tableLayoutPanel1);
                    break;
                case "spinthewheel":
                    Controls.Remove(tableLayoutPanel1);
                    Controls.Add(tableLayoutPanel3);
                    break;
                default: break;
            }
            CurrentMode = loadComboBox.Text;
        }
        private void TalkingButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Talking());

        private void NewGameButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.NewGame());

        private void ClapButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Clap());

        private void CheerButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Cheer());

        private void ShowAvatarButtonClick(object sender, EventArgs e)
        {
            SendOrReceiveAnException(Command.ShowAvatar());
            Controls.Add(tableLayoutPanel4);
            showAvatarButton.Enabled = false;
            hideAvatarButton.Enabled = true;
        }

        private void HideAvatarButtonClick(object sender, EventArgs e)
        {
            SendOrReceiveAnException(Command.HideAvatar());
            Controls.Remove(tableLayoutPanel4);
            showAvatarButton.Enabled = true;
            hideAvatarButton.Enabled = false;
        }

        private void AvatarPositionButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.AvatarPosition((int)positionXNumericUpDown.Value, (int)positionYNumericUpDown.Value));

        private void AvatarScaleButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.AvatarScale((int)scaleNumericUpDown.Value));

        private void NumberOfBallsToPickButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.NumberOfBallsToPick((int)numberOfBallsToPickNumericUpDown.Value));

        private void DelayAfterEachBallButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.DelayAfterEachBall((int)delayAfterEachBallNumericUpDown.Value));

        private void DrawBallButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.DrawBall((int)numberBallNumericUpDown.Value, colorBallComboBox.Text));

        private void SetBackGroundButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.SetBackground(dictNameImage[backGroundButton.ImageIndex]));

        private void PlayAudioOnceButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.PlayAudioOnce(audioOnceComboBox.Text));

        private void PlayAudioLoopButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.PlayAudioLoop(audioLoopComboBox.Text));

        private void ZoomToModelButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.ZoomToModel());

        private void ZoomToScreenButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.ZoomToScreen());

        private void TwoWheelsButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Mode(1));

        private void LeftWheelButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Mode(2));

        private void RightWheelButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Mode(3));

        private void SpinLeftButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Spin(1, (int)spinLeftNumericUpDown.Value));

        private void SpinRightButtonClick(object sender, EventArgs e) => SendOrReceiveAnException(Command.Spin(2, (int)spinRightNumericUpDown.Value));
        
        private void BackgroundImageButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (++button.ImageIndex == button.ImageList.Images.Count)
                button.ImageIndex = 0;
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
