namespace PumpUpdater
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.PWMBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.PWMLabel = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.SpeedBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Auto Detect Port";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(13, 27);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 1;
            this.ComboBox.Text = "Pick a port";
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 144);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(331, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // PWMBar
            // 
            this.PWMBar.Location = new System.Drawing.Point(154, 115);
            this.PWMBar.Name = "PWMBar";
            this.PWMBar.Size = new System.Drawing.Size(189, 23);
            this.PWMBar.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mode";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(269, 9);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(75, 13);
            this.ModeLabel.TabIndex = 5;
            this.ModeLabel.Text = "Mode: Manual";
            // 
            // PWMLabel
            // 
            this.PWMLabel.AutoSize = true;
            this.PWMLabel.Location = new System.Drawing.Point(73, 115);
            this.PWMLabel.Name = "PWMLabel";
            this.PWMLabel.Size = new System.Drawing.Size(71, 13);
            this.PWMLabel.TabIndex = 6;
            this.PWMLabel.Text = "Current PWM";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(154, 82);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(189, 23);
            this.progressBar2.TabIndex = 7;
            // 
            // SpeedBar
            // 
            this.SpeedBar.AutoSize = true;
            this.SpeedBar.Location = new System.Drawing.Point(76, 82);
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(75, 13);
            this.SpeedBar.TabIndex = 8;
            this.SpeedBar.Text = "Current Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 189);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.PWMLabel);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PWMBar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Pump Control";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar PWMBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label PWMLabel;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label SpeedBar;
    }
}

