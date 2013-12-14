namespace _0001_Forms
{
    partial class FindInTextEditor
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
            this.Lines = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lines,
            this.Number});
            this.listView.Location = new System.Drawing.Point(12, 86);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(448, 278);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Lines
            // 
            this.Lines.Text = "Рядки";
            // 
            // Number
            // 
            this.Number.Text = "Номер рядка";
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Number.Width = 99;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(448, 20);
            this.textBox.TabIndex = 0;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(199, 37);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 25);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Знайти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // FindInTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 376);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindInTextEditor";
            this.Text = "Пошук";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Lines;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button findButton;
    }
}