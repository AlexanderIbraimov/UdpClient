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
            this.loadComboBox = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomToModelButton = new System.Windows.Forms.Button();
            this.zoomToScreenButton = new System.Windows.Forms.Button();
            this.twoWheelsButton = new System.Windows.Forms.Button();
            this.leftWheelButton = new System.Windows.Forms.Button();
            this.rightWheelButton = new System.Windows.Forms.Button();
            this.spinLeftButton = new System.Windows.Forms.Button();
            this.spinRightButton = new System.Windows.Forms.Button();
            this.spinLeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.spinRightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBallsToPickNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayAfterEachBallNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBallNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinLeftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRightNumericUpDown)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(113, 27);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(114, 22);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "127.0.0.1";
            this.ipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpTextBoxKeyPress);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ipLabel.Location = new System.Drawing.Point(27, 32);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(75, 17);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "IP address";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.portLabel.Location = new System.Drawing.Point(27, 74);
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
            this.talkingButton.Location = new System.Drawing.Point(3, 3);
            this.talkingButton.Name = "talkingButton";
            this.talkingButton.Size = new System.Drawing.Size(194, 25);
            this.talkingButton.TabIndex = 5;
            this.talkingButton.Text = "Talking";
            this.talkingButton.UseVisualStyleBackColor = true;
            this.talkingButton.Click += new System.EventHandler(this.TalkingButtonClick);
            // 
            // cheerButton
            // 
            this.cheerButton.Enabled = false;
            this.cheerButton.Location = new System.Drawing.Point(3, 65);
            this.cheerButton.Name = "cheerButton";
            this.cheerButton.Size = new System.Drawing.Size(194, 25);
            this.cheerButton.TabIndex = 7;
            this.cheerButton.Text = "Cheer";
            this.cheerButton.UseVisualStyleBackColor = true;
            this.cheerButton.Click += new System.EventHandler(this.CheerButtonClick);
            // 
            // showAvatarButton
            // 
            this.showAvatarButton.Enabled = false;
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
            this.hideAvatarButton.Enabled = false;
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
            this.button5.Location = new System.Drawing.Point(3, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 25);
            this.button5.TabIndex = 10;
            this.button5.Text = "Avatar Position";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AvatarPositionButtonClick);
            // 
            // avatarScaleButton
            // 
            this.avatarScaleButton.Enabled = false;
            this.avatarScaleButton.Location = new System.Drawing.Point(3, 158);
            this.avatarScaleButton.Name = "avatarScaleButton";
            this.avatarScaleButton.Size = new System.Drawing.Size(194, 25);
            this.avatarScaleButton.TabIndex = 13;
            this.avatarScaleButton.Text = "Avatar Scale";
            this.avatarScaleButton.UseVisualStyleBackColor = true;
            this.avatarScaleButton.Click += new System.EventHandler(this.AvatarScaleButtonClick);
            // 
            // numberOfBallsToPickButton
            // 
            this.numberOfBallsToPickButton.Enabled = false;
            this.numberOfBallsToPickButton.Location = new System.Drawing.Point(3, 99);
            this.numberOfBallsToPickButton.Name = "numberOfBallsToPickButton";
            this.numberOfBallsToPickButton.Size = new System.Drawing.Size(191, 42);
            this.numberOfBallsToPickButton.TabIndex = 15;
            this.numberOfBallsToPickButton.Text = "Number of balls to pick";
            this.numberOfBallsToPickButton.UseVisualStyleBackColor = true;
            this.numberOfBallsToPickButton.Click += new System.EventHandler(this.NumberOfBallsToPickButtonClick);
            // 
            // delayAfterEachBallButton
            // 
            this.delayAfterEachBallButton.Enabled = false;
            this.delayAfterEachBallButton.Location = new System.Drawing.Point(3, 147);
            this.delayAfterEachBallButton.Name = "delayAfterEachBallButton";
            this.delayAfterEachBallButton.Size = new System.Drawing.Size(191, 43);
            this.delayAfterEachBallButton.TabIndex = 17;
            this.delayAfterEachBallButton.Text = "Delay after each ball";
            this.delayAfterEachBallButton.UseVisualStyleBackColor = true;
            this.delayAfterEachBallButton.Click += new System.EventHandler(this.DelayAfterEachBallButtonClick);
            // 
            // drawBallButton
            // 
            this.drawBallButton.Enabled = false;
            this.drawBallButton.Location = new System.Drawing.Point(3, 51);
            this.drawBallButton.Name = "drawBallButton";
            this.drawBallButton.Size = new System.Drawing.Size(191, 42);
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
            this.colorBallComboBox.Location = new System.Drawing.Point(98, 3);
            this.colorBallComboBox.Name = "colorBallComboBox";
            this.colorBallComboBox.Size = new System.Drawing.Size(90, 24);
            this.colorBallComboBox.TabIndex = 21;
            this.colorBallComboBox.Text = "black";
            // 
            // newGameButton
            // 
            this.newGameButton.Enabled = false;
            this.newGameButton.Location = new System.Drawing.Point(3, 3);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(191, 42);
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
            this.setBackgroundButton.Size = new System.Drawing.Size(170, 37);
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
            // loadComboBox
            // 
            this.loadComboBox.Enabled = false;
            this.loadComboBox.FormattingEnabled = true;
            this.loadComboBox.Items.AddRange(new object[] {
            "keno",
            "lotto",
            "spinthewheel",
            "video"});
            this.loadComboBox.Location = new System.Drawing.Point(230, 145);
            this.loadComboBox.Name = "loadComboBox";
            this.loadComboBox.Size = new System.Drawing.Size(170, 24);
            this.loadComboBox.TabIndex = 28;
            this.loadComboBox.Text = "keno";
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
            this.clapButton.Location = new System.Drawing.Point(3, 34);
            this.clapButton.Name = "clapButton";
            this.clapButton.Size = new System.Drawing.Size(194, 25);
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
            this.positionXNumericUpDown.Location = new System.Drawing.Point(3, 3);
            this.positionXNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.positionXNumericUpDown.Name = "positionXNumericUpDown";
            this.positionXNumericUpDown.Size = new System.Drawing.Size(91, 22);
            this.positionXNumericUpDown.TabIndex = 31;
            // 
            // positionYNumericUpDown
            // 
            this.positionYNumericUpDown.Enabled = false;
            this.positionYNumericUpDown.Location = new System.Drawing.Point(100, 3);
            this.positionYNumericUpDown.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.positionYNumericUpDown.Name = "positionYNumericUpDown";
            this.positionYNumericUpDown.Size = new System.Drawing.Size(91, 22);
            this.positionYNumericUpDown.TabIndex = 32;
            // 
            // scaleNumericUpDown
            // 
            this.scaleNumericUpDown.Enabled = false;
            this.scaleNumericUpDown.Location = new System.Drawing.Point(3, 189);
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
            this.scaleNumericUpDown.Size = new System.Drawing.Size(94, 22);
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
            this.numberOfBallsToPickNumericUpDown.Location = new System.Drawing.Point(200, 99);
            this.numberOfBallsToPickNumericUpDown.Name = "numberOfBallsToPickNumericUpDown";
            this.numberOfBallsToPickNumericUpDown.Size = new System.Drawing.Size(92, 22);
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
            this.delayAfterEachBallNumericUpDown.Location = new System.Drawing.Point(200, 147);
            this.delayAfterEachBallNumericUpDown.Name = "delayAfterEachBallNumericUpDown";
            this.delayAfterEachBallNumericUpDown.Size = new System.Drawing.Size(92, 22);
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
            this.numberBallNumericUpDown.Location = new System.Drawing.Point(3, 3);
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
            this.numberBallNumericUpDown.Size = new System.Drawing.Size(89, 22);
            this.numberBallNumericUpDown.TabIndex = 36;
            this.numberBallNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // playAudioOnceButton
            // 
            this.playAudioOnceButton.Enabled = false;
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
            this.playAudioLoopButton.Enabled = false;
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
            this.audioOnceComboBox.Enabled = false;
            this.audioOnceComboBox.FormattingEnabled = true;
            this.audioOnceComboBox.Location = new System.Drawing.Point(230, 189);
            this.audioOnceComboBox.Name = "audioOnceComboBox";
            this.audioOnceComboBox.Size = new System.Drawing.Size(170, 24);
            this.audioOnceComboBox.TabIndex = 39;
            this.audioOnceComboBox.Text = "1.mp3";
            // 
            // audioLoopComboBox
            // 
            this.audioLoopComboBox.Enabled = false;
            this.audioLoopComboBox.FormattingEnabled = true;
            this.audioLoopComboBox.Location = new System.Drawing.Point(230, 229);
            this.audioLoopComboBox.Name = "audioLoopComboBox";
            this.audioLoopComboBox.Size = new System.Drawing.Size(170, 24);
            this.audioLoopComboBox.TabIndex = 40;
            this.audioLoopComboBox.Text = "1.mp3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.delayAfterEachBallButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.drawBallButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberOfBallsToPickNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.delayAfterEachBallNumericUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberOfBallsToPickButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newGameButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(553, 268);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 193);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.numberBallNumericUpDown, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.colorBallComboBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 42);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.11604F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.88396F));
            this.tableLayoutPanel3.Controls.Add(this.zoomToModelButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.zoomToScreenButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.twoWheelsButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.leftWheelButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.rightWheelButton, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.spinLeftButton, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.spinRightButton, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.spinLeftNumericUpDown, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.spinRightNumericUpDown, 1, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(556, 268);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.62637F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94506F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(293, 263);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // zoomToModelButton
            // 
            this.zoomToModelButton.Enabled = false;
            this.zoomToModelButton.Location = new System.Drawing.Point(3, 3);
            this.zoomToModelButton.Name = "zoomToModelButton";
            this.zoomToModelButton.Size = new System.Drawing.Size(167, 29);
            this.zoomToModelButton.TabIndex = 0;
            this.zoomToModelButton.Text = "Zoom to model";
            this.zoomToModelButton.UseVisualStyleBackColor = true;
            this.zoomToModelButton.Click += new System.EventHandler(this.ZoomToModelButtonClick);
            // 
            // zoomToScreenButton
            // 
            this.zoomToScreenButton.Enabled = false;
            this.zoomToScreenButton.Location = new System.Drawing.Point(3, 38);
            this.zoomToScreenButton.Name = "zoomToScreenButton";
            this.zoomToScreenButton.Size = new System.Drawing.Size(167, 33);
            this.zoomToScreenButton.TabIndex = 1;
            this.zoomToScreenButton.Text = "Zoom to screen";
            this.zoomToScreenButton.UseVisualStyleBackColor = true;
            this.zoomToScreenButton.Click += new System.EventHandler(this.ZoomToScreenButtonClick);
            // 
            // twoWheelsButton
            // 
            this.twoWheelsButton.Enabled = false;
            this.twoWheelsButton.Location = new System.Drawing.Point(3, 77);
            this.twoWheelsButton.Name = "twoWheelsButton";
            this.twoWheelsButton.Size = new System.Drawing.Size(167, 31);
            this.twoWheelsButton.TabIndex = 2;
            this.twoWheelsButton.Text = "Two wheels";
            this.twoWheelsButton.UseVisualStyleBackColor = true;
            this.twoWheelsButton.Click += new System.EventHandler(this.TwoWheelsButtonClick);
            // 
            // leftWheelButton
            // 
            this.leftWheelButton.Enabled = false;
            this.leftWheelButton.Location = new System.Drawing.Point(3, 114);
            this.leftWheelButton.Name = "leftWheelButton";
            this.leftWheelButton.Size = new System.Drawing.Size(167, 31);
            this.leftWheelButton.TabIndex = 3;
            this.leftWheelButton.Text = "Left wheel";
            this.leftWheelButton.UseVisualStyleBackColor = true;
            this.leftWheelButton.Click += new System.EventHandler(this.LeftWheelButtonClick);
            // 
            // rightWheelButton
            // 
            this.rightWheelButton.Enabled = false;
            this.rightWheelButton.Location = new System.Drawing.Point(3, 151);
            this.rightWheelButton.Name = "rightWheelButton";
            this.rightWheelButton.Size = new System.Drawing.Size(167, 31);
            this.rightWheelButton.TabIndex = 4;
            this.rightWheelButton.Text = "Right wheel";
            this.rightWheelButton.UseVisualStyleBackColor = true;
            this.rightWheelButton.Click += new System.EventHandler(this.RightWheelButtonClick);
            // 
            // spinLeftButton
            // 
            this.spinLeftButton.Enabled = false;
            this.spinLeftButton.Location = new System.Drawing.Point(3, 188);
            this.spinLeftButton.Name = "spinLeftButton";
            this.spinLeftButton.Size = new System.Drawing.Size(167, 31);
            this.spinLeftButton.TabIndex = 5;
            this.spinLeftButton.Text = "Spin left wheel ";
            this.spinLeftButton.UseVisualStyleBackColor = true;
            this.spinLeftButton.Click += new System.EventHandler(this.SpinLeftButtonClick);
            // 
            // spinRightButton
            // 
            this.spinRightButton.Enabled = false;
            this.spinRightButton.Location = new System.Drawing.Point(3, 225);
            this.spinRightButton.Name = "spinRightButton";
            this.spinRightButton.Size = new System.Drawing.Size(167, 35);
            this.spinRightButton.TabIndex = 6;
            this.spinRightButton.Text = "Spin right wheel ";
            this.spinRightButton.UseVisualStyleBackColor = true;
            this.spinRightButton.Click += new System.EventHandler(this.SpinRightButtonClick);
            // 
            // spinLeftNumericUpDown
            // 
            this.spinLeftNumericUpDown.Enabled = false;
            this.spinLeftNumericUpDown.Location = new System.Drawing.Point(184, 188);
            this.spinLeftNumericUpDown.Name = "spinLeftNumericUpDown";
            this.spinLeftNumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.spinLeftNumericUpDown.TabIndex = 7;
            // 
            // spinRightNumericUpDown
            // 
            this.spinRightNumericUpDown.Enabled = false;
            this.spinRightNumericUpDown.Location = new System.Drawing.Point(184, 225);
            this.spinRightNumericUpDown.Name = "spinRightNumericUpDown";
            this.spinRightNumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.spinRightNumericUpDown.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.talkingButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.clapButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cheerButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.button5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.avatarScaleButton, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.scaleNumericUpDown, 0, 6);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(553, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 219);
            this.tableLayoutPanel4.TabIndex = 43;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.positionXNumericUpDown, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.positionYNumericUpDown, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 127);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 25);
            this.tableLayoutPanel5.TabIndex = 34;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(959, 563);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.audioLoopComboBox);
            this.Controls.Add(this.audioOnceComboBox);
            this.Controls.Add(this.playAudioLoopButton);
            this.Controls.Add(this.playAudioOnceButton);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.loadComboBox);
            this.Controls.Add(this.gameModeButton);
            this.Controls.Add(this.hideAvatarButton);
            this.Controls.Add(this.showAvatarButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.backGroundButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.setBackgroundButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBallsToPickNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayAfterEachBallNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBallNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinLeftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRightNumericUpDown)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private ComboBox loadComboBox;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button zoomToModelButton;
        private Button zoomToScreenButton;
        private Button twoWheelsButton;
        private Button leftWheelButton;
        private Button rightWheelButton;
        private Button spinLeftButton;
        private Button spinRightButton;
        private NumericUpDown spinLeftNumericUpDown;
        private NumericUpDown spinRightNumericUpDown;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
    }
}