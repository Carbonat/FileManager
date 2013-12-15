namespace _0001_Forms
{
    partial class Info
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
            this.nameSection = new System.Windows.Forms.Label();
            this.fullPathSection = new System.Windows.Forms.Label();
            this.memorySection = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.creationTimeSection = new System.Windows.Forms.Label();
            this.memory = new System.Windows.Forms.Label();
            this.creationTime = new System.Windows.Forms.Label();
            this.typeSection = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameSection
            // 
            this.nameSection.AutoSize = true;
            this.nameSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameSection.Location = new System.Drawing.Point(11, 9);
            this.nameSection.Name = "nameSection";
            this.nameSection.Size = new System.Drawing.Size(37, 20);
            this.nameSection.TabIndex = 0;
            this.nameSection.Text = "Ім\'я";
            // 
            // fullPathSection
            // 
            this.fullPathSection.AutoSize = true;
            this.fullPathSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullPathSection.Location = new System.Drawing.Point(12, 58);
            this.fullPathSection.Name = "fullPathSection";
            this.fullPathSection.Size = new System.Drawing.Size(109, 20);
            this.fullPathSection.TabIndex = 1;
            this.fullPathSection.Text = "Повний шлях";
            // 
            // memorySection
            // 
            this.memorySection.AutoSize = true;
            this.memorySection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorySection.Location = new System.Drawing.Point(11, 212);
            this.memorySection.Name = "memorySection";
            this.memorySection.Size = new System.Drawing.Size(174, 20);
            this.memorySection.TabIndex = 2;
            this.memorySection.Text = "Займає пам\'яті (байт)";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(12, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 18);
            this.name.TabIndex = 3;
            this.name.Text = "name";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(12, 78);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(66, 18);
            this.fullName.TabIndex = 4;
            this.fullName.Text = "fullName";
            // 
            // creationTimeSection
            // 
            this.creationTimeSection.AutoSize = true;
            this.creationTimeSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creationTimeSection.Location = new System.Drawing.Point(11, 106);
            this.creationTimeSection.Name = "creationTimeSection";
            this.creationTimeSection.Size = new System.Drawing.Size(122, 20);
            this.creationTimeSection.TabIndex = 5;
            this.creationTimeSection.Text = "Час створення";
            // 
            // memory
            // 
            this.memory.AutoSize = true;
            this.memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memory.Location = new System.Drawing.Point(12, 232);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(63, 18);
            this.memory.TabIndex = 6;
            this.memory.Text = "memory";
            // 
            // creationTime
            // 
            this.creationTime.AutoSize = true;
            this.creationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creationTime.Location = new System.Drawing.Point(12, 126);
            this.creationTime.Name = "creationTime";
            this.creationTime.Size = new System.Drawing.Size(94, 18);
            this.creationTime.TabIndex = 7;
            this.creationTime.Text = "creationTime";
            // 
            // typeSection
            // 
            this.typeSection.AutoSize = true;
            this.typeSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeSection.Location = new System.Drawing.Point(12, 159);
            this.typeSection.Name = "typeSection";
            this.typeSection.Size = new System.Drawing.Size(36, 20);
            this.typeSection.TabIndex = 8;
            this.typeSection.Text = "Тип";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(14, 179);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(35, 18);
            this.type.TabIndex = 9;
            this.type.Text = "type";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 298);
            this.Controls.Add(this.type);
            this.Controls.Add(this.typeSection);
            this.Controls.Add(this.creationTime);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.creationTimeSection);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.memorySection);
            this.Controls.Add(this.fullPathSection);
            this.Controls.Add(this.nameSection);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.Text = "Властивості";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameSection;
        private System.Windows.Forms.Label fullPathSection;
        private System.Windows.Forms.Label memorySection;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label creationTimeSection;
        private System.Windows.Forms.Label memory;
        private System.Windows.Forms.Label creationTime;
        private System.Windows.Forms.Label typeSection;
        private System.Windows.Forms.Label type;

    }
}