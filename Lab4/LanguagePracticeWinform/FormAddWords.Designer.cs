namespace LanguagePracticeWinform
{
    partial class FormAddWords
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
            this.dataGridViewAddWords = new System.Windows.Forms.DataGridView();
            this.buttonAddWordsCancel = new System.Windows.Forms.Button();
            this.buttonAddWordsConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddWords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddWords
            // 
            this.dataGridViewAddWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAddWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddWords.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAddWords.Name = "dataGridViewAddWords";
            this.dataGridViewAddWords.Size = new System.Drawing.Size(467, 249);
            this.dataGridViewAddWords.TabIndex = 0;
            this.dataGridViewAddWords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAddWordsCancel
            // 
            this.buttonAddWordsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddWordsCancel.Location = new System.Drawing.Point(12, 271);
            this.buttonAddWordsCancel.Name = "buttonAddWordsCancel";
            this.buttonAddWordsCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWordsCancel.TabIndex = 1;
            this.buttonAddWordsCancel.Text = "Cancel";
            this.buttonAddWordsCancel.UseVisualStyleBackColor = true;
            this.buttonAddWordsCancel.Click += new System.EventHandler(this.buttonAddWordsCancel_Click);
            // 
            // buttonAddWordsConfirm
            // 
            this.buttonAddWordsConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWordsConfirm.Location = new System.Drawing.Point(404, 271);
            this.buttonAddWordsConfirm.Name = "buttonAddWordsConfirm";
            this.buttonAddWordsConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWordsConfirm.TabIndex = 2;
            this.buttonAddWordsConfirm.Text = "Confirm";
            this.buttonAddWordsConfirm.UseVisualStyleBackColor = true;
            // 
            // FormAddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 306);
            this.Controls.Add(this.buttonAddWordsConfirm);
            this.Controls.Add(this.buttonAddWordsCancel);
            this.Controls.Add(this.dataGridViewAddWords);
            this.Name = "FormAddWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Words";
            this.Load += new System.EventHandler(this.FormAddWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddWords;
        private System.Windows.Forms.Button buttonAddWordsCancel;
        private System.Windows.Forms.Button buttonAddWordsConfirm;
    }
}