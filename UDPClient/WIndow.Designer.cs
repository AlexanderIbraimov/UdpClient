using System.Windows.Forms;

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
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.talkingButton = new System.Windows.Forms.Button();
            this.cheerButton = new System.Windows.Forms.Button();
            this.showAvatarButton = new System.Windows.Forms.Button();
            this.hideAvatarButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.avatarScaleButton = new System.Windows.Forms.Button();
            this.numberOfBallsToPickButton = new System.Windows.Forms.Button();
            this.delayAfterEachBallButton = new System.Windows.Forms.Button();
            this.drawBallButton = new System.Windows.Forms.Button();
            this.colorBallComboBox = new System.Windows.Forms.ComboBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.setBackgroundButton = new System.Windows.Forms.Button();
            this.backgroundImageList = new System.Windows.Forms.ImageList(this.components);
            this.backGroundButton = new System.Windows.Forms.Button();
            this.gameModeComboBox = new System.Windows.Forms.ComboBox();
            this.gameModeButton = new System.Windows.Forms.Button();
            this.clapButton = new System.Windows.Forms.Button();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.positionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.positionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfBallsToPickNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.delayAfterEachBallNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberBallNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playAudioOnceButton = new System.Windows.Forms.Button();
            this.playAudioLoopButton = new System.Windows.Forms.Button();
            this.audioOnceComboBox = new System.Windows.Forms.ComboBox();
            this.audioLoopComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBallsToPickNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayAfterEachBallNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBallNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(113, 22);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(114, 22);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "127.0.0.1";
            this.ipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpTextBoxKeyPress);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(18, 27);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(75, 17);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "IP address";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(27, 75);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 17);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(242, 63);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // talkingButton
            // 
            this.talkingButton.Enabled = false;
            this.talkingButton.Location = new System.Drawing.Point(556, 12);
            this.talkingButton.Name = "talkingButton";
            this.talkingButton.Size = new System.Drawing.Size(170, 26);
            this.talkingButton.TabIndex = 5;
            this.talkingButton.Text = "Talking";
            this.talkingButton.UseVisualStyleBackColor = true;
            this.talkingButton.Click += new System.EventHandler(this.TalkingButtonClick);
            // 
            // cheerButton
            // 
            this.cheerButton.Enabled = false;
            this.cheerButton.Location = new System.Drawing.Point(556, 78);
            this.cheerButton.Name = "cheerButton";
            this.cheerButton.Size = new System.Drawing.Size(170, 28);
            this.cheerButton.TabIndex = 7;
            this.cheerButton.Text = "Cheer";
            this.cheerButton.UseVisualStyleBackColor = true;
            this.cheerButton.Click += new System.EventHandler(this.CheerButtonClick);
            // 
            // showAvatarButton
            // 
            this.showAvatarButton.Location = new System.Drawing.Point(374, 21);
            this.showAvatarButton.Name = "showAvatarButton";
            this.showAvatarButton.Size = new System.Drawing.Size(156, 28);
            this.showAvatarButton.TabIndex = 8;
            this.showAvatarButton.Text = "Show Avatar";
            this.showAvatarButton.UseVisualStyleBackColor = true;
            this.showAvatarButton.Click += new System.EventHandler(this.ShowAvatarButtonClick);
            // 
            // hideAvatarButton
            // 
            this.hideAvatarButton.Location = new System.Drawing.Point(374, 69);
            this.hideAvatarButton.Name = "hideAvatarButton";
            this.hideAvatarButton.Size = new System.Drawing.Size(156, 28);
            this.hideAvatarButton.TabIndex = 9;
            this.hideAvatarButton.Text = "Hide Avatar";
            this.hideAvatarButton.UseVisualStyleBackColor = true;
            this.hideAvatarButton.Click += new System.EventHandler(this.HideAvatarButtonClick);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(556, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "Avatar Position";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AvatarPositionButtonClick);
            // 
            // avatarScaleButton
            // 
            this.avatarScaleButton.Enabled = false;
            this.avatarScaleButton.Location = new System.Drawing.Point(556, 175);
            this.avatarScaleButton.Name = "avatarScaleButton";
            this.avatarScaleButton.Size = new System.Drawing.Size(170, 28);
            this.avatarScaleButton.TabIndex = 13;
            this.avatarScaleButton.Text = "Avatar Scale";
            this.avatarScaleButton.UseVisualStyleBackColor = true;
            this.avatarScaleButton.Click += new System.EventHandler(this.AvatarScaleButtonClick);
            // 
            // numberOfBallsToPickButton
            // 
            this.numberOfBallsToPickButton.Enabled = false;
            this.numberOfBallsToPickButton.Location = new System.Drawing.Point(556, 374);
            this.numberOfBallsToPickButton.Name = "numberOfBallsToPickButton";
            this.numberOfBallsToPickButton.Size = new System.Drawing.Size(192, 28);
            this.numberOfBallsToPickButton.TabIndex = 15;
            this.numberOfBallsToPickButton.Text = "Number of balls to pick";
            this.numberOfBallsToPickButton.UseVisualStyleBackColor = true;
            this.numberOfBallsToPickButton.Click += new System.EventHandler(this.NumberOfBallsToPickButtonClick);
            // 
            // delayAfterEachBallButton
            // 
            this.delayAfterEachBallButton.Enabled = false;
            this.delayAfterEachBallButton.Location = new System.Drawing.Point(556, 414);
            this.delayAfterEachBallButton.Name = "delayAfterEachBallButton";
            this.delayAfterEachBallButton.Size = new System.Drawing.Size(192, 28);
            this.delayAfterEachBallButton.TabIndex = 17;
            this.delayAfterEachBallButton.Text = "Delay after each ball";
            this.delayAfterEachBallButton.UseVisualStyleBackColor = true;
            this.delayAfterEachBallButton.Click += new System.EventHandler(this.DelayAfterEachBallButtonClick);
            // 
            // drawBallButton
            // 
            this.drawBallButton.Enabled = false;
            this.drawBallButton.Location = new System.Drawing.Point(556, 318);
            this.drawBallButton.Name = "drawBallButton";
            this.drawBallButton.Size = new System.Drawing.Size(100, 38);
            this.drawBallButton.TabIndex = 19;
            this.drawBallButton.Text = "Draw ball";
            this.drawBallButton.UseVisualStyleBackColor = true;
            this.drawBallButton.Click += new System.EventHandler(this.DrawBallButtonClick);
            // 
            // colorBallComboBox
            // 
            this.colorBallComboBox.Enabled = false;
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
            this.colorBallComboBox.Location = new System.Drawing.Point(771, 318);
            this.colorBallComboBox.Name = "colorBallComboBox";
            this.colorBallComboBox.Size = new System.Drawing.Size(106, 24);
            this.colorBallComboBox.TabIndex = 21;
            this.colorBallComboBox.Text = "black";
            // 
            // newGameButton
            // 
            this.newGameButton.Enabled = false;
            this.newGameButton.Location = new System.Drawing.Point(556, 268);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(100, 38);
            this.newGameButton.TabIndex = 22;
            this.newGameButton.Text = "New game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButtonClick);
            // 
            // setBackgroundButton
            // 
            this.setBackgroundButton.Enabled = false;
            this.setBackgroundButton.Location = new System.Drawing.Point(30, 268);
            this.setBackgroundButton.Name = "setBackgroundButton";
            this.setBackgroundButton.Size = new System.Drawing.Size(170, 32);
            this.setBackgroundButton.TabIndex = 23;
            this.setBackgroundButton.Text = "Set background";
            this.setBackgroundButton.UseVisualStyleBackColor = true;
            this.setBackgroundButton.Click += new System.EventHandler(this.SetBackGroundButtonClick);
            // 
            // backgroundImageList
            // 
            this.backgroundImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.backgroundImageList.ImageSize = new System.Drawing.Size(138, 100);
            this.backgroundImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // backGroundButton
            // 
            this.backGroundButton.Enabled = false;
            this.backGroundButton.ImageList = this.backgroundImageList;
            this.backGroundButton.Location = new System.Drawing.Point(230, 268);
            this.backGroundButton.Name = "backGroundButton";
            this.backGroundButton.Size = new System.Drawing.Size(170, 125);
            this.backGroundButton.TabIndex = 27;
            this.backGroundButton.UseVisualStyleBackColor = true;
            this.backGroundButton.Click += new System.EventHandler(this.BackgroundImageButton);
            // 
            // gameModeComboBox
            // 
            this.gameModeComboBox.Enabled = false;
            this.gameModeComboBox.FormattingEnabled = true;
            this.gameModeComboBox.Items.AddRange(new object[] {
            "keno",
            "lotto",
            "spinthewheel",
            "video"});
            this.gameModeComboBox.Location = new System.Drawing.Point(230, 145);
            this.gameModeComboBox.Name = "gameModeComboBox";
            this.gameModeComboBox.Size = new System.Drawing.Size(170, 24);
            this.gameModeComboBox.TabIndex = 28;
            this.gameModeComboBox.Text = "keno";
            // 
            // gameModeButton
            // 
            this.gameModeButton.Enabled = false;
            this.gameModeButton.Location = new System.Drawing.Point(30, 145);
            this.gameModeButton.Name = "gameModeButton";
            this.gameModeButton.Size = new System.Drawing.Size(170, 38);
            this.gameModeButton.TabIndex = 29;
            this.gameModeButton.Text = "Load ";
            this.gameModeButton.UseVisualStyleBackColor = true;
            this.gameModeButton.Click += new System.EventHandler(this.GameModeButtonClick);
            // 
            // clapButton
            // 
            this.clapButton.Enabled = false;
            this.clapButton.Location = new System.Drawing.Point(556, 44);
            this.clapButton.Name = "clapButton";
            this.clapButton.Size = new System.Drawing.Size(170, 28);
            this.clapButton.TabIndex = 6;
            this.clapButton.Text = "Clap";
            this.clapButton.UseVisualStyleBackColor = true;
            this.clapButton.Click += new System.EventHandler(this.ClapButtonClick);
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(113, 67);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(114, 22);
            this.portNumericUpDown.TabIndex = 30;
            this.portNumericUpDown.Value = new decimal(new int[] {
            3333,
            0,
            0,
            0});
            // 
            // positionXNumericUpDown
            // 
            this.positionXNumericUpDown.Enabled = false;
            this.positionXNumericUpDown.Location = new System.Drawing.Point(556, 147);
            this.positionXNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.positionXNumericUpDown.Name = "positionXNumericUpDown";
            this.positionXNumericUpDown.Size = new System.Drawing.Size(71, 22);
            this.positionXNumericUpDown.TabIndex = 31;
            // 
            // positionYNumericUpDown
            // 
            this.positionYNumericUpDown.Enabled = false;
            this.positionYNumericUpDown.Location = new System.Drawing.Point(644, 147);
            this.positionYNumericUpDown.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.positionYNumericUpDown.Name = "positionYNumericUpDown";
            this.positionYNumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.positionYNumericUpDown.TabIndex = 32;
            // 
            // scaleNumericUpDown
            // 
            this.scaleNumericUpDown.Enabled = false;
            this.scaleNumericUpDown.Location = new System.Drawing.Point(556, 209);
            this.scaleNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scaleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleNumericUpDown.Name = "scaleNumericUpDown";
            this.scaleNumericUpDown.Size = new System.Drawing.Size(170, 22);
            this.scaleNumericUpDown.TabIndex = 33;
            this.scaleNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numberOfBallsToPickNumericUpDown
            // 
            this.numberOfBallsToPickNumericUpDown.Enabled = false;
            this.numberOfBallsToPickNumericUpDown.Location = new System.Drawing.Point(771, 374);
            this.numberOfBallsToPickNumericUpDown.Name = "numberOfBallsToPickNumericUpDown";
            this.numberOfBallsToPickNumericUpDown.Size = new System.Drawing.Size(106, 22);
            this.numberOfBallsToPickNumericUpDown.TabIndex = 34;
            this.numberOfBallsToPickNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // delayAfterEachBallNumericUpDown
            // 
            this.delayAfterEachBallNumericUpDown.Enabled = false;
            this.delayAfterEachBallNumericUpDown.Location = new System.Drawing.Point(771, 414);
            this.delayAfterEachBallNumericUpDown.Name = "delayAfterEachBallNumericUpDown";
            this.delayAfterEachBallNumericUpDown.Size = new System.Drawing.Size(106, 22);
            this.delayAfterEachBallNumericUpDown.TabIndex = 35;
            this.delayAfterEachBallNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numberBallNumericUpDown
            // 
            this.numberBallNumericUpDown.Enabled = false;
            this.numberBallNumericUpDown.Location = new System.Drawing.Point(669, 318);
            this.numberBallNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberBallNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBallNumericUpDown.Name = "numberBallNumericUpDown";
            this.numberBallNumericUpDown.Size = new System.Drawing.Size(79, 22);
            this.numberBallNumericUpDown.TabIndex = 36;
            this.numberBallNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // playAudioOnceButton
            // 
            this.playAudioOnceButton.Location = new System.Drawing.Point(30, 189);
            this.playAudioOnceButton.Name = "playAudioOnceButton";
            this.playAudioOnceButton.Size = new System.Drawing.Size(170, 34);
            this.playAudioOnceButton.TabIndex = 37;
            this.playAudioOnceButton.Text = "Play audio once";
            this.playAudioOnceButton.UseVisualStyleBackColor = true;
            this.playAudioOnceButton.Click += new System.EventHandler(this.PlayAudioOnceButtonClick);
            // 
            // playAudioLoopButton
            // 
            this.playAudioLoopButton.Location = new System.Drawing.Point(30, 229);
            this.playAudioLoopButton.Name = "playAudioLoopButton";
            this.playAudioLoopButton.Size = new System.Drawing.Size(170, 33);
            this.playAudioLoopButton.TabIndex = 38;
            this.playAudioLoopButton.Text = "Play audio loop";
            this.playAudioLoopButton.UseVisualStyleBackColor = true;
            this.playAudioLoopButton.Click += new System.EventHandler(this.PlayAudioLoopButtonClick);
            // 
            // audioOnceComboBox
            // 
            this.audioOnceComboBox.FormattingEnabled = true;
            this.audioOnceComboBox.Location = new System.Drawing.Point(230, 189);
            this.audioOnceComboBox.Name = "audioOnceComboBox";
            this.audioOnceComboBox.Size = new System.Drawing.Size(170, 24);
            this.audioOnceComboBox.TabIndex = 39;
            this.audioOnceComboBox.Text = "1.mp3";
            // 
            // audioLoopComboBox
            // 
            this.audioLoopComboBox.FormattingEnabled = true;
            this.audioLoopComboBox.Location = new System.Drawing.Point(230, 229);
            this.audioLoopComboBox.Name = "audioLoopComboBox";
            this.audioLoopComboBox.Size = new System.Drawing.Size(170, 24);
            this.audioLoopComboBox.TabIndex = 40;
            this.audioLoopComboBox.Text = "1.mp3";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(962, 517);
            this.Controls.Add(this.audioLoopComboBox);
            this.Controls.Add(this.audioOnceComboBox);
            this.Controls.Add(this.playAudioLoopButton);
            this.Controls.Add(this.playAudioOnceButton);
            this.Controls.Add(this.numberBallNumericUpDown);
            this.Controls.Add(this.delayAfterEachBallNumericUpDown);
            this.Controls.Add(this.numberOfBallsToPickNumericUpDown);
            this.Controls.Add(this.scaleNumericUpDown);
            this.Controls.Add(this.positionYNumericUpDown);
            this.Controls.Add(this.positionXNumericUpDown);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.drawBallButton);
            this.Controls.Add(this.colorBallComboBox);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameModeComboBox);
            this.Controls.Add(this.gameModeButton);
            this.Controls.Add(this.hideAvatarButton);
            this.Controls.Add(this.showAvatarButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.backGroundButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.setBackgroundButton);
            this.Controls.Add(this.delayAfterEachBallButton);
            this.Controls.Add(this.numberOfBallsToPickButton);
            this.Controls.Add(this.avatarScaleButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cheerButton);
            this.Controls.Add(this.clapButton);
            this.Controls.Add(this.talkingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "WIndow";
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBallsToPickNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayAfterEachBallNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBallNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ipTextBox;
        private Label ipLabel;
        private Label portLabel;
        private Button saveButton;
        private Button talkingButton;
        private Button cheerButton;
        private Button showAvatarButton;
        private Button hideAvatarButton;
        private Button button5;
        private Button avatarScaleButton;
        private Button numberOfBallsToPickButton;
        private Button delayAfterEachBallButton;
        private Button drawBallButton;
        private ComboBox colorBallComboBox;
        private Button newGameButton;
        private Button setBackgroundButton;
        private ImageList backgroundImageList;
        private Button backGroundButton;
        private ComboBox gameModeComboBox;
        private Button gameModeButton;
        private Button clapButton;
        private NumericUpDown portNumericUpDown;
        private NumericUpDown positionXNumericUpDown;
        private NumericUpDown positionYNumericUpDown;
        private NumericUpDown scaleNumericUpDown;
        private NumericUpDown numberOfBallsToPickNumericUpDown;
        private NumericUpDown delayAfterEachBallNumericUpDown;
        private NumericUpDown numberBallNumericUpDown;
        private Button playAudioOnceButton;
        private Button playAudioLoopButton;
        private ComboBox audioOnceComboBox;
        private ComboBox audioLoopComboBox;
    }
}