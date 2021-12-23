using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class ChooseAnotherTrajectoryForm : Form
    {
        public ChooseAnotherTrajectoryForm()
        {
            InitializeComponent();
            
            

        }

        private RadioButton radioButtonEllipse;
        private RadioButton radioButtonLissajou;
        private RadioButton radioButtonHypocycloid;
        private Button buttonChooseTrajecOk;
        private Button buttonChooseTrajecCancel;
        //private Trajectory trajectory;
        

        private void InitializeComponent()
        {
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonLissajou = new System.Windows.Forms.RadioButton();
            this.radioButtonHypocycloid = new System.Windows.Forms.RadioButton();
            this.buttonChooseTrajecOk = new System.Windows.Forms.Button();
            this.buttonChooseTrajecCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Checked = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(28, 33);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(106, 19);
            this.radioButtonEllipse.TabIndex = 0;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Ellipse (default)";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonLissajou
            // 
            this.radioButtonLissajou.AutoSize = true;
            this.radioButtonLissajou.Location = new System.Drawing.Point(28, 59);
            this.radioButtonLissajou.Name = "radioButtonLissajou";
            this.radioButtonLissajou.Size = new System.Drawing.Size(67, 19);
            this.radioButtonLissajou.TabIndex = 1;
            this.radioButtonLissajou.Text = "Lissajou";
            this.radioButtonLissajou.UseVisualStyleBackColor = true;
            // 
            // radioButtonHypocycloid
            // 
            this.radioButtonHypocycloid.AutoSize = true;
            this.radioButtonHypocycloid.Location = new System.Drawing.Point(28, 85);
            this.radioButtonHypocycloid.Name = "radioButtonHypocycloid";
            this.radioButtonHypocycloid.Size = new System.Drawing.Size(92, 19);
            this.radioButtonHypocycloid.TabIndex = 2;
            this.radioButtonHypocycloid.Text = "Hypocycloid";
            this.radioButtonHypocycloid.UseVisualStyleBackColor = true;
            // 
            // buttonChooseTrajecOk
            // 
            this.buttonChooseTrajecOk.Location = new System.Drawing.Point(107, 205);
            this.buttonChooseTrajecOk.Name = "buttonChooseTrajecOk";
            this.buttonChooseTrajecOk.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseTrajecOk.TabIndex = 3;
            this.buttonChooseTrajecOk.Text = "Ok";
            this.buttonChooseTrajecOk.UseVisualStyleBackColor = true;
            this.buttonChooseTrajecOk.Click += new System.EventHandler(this.buttonChooseTrajecOk_Click);
            // 
            // buttonChooseTrajecCancel
            // 
            this.buttonChooseTrajecCancel.Location = new System.Drawing.Point(197, 205);
            this.buttonChooseTrajecCancel.Name = "buttonChooseTrajecCancel";
            this.buttonChooseTrajecCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseTrajecCancel.TabIndex = 4;
            this.buttonChooseTrajecCancel.Text = "Cancel";
            this.buttonChooseTrajecCancel.UseVisualStyleBackColor = true;
            this.buttonChooseTrajecCancel.Click += new System.EventHandler(this.buttonChooseTrajecCancel_Click);
            // 
            // ChooseAnotherTrajectoryForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonChooseTrajecCancel);
            this.Controls.Add(this.buttonChooseTrajecOk);
            this.Controls.Add(this.radioButtonHypocycloid);
            this.Controls.Add(this.radioButtonLissajou);
            this.Controls.Add(this.radioButtonEllipse);
            this.Name = "ChooseAnotherTrajectoryForm";
            this.Text = "Choose trajectory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonChooseTrajecOk_Click(object sender, EventArgs e)
        {
            if (radioButtonEllipse.Checked)
                СhangedObject.CurrentTrajectory = new Ellipse();
            if (radioButtonLissajou.Checked)
                СhangedObject.CurrentTrajectory = new Lissajou();
            if (radioButtonHypocycloid.Checked)
                СhangedObject.CurrentTrajectory = new Hypocycloid();

            Close();

        }

        private void buttonChooseTrajecCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
