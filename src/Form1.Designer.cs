namespace FM
{
    partial class FileManager
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.name_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTime_listView1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.name_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type__listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTime_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_listView1,
            this.type_listView1,
            this.lastWriteTime_listView1});
            this.listView1.Location = new System.Drawing.Point(12, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 420);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // name_listView1
            // 
            this.name_listView1.Text = "Ім\'я";
            this.name_listView1.Width = 110;
            // 
            // type_listView1
            // 
            this.type_listView1.Text = "Тип";
            this.type_listView1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.type_listView1.Width = 90;
            // 
            // lastWriteTime_listView1
            // 
            this.lastWriteTime_listView1.Text = "Час останніх змін";
            this.lastWriteTime_listView1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastWriteTime_listView1.Width = 177;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_listView2,
            this.type__listView2,
            this.lastWriteTime_listView2});
            this.listView2.Location = new System.Drawing.Point(473, 46);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(382, 420);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // name_listView2
            // 
            this.name_listView2.Text = "Ім\'я";
            this.name_listView2.Width = 110;
            // 
            // type__listView2
            // 
            this.type__listView2.Text = "Тип";
            this.type__listView2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.type__listView2.Width = 90;
            // 
            // lastWriteTime_listView2
            // 
            this.lastWriteTime_listView2.Text = "Розмір";
            this.lastWriteTime_listView2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastWriteTime_listView2.Width = 177;
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 478);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "FileManager";
            this.Text = "File Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name_listView1;
        private System.Windows.Forms.ColumnHeader type_listView1;
        private System.Windows.Forms.ColumnHeader lastWriteTime_listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader name_listView2;
        private System.Windows.Forms.ColumnHeader type__listView2;
        private System.Windows.Forms.ColumnHeader lastWriteTime_listView2;



    }
}

