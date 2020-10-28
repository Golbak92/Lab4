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
            this.SuspendLayout();
            // 
            // textboxPracticeAnswer
            // 
            this.textboxPracticeAnswer.Location = new System.Drawing.Point(134, 91);
            this.textboxPracticeAnswer.Name = "textboxPracticeAnswer";
            this.textboxPracticeAnswer.Size = new System.Drawing.Size(198, 20);
            this.textboxPracticeAnswer.TabIndex = 0;
            // 
            // buttonPracticeExit
            // 
            this.buttonPracticeExit.Location = new System.Drawing.Point(386, 212);
            this.buttonPracticeExit.Name = "buttonPracticeExit";
            this.buttonPracticeExit.Size = new System.Drawing.Size(75, 23);
            this.buttonPracticeExit.TabIndex = 1;
            this.buttonPracticeExit.Text = "Exit";
            this.buttonPracticeExit.UseVisualStyleBackColor = true;
            this.buttonPracticeExit.Click += new System.EventHandler(this.buttonExit);
            // 
            // buttonPracticeRestart
            // 
            this.buttonPracticeRestart.Location = new System.Drawing.Point(188, 175);
            this.buttonPracticeRestart.Name = "buttonPracticeRestart";
            this.buttonPracticeRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonPracticeRestart.TabIndex = 2;
            this.buttonPracticeRestart.Text = "Restart";
            this.buttonPracticeRestart.UseVisualStyleBackColor = true;
            // 
            // labelPracticeWordOutput
            // 
            this.labelPracticeWordOutput.AutoSize = true;
            this.labelPracticeWordOutput.Location = new System.Drawing.Point(200, 58);
            this.labelPracticeWordOutput.Name = "labelPracticeWordOutput";
            this.labelPracticeWordOutput.Size = new System.Drawing.Size(63, 13);
            this.labelPracticeWordOutput.TabIndex = 3;
            this.labelPracticeWordOutput.Text = "word output";
            // 
            // labelPracticeScore
            // 
            this.labelPracticeScore.AutoSize = true;
            this.labelPracticeScore.Location = new System.Drawing.Point(210, 149);
            this.labelPracticeScore.Name = "labelPracticeScore";
            this.labelPracticeScore.Size = new System.Drawing.Size(33, 13);
            this.labelPracticeScore.TabIndex = 4;
            this.labelPracticeScore.Text = "score";
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 247);
            this.Controls.Add(this.labelPracticeScore);
            this.Controls.Add(this.labelPracticeWordOutput);
            this.Controls.Add(this.buttonPracticeRestart);
            this.Controls.Add(this.buttonPracticeExit);
            this.Controls.Add(this.textboxPracticeAnswer);
            this.Name = "FormPractice";
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
    }
}