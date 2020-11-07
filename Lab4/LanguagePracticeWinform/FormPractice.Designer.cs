namespace LanguagePracticeWinform
{
    partial class FormPractice
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
            this.textboxPracticeAnswer = new System.Windows.Forms.TextBox();
            this.buttonPracticeExit = new System.Windows.Forms.Button();
            this.buttonPracticeRestart = new System.Windows.Forms.Button();
            this.labelPracticeWordOutput = new System.Windows.Forms.Label();
            this.labelPracticeScore = new System.Windows.Forms.Label();
            this.labelAnswerMessage = new System.Windows.Forms.Label();
            this.FromToLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxPracticeAnswer
            // 
            this.textboxPracticeAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPracticeAnswer.Location = new System.Drawing.Point(150, 56);
            this.textboxPracticeAnswer.Name = "textboxPracticeAnswer";
            this.textboxPracticeAnswer.Size = new System.Drawing.Size(200, 20);
            this.textboxPracticeAnswer.TabIndex = 0;
            this.textboxPracticeAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxPracticeAnswer_KeyDown);
            // 
            // buttonPracticeExit
            // 
            this.buttonPracticeExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPracticeExit.Location = new System.Drawing.Point(397, 219);
            this.buttonPracticeExit.Name = "buttonPracticeExit";
            this.buttonPracticeExit.Size = new System.Drawing.Size(75, 23);
            this.buttonPracticeExit.TabIndex = 1;
            this.buttonPracticeExit.Text = "Exit";
            this.buttonPracticeExit.UseVisualStyleBackColor = true;
            this.buttonPracticeExit.Click += new System.EventHandler(this.buttonExit);
            // 
            // buttonPracticeRestart
            // 
            this.buttonPracticeRestart.Location = new System.Drawing.Point(212, 177);
            this.buttonPracticeRestart.Name = "buttonPracticeRestart";
            this.buttonPracticeRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonPracticeRestart.TabIndex = 2;
            this.buttonPracticeRestart.Text = "Restart";
            this.buttonPracticeRestart.UseVisualStyleBackColor = true;
            this.buttonPracticeRestart.Click += new System.EventHandler(this.buttonPracticeRestart_Click);
            // 
            // labelPracticeWordOutput
            // 
            this.labelPracticeWordOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPracticeWordOutput.AutoSize = true;
            this.labelPracticeWordOutput.Location = new System.Drawing.Point(159, 40);
            this.labelPracticeWordOutput.Name = "labelPracticeWordOutput";
            this.labelPracticeWordOutput.Size = new System.Drawing.Size(63, 13);
            this.labelPracticeWordOutput.TabIndex = 3;
            this.labelPracticeWordOutput.Text = "word output";
            this.labelPracticeWordOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPracticeScore
            // 
            this.labelPracticeScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPracticeScore.AutoSize = true;
            this.labelPracticeScore.Location = new System.Drawing.Point(209, 144);
            this.labelPracticeScore.Name = "labelPracticeScore";
            this.labelPracticeScore.Size = new System.Drawing.Size(87, 13);
            this.labelPracticeScore.TabIndex = 4;
            this.labelPracticeScore.Text = "You got 0 points.";
            this.labelPracticeScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAnswerMessage
            // 
            this.labelAnswerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswerMessage.AutoSize = true;
            this.labelAnswerMessage.Location = new System.Drawing.Point(172, 108);
            this.labelAnswerMessage.Name = "labelAnswerMessage";
            this.labelAnswerMessage.Size = new System.Drawing.Size(85, 13);
            this.labelAnswerMessage.TabIndex = 6;
            this.labelAnswerMessage.Text = "AnswerMessage";
            this.labelAnswerMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromToLanguage
            // 
            this.FromToLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FromToLanguage.AutoSize = true;
            this.FromToLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromToLanguage.Location = new System.Drawing.Point(130, 9);
            this.FromToLanguage.Name = "FromToLanguage";
            this.FromToLanguage.Size = new System.Drawing.Size(127, 19);
            this.FromToLanguage.TabIndex = 7;
            this.FromToLanguage.Text = "FromToLanguage";
            this.FromToLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 254);
            this.Controls.Add(this.FromToLanguage);
            this.Controls.Add(this.labelAnswerMessage);
            this.Controls.Add(this.labelPracticeScore);
            this.Controls.Add(this.labelPracticeWordOutput);
            this.Controls.Add(this.buttonPracticeRestart);
            this.Controls.Add(this.buttonPracticeExit);
            this.Controls.Add(this.textboxPracticeAnswer);
            this.Name = "FormPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPractice";
            this.Load += new System.EventHandler(this.FormPractice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxPracticeAnswer;
        private System.Windows.Forms.Button buttonPracticeExit;
        private System.Windows.Forms.Button buttonPracticeRestart;
        private System.Windows.Forms.Label labelPracticeWordOutput;
        private System.Windows.Forms.Label labelPracticeScore;
        private System.Windows.Forms.Label labelAnswerMessage;
        private System.Windows.Forms.Label FromToLanguage;
    }
}