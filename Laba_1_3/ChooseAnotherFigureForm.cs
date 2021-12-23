using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class ChooseAnotherFigureForm : Form
    {
        private RadioButton radioButtonFigureVar_5;
        private RadioButton radioButtonFigureVar_8;
        private RadioButton radioButtonFigureVar_11;
        private RadioButton radioButtonFigureVar_16;
        private Button buttonChooseFigureOk;
        private Button buttonChooseFigureCancel;

        public ChooseAnotherFigureForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.radioButtonFigureVar_5 = new System.Windows.Forms.RadioButton();
            this.radioButtonFigureVar_8 = new System.Windows.Forms.RadioButton();
            this.radioButtonFigureVar_11 = new System.Windows.Forms.RadioButton();
            this.radioButtonFigureVar_16 = new System.Windows.Forms.RadioButton();
            this.buttonChooseFigureOk = new System.Windows.Forms.Button();
            this.buttonChooseFigureCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonFigureVar_5
            // 
            this.radioButtonFigureVar_5.AutoSize = true;
            this.radioButtonFigureVar_5.Checked = true;
            this.radioButtonFigureVar_5.Location = new System.Drawing.Point(22, 13);
            this.radioButtonFigureVar_5.Name = "radioButtonFigureVar_5";
            this.radioButtonFigureVar_5.Size = new System.Drawing.Size(122, 19);
            this.radioButtonFigureVar_5.TabIndex = 0;
            this.radioButtonFigureVar_5.TabStop = true;
            this.radioButtonFigureVar_5.Text = "Figure #1 (default)";
            this.radioButtonFigureVar_5.UseVisualStyleBackColor = true;
            // 
            // radioButtonFigureVar_8
            // 
            this.radioButtonFigureVar_8.AutoSize = true;
            this.radioButtonFigureVar_8.Location = new System.Drawing.Point(22, 39);
            this.radioButtonFigureVar_8.Name = "radioButtonFigureVar_8";
            this.radioButtonFigureVar_8.Size = new System.Drawing.Size(74, 19);
            this.radioButtonFigureVar_8.TabIndex = 1;
            this.radioButtonFigureVar_8.TabStop = true;
            this.radioButtonFigureVar_8.Text = "Figure #2";
            this.radioButtonFigureVar_8.UseVisualStyleBackColor = true;
            // 
            // radioButtonFigureVar_11
            // 
            this.radioButtonFigureVar_11.AutoSize = true;
            this.radioButtonFigureVar_11.Location = new System.Drawing.Point(22, 65);
            this.radioButtonFigureVar_11.Name = "radioButtonFigureVar_11";
            this.radioButtonFigureVar_11.Size = new System.Drawing.Size(74, 19);
            this.radioButtonFigureVar_11.TabIndex = 2;
            this.radioButtonFigureVar_11.TabStop = true;
            this.radioButtonFigureVar_11.Text = "Figure #3";
            this.radioButtonFigureVar_11.UseVisualStyleBackColor = true;
            // 
            // radioButtonFigureVar_16
            // 
            this.radioButtonFigureVar_16.AutoSize = true;
            this.radioButtonFigureVar_16.Location = new System.Drawing.Point(22, 91);
            this.radioButtonFigureVar_16.Name = "radioButtonFigureVar_16";
            this.radioButtonFigureVar_16.Size = new System.Drawing.Size(74, 19);
            this.radioButtonFigureVar_16.TabIndex = 3;
            this.radioButtonFigureVar_16.TabStop = true;
            this.radioButtonFigureVar_16.Text = "Figure #4";
            this.radioButtonFigureVar_16.UseVisualStyleBackColor = true;
            // 
            // buttonChooseFigureOk
            // 
            this.buttonChooseFigureOk.Location = new System.Drawing.Point(68, 203);
            this.buttonChooseFigureOk.Name = "buttonChooseFigureOk";
            this.buttonChooseFigureOk.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseFigureOk.TabIndex = 4;
            this.buttonChooseFigureOk.Text = "Ok";
            this.buttonChooseFigureOk.UseVisualStyleBackColor = true;
            this.buttonChooseFigureOk.Click += new System.EventHandler(this.buttonChooseFigureOk_Click);
            // 
            // buttonChooseFigureCancel
            // 
            this.buttonChooseFigureCancel.Location = new System.Drawing.Point(172, 203);
            this.buttonChooseFigureCancel.Name = "buttonChooseFigureCancel";
            this.buttonChooseFigureCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseFigureCancel.TabIndex = 5;
            this.buttonChooseFigureCancel.Text = "Cancel";
            this.buttonChooseFigureCancel.UseVisualStyleBackColor = true;
            this.buttonChooseFigureCancel.Click += new System.EventHandler(this.buttonChooseFigureCancel_Click);
            // 
            // ChooseAnotherFigureForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonChooseFigureCancel);
            this.Controls.Add(this.buttonChooseFigureOk);
            this.Controls.Add(this.radioButtonFigureVar_16);
            this.Controls.Add(this.radioButtonFigureVar_11);
            this.Controls.Add(this.radioButtonFigureVar_8);
            this.Controls.Add(this.radioButtonFigureVar_5);
            this.Name = "ChooseAnotherFigureForm";
            this.Text = "Choose figure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonChooseFigureOk_Click(object sender, EventArgs e)
        {
            if (radioButtonFigureVar_5.Checked)
                СhangedObject.CurrentFigure = new FigureVar_5(СhangedObject.CurrentTrajectory);
            if (radioButtonFigureVar_8.Checked)
                СhangedObject.CurrentFigure = new FigureVar_8(СhangedObject.CurrentTrajectory);
            if (radioButtonFigureVar_11.Checked)
                СhangedObject.CurrentFigure = new FigureVar_11(СhangedObject.CurrentTrajectory);
            if (radioButtonFigureVar_16.Checked)
                СhangedObject.CurrentFigure = new FigureVar_16(СhangedObject.CurrentTrajectory);
            Close();
        }

        private void buttonChooseFigureCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
