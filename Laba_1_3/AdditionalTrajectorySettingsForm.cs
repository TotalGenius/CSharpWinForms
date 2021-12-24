using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class AdditionalTrajectorySettingsForm : Form
    {
        public AdditionalTrajectorySettingsForm(Trajectory trajectory)
        {
            this.trajectory = trajectory;
            InitializeComponent();
        }
        private Trajectory trajectory;
        private Label labelChangeRange;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelDescription;
        private Label labelFrom;
        private Label labelTo;
        private Label labelChangeCoorDesc;
        private TextBox textBox3;
        private Label labelChoosePoint;
        private Label labelCoordinats;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label labelX;
        private Label labelY;
        private Button buttonAdditionalSettingsOk;
        private Button buttonAdditionalSettingsCancel;
        private Panel panel1;
        private RadioButton radioButtonFrom_7Pi4;
        private RadioButton radioButtonFrom_3Pi2;
        private RadioButton radioButtonFrom_5Pi4;
        private RadioButton radioButtonFrom_Pi;
        private RadioButton radioButtonFrom_3Pi4;
        private RadioButton radioButtonFrom_Pi2;
        private RadioButton radioButtonFrom_Pi4;
        private RadioButton radioButtonFrom_0;
        private Panel panel2;
        private RadioButton radioButtonTo_2Pi;
        private RadioButton radioButtonTo_7Pi4;
        private RadioButton radioButtonTo_3Pi2;
        private RadioButton radioButtonTo_5Pi4;
        private RadioButton radioButtonTo_Pi;
        private RadioButton radioButtonTo_3Pi4;
        private RadioButton radioButtonTo_Pi2;
        private RadioButton radioButtonTo_Pi4;
        private Label labelChangeCoordinates;

        private void InitializeComponent()
        {
            this.labelChangeRange = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelChangeCoordinates = new System.Windows.Forms.Label();
            this.labelChangeCoorDesc = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelChoosePoint = new System.Windows.Forms.Label();
            this.labelCoordinats = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonAdditionalSettingsOk = new System.Windows.Forms.Button();
            this.buttonAdditionalSettingsCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonFrom_7Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonFrom_3Pi2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFrom_5Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonFrom_Pi = new System.Windows.Forms.RadioButton();
            this.radioButtonFrom_3Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonFrom_Pi2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFrom_Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonFrom_0 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonTo_7Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTo_3Pi2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTo_5Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTo_Pi = new System.Windows.Forms.RadioButton();
            this.radioButtonTo_3Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTo_Pi2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTo_Pi4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTo_2Pi = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChangeRange
            // 
            this.labelChangeRange.AutoSize = true;
            this.labelChangeRange.Location = new System.Drawing.Point(12, 9);
            this.labelChangeRange.Name = "labelChangeRange";
            this.labelChangeRange.Size = new System.Drawing.Size(192, 15);
            this.labelChangeRange.TabIndex = 0;
            this.labelChangeRange.Text = "Изменить диапазон отображения";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 23);
            this.textBox2.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 24);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(134, 30);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Допустимые значения \r\n(0-360)";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 57);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 15);
            this.labelFrom.TabIndex = 4;
            this.labelFrom.Text = "from";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(79, 57);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(18, 15);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "to";
            // 
            // labelChangeCoordinates
            // 
            this.labelChangeCoordinates.AutoSize = true;
            this.labelChangeCoordinates.Location = new System.Drawing.Point(213, 9);
            this.labelChangeCoordinates.Name = "labelChangeCoordinates";
            this.labelChangeCoordinates.Size = new System.Drawing.Size(167, 15);
            this.labelChangeCoordinates.TabIndex = 6;
            this.labelChangeCoordinates.Text = "Поменять координаты точки";
            // 
            // labelChangeCoorDesc
            // 
            this.labelChangeCoorDesc.AutoSize = true;
            this.labelChangeCoorDesc.Location = new System.Drawing.Point(227, 24);
            this.labelChangeCoorDesc.Name = "labelChangeCoorDesc";
            this.labelChangeCoorDesc.Size = new System.Drawing.Size(147, 60);
            this.labelChangeCoorDesc.TabIndex = 7;
            this.labelChangeCoorDesc.Text = "Траетория состоит из \r\n25 точек. Выберите одну\r\nи укажите ее координаты\r\n(x,y)\r\n";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 23);
            this.textBox3.TabIndex = 8;
            // 
            // labelChoosePoint
            // 
            this.labelChoosePoint.AutoSize = true;
            this.labelChoosePoint.Location = new System.Drawing.Point(247, 98);
            this.labelChoosePoint.Name = "labelChoosePoint";
            this.labelChoosePoint.Size = new System.Drawing.Size(64, 45);
            this.labelChoosePoint.TabIndex = 9;
            this.labelChoosePoint.Text = "Выберите \r\nточку \r\n(1-25)";
            // 
            // labelCoordinats
            // 
            this.labelCoordinats.AutoSize = true;
            this.labelCoordinats.Location = new System.Drawing.Point(247, 160);
            this.labelCoordinats.Name = "labelCoordinats";
            this.labelCoordinats.Size = new System.Drawing.Size(88, 30);
            this.labelCoordinats.TabIndex = 10;
            this.labelCoordinats.Text = "Введите новые\r\nкоординаты";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(247, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(33, 23);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(324, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(36, 23);
            this.textBox5.TabIndex = 12;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(247, 201);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 15);
            this.labelX.TabIndex = 13;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(324, 201);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 15);
            this.labelY.TabIndex = 14;
            this.labelY.Text = "Y";
            // 
            // buttonAdditionalSettingsOk
            // 
            this.buttonAdditionalSettingsOk.Location = new System.Drawing.Point(261, 283);
            this.buttonAdditionalSettingsOk.Name = "buttonAdditionalSettingsOk";
            this.buttonAdditionalSettingsOk.Size = new System.Drawing.Size(44, 23);
            this.buttonAdditionalSettingsOk.TabIndex = 15;
            this.buttonAdditionalSettingsOk.Text = "Ok";
            this.buttonAdditionalSettingsOk.UseVisualStyleBackColor = true;
            this.buttonAdditionalSettingsOk.Click += new System.EventHandler(this.buttonAdditionalSettingsOk_Click);
            // 
            // buttonAdditionalSettingsCancel
            // 
            this.buttonAdditionalSettingsCancel.Location = new System.Drawing.Point(316, 283);
            this.buttonAdditionalSettingsCancel.Name = "buttonAdditionalSettingsCancel";
            this.buttonAdditionalSettingsCancel.Size = new System.Drawing.Size(64, 23);
            this.buttonAdditionalSettingsCancel.TabIndex = 16;
            this.buttonAdditionalSettingsCancel.Text = "Cancel";
            this.buttonAdditionalSettingsCancel.UseVisualStyleBackColor = true;
            this.buttonAdditionalSettingsCancel.Click += new System.EventHandler(this.buttonAdditionalSettingsCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonFrom_7Pi4);
            this.panel1.Controls.Add(this.radioButtonFrom_3Pi2);
            this.panel1.Controls.Add(this.radioButtonFrom_5Pi4);
            this.panel1.Controls.Add(this.radioButtonFrom_Pi);
            this.panel1.Controls.Add(this.radioButtonFrom_3Pi4);
            this.panel1.Controls.Add(this.radioButtonFrom_Pi2);
            this.panel1.Controls.Add(this.radioButtonFrom_Pi4);
            this.panel1.Controls.Add(this.radioButtonFrom_0);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 208);
            this.panel1.TabIndex = 17;
            // 
            // radioButtonFrom_7Pi4
            // 
            this.radioButtonFrom_7Pi4.AutoSize = true;
            this.radioButtonFrom_7Pi4.Location = new System.Drawing.Point(4, 185);
            this.radioButtonFrom_7Pi4.Name = "radioButtonFrom_7Pi4";
            this.radioButtonFrom_7Pi4.Size = new System.Drawing.Size(52, 19);
            this.radioButtonFrom_7Pi4.TabIndex = 7;
            this.radioButtonFrom_7Pi4.TabStop = true;
            this.radioButtonFrom_7Pi4.Text = "7Pi/4";
            this.radioButtonFrom_7Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrom_3Pi2
            // 
            this.radioButtonFrom_3Pi2.AutoSize = true;
            this.radioButtonFrom_3Pi2.Location = new System.Drawing.Point(4, 160);
            this.radioButtonFrom_3Pi2.Name = "radioButtonFrom_3Pi2";
            this.radioButtonFrom_3Pi2.Size = new System.Drawing.Size(52, 19);
            this.radioButtonFrom_3Pi2.TabIndex = 6;
            this.radioButtonFrom_3Pi2.TabStop = true;
            this.radioButtonFrom_3Pi2.Text = "3Pi/2";
            this.radioButtonFrom_3Pi2.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrom_5Pi4
            // 
            this.radioButtonFrom_5Pi4.AutoSize = true;
            this.radioButtonFrom_5Pi4.Location = new System.Drawing.Point(4, 135);
            this.radioButtonFrom_5Pi4.Name = "radioButtonFrom_5Pi4";
            this.radioButtonFrom_5Pi4.Size = new System.Drawing.Size(52, 19);
            this.radioButtonFrom_5Pi4.TabIndex = 5;
            this.radioButtonFrom_5Pi4.TabStop = true;
            this.radioButtonFrom_5Pi4.Text = "5Pi/4";
            this.radioButtonFrom_5Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrom_Pi
            // 
            this.radioButtonFrom_Pi.AutoSize = true;
            this.radioButtonFrom_Pi.Location = new System.Drawing.Point(4, 110);
            this.radioButtonFrom_Pi.Name = "radioButtonFrom_Pi";
            this.radioButtonFrom_Pi.Size = new System.Drawing.Size(35, 19);
            this.radioButtonFrom_Pi.TabIndex = 4;
            this.radioButtonFrom_Pi.TabStop = true;
            this.radioButtonFrom_Pi.Text = "Pi";
            this.radioButtonFrom_Pi.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrom_3Pi4
            // 
            this.radioButtonFrom_3Pi4.AutoSize = true;
            this.radioButtonFrom_3Pi4.Location = new System.Drawing.Point(4, 85);
            this.radioButtonFrom_3Pi4.Name = "radioButtonFrom_3Pi4";
            this.radioButtonFrom_3Pi4.Size = new System.Drawing.Size(52, 19);
            this.radioButtonFrom_3Pi4.TabIndex = 3;
            this.radioButtonFrom_3Pi4.TabStop = true;
            this.radioButtonFrom_3Pi4.Text = "3Pi/4";
            this.radioButtonFrom_3Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrom_Pi2
            // 
            this.radioButtonFrom_Pi2.AutoSize = true;
            this.radioButtonFrom_Pi2.Location = new System.Drawing.Point(4, 60);
            this.radioButtonFrom_Pi2.Name = "radioButtonFrom_Pi2";
            this.radioButtonFrom_Pi2.Size = new System.Drawing.Size(46, 19);
            this.radioButtonFrom_Pi2.TabIndex = 2;
            this.radioButtonFrom_Pi2.TabStop = true;
            this.radioButtonFrom_Pi2.Text = "Pi/2";
            this.radioButtonFrom_Pi2.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrom_Pi4
            // 
            this.radioButtonFrom_Pi4.AutoSize = true;
            this.radioButtonFrom_Pi4.Location = new System.Drawing.Point(4, 35);
            this.radioButtonFrom_Pi4.Name = "radioButtonFrom_Pi4";
            this.radioButtonFrom_Pi4.Size = new System.Drawing.Size(46, 19);
            this.radioButtonFrom_Pi4.TabIndex = 1;
            this.radioButtonFrom_Pi4.TabStop = true;
            this.radioButtonFrom_Pi4.Text = "Pi/4";
            this.radioButtonFrom_Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrom_0
            // 
            this.radioButtonFrom_0.AutoSize = true;
            this.radioButtonFrom_0.Location = new System.Drawing.Point(4, 10);
            this.radioButtonFrom_0.Name = "radioButtonFrom_0";
            this.radioButtonFrom_0.Size = new System.Drawing.Size(31, 19);
            this.radioButtonFrom_0.TabIndex = 0;
            this.radioButtonFrom_0.TabStop = true;
            this.radioButtonFrom_0.Text = "0";
            this.radioButtonFrom_0.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonTo_7Pi4);
            this.panel2.Controls.Add(this.radioButtonTo_3Pi2);
            this.panel2.Controls.Add(this.radioButtonTo_5Pi4);
            this.panel2.Controls.Add(this.radioButtonTo_Pi);
            this.panel2.Controls.Add(this.radioButtonTo_3Pi4);
            this.panel2.Controls.Add(this.radioButtonTo_Pi2);
            this.panel2.Controls.Add(this.radioButtonTo_Pi4);
            this.panel2.Controls.Add(this.radioButtonTo_2Pi);
            this.panel2.Location = new System.Drawing.Point(79, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 208);
            this.panel2.TabIndex = 18;
            // 
            // radioButtonTo_7Pi4
            // 
            this.radioButtonTo_7Pi4.AutoSize = true;
            this.radioButtonTo_7Pi4.Location = new System.Drawing.Point(4, 185);
            this.radioButtonTo_7Pi4.Name = "radioButtonTo_7Pi4";
            this.radioButtonTo_7Pi4.Size = new System.Drawing.Size(52, 19);
            this.radioButtonTo_7Pi4.TabIndex = 8;
            this.radioButtonTo_7Pi4.TabStop = true;
            this.radioButtonTo_7Pi4.Text = "7Pi/4";
            this.radioButtonTo_7Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonTo_3Pi2
            // 
            this.radioButtonTo_3Pi2.AutoSize = true;
            this.radioButtonTo_3Pi2.Location = new System.Drawing.Point(4, 160);
            this.radioButtonTo_3Pi2.Name = "radioButtonTo_3Pi2";
            this.radioButtonTo_3Pi2.Size = new System.Drawing.Size(52, 19);
            this.radioButtonTo_3Pi2.TabIndex = 7;
            this.radioButtonTo_3Pi2.TabStop = true;
            this.radioButtonTo_3Pi2.Text = "3Pi/2";
            this.radioButtonTo_3Pi2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTo_5Pi4
            // 
            this.radioButtonTo_5Pi4.AutoSize = true;
            this.radioButtonTo_5Pi4.Location = new System.Drawing.Point(4, 135);
            this.radioButtonTo_5Pi4.Name = "radioButtonTo_5Pi4";
            this.radioButtonTo_5Pi4.Size = new System.Drawing.Size(52, 19);
            this.radioButtonTo_5Pi4.TabIndex = 6;
            this.radioButtonTo_5Pi4.TabStop = true;
            this.radioButtonTo_5Pi4.Text = "5Pi/4";
            this.radioButtonTo_5Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonTo_Pi
            // 
            this.radioButtonTo_Pi.AutoSize = true;
            this.radioButtonTo_Pi.Location = new System.Drawing.Point(4, 110);
            this.radioButtonTo_Pi.Name = "radioButtonTo_Pi";
            this.radioButtonTo_Pi.Size = new System.Drawing.Size(35, 19);
            this.radioButtonTo_Pi.TabIndex = 5;
            this.radioButtonTo_Pi.TabStop = true;
            this.radioButtonTo_Pi.Text = "Pi";
            this.radioButtonTo_Pi.UseVisualStyleBackColor = true;
            // 
            // radioButtonTo_3Pi4
            // 
            this.radioButtonTo_3Pi4.AutoSize = true;
            this.radioButtonTo_3Pi4.Location = new System.Drawing.Point(4, 85);
            this.radioButtonTo_3Pi4.Name = "radioButtonTo_3Pi4";
            this.radioButtonTo_3Pi4.Size = new System.Drawing.Size(52, 19);
            this.radioButtonTo_3Pi4.TabIndex = 4;
            this.radioButtonTo_3Pi4.TabStop = true;
            this.radioButtonTo_3Pi4.Text = "3Pi/4";
            this.radioButtonTo_3Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonTo_Pi2
            // 
            this.radioButtonTo_Pi2.AutoSize = true;
            this.radioButtonTo_Pi2.Location = new System.Drawing.Point(4, 60);
            this.radioButtonTo_Pi2.Name = "radioButtonTo_Pi2";
            this.radioButtonTo_Pi2.Size = new System.Drawing.Size(46, 19);
            this.radioButtonTo_Pi2.TabIndex = 3;
            this.radioButtonTo_Pi2.TabStop = true;
            this.radioButtonTo_Pi2.Text = "Pi/2";
            this.radioButtonTo_Pi2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTo_Pi4
            // 
            this.radioButtonTo_Pi4.AutoSize = true;
            this.radioButtonTo_Pi4.Location = new System.Drawing.Point(4, 35);
            this.radioButtonTo_Pi4.Name = "radioButtonTo_Pi4";
            this.radioButtonTo_Pi4.Size = new System.Drawing.Size(46, 19);
            this.radioButtonTo_Pi4.TabIndex = 2;
            this.radioButtonTo_Pi4.TabStop = true;
            this.radioButtonTo_Pi4.Text = "Pi/4";
            this.radioButtonTo_Pi4.UseVisualStyleBackColor = true;
            // 
            // radioButtonTo_2Pi
            // 
            this.radioButtonTo_2Pi.AutoSize = true;
            this.radioButtonTo_2Pi.Location = new System.Drawing.Point(4, 9);
            this.radioButtonTo_2Pi.Name = "radioButtonTo_2Pi";
            this.radioButtonTo_2Pi.Size = new System.Drawing.Size(41, 19);
            this.radioButtonTo_2Pi.TabIndex = 0;
            this.radioButtonTo_2Pi.TabStop = true;
            this.radioButtonTo_2Pi.Text = "2Pi";
            this.radioButtonTo_2Pi.UseVisualStyleBackColor = true;
            // 
            // AdditionalTrajectorySettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(386, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdditionalSettingsCancel);
            this.Controls.Add(this.buttonAdditionalSettingsOk);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelCoordinats);
            this.Controls.Add(this.labelChoosePoint);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelChangeCoorDesc);
            this.Controls.Add(this.labelChangeCoordinates);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelChangeRange);
            this.Name = "AdditionalTrajectorySettingsForm";
            this.Text = "Addotional settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAdditionalSettingsOk_Click(object sender, EventArgs e)
        {
            //1) Начнем с углов

            //Начало
            if (radioButtonFrom_0.Checked)
                trajectory.InjectionStart = 0;
            if (radioButtonFrom_Pi4.Checked)
                trajectory.InjectionStart = Math.PI/4;
            if (radioButtonFrom_Pi2.Checked)
                trajectory.InjectionStart = Math.PI/2;
            if (radioButtonFrom_3Pi4.Checked)
                trajectory.InjectionStart = (3*Math.PI )/ 4;
            if (radioButtonFrom_Pi.Checked)
                trajectory.InjectionStart = Math.PI;
            if (radioButtonFrom_5Pi4.Checked)
                trajectory.InjectionStart = (5 * Math.PI) / 5;
            if (radioButtonFrom_3Pi2.Checked)
                trajectory.InjectionStart = (3 * Math.PI) / 2;
            if (radioButtonFrom_7Pi4.Checked)
                trajectory.InjectionStart = (7 * Math.PI) / 4;

            //Конец
            if (radioButtonTo_2Pi.Checked)
                trajectory.InjectionEnd = Math.PI*2;
            if (radioButtonTo_Pi4.Checked)
                trajectory.InjectionEnd = Math.PI / 4;
            if (radioButtonTo_Pi2.Checked)
                trajectory.InjectionEnd = Math.PI / 2;
            if (radioButtonTo_3Pi4.Checked)
                trajectory.InjectionEnd = (3 * Math.PI) / 4;
            if (radioButtonTo_Pi.Checked)
                trajectory.InjectionEnd = Math.PI;
            if (radioButtonTo_5Pi4.Checked)
                trajectory.InjectionEnd = (5 * Math.PI) / 5;
            if (radioButtonTo_3Pi2.Checked)
                trajectory.InjectionEnd = (3 * Math.PI) / 2;
            if (radioButtonTo_7Pi4.Checked)
                trajectory.InjectionEnd = (7 * Math.PI) / 4;


            //Закрываем окно
            Close();
        }

        private void buttonAdditionalSettingsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
