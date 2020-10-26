namespace LanguagePracticeWinform
{
    partial class FormNewList
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
            this.textboxCreateNewList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxEnterLanguages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewListCancel = new System.Windows.Forms.Button();
            this.buttonNewListOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxCreateNewList
            // 
            this.textboxCreateNewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxCreateNewList.Location = new System.Drawing.Point(71, 25);
            this.textboxCreateNewList.Name = "textboxCreateNewList";
            this.textboxCreateNewList.Size = new System.Drawing.Size(249, 20);
            this.textboxCreateNewList.TabIndex = 0;
            this.textboxCreateNewList.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter new ListName:";
            // 
            // textboxEnterLanguages
            // 
            this.textboxEnterLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxEnterLanguages.Location = new System.Drawing.Point(71, 74);
            this.textboxEnterLanguages.Multiline = true;
            this.textboxEnterLanguages.Name = "textboxEnterLanguages";
            this.textboxEnterLanguages.Size = new System.Drawing.Size(249, 138);
            this.textboxEnterLanguages.TabIndex = 2;
            this.textboxEnterLanguages.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter new Languages";
            // 
            // buttonNewListCancel
            // 
            this.buttonNewListCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewListCancel.Location = new System.Drawing.Point(12, 217);
            this.buttonNewListCancel.Name = "buttonNewListCancel";
            this.buttonNewListCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonNewListCancel.TabIndex = 4;
            this.buttonNewListCancel.Text = "Cancel";
            this.buttonNewListCancel.UseVisualStyleBackColor = true;
            this.buttonNewListCancel.Click += new System.EventHandler(this.buttonNewListCancel_Click);
            // 
            // buttonNewListOk
            // 
            this.buttonNewListOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewListOk.Location = new System.Drawing.Point(301, 217);
            this.buttonNewListOk.Name = "buttonNewListOk";
            this.buttonNewListOk.Size = new System.Drawing.Size(75, 23);
            this.buttonNewListOk.TabIndex = 5;
            this.buttonNewListOk.Text = "Ok";
            this.buttonNewListOk.UseVisualStyleBackColor = true;
            this.buttonNewListOk.Click += new System.EventHandler(this.buttonNewListOk_Click);
            // 
            // FormNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 254);
            this.Controls.Add(this.buttonNewListOk);
            this.Controls.Add(this.buttonNewListCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxEnterLanguages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxCreateNewList);
            this.Name = "FormNewList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxCreateNewList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxEnterLanguages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewListCancel;
        private System.Windows.Forms.Button buttonNewListOk;
    }
}