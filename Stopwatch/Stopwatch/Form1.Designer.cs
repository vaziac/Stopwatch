namespace Stopwatch
{
    partial class Stopwatch
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
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.k1Label = new System.Windows.Forms.Label();
            this.k2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 78);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 50);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(183, 78);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(114, 50);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.hourLabel.Location = new System.Drawing.Point(32, 24);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(55, 39);
            this.hourLabel.TabIndex = 2;
            this.hourLabel.Text = "00";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.minLabel.Location = new System.Drawing.Point(126, 24);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(55, 39);
            this.minLabel.TabIndex = 3;
            this.minLabel.Text = "00";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.secLabel.Location = new System.Drawing.Point(220, 24);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(55, 39);
            this.secLabel.TabIndex = 4;
            this.secLabel.Text = "00";
            // 
            // k1Label
            // 
            this.k1Label.AutoSize = true;
            this.k1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.k1Label.Location = new System.Drawing.Point(93, 24);
            this.k1Label.Name = "k1Label";
            this.k1Label.Size = new System.Drawing.Size(27, 39);
            this.k1Label.TabIndex = 5;
            this.k1Label.Text = ":";
            // 
            // k2Label
            // 
            this.k2Label.AutoSize = true;
            this.k2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.k2Label.Location = new System.Drawing.Point(187, 24);
            this.k2Label.Name = "k2Label";
            this.k2Label.Size = new System.Drawing.Size(27, 39);
            this.k2Label.TabIndex = 6;
            this.k2Label.Text = ":";
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 140);
            this.Controls.Add(this.k2Label);
            this.Controls.Add(this.k1Label);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Name = "Stopwatch";
            this.Text = "StopWatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label k1Label;
        private System.Windows.Forms.Label k2Label;
    }
}

