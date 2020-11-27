namespace GuessingGame
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(128, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(248, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guessing Game";
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.ForeColor = System.Drawing.Color.White;
            this.enterLabel.Location = new System.Drawing.Point(92, 93);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(306, 24);
            this.enterLabel.TabIndex = 1;
            this.enterLabel.Text = "Enter a number between 1 and 100";
            // 
            // numberText
            // 
            this.numberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberText.Location = new System.Drawing.Point(208, 142);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(81, 29);
            this.numberText.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.guessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.ForeColor = System.Drawing.Color.Black;
            this.guessButton.Location = new System.Drawing.Point(195, 177);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(108, 50);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(81, 243);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(338, 49);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetButton.Location = new System.Drawing.Point(181, 295);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 39);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(515, 400);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

