namespace UDPClient
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.talkingButton = new System.Windows.Forms.Button();
            this.clapButton = new System.Windows.Forms.Button();
            this.cheerButton = new System.Windows.Forms.Button();
            this.showAvatarButton = new System.Windows.Forms.Button();
            this.hideAvatarButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.positionXTextBox = new System.Windows.Forms.TextBox();
            this.positionYTextBox = new System.Windows.Forms.TextBox();
            this.avatarScaleButton = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.numberOfBallsToPickButton = new System.Windows.Forms.Button();
            this.numberOfBallsToPickTextBox = new System.Windows.Forms.TextBox();
            this.delayAfterEachBallButton = new System.Windows.Forms.Button();
            this.delayAfterEachBallTextBox = new System.Windows.Forms.TextBox();
            this.drawBallButton = new System.Windows.Forms.Button();
            this.numberBallTextBox = new System.Windows.Forms.TextBox();
            this.colorBallComboBox = new System.Windows.Forms.ComboBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.setBackgroundButton = new System.Windows.Forms.Button();
            this.backgroundImageList = new System.Windows.Forms.ImageList(this.components);
            this.backGroundButton = new System.Windows.Forms.Button();
            this.gameModeComboBox = new System.Windows.Forms.ComboBox();
            this.gameModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(121, 26);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 22);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpTextBoxKeyPress);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(121, 56);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 22);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigitKeyPress);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(30, 31);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(75, 17);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "IP address";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(30, 61);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 17);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(243, 26);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(76, 52);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Сonnect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // talkingButton
            // 
            this.talkingButton.Location = new System.Drawing.Point(397, 26);
            this.talkingButton.Name = "talkingButton";
            this.talkingButton.Size = new System.Drawing.Size(170, 28);
            this.talkingButton.TabIndex = 5;
            this.talkingButton.Text = "Talking";
            this.talkingButton.UseVisualStyleBackColor = true;
            this.talkingButton.Click += new System.EventHandler(this.TalkingButtonClick);
            // 
            // clapButton
            // 
            this.clapButton.Location = new System.Drawing.Point(397, 61);
            this.clapButton.Name = "clapButton";
            this.clapButton.Size = new System.Drawing.Size(170, 28);
            this.clapButton.TabIndex = 6;
            this.clapButton.Text = "Clap";
            this.clapButton.UseVisualStyleBackColor = true;
            this.clapButton.Click += new System.EventHandler(this.ClapButtonClick);
            // 
            // cheerButton
            // 
            this.cheerButton.Location = new System.Drawing.Point(397, 95);
            this.cheerButton.Name = "cheerButton";
            this.cheerButton.Size = new System.Drawing.Size(170, 28);
            this.cheerButton.TabIndex = 7;
            this.cheerButton.Text = "Cheer";
            this.cheerButton.UseVisualStyleBackColor = true;
            this.cheerButton.Click += new System.EventHandler(this.CheerButtonClick);
            // 
            // showAvatarButton
            // 
            this.showAvatarButton.Location = new System.Drawing.Point(397, 129);
            this.showAvatarButton.Name = "showAvatarButton";
            this.showAvatarButton.Size = new System.Drawing.Size(170, 28);
            this.showAvatarButton.TabIndex = 8;
            this.showAvatarButton.Text = "Show Avatar";
            this.showAvatarButton.UseVisualStyleBackColor = true;
            this.showAvatarButton.Click += new System.EventHandler(this.ShowAvatarButtonClick);
            // 
            // hideAvatarButton
            // 
            this.hideAvatarButton.Location = new System.Drawing.Point(397, 163);
            this.hideAvatarButton.Name = "hideAvatarButton";
            this.hideAvatarButton.Size = new System.Drawing.Size(170, 28);
            this.hideAvatarButton.TabIndex = 9;
            this.hideAvatarButton.Text = "Hide Avatar";
            this.hideAvatarButton.UseVisualStyleBackColor = true;
            this.hideAvatarButton.Click += new System.EventHandler(this.HideAvatarButtonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(397, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "Avatar Position";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AvatarPositionButtonClick);
            // 
            // positionXTextBox
            // 
            this.positionXTextBox.Location = new System.Drawing.Point(591, 202);
            this.positionXTextBox.Name = "positionXTextBox";
            this.positionXTextBox.Size = new System.Drawing.Size(63, 22);
            this.positionXTextBox.TabIndex = 11;
            this.positionXTextBox.Text = "1920";
            this.positionXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigitKeyPress);
            // 
            // positionYTextBox
            // 
            this.positionYTextBox.Location = new System.Drawing.Point(666, 202);
            this.positionYTextBox.Name = "positionYTextBox";
            this.positionYTextBox.Size = new System.Drawing.Size(63, 22);
            this.positionYTextBox.TabIndex = 12;
            this.positionYTextBox.Text = "1080";
            this.positionYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigitKeyPress);
            // 
            // avatarScaleButton
            // 
            this.avatarScaleButton.Location = new System.Drawing.Point(397, 230);
            this.avatarScaleButton.Name = "avatarScaleButton";
            this.avatarScaleButton.Size = new System.Drawing.Size(170, 28);
            this.avatarScaleButton.TabIndex = 13;
            this.avatarScaleButton.Text = "Avatar Scale";
            this.avatarScaleButton.UseVisualStyleBackColor = true;
            this.avatarScaleButton.Click += new System.EventHandler(this.AvatarScaleButtonClick);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(591, 236);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(63, 22);
            this.xTextBox.TabIndex = 14;
            this.xTextBox.Text = "5";
            this.xTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigitKeyPress);
            // 
            // numberOfBallsToPickButton
            // 
            this.numberOfBallsToPickButton.Location = new System.Drawing.Point(397, 264);
            this.numberOfBallsToPickButton.Name = "numberOfBallsToPickButton";
            this.numberOfBallsToPickButton.Size = new System.Drawing.Size(170, 28);
            this.numberOfBallsToPickButton.TabIndex = 15;
            this.numberOfBallsToPickButton.Text = "Number of balls to pick";
            this.numberOfBallsToPickButton.UseVisualStyleBackColor = true;
            this.numberOfBallsToPickButton.Click += new System.EventHandler(this.NumberOfBallsToPickButtonClick);
            // 
            // numberOfBallsToPickTextBox
            // 
            this.numberOfBallsToPickTextBox.Location = new System.Drawing.Point(591, 269);
            this.numberOfBallsToPickTextBox.Name = "numberOfBallsToPickTextBox";
            this.numberOfBallsToPickTextBox.Size = new System.Drawing.Size(63, 22);
            this.numberOfBallsToPickTextBox.TabIndex = 16;
            this.numberOfBallsToPickTextBox.Text = "5";
            this.numberOfBallsToPickTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigitKeyPress);
            // 
            // delayAfterEachBallButton
            // 
            this.delayAfterEachBallButton.Location = new System.Drawing.Point(397, 299);
            this.delayAfterEachBallButton.Name = "delayAfterEachBallButton";
            this.delayAfterEachBallButton.Size = new System.Drawing.Size(170, 28);
            this.delayAfterEachBallButton.TabIndex = 17;
            this.delayAfterEachBallButton.Text = "Delay after each ball";
            this.delayAfterEachBallButton.UseVisualStyleBackColor = true;
            this.delayAfterEachBallButton.Click += new System.EventHandler(this.DelayAfterEachBallButtonClick);
            // 
            // delayAfterEachBallTextBox
            // 
            this.delayAfterEachBallTextBox.Location = new System.Drawing.Point(591, 304);
            this.delayAfterEachBallTextBox.Name = "delayAfterEachBallTextBox";
            this.delayAfterEachBallTextBox.Size = new System.Drawing.Size(63, 22);
            this.delayAfterEachBallTextBox.TabIndex = 18;
            this.delayAfterEachBallTextBox.Text = "3";
            this.delayAfterEachBallTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigitKeyPress);
            // 
            // drawBallButton
            // 
            this.drawBallButton.Location = new System.Drawing.Point(397, 334);
            this.drawBallButton.Name = "drawBallButton";
            this.drawBallButton.Size = new System.Drawing.Size(170, 23);
            this.drawBallButton.TabIndex = 19;
            this.drawBallButton.Text = "Draw ball";
            this.drawBallButton.UseVisualStyleBackColor = true;
            this.drawBallButton.Click += new System.EventHandler(this.DrawBallButtonClick);
            // 
            // numberBallTextBox
            // 
            this.numberBallTextBox.Location = new System.Drawing.Point(591, 334);
            this.numberBallTextBox.Name = "numberBallTextBox";
            this.numberBallTextBox.Size = new System.Drawing.Size(63, 22);
            this.numberBallTextBox.TabIndex = 20;
            this.numberBallTextBox.Text = "1";
            this.numberBallTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigitKeyPress);
            // 
            // colorBallComboBox
            // 
            this.colorBallComboBox.FormattingEnabled = true;
            this.colorBallComboBox.Items.AddRange(new object[] {
            "black",
            "blue",
            "brown",
            "green",
            "orange",
            "pink",
            "purple",
            "red",
            "white",
            "yellow"});
            this.colorBallComboBox.Location = new System.Drawing.Point(677, 334);
            this.colorBallComboBox.Name = "colorBallComboBox";
            this.colorBallComboBox.Size = new System.Drawing.Size(121, 24);
            this.colorBallComboBox.TabIndex = 21;
            this.colorBallComboBox.Text = "black";
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(397, 363);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(170, 27);
            this.newGameButton.TabIndex = 22;
            this.newGameButton.Text = "New game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButtonClick);
            // 
            // setBackgroundButton
            // 
            this.setBackgroundButton.Location = new System.Drawing.Point(397, 397);
            this.setBackgroundButton.Name = "setBackgroundButton";
            this.setBackgroundButton.Size = new System.Drawing.Size(170, 78);
            this.setBackgroundButton.TabIndex = 23;
            this.setBackgroundButton.Text = "Set background";
            this.setBackgroundButton.UseVisualStyleBackColor = true;
            this.setBackgroundButton.Click += new System.EventHandler(this.SetBackGroundButtonClick);
            // 
            // backgroundImageList
            // 
            this.backgroundImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.backgroundImageList.ImageSize = new System.Drawing.Size(207, 78);
            this.backgroundImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // backGroundButton
            // 
            this.backGroundButton.ImageList = this.backgroundImageList;
            this.backGroundButton.Location = new System.Drawing.Point(591, 397);
            this.backGroundButton.Name = "backGroundButton";
            this.backGroundButton.Size = new System.Drawing.Size(207, 78);
            this.backGroundButton.TabIndex = 27;
            this.backGroundButton.UseVisualStyleBackColor = true;
            this.backGroundButton.Click += new System.EventHandler(this.BackgroundImageButton);
            // 
            // gameModeComboBox
            // 
            this.gameModeComboBox.FormattingEnabled = true;
            this.gameModeComboBox.Items.AddRange(new object[] {
            "keno",
            "lotto",
            "spinthewheel",
            "video"});
            this.gameModeComboBox.Location = new System.Drawing.Point(33, 115);
            this.gameModeComboBox.Name = "gameModeComboBox";
            this.gameModeComboBox.Size = new System.Drawing.Size(188, 24);
            this.gameModeComboBox.TabIndex = 28;
            this.gameModeComboBox.Text = "keno";
            // 
            // gameModeButton
            // 
            this.gameModeButton.Location = new System.Drawing.Point(33, 167);
            this.gameModeButton.Name = "gameModeButton";
            this.gameModeButton.Size = new System.Drawing.Size(188, 57);
            this.gameModeButton.TabIndex = 29;
            this.gameModeButton.Text = "Load ";
            this.gameModeButton.UseVisualStyleBackColor = true;
            this.gameModeButton.Click += new System.EventHandler(this.GameModeButtonClick);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.gameModeButton);
            this.Controls.Add(this.gameModeComboBox);
            this.Controls.Add(this.backGroundButton);
            this.Controls.Add(this.setBackgroundButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.colorBallComboBox);
            this.Controls.Add(this.numberBallTextBox);
            this.Controls.Add(this.drawBallButton);
            this.Controls.Add(this.delayAfterEachBallTextBox);
            this.Controls.Add(this.delayAfterEachBallButton);
            this.Controls.Add(this.numberOfBallsToPickTextBox);
            this.Controls.Add(this.numberOfBallsToPickButton);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.avatarScaleButton);
            this.Controls.Add(this.positionYTextBox);
            this.Controls.Add(this.positionXTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.hideAvatarButton);
            this.Controls.Add(this.showAvatarButton);
            this.Controls.Add(this.cheerButton);
            this.Controls.Add(this.clapButton);
            this.Controls.Add(this.talkingButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Window";
            this.Text = "WIndow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button talkingButton;
        private System.Windows.Forms.Button clapButton;
        private System.Windows.Forms.Button cheerButton;
        private System.Windows.Forms.Button showAvatarButton;
        private System.Windows.Forms.Button hideAvatarButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox positionXTextBox;
        private System.Windows.Forms.TextBox positionYTextBox;
        private System.Windows.Forms.Button avatarScaleButton;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Button numberOfBallsToPickButton;
        private System.Windows.Forms.TextBox numberOfBallsToPickTextBox;
        private System.Windows.Forms.Button delayAfterEachBallButton;
        private System.Windows.Forms.TextBox delayAfterEachBallTextBox;
        private System.Windows.Forms.Button drawBallButton;
        private System.Windows.Forms.TextBox numberBallTextBox;
        private System.Windows.Forms.ComboBox colorBallComboBox;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button setBackgroundButton;
        private System.Windows.Forms.ImageList backgroundImageList;
        private System.Windows.Forms.Button backGroundButton;
        private System.Windows.Forms.ComboBox gameModeComboBox;
        private System.Windows.Forms.Button gameModeButton;
    }
}