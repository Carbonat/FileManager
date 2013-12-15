namespace _0001_Forms
{
    partial class WordsFrequency
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
            this.listView = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox = new System.Windows.Forms.TextBox();
            this.countFrequencyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Frequency});
            this.listView.Location = new System.Drawing.Point(12, 38);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(395, 348);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Слово";
            this.Word.Width = 236;
            // 
            // Frequency
            // 
            this.Frequency.Text = "Частота";
            this.Frequency.Width = 154;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(322, 20);
            this.textBox.TabIndex = 1;
            // 
            // countFrequencyButton
            // 
            this.countFrequencyButton.Location = new System.Drawing.Point(340, 11);
            this.countFrequencyButton.Name = "countFrequencyButton";
            this.countFrequencyButton.Size = new System.Drawing.Size(67, 20);
            this.countFrequencyButton.TabIndex = 2;
            this.countFrequencyButton.Text = "Частота";
            this.countFrequencyButton.UseVisualStyleBackColor = true;
            this.countFrequencyButton.Click += new System.EventHandler(this.countFrequencyButton_Click);
            // 
            // WordsFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 398);
            this.Controls.Add(this.countFrequencyButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listView);
            this.Name = "WordsFrequency";
            this.Text = "Частота слів";
            this.Load += new System.EventHandler(this.WordsFrequency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Frequency;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button countFrequencyButton;
    }
}