
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
            this.BreathButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.panel.SuspendLayout();
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
            this.pBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxPaint);
            this.pBox.Resize += new System.EventHandler(this.pBoxResize);
            // 
            // panel
            // 
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
            this.panel.Size = new System.Drawing.Size(234, 428);
            this.panel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ChangeFigureSize";
            // 
            // changeFigureSize
            // 
            this.changeFigureSize.Location = new System.Drawing.Point(3, 250);
            this.changeFigureSize.Maximum = 50;
            this.changeFigureSize.Name = "changeFigureSize";
            this.changeFigureSize.Size = new System.Drawing.Size(225, 45);
            this.changeFigureSize.TabIndex = 7;
            this.changeFigureSize.Scroll += new System.EventHandler(this.ChangeFigureSize);
            // 
            // FigureSpeedMovement
            // 
            this.FigureSpeedMovement.Location = new System.Drawing.Point(39, 174);
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
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed of the figure";
            // 
            // PointMoveStop
            // 
            this.PointMoveStop.Location = new System.Drawing.Point(121, 118);
            this.PointMoveStop.Name = "PointMoveStop";
            this.PointMoveStop.Size = new System.Drawing.Size(75, 23);
            this.PointMoveStop.TabIndex = 4;
            this.PointMoveStop.Text = "Stop";
            this.PointMoveStop.UseVisualStyleBackColor = true;
            this.PointMoveStop.Click += new System.EventHandler(this.PointMoveStop_Click);
            // 
            // MoveStart
            // 
            this.MoveStart.Location = new System.Drawing.Point(23, 118);
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
            this.label2.Location = new System.Drawing.Point(77, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point move";
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
            this.label.Location = new System.Drawing.Point(53, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 15);
            this.label.TabIndex = 0;
            this.label.Text = "Change trjectory size";
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // BreathButton
            // 
            this.BreathButton.Location = new System.Drawing.Point(22, 302);
            this.BreathButton.Name = "BreathButton";
            this.BreathButton.Size = new System.Drawing.Size(159, 23);
            this.BreathButton.TabIndex = 9;
            this.BreathButton.Text = "Start/Stop breath";
            this.BreathButton.UseVisualStyleBackColor = true;
            this.BreathButton.Click += new System.EventHandler(this.BreathButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.mainFormResize);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
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
    }
}

