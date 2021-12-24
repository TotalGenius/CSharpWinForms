
namespace Laba_1_3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonAdditionalSettings = new System.Windows.Forms.Button();
            this.buttonChooseAnotherFigure = new System.Windows.Forms.Button();
            this.buttonChooseAnotherTrajec = new System.Windows.Forms.Button();
            this.labelFigureName = new System.Windows.Forms.Label();
            this.labelTrajName = new System.Windows.Forms.Label();
            this.backGroundColor = new System.Windows.Forms.Button();
            this.objColor = new System.Windows.Forms.Button();
            this.trajecColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.breathSize = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.breathSpeed = new System.Windows.Forms.TrackBar();
            this.BreathButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.changeFigureSize = new System.Windows.Forms.TrackBar();
            this.FigureSpeedMovement = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PointMoveStop = new System.Windows.Forms.Button();
            this.MoveStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changeTrajecSizeTBar = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.chooseColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breathSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breathSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeFigureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureSpeedMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTrajecSizeTBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(13, 3);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(538, 435);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.BackColorChanged += new System.EventHandler(this.pBox_BackColorChanged);
            this.pBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxPaint);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonAdditionalSettings);
            this.panel.Controls.Add(this.buttonChooseAnotherFigure);
            this.panel.Controls.Add(this.buttonChooseAnotherTrajec);
            this.panel.Controls.Add(this.labelFigureName);
            this.panel.Controls.Add(this.labelTrajName);
            this.panel.Controls.Add(this.backGroundColor);
            this.panel.Controls.Add(this.objColor);
            this.panel.Controls.Add(this.trajecColor);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.breathSize);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.breathSpeed);
            this.panel.Controls.Add(this.BreathButton);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.changeFigureSize);
            this.panel.Controls.Add(this.FigureSpeedMovement);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.PointMoveStop);
            this.panel.Controls.Add(this.MoveStart);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.changeTrajecSizeTBar);
            this.panel.Controls.Add(this.label);
            this.panel.Location = new System.Drawing.Point(560, 9);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(457, 428);
            this.panel.TabIndex = 1;
            // 
            // buttonAdditionalSettings
            // 
            this.buttonAdditionalSettings.Location = new System.Drawing.Point(365, 90);
            this.buttonAdditionalSettings.Name = "buttonAdditionalSettings";
            this.buttonAdditionalSettings.Size = new System.Drawing.Size(87, 43);
            this.buttonAdditionalSettings.TabIndex = 21;
            this.buttonAdditionalSettings.Text = "Доп. настройки";
            this.buttonAdditionalSettings.UseVisualStyleBackColor = true;
            this.buttonAdditionalSettings.Click += new System.EventHandler(this.buttonAdditionalSettings_Click);
            // 
            // buttonChooseAnotherFigure
            // 
            this.buttonChooseAnotherFigure.Location = new System.Drawing.Point(3, 325);
            this.buttonChooseAnotherFigure.Name = "buttonChooseAnotherFigure";
            this.buttonChooseAnotherFigure.Size = new System.Drawing.Size(104, 41);
            this.buttonChooseAnotherFigure.TabIndex = 20;
            this.buttonChooseAnotherFigure.Text = "Выбрать другую фигуру";
            this.buttonChooseAnotherFigure.UseVisualStyleBackColor = true;
            this.buttonChooseAnotherFigure.Click += new System.EventHandler(this.buttonChooseAnotherFigure_Click);
            // 
            // buttonChooseAnotherTrajec
            // 
            this.buttonChooseAnotherTrajec.Location = new System.Drawing.Point(253, 90);
            this.buttonChooseAnotherTrajec.Name = "buttonChooseAnotherTrajec";
            this.buttonChooseAnotherTrajec.Size = new System.Drawing.Size(105, 43);
            this.buttonChooseAnotherTrajec.TabIndex = 19;
            this.buttonChooseAnotherTrajec.Text = "Выбрать другую траекторию";
            this.buttonChooseAnotherTrajec.UseVisualStyleBackColor = true;
            this.buttonChooseAnotherTrajec.Click += new System.EventHandler(this.buttonChooseAnotherTrajec_Click);
            // 
            // labelFigureName
            // 
            this.labelFigureName.AutoSize = true;
            this.labelFigureName.Location = new System.Drawing.Point(206, 156);
            this.labelFigureName.Name = "labelFigureName";
            this.labelFigureName.Size = new System.Drawing.Size(47, 15);
            this.labelFigureName.TabIndex = 18;
            this.labelFigureName.Text = "Фигура";
            // 
            // labelTrajName
            // 
            this.labelTrajName.AutoSize = true;
            this.labelTrajName.Location = new System.Drawing.Point(188, 10);
            this.labelTrajName.Name = "labelTrajName";
            this.labelTrajName.Size = new System.Drawing.Size(70, 15);
            this.labelTrajName.TabIndex = 17;
            this.labelTrajName.Text = "Траектория";
            // 
            // backGroundColor
            // 
            this.backGroundColor.Location = new System.Drawing.Point(130, 90);
            this.backGroundColor.Name = "backGroundColor";
            this.backGroundColor.Size = new System.Drawing.Size(116, 43);
            this.backGroundColor.TabIndex = 16;
            this.backGroundColor.Text = "Изменить цвет фона";
            this.backGroundColor.UseVisualStyleBackColor = true;
            this.backGroundColor.Click += new System.EventHandler(this.backGroundColor_Click);
            // 
            // objColor
            // 
            this.objColor.Location = new System.Drawing.Point(3, 272);
            this.objColor.Name = "objColor";
            this.objColor.Size = new System.Drawing.Size(116, 41);
            this.objColor.TabIndex = 15;
            this.objColor.Text = "Изменить цвет фигуры";
            this.objColor.UseVisualStyleBackColor = true;
            this.objColor.Click += new System.EventHandler(this.objColor_Click);
            // 
            // trajecColor
            // 
            this.trajecColor.Location = new System.Drawing.Point(3, 90);
            this.trajecColor.Name = "trajecColor";
            this.trajecColor.Size = new System.Drawing.Size(116, 45);
            this.trajecColor.TabIndex = 14;
            this.trajecColor.Text = "Изменить цвет траектории";
            this.trajecColor.UseVisualStyleBackColor = true;
            this.trajecColor.Click += new System.EventHandler(this.trajecColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Размер дыхания";
            // 
            // breathSize
            // 
            this.breathSize.Location = new System.Drawing.Point(279, 303);
            this.breathSize.Maximum = 50;
            this.breathSize.Minimum = 15;
            this.breathSize.Name = "breathSize";
            this.breathSize.Size = new System.Drawing.Size(173, 45);
            this.breathSize.TabIndex = 12;
            this.breathSize.Value = 15;
            this.breathSize.Scroll += new System.EventHandler(this.ChangeBreathSize);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Скорость дыхания";
            // 
            // breathSpeed
            // 
            this.breathSpeed.Location = new System.Drawing.Point(294, 380);
            this.breathSpeed.Maximum = 5;
            this.breathSpeed.Minimum = 1;
            this.breathSpeed.Name = "breathSpeed";
            this.breathSpeed.Size = new System.Drawing.Size(158, 45);
            this.breathSpeed.TabIndex = 10;
            this.breathSpeed.Value = 1;
            this.breathSpeed.Scroll += new System.EventHandler(this.ChangeBreathSpeed);
            // 
            // BreathButton
            // 
            this.BreathButton.Location = new System.Drawing.Point(3, 233);
            this.BreathButton.Name = "BreathButton";
            this.BreathButton.Size = new System.Drawing.Size(157, 23);
            this.BreathButton.TabIndex = 9;
            this.BreathButton.Text = "Start/Stop дыхание";
            this.BreathButton.UseVisualStyleBackColor = true;
            this.BreathButton.Click += new System.EventHandler(this.BreathButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Изменить размер фигуры";
            // 
            // changeFigureSize
            // 
            this.changeFigureSize.Location = new System.Drawing.Point(229, 194);
            this.changeFigureSize.Maximum = 50;
            this.changeFigureSize.Name = "changeFigureSize";
            this.changeFigureSize.Size = new System.Drawing.Size(225, 45);
            this.changeFigureSize.TabIndex = 7;
            this.changeFigureSize.Scroll += new System.EventHandler(this.ChangeFigureSize);
            // 
            // FigureSpeedMovement
            // 
            this.FigureSpeedMovement.Location = new System.Drawing.Point(292, 255);
            this.FigureSpeedMovement.Maximum = 5;
            this.FigureSpeedMovement.Minimum = 1;
            this.FigureSpeedMovement.Name = "FigureSpeedMovement";
            this.FigureSpeedMovement.Size = new System.Drawing.Size(142, 45);
            this.FigureSpeedMovement.TabIndex = 6;
            this.FigureSpeedMovement.Value = 2;
            this.FigureSpeedMovement.ValueChanged += new System.EventHandler(this.ChangeFigureSpeed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Скорость движения";
            // 
            // PointMoveStop
            // 
            this.PointMoveStop.Location = new System.Drawing.Point(84, 194);
            this.PointMoveStop.Name = "PointMoveStop";
            this.PointMoveStop.Size = new System.Drawing.Size(75, 23);
            this.PointMoveStop.TabIndex = 4;
            this.PointMoveStop.Text = "Stop";
            this.PointMoveStop.UseVisualStyleBackColor = true;
            this.PointMoveStop.Click += new System.EventHandler(this.PointMoveStop_Click);
            // 
            // MoveStart
            // 
            this.MoveStart.Location = new System.Drawing.Point(3, 194);
            this.MoveStart.Name = "MoveStart";
            this.MoveStart.Size = new System.Drawing.Size(75, 23);
            this.MoveStart.TabIndex = 3;
            this.MoveStart.Text = "Start";
            this.MoveStart.UseVisualStyleBackColor = true;
            this.MoveStart.Click += new System.EventHandler(this.MoveStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Активировать движение";
            // 
            // changeTrajecSizeTBar
            // 
            this.changeTrajecSizeTBar.Location = new System.Drawing.Point(3, 52);
            this.changeTrajecSizeTBar.Maximum = 100;
            this.changeTrajecSizeTBar.Minimum = 1;
            this.changeTrajecSizeTBar.Name = "changeTrajecSizeTBar";
            this.changeTrajecSizeTBar.Size = new System.Drawing.Size(225, 45);
            this.changeTrajecSizeTBar.TabIndex = 1;
            this.changeTrajecSizeTBar.Value = 50;
            this.changeTrajecSizeTBar.Scroll += new System.EventHandler(this.ChangeTrajecSize);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 15);
            this.label.TabIndex = 0;
            this.label.Text = "Поменять размер траектории";
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // chooseColor
            // 
            this.chooseColor.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.mainFormResize);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breathSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breathSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeFigureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureSpeedMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeTrajecSizeTBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TrackBar changeTrajecSizeTBar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button PointMoveStop;
        private System.Windows.Forms.Button MoveStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar FigureSpeedMovement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar changeFigureSize;
        private System.Windows.Forms.Button BreathButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar breathSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar breathSpeed;
        private System.Windows.Forms.Button trajecColor;
        private System.Windows.Forms.ColorDialog chooseColor;
        private System.Windows.Forms.Button objColor;
        private System.Windows.Forms.Button backGroundColor;
        private System.Windows.Forms.Label labelTrajName;
        private System.Windows.Forms.Label labelFigureName;
        private System.Windows.Forms.Button buttonChooseAnotherTrajec;
        private System.Windows.Forms.Button buttonChooseAnotherFigure;
        private System.Windows.Forms.Button buttonAdditionalSettings;
    }
}

