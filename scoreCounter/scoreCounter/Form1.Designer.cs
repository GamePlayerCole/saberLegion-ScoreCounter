namespace scoreCounter
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
            this.contestant1TextBox = new System.Windows.Forms.TextBox();
            this.contestant2TextBox = new System.Windows.Forms.TextBox();
            this.updateContestantsButton = new System.Windows.Forms.Button();
            this.Participant1Label = new System.Windows.Forms.Label();
            this.Participant2Label = new System.Windows.Forms.Label();
            this.contestant1ScoreLabel = new System.Windows.Forms.Label();
            this.contestant1MinusButton = new System.Windows.Forms.Button();
            this.contestant1PlusButton = new System.Windows.Forms.Button();
            this.contestant2MinusButton = new System.Windows.Forms.Button();
            this.contestant2ScoreLabel = new System.Windows.Forms.Label();
            this.contestant2PlusButton = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundNumberLabel = new System.Windows.Forms.Label();
            this.plusRoundButton = new System.Windows.Forms.Button();
            this.minusRoundButton = new System.Windows.Forms.Button();
            this.newMatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contestant1TextBox
            // 
            this.contestant1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant1TextBox.Location = new System.Drawing.Point(12, 106);
            this.contestant1TextBox.Name = "contestant1TextBox";
            this.contestant1TextBox.Size = new System.Drawing.Size(281, 35);
            this.contestant1TextBox.TabIndex = 0;
            // 
            // contestant2TextBox
            // 
            this.contestant2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant2TextBox.Location = new System.Drawing.Point(400, 106);
            this.contestant2TextBox.Name = "contestant2TextBox";
            this.contestant2TextBox.Size = new System.Drawing.Size(281, 35);
            this.contestant2TextBox.TabIndex = 1;
            // 
            // updateContestantsButton
            // 
            this.updateContestantsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateContestantsButton.Location = new System.Drawing.Point(231, 12);
            this.updateContestantsButton.Name = "updateContestantsButton";
            this.updateContestantsButton.Size = new System.Drawing.Size(239, 43);
            this.updateContestantsButton.TabIndex = 2;
            this.updateContestantsButton.Text = "Update Contestants";
            this.updateContestantsButton.UseVisualStyleBackColor = true;
            this.updateContestantsButton.Click += new System.EventHandler(this.updateContestantsButton_Click);
            // 
            // Participant1Label
            // 
            this.Participant1Label.AutoSize = true;
            this.Participant1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant1Label.Location = new System.Drawing.Point(40, 74);
            this.Participant1Label.Name = "Participant1Label";
            this.Participant1Label.Size = new System.Drawing.Size(225, 29);
            this.Participant1Label.TabIndex = 3;
            this.Participant1Label.Text = "Participant #1 (Red)";
            // 
            // Participant2Label
            // 
            this.Participant2Label.AutoSize = true;
            this.Participant2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant2Label.Location = new System.Drawing.Point(432, 74);
            this.Participant2Label.Name = "Participant2Label";
            this.Participant2Label.Size = new System.Drawing.Size(229, 29);
            this.Participant2Label.TabIndex = 4;
            this.Participant2Label.Text = "Participant #2 (Blue)";
            // 
            // contestant1ScoreLabel
            // 
            this.contestant1ScoreLabel.AutoSize = true;
            this.contestant1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant1ScoreLabel.Location = new System.Drawing.Point(124, 144);
            this.contestant1ScoreLabel.Name = "contestant1ScoreLabel";
            this.contestant1ScoreLabel.Size = new System.Drawing.Size(0, 55);
            this.contestant1ScoreLabel.TabIndex = 5;
            // 
            // contestant1MinusButton
            // 
            this.contestant1MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant1MinusButton.Location = new System.Drawing.Point(12, 147);
            this.contestant1MinusButton.Name = "contestant1MinusButton";
            this.contestant1MinusButton.Size = new System.Drawing.Size(78, 52);
            this.contestant1MinusButton.TabIndex = 6;
            this.contestant1MinusButton.Text = "-";
            this.contestant1MinusButton.UseVisualStyleBackColor = true;
            // 
            // contestant1PlusButton
            // 
            this.contestant1PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant1PlusButton.Location = new System.Drawing.Point(215, 147);
            this.contestant1PlusButton.Name = "contestant1PlusButton";
            this.contestant1PlusButton.Size = new System.Drawing.Size(78, 52);
            this.contestant1PlusButton.TabIndex = 7;
            this.contestant1PlusButton.Text = "+";
            this.contestant1PlusButton.UseVisualStyleBackColor = true;
            // 
            // contestant2MinusButton
            // 
            this.contestant2MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant2MinusButton.Location = new System.Drawing.Point(400, 149);
            this.contestant2MinusButton.Name = "contestant2MinusButton";
            this.contestant2MinusButton.Size = new System.Drawing.Size(78, 52);
            this.contestant2MinusButton.TabIndex = 8;
            this.contestant2MinusButton.Text = "-";
            this.contestant2MinusButton.UseVisualStyleBackColor = true;
            // 
            // contestant2ScoreLabel
            // 
            this.contestant2ScoreLabel.AutoSize = true;
            this.contestant2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant2ScoreLabel.Location = new System.Drawing.Point(515, 147);
            this.contestant2ScoreLabel.Name = "contestant2ScoreLabel";
            this.contestant2ScoreLabel.Size = new System.Drawing.Size(0, 55);
            this.contestant2ScoreLabel.TabIndex = 9;
            // 
            // contestant2PlusButton
            // 
            this.contestant2PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestant2PlusButton.Location = new System.Drawing.Point(603, 149);
            this.contestant2PlusButton.Name = "contestant2PlusButton";
            this.contestant2PlusButton.Size = new System.Drawing.Size(78, 52);
            this.contestant2PlusButton.TabIndex = 10;
            this.contestant2PlusButton.Text = "+";
            this.contestant2PlusButton.UseVisualStyleBackColor = true;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(296, 216);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(105, 33);
            this.roundLabel.TabIndex = 11;
            this.roundLabel.Text = "Round";
            // 
            // roundNumberLabel
            // 
            this.roundNumberLabel.AutoSize = true;
            this.roundNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNumberLabel.Location = new System.Drawing.Point(323, 249);
            this.roundNumberLabel.Name = "roundNumberLabel";
            this.roundNumberLabel.Size = new System.Drawing.Size(51, 55);
            this.roundNumberLabel.TabIndex = 12;
            this.roundNumberLabel.Text = "1";
            // 
            // plusRoundButton
            // 
            this.plusRoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRoundButton.Location = new System.Drawing.Point(380, 252);
            this.plusRoundButton.Name = "plusRoundButton";
            this.plusRoundButton.Size = new System.Drawing.Size(62, 52);
            this.plusRoundButton.TabIndex = 13;
            this.plusRoundButton.Text = "►";
            this.plusRoundButton.UseVisualStyleBackColor = true;
            // 
            // minusRoundButton
            // 
            this.minusRoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRoundButton.Location = new System.Drawing.Point(255, 252);
            this.minusRoundButton.Name = "minusRoundButton";
            this.minusRoundButton.Size = new System.Drawing.Size(62, 52);
            this.minusRoundButton.TabIndex = 14;
            this.minusRoundButton.Text = "◄";
            this.minusRoundButton.UseVisualStyleBackColor = true;
            // 
            // newMatchButton
            // 
            this.newMatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMatchButton.Location = new System.Drawing.Point(255, 326);
            this.newMatchButton.Name = "newMatchButton";
            this.newMatchButton.Size = new System.Drawing.Size(187, 43);
            this.newMatchButton.TabIndex = 15;
            this.newMatchButton.Text = "New Match";
            this.newMatchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 379);
            this.Controls.Add(this.newMatchButton);
            this.Controls.Add(this.minusRoundButton);
            this.Controls.Add(this.plusRoundButton);
            this.Controls.Add(this.roundNumberLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.contestant2PlusButton);
            this.Controls.Add(this.contestant2ScoreLabel);
            this.Controls.Add(this.contestant2MinusButton);
            this.Controls.Add(this.contestant1PlusButton);
            this.Controls.Add(this.contestant1MinusButton);
            this.Controls.Add(this.contestant1ScoreLabel);
            this.Controls.Add(this.Participant2Label);
            this.Controls.Add(this.Participant1Label);
            this.Controls.Add(this.updateContestantsButton);
            this.Controls.Add(this.contestant2TextBox);
            this.Controls.Add(this.contestant1TextBox);
            this.Name = "Form1";
            this.Text = "Saber Legion Score Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contestant1TextBox;
        private System.Windows.Forms.TextBox contestant2TextBox;
        private System.Windows.Forms.Button updateContestantsButton;
        private System.Windows.Forms.Label Participant1Label;
        private System.Windows.Forms.Label Participant2Label;
        private System.Windows.Forms.Label contestant1ScoreLabel;
        private System.Windows.Forms.Button contestant1MinusButton;
        private System.Windows.Forms.Button contestant1PlusButton;
        private System.Windows.Forms.Button contestant2MinusButton;
        private System.Windows.Forms.Label contestant2ScoreLabel;
        private System.Windows.Forms.Button contestant2PlusButton;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label roundNumberLabel;
        private System.Windows.Forms.Button plusRoundButton;
        private System.Windows.Forms.Button minusRoundButton;
        private System.Windows.Forms.Button newMatchButton;
    }
}

